namespace Assignment3
{
    /// <summary>
    /// Main Form for the Loan Repayment application for handling of user interaction and displaying calculated loan repayment details
    /// </summary>
    public partial class Form1 : Form
    {
        private LoanRepayment loanRepayment;

        public Form1()
        {
            InitializeComponent();
            loanRepayment = new LoanRepayment();
        }


        /// <summary>
        /// Function for handling Calculate button click which is activating functions that reading inputs 
        /// if valid showing the loan repayment results
        /// </summary>
        /// <param name="sender">Calculate Button</param>
        /// <param name="e"></param>
        private void btnCalcLoanRepayment_Click(object sender, EventArgs e)
        {
            bool ok = ReadLoanRepaymentInput();
            if (ok)
                DisplayLoanRepaymentResults();
        }


        /// <summary>
        /// Function for reading and validating users inputs for loan repayment details.
        /// Displays an error message if input validation fails
        /// </summary>
        /// <returns>
        /// Returns true if input is valid and false if not
        /// </returns>
        private bool ReadLoanRepaymentInput()
        {
            bool ok = true;

            try
            {
                loanRepayment.SetLoanAmount(Convert.ToDouble(txtAmount.Text));
                loanRepayment.SetAnnualInterestRate(Convert.ToDouble(txtAnnualInterest.Text));
                loanRepayment.SetLoanTermInYears(Convert.ToInt32(txtLoanTermInYears.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Make Sure You Typed In All The Information Correctly And Entered Numbers Only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }

            return ok;
        }


        /// <summary>
        /// Function for displaying all the repayment details in the UI
        /// </summary>
        private void DisplayLoanRepaymentResults()
        {
            double monthlyRepayment = loanRepayment.GetMonthlyRepayment();
            int numOfPayments = loanRepayment.GetNumOfPayments();
            double totalPayment = loanRepayment.GetTotalPayment();
            double totalInterest = totalPayment - loanRepayment.GetLoanAmount();

            lblMonthlyTotal.Text = monthlyRepayment.ToString("N2");
            lblNumPayments.Text = numOfPayments.ToString();
            lblTotalInterest.Text = totalInterest.ToString("N2");
            lblTotalPayment.Text = totalPayment.ToString("N2");
        }
    }
}
