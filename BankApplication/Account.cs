using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    /// <summary>
    /// Base class for accounts, to be derived into savings and checking accounts
    /// </summary>
    public abstract class Account
    {
        private decimal Balance;

        /// <summary>
        /// Constructor for the base class account
        /// </summary>
        /// <param name="startBalance"></param>
        public Account(decimal startBalance)
        {
            if (startBalance < 0)
            {
                throw new Exception();
            }
            Balance = startBalance;
        }

        /// <summary>
        /// Method to be used and overriden to add to balance
        /// </summary>
        /// <param name="amtAdd"></param>
        public virtual void Credit(decimal amtAdd)
        {
            Balance += amtAdd;
        }

        /// <summary>
        /// Method to be used and overriden to take away from balance
        /// </summary>
        /// <param name="amtSub"></param>
        /// <returns></returns>
        public virtual bool Debit(decimal amtSub)
        {
            Balance -= amtSub;
            if(Balance < 0)
            {
                Balance += amtSub;
                Console.WriteLine("Debit amount exceeded account balance");
                return false;
            }
            return true;
        }

        /// <summary>
        /// getter method for the private variable balance
        /// </summary>
        /// <returns></returns>
        public decimal GetBalance()
        {
            return Balance;
        }
    }
}
