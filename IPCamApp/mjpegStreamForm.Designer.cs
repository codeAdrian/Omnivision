namespace IPCamApp
{
    partial class mjpegStreamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mjpegStreamForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pbx_image = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_invert = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_treshold = new System.Windows.Forms.CheckBox();
            this.cbx_sharpen = new System.Windows.Forms.CheckBox();
            this.cbx_dither = new System.Windows.Forms.CheckBox();
            this.cbx_edges = new System.Windows.Forms.CheckBox();
            this.cbx_smooth = new System.Windows.Forms.CheckBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.btn_flipY = new System.Windows.Forms.Button();
            this.btn_flipX = new System.Windows.Forms.Button();
            this.btn_rotate_counter = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btn_capImage = new System.Windows.Forms.Button();
            this.btn_playPause = new System.Windows.Forms.Button();
            this.btn_rotate_clockwise = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_image)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pbx_image);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(205)))), ((int)(((byte)(239)))));
            this.splitContainer1.Panel2.Controls.Add(this.btn_flipY);
            this.splitContainer1.Panel2.Controls.Add(this.btn_flipX);
            this.splitContainer1.Panel2.Controls.Add(this.btn_rotate_counter);
            this.splitContainer1.Panel2.Controls.Add(this.btn_close);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.trackBar1);
            this.splitContainer1.Panel2.Controls.Add(this.btn_capImage);
            this.splitContainer1.Panel2.Controls.Add(this.btn_playPause);
            this.splitContainer1.Panel2.Controls.Add(this.btn_rotate_clockwise);
            this.splitContainer1.Size = new System.Drawing.Size(624, 422);
            this.splitContainer1.SplitterDistance = 346;
            this.splitContainer1.TabIndex = 0;
            // 
            // pbx_image
            // 
            this.pbx_image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_image.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbx_image.Location = new System.Drawing.Point(0, 0);
            this.pbx_image.Name = "pbx_image";
            this.pbx_image.Size = new System.Drawing.Size(448, 336);
            this.pbx_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_image.TabIndex = 0;
            this.pbx_image.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(205)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.cbx_invert);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbx_treshold);
            this.panel1.Controls.Add(this.cbx_sharpen);
            this.panel1.Controls.Add(this.cbx_dither);
            this.panel1.Controls.Add(this.cbx_edges);
            this.panel1.Controls.Add(this.cbx_smooth);
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(462, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 346);
            this.panel1.TabIndex = 22;
            // 
            // cbx_invert
            // 
            this.cbx_invert.AutoSize = true;
            this.cbx_invert.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_invert.Location = new System.Drawing.Point(16, 58);
            this.cbx_invert.Name = "cbx_invert";
            this.cbx_invert.Size = new System.Drawing.Size(55, 19);
            this.cbx_invert.TabIndex = 21;
            this.cbx_invert.Text = "Invert";
            this.cbx_invert.UseVisualStyleBackColor = true;
            this.cbx_invert.CheckedChanged += new System.EventHandler(this.cbx_invert_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Filters";
            // 
            // cbx_treshold
            // 
            this.cbx_treshold.AutoSize = true;
            this.cbx_treshold.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_treshold.Location = new System.Drawing.Point(16, 158);
            this.cbx_treshold.Name = "cbx_treshold";
            this.cbx_treshold.Size = new System.Drawing.Size(117, 19);
            this.cbx_treshold.TabIndex = 19;
            this.cbx_treshold.Text = "Corner detection";
            this.cbx_treshold.UseVisualStyleBackColor = true;
            this.cbx_treshold.CheckedChanged += new System.EventHandler(this.cbx_treshold_CheckedChanged);
            // 
            // cbx_sharpen
            // 
            this.cbx_sharpen.AutoSize = true;
            this.cbx_sharpen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_sharpen.Location = new System.Drawing.Point(16, 33);
            this.cbx_sharpen.Name = "cbx_sharpen";
            this.cbx_sharpen.Size = new System.Drawing.Size(73, 19);
            this.cbx_sharpen.TabIndex = 12;
            this.cbx_sharpen.Text = "Sharpen";
            this.cbx_sharpen.UseVisualStyleBackColor = true;
            this.cbx_sharpen.CheckedChanged += new System.EventHandler(this.cbx_sharpen_CheckedChanged);
            // 
            // cbx_dither
            // 
            this.cbx_dither.AutoSize = true;
            this.cbx_dither.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_dither.Location = new System.Drawing.Point(16, 83);
            this.cbx_dither.Name = "cbx_dither";
            this.cbx_dither.Size = new System.Drawing.Size(77, 19);
            this.cbx_dither.TabIndex = 18;
            this.cbx_dither.Text = "Posterize";
            this.cbx_dither.UseVisualStyleBackColor = true;
            this.cbx_dither.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbx_edges
            // 
            this.cbx_edges.AutoSize = true;
            this.cbx_edges.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_edges.Location = new System.Drawing.Point(16, 133);
            this.cbx_edges.Name = "cbx_edges";
            this.cbx_edges.Size = new System.Drawing.Size(108, 19);
            this.cbx_edges.TabIndex = 13;
            this.cbx_edges.Text = "Edge detection";
            this.cbx_edges.UseVisualStyleBackColor = true;
            this.cbx_edges.CheckedChanged += new System.EventHandler(this.cbx_edges_CheckedChanged);
            // 
            // cbx_smooth
            // 
            this.cbx_smooth.AutoSize = true;
            this.cbx_smooth.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_smooth.Location = new System.Drawing.Point(16, 108);
            this.cbx_smooth.Name = "cbx_smooth";
            this.cbx_smooth.Size = new System.Drawing.Size(81, 19);
            this.cbx_smooth.TabIndex = 17;
            this.cbx_smooth.Text = "Grayscale";
            this.cbx_smooth.UseVisualStyleBackColor = true;
            this.cbx_smooth.CheckedChanged += new System.EventHandler(this.cbx_smooth_CheckedChanged);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(13, 201);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(66, 13);
            this.lbl_time.TabIndex = 16;
            this.lbl_time.Text = "Frame times:";
            // 
            // btn_flipY
            // 
            this.btn_flipY.BackColor = System.Drawing.Color.Transparent;
            this.btn_flipY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_flipY.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_flipY.ForeColor = System.Drawing.Color.Black;
            this.btn_flipY.Location = new System.Drawing.Point(358, 38);
            this.btn_flipY.Name = "btn_flipY";
            this.btn_flipY.Size = new System.Drawing.Size(90, 35);
            this.btn_flipY.TabIndex = 9;
            this.btn_flipY.Text = "Mirror Y";
            this.btn_flipY.UseVisualStyleBackColor = false;
            this.btn_flipY.Click += new System.EventHandler(this.btn_flipY_Click);
            // 
            // btn_flipX
            // 
            this.btn_flipX.BackColor = System.Drawing.Color.Transparent;
            this.btn_flipX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_flipX.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_flipX.ForeColor = System.Drawing.Color.Black;
            this.btn_flipX.Location = new System.Drawing.Point(358, 0);
            this.btn_flipX.Name = "btn_flipX";
            this.btn_flipX.Size = new System.Drawing.Size(90, 35);
            this.btn_flipX.TabIndex = 8;
            this.btn_flipX.Text = "Mirror X";
            this.btn_flipX.UseVisualStyleBackColor = false;
            this.btn_flipX.Click += new System.EventHandler(this.btn_flipX_Click);
            // 
            // btn_rotate_counter
            // 
            this.btn_rotate_counter.BackColor = System.Drawing.Color.Transparent;
            this.btn_rotate_counter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_rotate_counter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_rotate_counter.ForeColor = System.Drawing.Color.Black;
            this.btn_rotate_counter.Location = new System.Drawing.Point(216, 39);
            this.btn_rotate_counter.Name = "btn_rotate_counter";
            this.btn_rotate_counter.Size = new System.Drawing.Size(136, 33);
            this.btn_rotate_counter.TabIndex = 7;
            this.btn_rotate_counter.Text = "Rotate 90° CCW";
            this.btn_rotate_counter.UseVisualStyleBackColor = false;
            this.btn_rotate_counter.Click += new System.EventHandler(this.btn_rotate_counter_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(140, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(70, 70);
            this.btn_close.TabIndex = 5;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(504, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Brightness";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(205)))), ((int)(((byte)(239)))));
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(470, 24);
            this.trackBar1.Maximum = 150;
            this.trackBar1.Minimum = -150;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(141, 45);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 10;
            this.trackBar1.TickFrequency = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btn_capImage
            // 
            this.btn_capImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_capImage.BackColor = System.Drawing.Color.Transparent;
            this.btn_capImage.Enabled = false;
            this.btn_capImage.ForeColor = System.Drawing.Color.Transparent;
            this.btn_capImage.Image = ((System.Drawing.Image)(resources.GetObject("btn_capImage.Image")));
            this.btn_capImage.Location = new System.Drawing.Point(70, 0);
            this.btn_capImage.Name = "btn_capImage";
            this.btn_capImage.Size = new System.Drawing.Size(70, 70);
            this.btn_capImage.TabIndex = 2;
            this.btn_capImage.UseVisualStyleBackColor = false;
            this.btn_capImage.Click += new System.EventHandler(this.btn_capImage_Click);
            // 
            // btn_playPause
            // 
            this.btn_playPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_playPause.BackColor = System.Drawing.Color.Transparent;
            this.btn_playPause.ForeColor = System.Drawing.Color.Transparent;
            this.btn_playPause.Image = global::IPCamApp.Properties.Resources.playIcon;
            this.btn_playPause.Location = new System.Drawing.Point(0, 0);
            this.btn_playPause.Name = "btn_playPause";
            this.btn_playPause.Size = new System.Drawing.Size(70, 70);
            this.btn_playPause.TabIndex = 1;
            this.btn_playPause.UseVisualStyleBackColor = false;
            this.btn_playPause.Click += new System.EventHandler(this.btn_playPause_Click);
            // 
            // btn_rotate_clockwise
            // 
            this.btn_rotate_clockwise.BackColor = System.Drawing.Color.Transparent;
            this.btn_rotate_clockwise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_rotate_clockwise.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_rotate_clockwise.ForeColor = System.Drawing.Color.Black;
            this.btn_rotate_clockwise.Location = new System.Drawing.Point(216, 0);
            this.btn_rotate_clockwise.Name = "btn_rotate_clockwise";
            this.btn_rotate_clockwise.Size = new System.Drawing.Size(136, 35);
            this.btn_rotate_clockwise.TabIndex = 6;
            this.btn_rotate_clockwise.Text = "Rotate 90° CW";
            this.btn_rotate_clockwise.UseVisualStyleBackColor = false;
            this.btn_rotate_clockwise.Click += new System.EventHandler(this.btn_rotate_clockwise_Click);
            // 
            // mjpegStreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(205)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(624, 422);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(336, 355);
            this.Name = "mjpegStreamForm";
            this.Text = "Video Stream";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mjpegStreamForm_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_image)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pbx_image;
        private System.Windows.Forms.Button btn_playPause;
        private System.Windows.Forms.Button btn_capImage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_rotate_clockwise;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_rotate_counter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btn_flipY;
        private System.Windows.Forms.Button btn_flipX;
        private System.Windows.Forms.CheckBox cbx_edges;
        private System.Windows.Forms.CheckBox cbx_sharpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.CheckBox cbx_smooth;
        private System.Windows.Forms.CheckBox cbx_dither;
        private System.Windows.Forms.CheckBox cbx_treshold;
        private System.Windows.Forms.CheckBox cbx_invert;
        private System.Windows.Forms.Panel panel1;

    }
}