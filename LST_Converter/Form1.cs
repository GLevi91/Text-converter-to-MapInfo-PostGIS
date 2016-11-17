using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;
using Npgsql;

namespace LST_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Application.ThreadException += myHandler;
            InitializeComponent();
        }
        

        private static DialogResult ShowThreadExceptionDialog(string title, Exception e)
        {
            string errorMsg = "An application error occurred: ";
            errorMsg = errorMsg + e.Message;
            return MessageBox.Show(errorMsg, title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }


        private void myHandler(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            try
            {
                ShowThreadExceptionDialog("Error message", e.Exception);
            }

            catch
            {
                try
                {
                    MessageBox.Show("Unknown error",
                        "Fatal error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                finally
                {
                    Application.Exit();
                }
            }
        }


        private void clearWhenFinishedOrReset()
        {
            Lists.Instance.coordList.Clear();
            Lists.Instance.hrszList.Clear();
            PostGIS.Instance.coordsForQueryList.Clear();
        }


        private void Read_LST_Button_EnabledChanged(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Enabled)
            {
                button.BackgroundImage = LST_Converter.Properties.Resources.OpenFile;
            }

            else
            {
                button.BackgroundImage = LST_Converter.Properties.Resources.OpenFile_Disabled;
            }

        }


        private void Read_LST_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog lstOpen = new OpenFileDialog();
            lstOpen.Filter = "LST files | *.lst";

            Coordinates.Instance.coordBuilder.Append("Version 300\r\nCharset \"WindowsLatin2\"\r\nDelimiter \",\"\r\nCoordSys NonEarth Units \"m\" Bounds (0, 0) (1000000, 1000000)\r\nColumns 1\r\nHRSZ Char(10)\r\nData\r\n\r\n");

            if(lstOpen.ShowDialog() == DialogResult.OK)
            {
                Lists.Instance.allLines = File.ReadLines(lstOpen.FileName);

                foreach (var line in Lists.Instance.allLines)
                {
                    RegexQuery.Instance.searchWithRegex(line);

                    if (RegexQuery.Instance.hrsz.Success)
                    {
                        Lists.Instance.hrszList.Add(RegexQuery.Instance.hrsz.Value + Environment.NewLine);
                    }

                    else if (RegexQuery.Instance.blokkStart.Success)
                    {
                        Lists.Instance.coordList.Add("REGION 1" + Environment.NewLine);
                    }

                    else if (RegexQuery.Instance.coord.Success)
                    {
                        Coordinates.Instance.getCoordinates(RegexQuery.Instance.coord);
                        PostGIS.Instance.addCoords(Coordinates.Instance.xCoord, Coordinates.Instance.yCoord);
                        Lists.Instance.coordList.Add(" " + Coordinates.Instance.xCoord + Coordinates.Instance.spacing + Coordinates.Instance.yCoord + " " + Environment.NewLine);
                    }

                    else if (RegexQuery.Instance.blokkEnd.Success)
                    {
                        PostGIS.Instance.clearCoordsForQueryString();
                        string indexString = Convert.ToString(Coordinates.Instance.index);
                        int listIndex = Lists.Instance.coordList.Count - Coordinates.Instance.index;

                        Lists.Instance.coordList.Insert(listIndex, " " + indexString + " " + Environment.NewLine);

                        Coordinates.Instance.index = 0;

                        continue;
                    }

                    else if (RegexQuery.Instance.endRead.Success)
                    {
                        break;
                    }
                }
                
                foreach (var line in Lists.Instance.hrszList)
                {
                    Coordinates.Instance.hrszBuilder.Append(line);
                }

                foreach (var line in Lists.Instance.coordList)
                {
                    Coordinates.Instance.coordBuilder.Append(line);
                }

                Coordinates.Instance.finalHrszString = Coordinates.Instance.hrszBuilder.ToString().TrimEnd();
                Coordinates.Instance.finalCoordString = Coordinates.Instance.coordBuilder.ToString().TrimEnd();

                DialogResult result = MessageBox.Show("LST file has been processed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    numberOfElementsLabel.Text = "Number of elements: " + Lists.Instance.hrszList.Count.ToString();
                    Read_LST_Button.Enabled = false;
                    ConvertToMapinfoButton.Enabled = true;
                }
            }
        }

        private void ConvertToMapinfoButton_EnabledChanged(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Enabled)
            {
                button.BackgroundImage = LST_Converter.Properties.Resources.ConvertToMapinfo;
            }

            else
            {
                button.BackgroundImage = LST_Converter.Properties.Resources.ConvertToMapinfo_Disabled;
            }
        }

        private void ConvertToMapinfoButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveMapinfo = new SaveFileDialog();
            SaveMapinfo.Filter = "MapInfo Interchange Format | *.mif";

            if (SaveMapinfo.ShowDialog() == DialogResult.OK)
            {
                string mifFile = SaveMapinfo.FileName;
                string midName = Path.GetFileNameWithoutExtension(mifFile);
                string midPath = Path.GetDirectoryName(mifFile);
                string midFile = midPath + "/" + midName + ".mid";

                File.WriteAllText(mifFile, Coordinates.Instance.finalCoordString);
                File.WriteAllText(midFile, Coordinates.Instance.finalHrszString);


                DialogResult result = MessageBox.Show("Conversion finished!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(result == DialogResult.OK)
                {
                    ConvertToMapinfoButton.Enabled = false;
                    LoadToPostGISButton.Enabled = true;
                }
            }
        }

        private void LoadToPostGISButton_EnabledChanged(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Enabled)
            {
                button.BackgroundImage = LST_Converter.Properties.Resources.LoadToDb;
            }

            else
            {
                button.BackgroundImage = LST_Converter.Properties.Resources.LoadToDb_Disabled;
            }
        }

        private void LoadToPostGISButton_Click(object sender, EventArgs e)
        {
            
            Connect_to_PostGIS connectForm = new Connect_to_PostGIS();

            CreateTable createTableForm = new CreateTable();

            if(connectForm.ShowDialog() == DialogResult.OK)
            {
                createTableForm.ShowDialog();

                PostGIS.Instance.cnsb.ConnectionString = connectForm.cnsb.ConnectionString;

                PostGIS.Instance.runQueries();

                DialogResult result = MessageBox.Show("Upload to database finished!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    LoadToPostGISButton.Enabled = false;
                    Read_LST_Button.Enabled = true;
                    numberOfElementsLabel.Text = "";
                    clearWhenFinishedOrReset();
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void resetProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset the current process?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                Read_LST_Button.Enabled = true;
                ConvertToMapinfoButton.Enabled = false;
                LoadToPostGISButton.Enabled = false;
                numberOfElementsLabel.Text = "";
                clearWhenFinishedOrReset();
            }
        }
    }
}
