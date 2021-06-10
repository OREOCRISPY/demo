using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Account
    {
        private String pin;
        private int balance;
        public Account() { pin = "123";balance = 1000; }
        public int CheckBalance() {
            return balance;
        }
        public void WithdrawCash(int amount,out String msg)
        {
            if (amount <= balance && amount >= 0)
            {
                balance = balance - amount;
                msg = "successed";
            }
            else if (amount > balance)
            {
                msg = "insufficient balance";
            }
            else if (amount < 0) {
                msg = "amount cant be negative";
            }
            else
            {
                msg = "unknow error";
            }
        }

        public void DepositCash( int amount, out String msg) {
            if (amount > 0)
            {
                balance = balance + amount;
                msg = "successed";
            }
            else if (amount < 0) {
                msg = "amount cant be negative";
            }
            else
            {
                msg = "unknow error";
            }
        }
        public Boolean CheckPin(String pin) {
            return pin.CompareTo(this.pin)==0?true:false;
        }
    }
}
