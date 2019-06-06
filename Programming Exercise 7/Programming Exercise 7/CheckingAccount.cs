using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAccountNamespace;

namespace CheckingAccountNampespace
{
    class CheckingAccount : BankAccount
    {
        private double minimumBalance;
        private double fee;

        public CheckingAccount()
            : base()
        {

        }

        public double MinimumBalance
        {
            get
            {
                return minimumBalance;
            }
            set
            {
                minimumBalance = value;
            }
        }

        public double Fee
        {
            get
            {
                return fee;
            }
            set
            {
                fee = value;
            }
        }

        public CheckingAccount(string uId, int aId, double bal, string first, string last)
            : base(uId, aId, bal, first, last)
        {
            minimumBalance = 500;
            fee = 10;
            overdraftFee = 15;
        }

        public override void Deposit(double amt)
        {

            double Amt;
            Amt = amt;
            Math.Round(Amt, 2);
            if (accountBal < minimumBalance)
            {
                Amt -= fee;
                accountBal += Amt;
                Math.Round(accountBal, 2);
                MessageBox.Show("Account Lower Then $500 Fee Applied");
            }
            else
            {
                accountBal += Amt;
                Math.Round(accountBal, 2);
            }
        }

        public override void Withdraw(double amt)
        {
            if (amt > accountBal)
            {
                accountBal -= overdraftFee;
                Math.Round(accountBal, 2);
                MessageBox.Show("Amount Larger Then Current Held Balance Overdraft Fee Applied");
            }
            else
            {
                accountBal -= amt;
                Math.Round(accountBal, 2);

            }
        }
    }
}
