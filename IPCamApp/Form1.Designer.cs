namespace IPCamApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addNewCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbx_camList = new System.Windows.Forms.ListBox();
            this.btn_getSelected = new System.Windows.Forms.Button();
            this.btn_deleteSel = new System.Windows.Forms.Button();
            this.btn_deletePrevious = new System.Windows.Forms.Button();
            this.btn_getEntries = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCameraToolStripMenuItem,
            this.selectCameraToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 5, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(98, 295);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addNewCameraToolStripMenuItem
            // 
            this.addNewCameraToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.addNewCameraToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewCameraToolStripMenuItem.Image = global::IPCamApp.Properties.Resources.addNew21;
            this.addNewCameraToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewCameraToolStripMenuItem.Name = "addNewCameraToolStripMenuItem";
            this.addNewCameraToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.addNewCameraToolStripMenuItem.Size = new System.Drawing.Size(85, 92);
            this.addNewCameraToolStripMenuItem.Text = "Add IP Camera";
            this.addNewCameraToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addNewCameraToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addNewCameraToolStripMenuItem.ToolTipText = "Add New IP Camera";
            this.addNewCameraToolStripMenuItem.Click += new System.EventHandler(this.addNewCameraToolStripMenuItem_Click);
            // 
            // selectCameraToolStripMenuItem
            // 
            this.selectCameraToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.selectCameraToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.selectCameraToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectCameraToolStripMenuItem.Image = global::IPCamApp.Properties.Resources.helpIcon;
            this.selectCameraToolStripMenuItem.Name = "selectCameraToolStripMenuItem";
            this.selectCameraToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.selectCameraToolStripMenuItem.Size = new System.Drawing.Size(85, 92);
            this.selectCameraToolStripMenuItem.Text = "Help And Info";
            this.selectCameraToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.selectCameraToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.selectCameraToolStripMenuItem.Click += new System.EventHandler(this.selectCameraToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(85, 92);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lbx_camList
            // 
            this.lbx_camList.ColumnWidth = 20;
            this.lbx_camList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbx_camList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbx_camList.FormattingEnabled = true;
            this.lbx_camList.HorizontalScrollbar = true;
            this.lbx_camList.ItemHeight = 15;
            this.lbx_camList.Location = new System.Drawing.Point(111, 37);
            this.lbx_camList.Margin = new System.Windows.Forms.Padding(5);
            this.lbx_camList.Name = "lbx_camList";
            this.lbx_camList.Size = new System.Drawing.Size(536, 139);
            this.lbx_camList.TabIndex = 4;
            this.lbx_camList.SelectedIndexChanged += new System.EventHandler(this.lbx_camList_SelectedIndexChanged);
            // 
            // btn_getSelected
            // 
            this.btn_getSelected.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_getSelected.Enabled = false;
            this.btn_getSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_getSelected.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_getSelected.ForeColor = System.Drawing.Color.White;
            this.btn_getSelected.Location = new System.Drawing.Point(14, 28);
            this.btn_getSelected.Name = "btn_getSelected";
            this.btn_getSelected.Size = new System.Drawing.Size(109, 59);
            this.btn_getSelected.TabIndex = 5;
            this.btn_getSelected.Text = "Start Selected";
            this.btn_getSelected.UseVisualStyleBackColor = false;
            this.btn_getSelected.Click += new System.EventHandler(this.btn_getSelected_Click);
            // 
            // btn_deleteSel
            // 
            this.btn_deleteSel.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_deleteSel.Enabled = false;
            this.btn_deleteSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteSel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_deleteSel.ForeColor = System.Drawing.Color.White;
            this.btn_deleteSel.Location = new System.Drawing.Point(139, 28);
            this.btn_deleteSel.Name = "btn_deleteSel";
            this.btn_deleteSel.Size = new System.Drawing.Size(121, 59);
            this.btn_deleteSel.TabIndex = 6;
            this.btn_deleteSel.Text = "Remove Selected";
            this.btn_deleteSel.UseVisualStyleBackColor = false;
            this.btn_deleteSel.Click += new System.EventHandler(this.btn_deleteSel_Click);
            // 
            // btn_deletePrevious
            // 
            this.btn_deletePrevious.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_deletePrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletePrevious.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_deletePrevious.ForeColor = System.Drawing.Color.White;
            this.btn_deletePrevious.Location = new System.Drawing.Point(138, 27);
            this.btn_deletePrevious.Name = "btn_deletePrevious";
            this.btn_deletePrevious.Size = new System.Drawing.Size(114, 60);
            this.btn_deletePrevious.TabIndex = 8;
            this.btn_deletePrevious.Text = "Delete Previous";
            this.btn_deletePrevious.UseVisualStyleBackColor = false;
            this.btn_deletePrevious.Click += new System.EventHandler(this.btn_deletePrevious_Click);
            // 
            // btn_getEntries
            // 
            this.btn_getEntries.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_getEntries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_getEntries.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_getEntries.ForeColor = System.Drawing.Color.White;
            this.btn_getEntries.Location = new System.Drawing.Point(14, 27);
            this.btn_getEntries.Name = "btn_getEntries";
            this.btn_getEntries.Size = new System.Drawing.Size(110, 60);
            this.btn_getEntries.TabIndex = 9;
            this.btn_getEntries.Text = "Get Previous";
            this.btn_getEntries.UseVisualStyleBackColor = false;
            this.btn_getEntries.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_deleteSel);
            this.groupBox1.Controls.Add(this.btn_getSelected);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(98, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 96);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera List Controls";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_deletePrevious);
            this.groupBox2.Controls.Add(this.btn_getEntries);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(391, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 96);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Backup List Controls";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(98, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 179);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Available IP Cameras";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(205)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(672, 295);
            this.Controls.Add(this.lbx_camList);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OmniVision IP Camera Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox lbx_camList;
        private System.Windows.Forms.Button btn_getSelected;
        private System.Windows.Forms.Button btn_deleteSel;
        private System.Windows.Forms.Button btn_deletePrevious;
        private System.Windows.Forms.Button btn_getEntries;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem addNewCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;

    }
}

