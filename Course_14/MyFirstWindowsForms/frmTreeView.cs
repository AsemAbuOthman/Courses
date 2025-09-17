using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyFirstWindowsForms
{
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeView1.SelectedNode.Checked = true;
            MessageBox.Show(treeView1.SelectedNode.Text);
        }

        private void CheckTreeViewNode(TreeNode node, Boolean isChecked) 
        {
            foreach (TreeNode item in node.Nodes) 
            {
                item.Checked = isChecked;

                if (item.Nodes.Count > 0) 
                {
                    CheckTreeViewNode(item, item.Checked);
                }
            }
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked);
        }
    }
}
