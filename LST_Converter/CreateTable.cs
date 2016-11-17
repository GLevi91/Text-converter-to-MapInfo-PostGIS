using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LST_Converter
{
    public partial class CreateTable : Form
    {

        public CreateTable()
        {
            InitializeComponent();
        }


        private void CreateTableButton_Click(object sender, EventArgs e)
        {
            PostGIS.Instance.tableName = TableNameTextBox.Text;
            this.Close();
        }
    }
}
