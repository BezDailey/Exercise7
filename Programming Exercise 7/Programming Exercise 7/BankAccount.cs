using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountNamespace
{
    public abstract class BankAccount
    {
        protected string userId;
        protected int accountId;
        protected double accountBal;
        protected string fName;
        protected string lName;
        protected double overdraftFee;

        public BankAccount()
        {

        }

        public BankAccount(string uId, int aId, double bal, string first, string last)
        {
            userId = uId;
            accountId = aId;
            accountBal = bal;
            fName = first;
            lName = last;
            overdraftFee = 15;
        }

        public string UserId
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
            }
        }

        public int AccountId
        {
            get
            {
                return accountId;
            }
            set
            {
                accountId = value;
            }
        }

        public double AccountBal
        {
            get
            {
                return accountBal;
            }
            set
            {
                accountBal = value;
            }
        }

        public string FName
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }

        public string LName
        {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }
        }

        public double OverdraftFee
        {
            get
            {
                return overdraftFee;
            }
            set
            {
                overdraftFee = value;
            }
        }

        public virtual void Deposit(double amt)
        {
            accountBal += amt;
        }

        public virtual void Withdraw(double amt)
        {
            if (amt > accountBal)
            {
                accountBal -= overdraftFee;
            }
            else
            {
                accountBal -= amt;
            }
        }

    }
}
