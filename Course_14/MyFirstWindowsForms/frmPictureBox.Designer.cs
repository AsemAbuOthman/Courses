namespace MyFirstWindowsForms
{
    partial class frmPictureBox
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
            this.btnLightOff = new System.Windows.Forms.Button();
            this.btnLight = new System.Windows.Forms.Button();
            this.btnLightOn = new System.Windows.Forms.Button();
            this.pbLight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLight)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLightOff
            // 
            this.btnLightOff.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLightOff.Location = new System.Drawing.Point(0, 397);
            this.btnLightOff.Name = "btnLightOff";
            this.btnLightOff.Size = new System.Drawing.Size(78, 55);
            this.btnLightOff.TabIndex = 2;
            this.btnLightOff.Text = "Light Off";
            this.btnLightOff.UseVisualStyleBackColor = true;
            this.btnLightOff.Click += new System.EventHandler(this.btnLightOff_Click);
            // 
            // btnLight
            // 
            this.btnLight.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLight.Location = new System.Drawing.Point(78, 397);
            this.btnLight.Name = "btnLight";
            this.btnLight.Size = new System.Drawing.Size(92, 55);
            this.btnLight.TabIndex = 3;
            this.btnLight.Text = "Light";
            this.btnLight.UseVisualStyleBackColor = true;
            this.btnLight.Click += new System.EventHandler(this.btnLight_Click);
            // 
            // btnLightOn
            // 
            this.btnLightOn.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLightOn.Location = new System.Drawing.Point(170, 397);
            this.btnLightOn.Name = "btnLightOn";
            this.btnLightOn.Size = new System.Drawing.Size(78, 55);
            this.btnLightOn.TabIndex = 4;
            this.btnLightOn.Text = "Light On";
            this.btnLightOn.UseVisualStyleBackColor = true;
            this.btnLightOn.Click += new System.EventHandler(this.btnLightOn_Click);
            // 
            // pbLight
            // 
            this.pbLight.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLight.Image = global::MyFirstWindowsForms.Properties.Resources.lightOff;
            this.pbLight.Location = new System.Drawing.Point(0, 0);
            this.pbLight.Name = "pbLight";
            this.pbLight.Size = new System.Drawing.Size(248, 397);
            this.pbLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLight.TabIndex = 0;
            this.pbLight.TabStop = false;
            // 
            // frmPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 452);
            this.Controls.Add(this.btnLightOn);
            this.Controls.Add(this.btnLight);
            this.Controls.Add(this.btnLightOff);
            this.Controls.Add(this.pbLight);
            this.Name = "frmPictureBox";
            this.Text = "frmPictureBox";
            ((System.ComponentModel.ISupportInitialize)(this.pbLight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLight;
        private System.Windows.Forms.Button btnLightOff;
        private System.Windows.Forms.Button btnLight;
        private System.Windows.Forms.Button btnLightOn;
    }
}