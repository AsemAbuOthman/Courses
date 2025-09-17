namespace MyFirstWindowsForms
{
    partial class frmMdiContinter
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
            this.btnMakeFormChild = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMakeFormChild
            // 
            this.btnMakeFormChild.Location = new System.Drawing.Point(589, 359);
            this.btnMakeFormChild.Name = "btnMakeFormChild";
            this.btnMakeFormChild.Size = new System.Drawing.Size(199, 79);
            this.btnMakeFormChild.TabIndex = 1;
            this.btnMakeFormChild.Text = "Make Form Child";
            this.btnMakeFormChild.UseVisualStyleBackColor = true;
            this.btnMakeFormChild.Click += new System.EventHandler(this.btnMakeFormChild_Click);
            // 
            // frmMdiContinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMakeFormChild);
            this.IsMdiContainer = true;
            this.Name = "frmMdiContinter";
            this.Text = "frmMdiContinter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMakeFormChild;
    }
}