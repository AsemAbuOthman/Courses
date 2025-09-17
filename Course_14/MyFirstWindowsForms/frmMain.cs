using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWindowsForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnShowPart1_Click(object sender, EventArgs e)
        {
            Form frmPart1 = new frm1();

            frmPart1.Show();
        }
        private void btnShowDialoge_Click(object sender, EventArgs e)
        {
            Form frmPart1 = new frm1();

            frmPart1.ShowDialog();
        }

        private void btnShowMessageBox_Click(object sender, EventArgs e)
        {
            Form frmPart2 = new frmMessageBox();

            frmPart2.ShowDialog();
        }

        private void btnFrmChkBox_Click(object sender, EventArgs e)
        {
            Form frmPart3 = new frmChkRadioGroup();

            frmPart3.Show();
        }

        private void btnShowMoreAboutTextBox_Click(object sender, EventArgs e)
        {
            Form frmAboutTextBox = new frmMoreAboutTextBox();

            frmAboutTextBox.Show();
        }

        private void btnPictureBox_Click(object sender, EventArgs e)
        {
            Form frmPicBox = new frmPictureBox();

            frmPicBox.Show();
        }

        private void btnMaskedTextBox_Click(object sender, EventArgs e)
        {
            Form frmMasekdTxtBox = new frmMaskedTextBox();

            frmMasekdTxtBox.Show();
        }

        private void btnComboBox_Click(object sender, EventArgs e)
        {
            frmComboBox frmCombo = new frmComboBox();

            frmCombo.Show();
        }

        private void btnLinkLabel_Click(object sender, EventArgs e)
        {
            frmLinkLabel frmLnkLabel = new frmLinkLabel();

            frmLnkLabel.Show();
        }

        private void clbCheckListBox_Click(object sender, EventArgs e)
        {
            frmCheckBoxList frmBoxList = new frmCheckBoxList();

            frmBoxList.Show();
        }

        private void btnDateTimePicker_Click(object sender, EventArgs e)
        {
            frmDateTimePicker frmDateTime = new frmDateTimePicker();

            frmDateTime.Show();
        }

        private void btnMonthCalender_Click(object sender, EventArgs e)
        {
            frmMonthCalender frmMonth = new frmMonthCalender();

            frmMonth.Show();
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            frmTimer frmTimer = new frmTimer();

            frmTimer.Show();
        }

        private void btnNotifyIcon_Click(object sender, EventArgs e)
        {
            frmNotifyIcon frmNotify = new frmNotifyIcon();

            frmNotify.Show();
        }

        private void btnTreeView_Click(object sender, EventArgs e)
        {
            frmTreeView frmTreeView = new frmTreeView();

            frmTreeView.Show();
        }

        private void btnProgressBar_Click(object sender, EventArgs e)
        {
            frmProgressBar frmProgressBar = new frmProgressBar();

            frmProgressBar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListView frmListView = new frmListView();

            frmListView.Show();
        }

        private void btnErrorProvider_Click(object sender, EventArgs e)
        {
            frmErrorProvider frmErrorProvider = new frmErrorProvider();

            frmErrorProvider.Show();
        }

        private void btnTrackBar_Click(object sender, EventArgs e)
        {
            frmTrackBar frmTrackBar = new frmTrackBar();

            frmTrackBar.Show();
        }

        private void btnNumericUpDown_Click(object sender, EventArgs e)
        {
            frmNumericUpDown frmNumericUpDown = new frmNumericUpDown();

            frmNumericUpDown.Show();
        }

        private void btnTabControl_Click(object sender, EventArgs e)
        {
            frmTabControl frmTabControl = new frmTabControl();

            frmTabControl.Show();
        }

        private void btnPanelControl_Click(object sender, EventArgs e)
        {
            frmPanel frmPanel = new frmPanel();

            frmPanel.Show();
        }

        private void btnColorDialoges_Click(object sender, EventArgs e)
        {
            frmColorDialoges frmColorDialoges = new frmColorDialoges();

            frmColorDialoges.Show();
        }

        private void btnFontDialoges_Click(object sender, EventArgs e)
        {
            frmFontDialog frmFontDialog = new frmFontDialog();

            frmFontDialog.Show();
        }

        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            frmFileSaveDialog frmFileSaveDialog = new frmFileSaveDialog();

            frmFileSaveDialog.Show();
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            frmOpenFileDialog frmOpenFileDialog = new frmOpenFileDialog();

            frmOpenFileDialog.Show();
        }

        private void btnFolderBrowsersDialog_Click(object sender, EventArgs e)
        {
            frmBrowseFileDialog frmBrowseFileDialog = new frmBrowseFileDialog();

            frmBrowseFileDialog.Show();
        }

        private void btnMDI_Click(object sender, EventArgs e)
        {
            frmMdiContinter frmMdiContinter = new frmMdiContinter();

            frmMdiContinter.Show();
        }

        private void btnMenuStrip_Click(object sender, EventArgs e)
        {
            frmMenuStrip frmMenuStrip = new frmMenuStrip();

            frmMenuStrip.Show(); 
        }

        private void btnContextMenuStrip_Click(object sender, EventArgs e)
        {
            frmContextMenu frmContextMenu = new frmContextMenu();

            frmContextMenu.Show();
        }
    }
}
