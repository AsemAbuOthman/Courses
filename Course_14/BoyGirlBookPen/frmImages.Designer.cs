namespace BoyGirlBookPen
{
    partial class frmImages
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
            this.pbImages = new System.Windows.Forms.PictureBox();
            this.rbBoy = new System.Windows.Forms.RadioButton();
            this.rdGirl = new System.Windows.Forms.RadioButton();
            this.rbBook = new System.Windows.Forms.RadioButton();
            this.rbPen = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImages)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImages
            // 
            this.pbImages.Image = global::BoyGirlBookPen.Properties.Resources.Boy;
            this.pbImages.Location = new System.Drawing.Point(0, 69);
            this.pbImages.Name = "pbImages";
            this.pbImages.Size = new System.Drawing.Size(601, 255);
            this.pbImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImages.TabIndex = 0;
            this.pbImages.TabStop = false;
            // 
            // rbBoy
            // 
            this.rbBoy.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbBoy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rbBoy.Location = new System.Drawing.Point(0, 420);
            this.rbBoy.Name = "rbBoy";
            this.rbBoy.Size = new System.Drawing.Size(601, 30);
            this.rbBoy.TabIndex = 1;
            this.rbBoy.TabStop = true;
            this.rbBoy.Tag = "Boy";
            this.rbBoy.Text = "Boy";
            this.rbBoy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBoy.UseVisualStyleBackColor = true;
            this.rbBoy.CheckedChanged += new System.EventHandler(this.rbBoy_CheckedChanged);
            // 
            // rdGirl
            // 
            this.rdGirl.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdGirl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rdGirl.Location = new System.Drawing.Point(0, 390);
            this.rdGirl.Name = "rdGirl";
            this.rdGirl.Size = new System.Drawing.Size(601, 30);
            this.rdGirl.TabIndex = 2;
            this.rdGirl.TabStop = true;
            this.rdGirl.Tag = "Girl";
            this.rdGirl.Text = "Girl";
            this.rdGirl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdGirl.UseVisualStyleBackColor = true;
            this.rdGirl.CheckedChanged += new System.EventHandler(this.rdGirl_CheckedChanged);
            // 
            // rbBook
            // 
            this.rbBook.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rbBook.Location = new System.Drawing.Point(0, 360);
            this.rbBook.Name = "rbBook";
            this.rbBook.Size = new System.Drawing.Size(601, 30);
            this.rbBook.TabIndex = 3;
            this.rbBook.TabStop = true;
            this.rbBook.Tag = "Book";
            this.rbBook.Text = "Book";
            this.rbBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBook.UseVisualStyleBackColor = true;
            this.rbBook.CheckedChanged += new System.EventHandler(this.rbBook_CheckedChanged);
            // 
            // rbPen
            // 
            this.rbPen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbPen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rbPen.Location = new System.Drawing.Point(0, 330);
            this.rbPen.Name = "rbPen";
            this.rbPen.Size = new System.Drawing.Size(601, 30);
            this.rbPen.TabIndex = 4;
            this.rbPen.TabStop = true;
            this.rbPen.Tag = "Pen";
            this.rbPen.Text = "Pen";
            this.rbPen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPen.UseVisualStyleBackColor = true;
            this.rbPen.CheckedChanged += new System.EventHandler(this.rbPen_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Maiandra GD", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(241, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(118, 57);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Title";
            // 
            // frmImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rbPen);
            this.Controls.Add(this.rbBook);
            this.Controls.Add(this.rdGirl);
            this.Controls.Add(this.rbBoy);
            this.Controls.Add(this.pbImages);
            this.Name = "frmImages";
            this.Text = "Images";
            this.Load += new System.EventHandler(this.frmImages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImages;
        private System.Windows.Forms.RadioButton rbBoy;
        private System.Windows.Forms.RadioButton rdGirl;
        private System.Windows.Forms.RadioButton rbBook;
        private System.Windows.Forms.RadioButton rbPen;
        private System.Windows.Forms.Label lblTitle;
    }
}

