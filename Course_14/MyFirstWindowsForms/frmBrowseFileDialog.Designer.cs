﻿namespace MyFirstWindowsForms
{
    partial class frmBrowseFileDialog
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
            this.btnBrowseFolderDialog = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnBrowseFolderDialog
            // 
            this.btnBrowseFolderDialog.Location = new System.Drawing.Point(249, 164);
            this.btnBrowseFolderDialog.Name = "btnBrowseFolderDialog";
            this.btnBrowseFolderDialog.Size = new System.Drawing.Size(282, 112);
            this.btnBrowseFolderDialog.TabIndex = 0;
            this.btnBrowseFolderDialog.Text = "Browse Folder Dialog";
            this.btnBrowseFolderDialog.UseVisualStyleBackColor = true;
            this.btnBrowseFolderDialog.Click += new System.EventHandler(this.btnBrowseFolderDialog_Click);
            // 
            // frmBrowseFileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBrowseFolderDialog);
            this.Name = "frmBrowseFileDialog";
            this.Text = "frmBrowseFileDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseFolderDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}