using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    /// <summary>
    /// Represents logic for calculating user inputs such as loan amount,
    /// annual interest rate, and repayment period in years.
    /// </summary>
    public class LoanRepayment
    {

        // Fields
        private double loanAmount;
        private double annualInterestRate;
        private double monthlyPayment;
        private int periodInYears;

        /// <summary>
        /// Gets the loan amount
        /// </summary>
        /// <returns>Returns loan amount as a double</returns>
        public double GetLoanAmount() => loanAmount;

        /// <summary>
        /// Sets the loan amount
        /// </summary>
        /// <param name="amount">Should be non-negative double</param>
        public void SetLoanAmount(double amount) => loanAmount = amount;

        /// <summary>
        /// Gets the annual interest rate
        /// </summary>
        /// <returns>Returns annual interest rate as a percentage</returns>
        public double GetAnnualInterestRate() => annualInterestRate;

        /// <summary>
        /// Sets the annual interest rate
        /// </summary>
        /// <param name="amount">Annual interest rate as a percentage</param>
        public void SetAnnualInterestRate(double amount) => annualInterestRate = amount;

        /// <summary>
        /// Gets loan period in years
        /// </summary>
        /// <returns>Period in years as an integer</returns>
        public int GetLoanTermInYears() => periodInYears;

        
        /// <summary>
        /// Sets loan period in years
        /// </summary>
        /// <param name="years">Period in years as an integer</param>
        public void SetLoanTermInYears(int years) => periodInYears = years;


        /// <summary>
        /// Calculationg total number of payments for full period
        /// </summary>
        /// <returns>
        /// Returns total number of monthly payments as int
        /// </returns>
        public int GetNumOfPayments() => periodInYears * 12;


        /// <summary>
        /// Function for calculating monthly repayment according to EMI
        /// </summary>
        /// <returns>Returns monthly payment amount as a double
        /// </returns>
        public double GetMonthlyRepayment()
        {
            double monthlyRate = annualInterestRate / (12 * 100);
            int numOfPayments = GetNumOfPayments();
            return loanAmount * monthlyRate / (1 - Math.Pow(1 + monthlyRate, -numOfPayments));
        }

        /// <summary>
        /// Function for calculating total payment amount over the full period
        /// </summary>
        /// <returns>
        /// Returns total payment amount as a double
        /// </returns>
        public double GetTotalPayment()
        {
            return GetMonthlyRepayment() * GetNumOfPayments();
        }
    }
}
