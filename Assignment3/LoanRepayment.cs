using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public class LoanRepayment
    {

        // Variables for user inputs
        private double loanAmount;
        private double annualInterestRate;
        private double monthlyPayment;
        private int periodInYears;

        //// Get & Set Properties
        public double GetLoanAmount() => loanAmount;
        public void SetLoanAmount(double amount) => loanAmount = amount;
        public double GetAnnualInterestRate() => annualInterestRate;
        public void SetAnnualInterestRate(double amount) => annualInterestRate = amount;
        public int GetLoanTermInYears() => periodInYears;
        public void SetLoanTermInYears(int years) => periodInYears = years;
        public int GetNumOfPayments() => periodInYears * 12;


        //Function for calculating monthly repayment according to EMI
        public double GetMonthlyRepayment()
        {
            double monthlyRate = annualInterestRate / (12 * 100);
            int numOfPayments = GetNumOfPayments();
            return loanAmount * monthlyRate / (1 - Math.Pow(1 + monthlyRate, -numOfPayments));
        }

        //Function for calculating total payment amount
        public double GetTotalPayment()
        {
            return GetMonthlyRepayment() * GetNumOfPayments();
        }
    }
}
