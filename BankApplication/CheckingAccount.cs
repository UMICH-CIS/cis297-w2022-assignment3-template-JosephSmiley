using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    /// <summary>
    /// Constuctor for the checking account
    /// </summary>
    public class CheckingAccount : Account
    {
        private decimal Fee;

        /// <summary>
        /// Constuctor for the checking account which also initializes the fee added to the transaction
        /// </summary>
        public CheckingAccount(decimal startBalance, decimal fee) : base(startBalance)
        {
            Fee = fee;
        }

        /// <summary>
        /// overrided method for taking money out of the checking account
        /// </summary>
        /// <param name="amtToAdd"></param>
        public override void Credit(decimal amtToAdd)
        {
            base.Credit(amtToAdd);
            base.Debit(Fee);
        }

        /// <summary>
        /// overrided method for putting money into the checking account
        /// </summary>
        /// <param name="amtToAdd"></param>
        public override bool Debit(decimal amtToAdd)
        {
            bool check = base.Debit(amtToAdd);
            if (check)
            {
                base.Debit(Fee);
            }
            return check;
        }
    }
}
