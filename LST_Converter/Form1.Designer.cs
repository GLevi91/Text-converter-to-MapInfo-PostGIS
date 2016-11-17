namespace LST_Converter
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Read_LST_Button = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ConvertToMapinfoButton = new System.Windows.Forms.Button();
            this.LoadToPostGISButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resetProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.numberOfElementsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Read_LST_Button);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(799, 329);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 1;
            // 
            // Read_LST_Button
            // 
            this.Read_LST_Button.BackgroundImage = global::LST_Converter.Properties.Resources.OpenFile;
            this.Read_LST_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Read_LST_Button.Location = new System.Drawing.Point(0, 0);
            this.Read_LST_Button.Name = "Read_LST_Button";
            this.Read_LST_Button.Size = new System.Drawing.Size(261, 301);
            this.Read_LST_Button.TabIndex = 0;
            this.Read_LST_Button.Text = "Read LST File...";
            this.Read_LST_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Read_LST_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Read_LST_Button.UseVisualStyleBackColor = true;
            this.Read_LST_Button.EnabledChanged += new System.EventHandler(this.Read_LST_Button_EnabledChanged);
            this.Read_LST_Button.Click += new System.EventHandler(this.Read_LST_Button_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ConvertToMapinfoButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.LoadToPostGISButton);
            this.splitContainer2.Size = new System.Drawing.Size(533, 329);
            this.splitContainer2.SplitterDistance = 262;
            this.splitContainer2.TabIndex = 0;
            // 
            // ConvertToMapinfoButton
            // 
            this.ConvertToMapinfoButton.BackgroundImage = global::LST_Converter.Properties.Resources.ConvertToMapinfo_Disabled;
            this.ConvertToMapinfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConvertToMapinfoButton.Enabled = false;
            this.ConvertToMapinfoButton.Location = new System.Drawing.Point(0, 0);
            this.ConvertToMapinfoButton.Name = "ConvertToMapinfoButton";
            this.ConvertToMapinfoButton.Size = new System.Drawing.Size(261, 301);
            this.ConvertToMapinfoButton.TabIndex = 0;
            this.ConvertToMapinfoButton.Text = "Convert to MapInfo Interchange";
            this.ConvertToMapinfoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ConvertToMapinfoButton.UseVisualStyleBackColor = true;
            this.ConvertToMapinfoButton.EnabledChanged += new System.EventHandler(this.ConvertToMapinfoButton_EnabledChanged);
            this.ConvertToMapinfoButton.Click += new System.EventHandler(this.ConvertToMapinfoButton_Click);
            // 
            // LoadToPostGISButton
            // 
            this.LoadToPostGISButton.BackgroundImage = global::LST_Converter.Properties.Resources.LoadToDb_Disabled;
            this.LoadToPostGISButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadToPostGISButton.Enabled = false;
            this.LoadToPostGISButton.Location = new System.Drawing.Point(0, 0);
            this.LoadToPostGISButton.Name = "LoadToPostGISButton";
            this.LoadToPostGISButton.Size = new System.Drawing.Size(261, 301);
            this.LoadToPostGISButton.TabIndex = 0;
            this.LoadToPostGISButton.Text = "Load into PostGIS database";
            this.LoadToPostGISButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadToPostGISButton.UseVisualStyleBackColor = true;
            this.LoadToPostGISButton.EnabledChanged += new System.EventHandler(this.LoadToPostGISButton_EnabledChanged);
            this.LoadToPostGISButton.Click += new System.EventHandler(this.LoadToPostGISButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetProcessToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resetProcessToolStripMenuItem
            // 
            this.resetProcessToolStripMenuItem.Name = "resetProcessToolStripMenuItem";
            this.resetProcessToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.resetProcessToolStripMenuItem.Text = "Reset process";
            this.resetProcessToolStripMenuItem.Click += new System.EventHandler(this.resetProcessToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberOfElementsLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 332);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(799, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // numberOfElementsLabel
            // 
            this.numberOfElementsLabel.Name = "numberOfElementsLabel";
            this.numberOfElementsLabel.Size = new System.Drawing.Size(21, 20);
            this.numberOfElementsLabel.Text = "   ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 357);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "LST Converter";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Read_LST_Button;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button ConvertToMapinfoButton;
        private System.Windows.Forms.Button LoadToPostGISButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel numberOfElementsLabel;
        private System.Windows.Forms.ToolStripMenuItem resetProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

