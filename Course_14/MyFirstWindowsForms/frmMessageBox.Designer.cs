namespace MyFirstWindowsForms
{
    partial class frmMessageBox
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
            this.btnShowMessage1 = new System.Windows.Forms.Button();
            this.btnShowMessage2 = new System.Windows.Forms.Button();
            this.btnShowMessage3 = new System.Windows.Forms.Button();
            this.btnShowMessage4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowMessage1
            // 
            this.btnShowMessage1.Location = new System.Drawing.Point(286, 33);
            this.btnShowMessage1.Name = "btnShowMessage1";
            this.btnShowMessage1.Size = new System.Drawing.Size(165, 78);
            this.btnShowMessage1.TabIndex = 0;
            this.btnShowMessage1.Text = "Show Message1";
            this.btnShowMessage1.UseVisualStyleBackColor = true;
            this.btnShowMessage1.Click += new System.EventHandler(this.btnShowMessage_Click);
            // 
            // btnShowMessage2
            // 
            this.btnShowMessage2.Location = new System.Drawing.Point(286, 142);
            this.btnShowMessage2.Name = "btnShowMessage2";
            this.btnShowMessage2.Size = new System.Drawing.Size(165, 78);
            this.btnShowMessage2.TabIndex = 1;
            this.btnShowMessage2.Text = "Show Message2";
            this.btnShowMessage2.UseVisualStyleBackColor = true;
            this.btnShowMessage2.Click += new System.EventHandler(this.btnShowMessage2_Click);
            // 
            // btnShowMessage3
            // 
            this.btnShowMessage3.Location = new System.Drawing.Point(286, 251);
            this.btnShowMessage3.Name = "btnShowMessage3";
            this.btnShowMessage3.Size = new System.Drawing.Size(165, 78);
            this.btnShowMessage3.TabIndex = 2;
            this.btnShowMessage3.Text = "Show Message3";
            this.btnShowMessage3.UseVisualStyleBackColor = true;
            this.btnShowMessage3.Click += new System.EventHandler(this.btnShowMessage3_Click);
            // 
            // btnShowMessage4
            // 
            this.btnShowMessage4.Location = new System.Drawing.Point(286, 360);
            this.btnShowMessage4.Name = "btnShowMessage4";
            this.btnShowMessage4.Size = new System.Drawing.Size(165, 78);
            this.btnShowMessage4.TabIndex = 3;
            this.btnShowMessage4.Text = "Show Message4";
            this.btnShowMessage4.UseVisualStyleBackColor = true;
            this.btnShowMessage4.Click += new System.EventHandler(this.btnShowMessage4_Click);
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowMessage4);
            this.Controls.Add(this.btnShowMessage3);
            this.Controls.Add(this.btnShowMessage2);
            this.Controls.Add(this.btnShowMessage1);
            this.Name = "frmMessageBox";
            this.Text = "Show Message Box";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowMessage1;
        private System.Windows.Forms.Button btnShowMessage2;
        private System.Windows.Forms.Button btnShowMessage3;
        private System.Windows.Forms.Button btnShowMessage4;
    }
}