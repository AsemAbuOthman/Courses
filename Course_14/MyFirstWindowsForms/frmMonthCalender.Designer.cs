namespace MyFirstWindowsForms
{
    partial class frmMonthCalender
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnStrat = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnSelectedRange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(259, 75);
            this.monthCalendar1.MaxSelectionCount = 5;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // btnStrat
            // 
            this.btnStrat.Location = new System.Drawing.Point(259, 310);
            this.btnStrat.Name = "btnStrat";
            this.btnStrat.Size = new System.Drawing.Size(75, 23);
            this.btnStrat.TabIndex = 1;
            this.btnStrat.Text = "Strat";
            this.btnStrat.UseVisualStyleBackColor = true;
            this.btnStrat.Click += new System.EventHandler(this.btnStrat_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(411, 310);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnSelectedRange
            // 
            this.btnSelectedRange.Location = new System.Drawing.Point(336, 372);
            this.btnSelectedRange.Name = "btnSelectedRange";
            this.btnSelectedRange.Size = new System.Drawing.Size(75, 50);
            this.btnSelectedRange.TabIndex = 4;
            this.btnSelectedRange.Text = "Selected Range";
            this.btnSelectedRange.UseVisualStyleBackColor = true;
            this.btnSelectedRange.Click += new System.EventHandler(this.btnSelectedRange_Click);
            // 
            // frmMonthCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelectedRange);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStrat);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "frmMonthCalender";
            this.Text = "frmMonthCalender";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnStrat;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnSelectedRange;
    }
}