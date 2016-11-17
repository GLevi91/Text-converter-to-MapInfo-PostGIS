namespace LST_Converter
{
    partial class CreateTable
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
            this.TableNameTextBox = new System.Windows.Forms.TextBox();
            this.TableNameLabel = new System.Windows.Forms.Label();
            this.CreateTableButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TableNameTextBox
            // 
            this.TableNameTextBox.Location = new System.Drawing.Point(108, 10);
            this.TableNameTextBox.Name = "TableNameTextBox";
            this.TableNameTextBox.Size = new System.Drawing.Size(160, 22);
            this.TableNameTextBox.TabIndex = 0;
            // 
            // TableNameLabel
            // 
            this.TableNameLabel.AutoSize = true;
            this.TableNameLabel.Location = new System.Drawing.Point(15, 13);
            this.TableNameLabel.Name = "TableNameLabel";
            this.TableNameLabel.Size = new System.Drawing.Size(87, 17);
            this.TableNameLabel.TabIndex = 1;
            this.TableNameLabel.Text = "Table name:";
            // 
            // CreateTableButton
            // 
            this.CreateTableButton.Location = new System.Drawing.Point(104, 48);
            this.CreateTableButton.Name = "CreateTableButton";
            this.CreateTableButton.Size = new System.Drawing.Size(75, 23);
            this.CreateTableButton.TabIndex = 2;
            this.CreateTableButton.Text = "Create";
            this.CreateTableButton.UseVisualStyleBackColor = true;
            this.CreateTableButton.Click += new System.EventHandler(this.CreateTableButton_Click);
            // 
            // CreateTable
            // 
            this.AcceptButton = this.CreateTableButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 78);
            this.Controls.Add(this.CreateTableButton);
            this.Controls.Add(this.TableNameLabel);
            this.Controls.Add(this.TableNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateTable";
            this.Text = "Create table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TableNameTextBox;
        private System.Windows.Forms.Label TableNameLabel;
        private System.Windows.Forms.Button CreateTableButton;
    }
}