namespace Assignment3
{
    public partial class Form1 : Form
    {
        private LoanRepayment loanRepayment;

        public Form1()
        {
            InitializeComponent();
            loanRepayment = new LoanRepayment();
        }

        //Function for handling Calculate button click which activating functions that reading inputs and showing the results
        private void btnCalcLoanRepayment_Click(object sender, EventArgs e)
        {
            bool ok = ReadLoanRepaymentInput();
            if (ok)
                DisplayLoanRepaymentResults();
        }

        //Function for reading and validating users inputs
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

        //Function for displaying all the repayment details
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
