using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace LST_Converter
{
    public partial class Connect_to_PostGIS : Form
    {

        public NpgsqlConnectionStringBuilder cnsb = new NpgsqlConnectionStringBuilder();

        public Connect_to_PostGIS()
        {
            InitializeComponent();
        }

        private void Connect_button_Click(object sender, EventArgs e)
        {
            cnsb.Host = Hostname_textbox.Text;
            cnsb.Username = Username_textbox.Text;
            cnsb.Database = Database_textbox.Text;
            cnsb.Password = Password_textbox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
