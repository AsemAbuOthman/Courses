namespace MyFirstWindowsForms
{
    partial class frmTreeView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Hat 1", 6, 6);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Hat 2", 5, 5);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Hat 3", 7, 7);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Hat", 4, 4, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Gloves 1", 0, 0);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Gloves 2", 2, 2);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Gloves 3", 1, 1);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Gloves", 3, 3, new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreeView));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.CheckBoxes = true;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeView1.ImageIndex = 3;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Indent = 40;
            this.treeView1.ItemHeight = 45;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 6;
            treeNode1.Name = "Hat 1";
            treeNode1.SelectedImageIndex = 6;
            treeNode1.Text = "Hat 1";
            treeNode2.ImageIndex = 5;
            treeNode2.Name = "Hat 2";
            treeNode2.SelectedImageIndex = 5;
            treeNode2.Text = "Hat 2";
            treeNode3.ImageIndex = 7;
            treeNode3.Name = "Hat 3";
            treeNode3.SelectedImageIndex = 7;
            treeNode3.Text = "Hat 3";
            treeNode4.ImageIndex = 4;
            treeNode4.Name = "Hat";
            treeNode4.SelectedImageIndex = 4;
            treeNode4.Text = "Hat";
            treeNode5.ImageIndex = 0;
            treeNode5.Name = "Gloves 1";
            treeNode5.SelectedImageIndex = 0;
            treeNode5.Text = "Gloves 1";
            treeNode6.ImageIndex = 2;
            treeNode6.Name = "Gloves 2";
            treeNode6.SelectedImageIndex = 2;
            treeNode6.Text = "Gloves 2";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "Gloves 3";
            treeNode7.SelectedImageIndex = 1;
            treeNode7.Text = "Gloves 3";
            treeNode8.ImageIndex = 3;
            treeNode8.Name = "Gloves";
            treeNode8.SelectedImageIndex = 3;
            treeNode8.Text = "Gloves";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(697, 356);
            this.treeView1.TabIndex = 0;
            this.treeView1.TabStop = false;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-gloves-48 (1).png");
            this.imageList1.Images.SetKeyName(1, "icons8-garden-gloves-48.png");
            this.imageList1.Images.SetKeyName(2, "icons8-gauntlet-gloves-48.png");
            this.imageList1.Images.SetKeyName(3, "icons8-gloves-48.png");
            this.imageList1.Images.SetKeyName(4, "icons8-hat-64.png");
            this.imageList1.Images.SetKeyName(5, "icons8-hat-48 (2).png");
            this.imageList1.Images.SetKeyName(6, "icons8-hat-48 (1).png");
            this.imageList1.Images.SetKeyName(7, "icons8-hat-48.png");
            // 
            // frmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 413);
            this.Controls.Add(this.treeView1);
            this.Name = "frmTreeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTreeView";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}