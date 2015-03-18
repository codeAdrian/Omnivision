using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IPCamApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private Form1 mainForm = null;
        public Form2(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void cbx_camLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_camLogin.Checked==true)
            {
                tbx_username.Enabled = true;
                tbx_password.Enabled = true;
            }

            if (cbx_camLogin.Checked == false)
            {
                tbx_username.Enabled = false;
                tbx_password.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbx_name.Text == "" || tbx_url.Text == "")
            { MessageBox.Show("Please type in the custom name for camera (example - Camera 1) and URL of the IP camera.", "Required fields not filled"); }
            else
            {
                using (StreamWriter writer = new StreamWriter("camList.ini", true))
                {
                    writer.WriteLine(tbx_name.Text.ToString() + "          " + tbx_url.Text + "          " + tbx_username.Text + "          " + tbx_password.Text);
                }
                this.mainForm.LabelText = tbx_name.Text + "          " + tbx_url.Text + "          " + tbx_username.Text + "          " + tbx_password.Text;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
