namespace Forms_Controls
{
    partial class Form2
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
            this.lblDatafromForm1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.btnSendBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDatafromForm1
            // 
            this.lblDatafromForm1.AutoSize = true;
            this.lblDatafromForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatafromForm1.Location = new System.Drawing.Point(226, 33);
            this.lblDatafromForm1.Name = "lblDatafromForm1";
            this.lblDatafromForm1.Size = new System.Drawing.Size(134, 20);
            this.lblDatafromForm1.TabIndex = 0;
            this.lblDatafromForm1.Text = "Data from  Form1";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(266, 100);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 20);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result";
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(161, 167);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(264, 20);
            this.txtPersonID.TabIndex = 2;
            // 
            // btnSendBack
            // 
            this.btnSendBack.Location = new System.Drawing.Point(256, 221);
            this.btnSendBack.Name = "btnSendBack";
            this.btnSendBack.Size = new System.Drawing.Size(75, 23);
            this.btnSendBack.TabIndex = 3;
            this.btnSendBack.Text = "Send Back";
            this.btnSendBack.UseVisualStyleBackColor = true;
            this.btnSendBack.Click += new System.EventHandler(this.btnSendBack_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 275);
            this.Controls.Add(this.btnSendBack);
            this.Controls.Add(this.txtPersonID);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDatafromForm1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatafromForm1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Button btnSendBack;
    }
}