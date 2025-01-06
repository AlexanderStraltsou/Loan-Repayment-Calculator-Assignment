namespace Assignment3
{
    partial class Form1
    {
        private TextBox txtAmount;
        private TextBox txtAnnualInterest;
        private TextBox txtLoanTermInYears;
        private Label lblMonthlyTotal;
        private Label lblNumPayments;
        private Label lblTotalInterest;
        private Label lblTotalPayment;
        private Button btnCalculate;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Loan Repayment Calculator By Aliaksandr Straltsou";
            this.ClientSize = new System.Drawing.Size(800, 300);

            //Includes TextBoxes for inputs, labels for displaying info and button to calculate
            this.txtAmount = new TextBox { Location = new System.Drawing.Point(200, 20), Width = 100 };
            this.txtAnnualInterest = new TextBox { Location = new System.Drawing.Point(200, 50), Width = 100 };
            this.txtLoanTermInYears = new TextBox { Location = new System.Drawing.Point(200, 80), Width = 100 };
            this.lblMonthlyTotal = new Label { Location = new System.Drawing.Point(650, 20), Width = 200 };
            this.lblNumPayments = new Label { Location = new System.Drawing.Point(650, 50), Width = 200 };
            this.lblTotalInterest = new Label { Location = new System.Drawing.Point(650, 80), Width = 200 };
            this.lblTotalPayment = new Label { Location = new System.Drawing.Point(650, 110), Width = 200 };
            this.btnCalculate = new Button { Text = "Calculate", Location = new System.Drawing.Point(150, 120), Width = 150, Height = 40 };
            this.btnCalculate.Click += new EventHandler(this.btnCalcLoanRepayment_Click);
            this.Controls.Add(new Label { Text = "Amount", Location = new System.Drawing.Point(20, 20), Width = 100 });
            this.Controls.Add(new Label { Text = "Annual Interest (%)", Location = new System.Drawing.Point(20, 50), Width = 150 });
            this.Controls.Add(new Label { Text = "Period (years)", Location = new System.Drawing.Point(20, 80), Width = 150 });
            this.Controls.Add(new Label { Text = "Monthly due amount", Location = new System.Drawing.Point(400, 20), Width = 250 });
            this.Controls.Add(new Label { Text = "Number of payments (months)", Location = new System.Drawing.Point(400, 50), Width = 250 });
            this.Controls.Add(new Label { Text = "Total interest", Location = new System.Drawing.Point(400, 80), Width = 250 });
            this.Controls.Add(new Label { Text = "Total amount + interest", Location = new System.Drawing.Point(400, 110), Width = 250 });

            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtAnnualInterest);
            this.Controls.Add(this.txtLoanTermInYears);
            this.Controls.Add(this.lblMonthlyTotal);
            this.Controls.Add(this.lblNumPayments);
            this.Controls.Add(this.lblTotalInterest);
            this.Controls.Add(this.lblTotalPayment);
            this.Controls.Add(this.btnCalculate);
        }
        #endregion
    }

}
