using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{

    /// <summary>
    /// Derived class to implement the savings account
    /// </summary>
    public class SavingsAccount : Account
    {
        private decimal InterestRate;

        /// <summary>
        /// Constructor for the savings account which includes an interest rate
        /// </summary>
        /// <param name="startBalance"></param>
        /// <param name="rate"></param>
        public SavingsAccount(decimal startBalance, decimal rate) : base(startBalance)
        {
            InterestRate = rate;
        }
        
        /// <summary>
        /// Method to calculate the amount of money being added due to interest
        /// </summary>
        /// <returns></returns>
        public decimal CalculateInterest()
        {
            decimal amtToAdd;

            amtToAdd = GetBalance() * InterestRate;

            return amtToAdd;
        }
    }
}
