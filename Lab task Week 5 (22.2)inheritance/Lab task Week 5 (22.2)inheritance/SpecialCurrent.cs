﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_Week_5__22._2_inheritance
{
    class SpecialCurrent : Account
    {
         int openingBalance;
        int minBalance;

        public SpecialCurrent() { }
        public SpecialCurrent(string accName, string accid, int balance)
            : base(accName, accid, balance)
        {
            this.OpeningBalance = balance;
            minBalance = (openingBalance * 10) / 100;
        }
        public int OpeningBalance
        {
            set { this.openingBalance = value; }
            get { return this.openingBalance; }
        }
        public int MinBalance
        {
            get { return this.minBalance; }
        }

        public override void Withdraw(int amount)
        {
            if (this.MinBalance < this.Balance - amount)
            {
                base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Minimum balance exceed!!");
                Console.WriteLine();
            }
        }

        public override void Deposit(int amount)
        {
            base.Deposit(amount);
        }

        public override void Transfer(int amount, Account acc)
        {
            if (this.MinBalance < base.Balance - amount)
            {
                base.Transfer(amount, acc);
            }
            else
            {
                Console.WriteLine(" Minimum balance exceed!!");
                Console.WriteLine();
            }
        }
    }
}