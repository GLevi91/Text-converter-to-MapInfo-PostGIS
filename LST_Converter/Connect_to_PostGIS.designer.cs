namespace LST_Converter
{
    partial class Connect_to_PostGIS
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
            this.Hostname_textbox = new System.Windows.Forms.TextBox();
            this.Database_textbox = new System.Windows.Forms.TextBox();
            this.Username_textbox = new System.Windows.Forms.TextBox();
            this.Password_textbox = new System.Windows.Forms.TextBox();
            this.Hostname_label = new System.Windows.Forms.Label();
            this.Database_label = new System.Windows.Forms.Label();
            this.Username_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Connect_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hostname_textbox
            // 
            this.Hostname_textbox.Location = new System.Drawing.Point(166, 40);
            this.Hostname_textbox.Name = "Hostname_textbox";
            this.Hostname_textbox.Size = new System.Drawing.Size(150, 22);
            this.Hostname_textbox.TabIndex = 0;
            // 
            // Database_textbox
            // 
            this.Database_textbox.Location = new System.Drawing.Point(166, 91);
            this.Database_textbox.Name = "Database_textbox";
            this.Database_textbox.Size = new System.Drawing.Size(150, 22);
            this.Database_textbox.TabIndex = 1;
            // 
            // Username_textbox
            // 
            this.Username_textbox.Location = new System.Drawing.Point(166, 142);
            this.Username_textbox.Name = "Username_textbox";
            this.Username_textbox.Size = new System.Drawing.Size(150, 22);
            this.Username_textbox.TabIndex = 2;
            // 
            // Password_textbox
            // 
            this.Password_textbox.Location = new System.Drawing.Point(166, 193);
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.Size = new System.Drawing.Size(150, 22);
            this.Password_textbox.TabIndex = 3;
            this.Password_textbox.UseSystemPasswordChar = true;
            // 
            // Hostname_label
            // 
            this.Hostname_label.AutoSize = true;
            this.Hostname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hostname_label.Location = new System.Drawing.Point(80, 40);
            this.Hostname_label.Name = "Hostname_label";
            this.Hostname_label.Size = new System.Drawing.Size(80, 17);
            this.Hostname_label.TabIndex = 4;
            this.Hostname_label.Text = "Host name:";
            // 
            // Database_label
            // 
            this.Database_label.AutoSize = true;
            this.Database_label.Location = new System.Drawing.Point(48, 91);
            this.Database_label.Name = "Database_label";
            this.Database_label.Size = new System.Drawing.Size(112, 17);
            this.Database_label.TabIndex = 5;
            this.Database_label.Text = "Database name:";
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Location = new System.Drawing.Point(83, 142);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(77, 17);
            this.Username_label.TabIndex = 6;
            this.Username_label.Text = "Username:";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(87, 193);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(73, 17);
            this.Password_label.TabIndex = 7;
            this.Password_label.Text = "Password:";
            // 
            // Connect_button
            // 
            this.Connect_button.Location = new System.Drawing.Point(50, 250);
            this.Connect_button.Name = "Connect_button";
            this.Connect_button.Size = new System.Drawing.Size(100, 30);
            this.Connect_button.TabIndex = 8;
            this.Connect_button.Text = "Connect";
            this.Connect_button.UseVisualStyleBackColor = true;
            this.Connect_button.Click += new System.EventHandler(this.Connect_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(236, 250);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(100, 30);
            this.Cancel_button.TabIndex = 9;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Connect_to_PostGIS
            // 
            this.AcceptButton = this.Connect_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 305);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Connect_button);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.Database_label);
            this.Controls.Add(this.Hostname_label);
            this.Controls.Add(this.Password_textbox);
            this.Controls.Add(this.Username_textbox);
            this.Controls.Add(this.Database_textbox);
            this.Controls.Add(this.Hostname_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Connect_to_PostGIS";
            this.Text = "Connect to PostGIS database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Hostname_textbox;
        private System.Windows.Forms.TextBox Database_textbox;
        private System.Windows.Forms.TextBox Username_textbox;
        private System.Windows.Forms.TextBox Password_textbox;
        private System.Windows.Forms.Label Hostname_label;
        private System.Windows.Forms.Label Database_label;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Button Connect_button;
        private System.Windows.Forms.Button Cancel_button;
    }
}