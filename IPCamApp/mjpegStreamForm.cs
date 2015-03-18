using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
using AForge.Imaging.Filters;
using System.Threading;
using System.Diagnostics;

using PictureBox = AForge.Controls.PictureBox;   

namespace IPCamApp
{
    public partial class mjpegStreamForm : Form
    {
        int i=0;
        int flag_sharpen, flag_edge = 0;
        int flag_rotate,flag_flipX,flag_flipY = 0;
        int flag_smooth,flag_dither,flag_treshold,flag_invert = 0;
        int n = 0;
        string camURL, camUsername, camPassword;
        MJPEGStream videoSource = new MJPEGStream();
        BrightnessCorrection br = new BrightnessCorrection(-50);
        static int[,] matrica = {
                                { -2, -1,  0 },
                                { -1,  1,  1 },
                                {  0,  1,  2 } 
                                };
        Convolution sharpen = new Convolution(matrica);
        Edges rubovi = new Edges();
        Grayscale grayscale = new Grayscale(0.2125, 0.7154, 0.0721);
        SimplePosterization poster_filter = new SimplePosterization();
        static SusanCornersDetector corners_filter = new SusanCornersDetector();
        CornersMarker marker = new CornersMarker(corners_filter, Color.Red);
        Invert invert_filter = new Invert();
        Stopwatch time = new Stopwatch();

        public mjpegStreamForm(string name, string url, string username, string password)
        {
            InitializeComponent();
            this.Text = "Camera: "+name;
            camURL = url;
            camUsername = username;
            camPassword = password;
            videoSource.Login = camUsername;
            videoSource.Password = camPassword;
            splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            videoSource.Source = camURL;
        }

        public void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            time.Start();
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            if (flag_rotate!=0)
            { 
            if (flag_rotate == 1) { img.RotateFlip(RotateFlipType.Rotate90FlipNone); }
            else if (flag_rotate == 2) { img.RotateFlip(RotateFlipType.Rotate180FlipNone); }
            else { img.RotateFlip(RotateFlipType.Rotate270FlipNone); }
            }
            if (flag_smooth == 1) { img = grayscale.Apply(img); }
            if (trackBar1.Value != 0) { img = br.Apply(img); }
            if (flag_flipX == 1) {img.RotateFlip(RotateFlipType.RotateNoneFlipX);}
            if (flag_flipY == 1) { img.RotateFlip(RotateFlipType.RotateNoneFlipY); }
            if (flag_sharpen == 1) { sharpen.ApplyInPlace(img);}
            if (flag_treshold == 1) {marker.ApplyInPlace(img); }
            if (flag_edge == 1) { rubovi.ApplyInPlace(img); }
            if (flag_dither == 1) {poster_filter.ApplyInPlace(img); }
            if (flag_invert == 1) { invert_filter.ApplyInPlace(img); }
            pbx_image.Image = img;
            time.Stop();
            lbl_time.Text = "Frame times: " + time.ElapsedMilliseconds+" ms";
            time.Reset();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_playPause_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 == 0)
            {
                this.btn_playPause.Image = ((System.Drawing.Image)(Properties.Resources.playIcon));
                
                btn_capImage.Enabled = false;
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource.Stop();
            }
            else
            {
                new Thread(() =>{
                Thread.CurrentThread.IsBackground = true;
                btn_capImage.Enabled = true;
                videoSource.Login = camUsername;
                videoSource.Password = camPassword;
                this.btn_playPause.Image = ((System.Drawing.Image)(Properties.Resources.pauseIcon));
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                videoSource.Start();
                }).Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            videoSource.SignalToStop();
            videoSource.WaitForStop();
            videoSource.Stop();
            videoSource = null;
            this.Close();
        }

        /*private void btn_capVid_Click(object sender, EventArgs e)
        {
            j++;
            if (j % 2 == 0) this.btn_capVid.Image = ((System.Drawing.Image)(Properties.Resources.capVidIcon));
            else this.btn_capVid.Image = ((System.Drawing.Image)(Properties.Resources.capVidIconA));
        }*/

        private void mjpegStreamForm_FormClosing(object sender, EventArgs e)
        {
            videoSource.SignalToStop();
            videoSource.WaitForStop();
            videoSource.Stop();
            videoSource = null;
            this.Close();
        }

        private void btn_capImage_Click(object sender, EventArgs e)
        {
            pbx_image.Image.Save("Capture-" + DateTime.Now.ToString("HH-mm-ss tt") + ".jpg");
        }

        private void btn_rotate_clockwise_Click(object sender, EventArgs e)
        {
            flag_rotate++;
            if (flag_rotate>3)
            {
                flag_rotate = 0;
            }
        }

        private void btn_rotate_counter_Click(object sender, EventArgs e)
        {
            flag_rotate--;
            if (flag_rotate < 0)
            {
                flag_rotate = 3;
            }
        }

        private void btn_flipX_Click(object sender, EventArgs e)
        {
            if (flag_flipX == 0)
            {
                flag_flipX = 1;
            }
            else flag_flipX = 0;
        }

        private void btn_flipY_Click(object sender, EventArgs e)
        {
            if (flag_flipY == 0)
            {
                flag_flipY = 1;
            }
            else flag_flipY = 0;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            n = trackBar1.Value;
            br.AdjustValue = n;
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            videoSource.SignalToStop();
            videoSource.Stop();
            this.Close();
        }

        private void cbx_sharpen_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_sharpen.Checked == true) flag_sharpen = 1;
            else flag_sharpen = 0;
        }

        private void cbx_edges_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_edges.Checked == true) flag_edge = 1;
            else flag_edge = 0;
        }

        private void mjpegStreamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoSource.SignalToStop();
            videoSource.Stop();
        }

        private void cbx_smooth_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_smooth.Checked == true) flag_smooth = 1;
                        else flag_smooth = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_dither.Checked == true) flag_dither = 1;
            else flag_dither = 0;
        }

        private void cbx_treshold_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_treshold.Checked == true) flag_treshold = 1;
            else flag_treshold = 0;
        }

        private void cbx_invert_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_invert.Checked == true) flag_invert = 1;
            else flag_invert = 0;
        } 
    }
}
