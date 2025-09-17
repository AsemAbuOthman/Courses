namespace PizzaApp
{
    partial class frmPizzaOrder
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
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPapers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkTommatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeAWay = new System.Windows.Forms.RadioButton();
            this.rbDineIn = new System.Windows.Forms.RadioButton();
            this.lblMakeYourOwnPizza = new System.Windows.Forms.Label();
            this.gbOrdreSummary = new System.Windows.Forms.GroupBox();
            this.lblTotalPriceAnswer = new System.Windows.Forms.Label();
            this.lblWhereToEatAnswer = new System.Windows.Forms.Label();
            this.lblCrustTypeAnswer = new System.Windows.Forms.Label();
            this.lblToppingsAnswer = new System.Windows.Forms.Label();
            this.lblSizeAnswer = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetPizza = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbOrdreSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSize.Location = new System.Drawing.Point(42, 98);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(166, 138);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(45, 98);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(52, 17);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(45, 68);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(62, 17);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(45, 38);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(50, 17);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbCrust
            // 
            this.gbCrust.Controls.Add(this.rbThickCrust);
            this.gbCrust.Controls.Add(this.rbThinCrust);
            this.gbCrust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCrust.Location = new System.Drawing.Point(42, 289);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(166, 138);
            this.gbCrust.TabIndex = 2;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust";
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Location = new System.Drawing.Point(45, 83);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(79, 17);
            this.rbThickCrust.TabIndex = 1;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Text = "Thick Crust";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThickCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Location = new System.Drawing.Point(45, 53);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(76, 17);
            this.rbThinCrust.TabIndex = 0;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Text = " Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkGreenPapers);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkTommatoes);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkExtraCheese);
            this.gbToppings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbToppings.Location = new System.Drawing.Point(297, 98);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(236, 138);
            this.gbToppings.TabIndex = 1;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkGreenPapers
            // 
            this.chkGreenPapers.AutoSize = true;
            this.chkGreenPapers.Location = new System.Drawing.Point(127, 99);
            this.chkGreenPapers.Name = "chkGreenPapers";
            this.chkGreenPapers.Size = new System.Drawing.Size(91, 17);
            this.chkGreenPapers.TabIndex = 5;
            this.chkGreenPapers.Text = "Green Papers";
            this.chkGreenPapers.UseVisualStyleBackColor = true;
            this.chkGreenPapers.CheckedChanged += new System.EventHandler(this.chkGreenPapers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(127, 68);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(55, 17);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkTommatoes
            // 
            this.chkTommatoes.AutoSize = true;
            this.chkTommatoes.Location = new System.Drawing.Point(9, 100);
            this.chkTommatoes.Name = "chkTommatoes";
            this.chkTommatoes.Size = new System.Drawing.Size(81, 17);
            this.chkTommatoes.TabIndex = 2;
            this.chkTommatoes.Text = "Tommatoes";
            this.chkTommatoes.UseVisualStyleBackColor = true;
            this.chkTommatoes.CheckedChanged += new System.EventHandler(this.chkTommatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(9, 68);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(80, 17);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(127, 38);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(54, 17);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(9, 38);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(89, 17);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeAWay);
            this.gbWhereToEat.Controls.Add(this.rbDineIn);
            this.gbWhereToEat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbWhereToEat.Location = new System.Drawing.Point(300, 289);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(229, 138);
            this.gbWhereToEat.TabIndex = 3;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where to eat ?";
            // 
            // rbTakeAWay
            // 
            this.rbTakeAWay.AutoSize = true;
            this.rbTakeAWay.Location = new System.Drawing.Point(30, 83);
            this.rbTakeAWay.Name = "rbTakeAWay";
            this.rbTakeAWay.Size = new System.Drawing.Size(85, 17);
            this.rbTakeAWay.TabIndex = 1;
            this.rbTakeAWay.TabStop = true;
            this.rbTakeAWay.Text = "Take A Way";
            this.rbTakeAWay.UseVisualStyleBackColor = true;
            this.rbTakeAWay.CheckedChanged += new System.EventHandler(this.rbTakeAWay_CheckedChanged);
            // 
            // rbDineIn
            // 
            this.rbDineIn.AutoSize = true;
            this.rbDineIn.Location = new System.Drawing.Point(30, 53);
            this.rbDineIn.Name = "rbDineIn";
            this.rbDineIn.Size = new System.Drawing.Size(59, 17);
            this.rbDineIn.TabIndex = 0;
            this.rbDineIn.TabStop = true;
            this.rbDineIn.Text = "Dine In";
            this.rbDineIn.UseVisualStyleBackColor = true;
            this.rbDineIn.CheckedChanged += new System.EventHandler(this.rbDineIn_CheckedChanged);
            // 
            // lblMakeYourOwnPizza
            // 
            this.lblMakeYourOwnPizza.AutoSize = true;
            this.lblMakeYourOwnPizza.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeYourOwnPizza.ForeColor = System.Drawing.Color.Red;
            this.lblMakeYourOwnPizza.Location = new System.Drawing.Point(46, 9);
            this.lblMakeYourOwnPizza.Name = "lblMakeYourOwnPizza";
            this.lblMakeYourOwnPizza.Size = new System.Drawing.Size(439, 59);
            this.lblMakeYourOwnPizza.TabIndex = 3;
            this.lblMakeYourOwnPizza.Text = "Make Your Own Pizza";
            // 
            // gbOrdreSummary
            // 
            this.gbOrdreSummary.Controls.Add(this.lblTotalPriceAnswer);
            this.gbOrdreSummary.Controls.Add(this.lblWhereToEatAnswer);
            this.gbOrdreSummary.Controls.Add(this.lblCrustTypeAnswer);
            this.gbOrdreSummary.Controls.Add(this.lblToppingsAnswer);
            this.gbOrdreSummary.Controls.Add(this.lblSizeAnswer);
            this.gbOrdreSummary.Controls.Add(this.lblTotalPrice);
            this.gbOrdreSummary.Controls.Add(this.lblWhereToEat);
            this.gbOrdreSummary.Controls.Add(this.lblCrustType);
            this.gbOrdreSummary.Controls.Add(this.lblToppings);
            this.gbOrdreSummary.Controls.Add(this.lblSize);
            this.gbOrdreSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOrdreSummary.Location = new System.Drawing.Point(567, 98);
            this.gbOrdreSummary.Name = "gbOrdreSummary";
            this.gbOrdreSummary.Size = new System.Drawing.Size(290, 329);
            this.gbOrdreSummary.TabIndex = 6;
            this.gbOrdreSummary.TabStop = false;
            this.gbOrdreSummary.Text = "Ordre Summary";
            // 
            // lblTotalPriceAnswer
            // 
            this.lblTotalPriceAnswer.AutoSize = true;
            this.lblTotalPriceAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceAnswer.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPriceAnswer.Location = new System.Drawing.Point(127, 293);
            this.lblTotalPriceAnswer.Name = "lblTotalPriceAnswer";
            this.lblTotalPriceAnswer.Size = new System.Drawing.Size(0, 24);
            this.lblTotalPriceAnswer.TabIndex = 15;
            // 
            // lblWhereToEatAnswer
            // 
            this.lblWhereToEatAnswer.AutoSize = true;
            this.lblWhereToEatAnswer.Location = new System.Drawing.Point(127, 232);
            this.lblWhereToEatAnswer.Name = "lblWhereToEatAnswer";
            this.lblWhereToEatAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblWhereToEatAnswer.TabIndex = 14;
            // 
            // lblCrustTypeAnswer
            // 
            this.lblCrustTypeAnswer.AutoSize = true;
            this.lblCrustTypeAnswer.Location = new System.Drawing.Point(127, 169);
            this.lblCrustTypeAnswer.Name = "lblCrustTypeAnswer";
            this.lblCrustTypeAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblCrustTypeAnswer.TabIndex = 13;
            // 
            // lblToppingsAnswer
            // 
            this.lblToppingsAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToppingsAnswer.Location = new System.Drawing.Point(127, 106);
            this.lblToppingsAnswer.Name = "lblToppingsAnswer";
            this.lblToppingsAnswer.Size = new System.Drawing.Size(157, 58);
            this.lblToppingsAnswer.TabIndex = 12;
            // 
            // lblSizeAnswer
            // 
            this.lblSizeAnswer.AutoSize = true;
            this.lblSizeAnswer.Location = new System.Drawing.Point(127, 45);
            this.lblSizeAnswer.Name = "lblSizeAnswer";
            this.lblSizeAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblSizeAnswer.TabIndex = 11;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(20, 296);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(88, 20);
            this.lblTotalPrice.TabIndex = 10;
            this.lblTotalPrice.Text = "Total Price : ";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.Location = new System.Drawing.Point(20, 227);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(99, 20);
            this.lblWhereToEat.TabIndex = 9;
            this.lblWhereToEat.Text = "Where to Eat : ";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.Location = new System.Drawing.Point(20, 164);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(88, 20);
            this.lblCrustType.TabIndex = 8;
            this.lblCrustType.Text = "Crust Type : ";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(20, 101);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(80, 20);
            this.lblToppings.TabIndex = 7;
            this.lblToppings.Text = "Toppings : ";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(20, 38);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(47, 20);
            this.lblSize.TabIndex = 6;
            this.lblSize.Text = "Size : ";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(300, 452);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(91, 34);
            this.btnOrderPizza.TabIndex = 4;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetPizza
            // 
            this.btnResetPizza.Location = new System.Drawing.Point(440, 452);
            this.btnResetPizza.Name = "btnResetPizza";
            this.btnResetPizza.Size = new System.Drawing.Size(89, 34);
            this.btnResetPizza.TabIndex = 5;
            this.btnResetPizza.Text = "Reset Pizza";
            this.btnResetPizza.UseVisualStyleBackColor = true;
            this.btnResetPizza.Click += new System.EventHandler(this.btnResetPizza_Click);
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 498);
            this.Controls.Add(this.btnResetPizza);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbOrdreSummary);
            this.Controls.Add(this.lblMakeYourOwnPizza);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbSize);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.frmPizzaOrder_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbOrdreSummary.ResumeLayout(false);
            this.gbOrdreSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.CheckBox chkGreenPapers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkTommatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.RadioButton rbTakeAWay;
        private System.Windows.Forms.RadioButton rbDineIn;
        private System.Windows.Forms.Label lblMakeYourOwnPizza;
        private System.Windows.Forms.GroupBox gbOrdreSummary;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetPizza;
        private System.Windows.Forms.Label lblSizeAnswer;
        private System.Windows.Forms.Label lblWhereToEatAnswer;
        private System.Windows.Forms.Label lblCrustTypeAnswer;
        private System.Windows.Forms.Label lblToppingsAnswer;
        private System.Windows.Forms.Label lblTotalPriceAnswer;
    }
}

