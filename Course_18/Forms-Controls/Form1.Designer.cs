namespace Forms_Controls
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
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.btnSendDataToForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(135, 122);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(143, 20);
            this.txtPersonID.TabIndex = 0;
            // 
            // btnSendDataToForm2
            // 
            this.btnSendDataToForm2.Location = new System.Drawing.Point(339, 122);
            this.btnSendDataToForm2.Name = "btnSendDataToForm2";
            this.btnSendDataToForm2.Size = new System.Drawing.Size(75, 23);
            this.btnSendDataToForm2.TabIndex = 1;
            this.btnSendDataToForm2.Text = "Send Data to Form2";
            this.btnSendDataToForm2.UseVisualStyleBackColor = true;
            this.btnSendDataToForm2.Click += new System.EventHandler(this.btnSendDataToForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 244);
            this.Controls.Add(this.btnSendDataToForm2);
            this.Controls.Add(this.txtPersonID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Button btnSendDataToForm2;
    }
}

