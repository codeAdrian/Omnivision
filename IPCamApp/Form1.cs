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
    public partial class Form1 : Form
    {
        string camName, camURL, camUserName, camPassword;
        
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void addNewCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 addCam=new Form2(this);
            addCam.Show();
        }

        public string LabelText
        {
            get {return lbx_camList.Items.ToString();}
            set { lbx_camList.Items.Add(value); }
        }

        private void btn_getSelected_Click(object sender, EventArgs e)
        {
            if (lbx_camList.SelectedIndex != -1) // provjeri da li je nesto odabrano
            {
                //test.Text = lbx_camList.SelectedItem.ToString();
                mjpegStreamForm streamForm = new mjpegStreamForm(camName,camURL,camUserName,camPassword);
                streamForm.Show();
            }
        }

        private void btn_deleteSel_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lbx_camList);
            selectedItems = lbx_camList.SelectedItems;

            if (lbx_camList.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    lbx_camList.Items.Remove(selectedItems[i]);
            }
            else
                MessageBox.Show("Select the Camera you want to delete and press the button","Camera not selected");
        }

        private void lbx_camList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lbx_camList);
            selectedItems = lbx_camList.SelectedItems;

            if (lbx_camList.SelectedIndex != -1)
            {
                btn_deleteSel.Enabled = true;
                btn_getSelected.Enabled = true;
                string selCam = lbx_camList.SelectedItem.ToString();
                string[] selectedCam = selCam.Split(new string[] { "          " }, StringSplitOptions.None);
                camName = selectedCam[0]; // ime kamere
                camURL = selectedCam[1]; // URL kamere
                camUserName = selectedCam[2]; // Username
                camPassword = selectedCam[3]; // Password za kameru
            }
        }

        private void btn_deletePrevious_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("camList.ini")){}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line;
            StreamReader file =
            new System.IO.StreamReader("camList.ini");
            while ((line = file.ReadLine()) != null)
            {
                lbx_camList.Items.Add(line);    
            }
            file.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                    Application.OpenForms[i].Close();
            }
        }

        private void selectCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 infoForm = new Form3();
            infoForm.Show();
        }



    }
}
