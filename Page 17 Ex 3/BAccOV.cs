using System;
using System.Collections.Generic;
using System.Text;

namespace Page_17_Ex_3
{
    public class BAccOV 
    {
        string userId;
        string accNum;
        int branchNum;
        int bankNum;  
        double balance;
        double approvedMinus;

        //ctors 
        public BAccOV(string uId, string aNum, int brNum, int baNum,
             double bal, double aM)
        {
            this.userId = uId;
            this.accNum = aNum;
            this.branchNum = brNum;
            this.bankNum = baNum;
            this.balance = bal;
            this.approvedMinus = aM;
        }
        // Deposit Money - return account balance after deposit 
        public double Deposit(double money)
        {
            this.balance += money;
            return balance;
        }
        //Withdraw money retruns the money withdrawn. 
        public bool Withdraw(double money)
        {
            if (this.balance + this.approvedMinus > money)
            {
                this.balance -= money;
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}

