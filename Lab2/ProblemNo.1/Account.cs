using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemNo._1
{
    public class Account
    {
        #region Fields
        private double anualnterestRate;
        private decimal balance;
        private DateTime dateCreated;
        private string id;
        #endregion

        #region Constructors
        public Account() { }
              
        public Account(decimal balance)
        {
            Balance = balance;
        }
        #endregion

        #region Properties
        public double AnualInterestRate
        {
            get
            {
                return anualnterestRate;
            }

            set
            {
                if (value <= 0)
                {
                    anualnterestRate = value;
                }
            }
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }

            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
            }
        }

        public DateTime DateCreated
        {
            get
            {
                return dateCreated;
            }

            set
            {
                value = dateCreated;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        #endregion
    }
}