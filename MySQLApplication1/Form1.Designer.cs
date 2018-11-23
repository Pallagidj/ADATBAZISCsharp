namespace MySQLApplication1
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
            this.nevTextBox = new System.Windows.Forms.TextBox();
            this.jelszotextBox = new System.Windows.Forms.TextBox();
            this.regDatum = new System.Windows.Forms.DateTimePicker();
            this.regbutton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nevTextBox
            // 
            this.nevTextBox.Location = new System.Drawing.Point(13, 13);
            this.nevTextBox.Name = "nevTextBox";
            this.nevTextBox.Size = new System.Drawing.Size(200, 20);
            this.nevTextBox.TabIndex = 0;
            // 
            // jelszotextBox
            // 
            this.jelszotextBox.Location = new System.Drawing.Point(13, 40);
            this.jelszotextBox.Name = "jelszotextBox";
            this.jelszotextBox.PasswordChar = '*';
            this.jelszotextBox.Size = new System.Drawing.Size(200, 20);
            this.jelszotextBox.TabIndex = 1;
            // 
            // regDatum
            // 
            this.regDatum.Location = new System.Drawing.Point(13, 67);
            this.regDatum.Name = "regDatum";
            this.regDatum.Size = new System.Drawing.Size(200, 20);
            this.regDatum.TabIndex = 2;
            // 
            // regbutton
            // 
            this.regbutton.Location = new System.Drawing.Point(137, 94);
            this.regbutton.Name = "regbutton";
            this.regbutton.Size = new System.Drawing.Size(75, 23);
            this.regbutton.TabIndex = 3;
            this.regbutton.Text = "regButton";
            this.regbutton.UseVisualStyleBackColor = true;
            this.regbutton.Click += new System.EventHandler(this.regbutton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(136, 124);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // deleteButt
            // 
            this.deleteButt.Location = new System.Drawing.Point(135, 154);
            this.deleteButt.Name = "deleteButt";
            this.deleteButt.Size = new System.Drawing.Size(75, 23);
            this.deleteButt.TabIndex = 5;
            this.deleteButt.Text = "DELETE";
            this.deleteButt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.deleteButt);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.regbutton);
            this.Controls.Add(this.regDatum);
            this.Controls.Add(this.jelszotextBox);
            this.Controls.Add(this.nevTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nevTextBox;
        private System.Windows.Forms.TextBox jelszotextBox;
        private System.Windows.Forms.DateTimePicker regDatum;
        private System.Windows.Forms.Button regbutton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButt;
    }
}

