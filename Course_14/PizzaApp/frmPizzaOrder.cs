using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApp
{
    public partial class frmPizzaOrder : Form
    {
        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            lblSizeAnswer.Text = rbSmall.Text.ToString();
            lblTotalPriceAnswer.Text = "$30";

        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            lblSizeAnswer.Text = rbMedium.Text.ToString();
            lblTotalPriceAnswer.Text = "$40";

        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            lblSizeAnswer.Text = rbLarge.Text.ToString();
            lblTotalPriceAnswer.Text = "$50";

        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExtraCheese.Checked)
            {
                lblToppingsAnswer.Text += chkExtraCheese.Text.ToString() + ", ";
            }
            else 
            {
                lblToppingsAnswer.Text = lblToppingsAnswer.Text.Replace(chkExtraCheese.Text.ToString() + ", ", "");
            }
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMushrooms.Checked)
            {
                lblToppingsAnswer.Text += chkMushrooms.Text.ToString() + ", ";
            }
            else
            {
                lblToppingsAnswer.Text = lblToppingsAnswer.Text.Replace(chkMushrooms.Text.ToString() + ", ", "");

            }
        }

        private void chkTommatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTommatoes.Checked)
            {
                lblToppingsAnswer.Text += chkTommatoes.Text.ToString() + ", ";
            }
            else
            {
                lblToppingsAnswer.Text = lblToppingsAnswer.Text.Replace(chkTommatoes.Text.ToString() + ", ", "");
            }
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnion.Checked)
            {
                lblToppingsAnswer.Text += chkOnion.Text.ToString() + ", ";
            }
            else
            {
                lblToppingsAnswer.Text = lblToppingsAnswer.Text.Replace(chkOnion.Text.ToString() + ", ", "");
            }
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOlives.Checked)
            {
                lblToppingsAnswer.Text += chkOlives.Text.ToString() + ", ";
            }
            else
            {
                lblToppingsAnswer.Text = lblToppingsAnswer.Text.Replace(chkOlives.Text.ToString() + ", ", "");
            }
        }

        private void chkGreenPapers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGreenPapers.Checked)
            {
                lblToppingsAnswer.Text += chkGreenPapers.Text.ToString() + ", ";
            }
            else
            {
                lblToppingsAnswer.Text = lblToppingsAnswer.Text.Replace(chkGreenPapers.Text.ToString() + ", ", "");
            }
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            lblCrustTypeAnswer.Text = rbThinCrust.Text.ToString();

        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            lblCrustTypeAnswer.Text = rbThickCrust.Text.ToString();

        }

        private void rbDineIn_CheckedChanged(object sender, EventArgs e)
        {
            lblWhereToEatAnswer.Text = rbDineIn.Text.ToString();    
        }

        private void rbTakeAWay_CheckedChanged(object sender, EventArgs e)
        {
            lblWhereToEatAnswer.Text = rbTakeAWay.Text.ToString();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            DialogResult isOrderConfirmed = MessageBox.Show("Confirm Order ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (isOrderConfirmed == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                gbSize.Enabled = false;
                gbCrust.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrderPizza.Enabled = false;
            }


        }

        private void btnResetPizza_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbCrust.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
            btnOrderPizza.Enabled = true;

            rbSmall.Checked = false;
            rbMedium.Checked = false;
            rbLarge.Checked = false;

            rbThickCrust.Checked = false;
            rbThinCrust.Checked = false;

            chkExtraCheese.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTommatoes.Checked = false;
            chkGreenPapers.Checked = false;

            rbDineIn.Checked = false;
            rbTakeAWay.Checked = false;

            lblSizeAnswer.Text = "";
            lblCrustTypeAnswer.Text = "";
            lblToppingsAnswer.Text = "";
            lblWhereToEatAnswer.Text = "";
            lblTotalPriceAnswer.Text = "";
        }

        private void frmPizzaOrder_Load(object sender, EventArgs e)
        {
            rbSmall.Checked = false;
        }
    }
}
