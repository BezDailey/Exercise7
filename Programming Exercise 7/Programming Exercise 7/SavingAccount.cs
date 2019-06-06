using BankAccountNamespace;
using System;
using System.Windows.Forms;

namespace SavingAccountNamespace
{
    class SavingAccount : BankAccount
    {
        private double interest;

        public SavingAccount()
            : base()
        {

        }

        public SavingAccount(string uId, int aId, double bal, string first, string last)
            :base(uId, aId, bal, first, last)
        {
            interest = .23;
            overdraftFee = 15;
        }

        public double Interest
        {
            get
            {
                return interest;
            }
            set
            {
                interest = value;
            }
        }

        public override void Deposit(double amt)
        {
            double Amt;
            Amt = amt;
            Math.Round(Amt, 2);
            accountBal += Amt;
            Math.Round(accountBal, 2);
        }

        public override void Withdraw(double amt)
        {
            Math.Round(amt, 2);
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

        public void CompoundInterest()
        {
            double value;
            value = accountBal;
            value = value * interest;
            Math.Round(value, 2);
            accountBal += value;
            Math.Round(accountBal, 2);
        }
    }
}
