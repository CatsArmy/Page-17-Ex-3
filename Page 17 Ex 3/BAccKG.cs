using System;
using System.Collections.Generic;
using System.Text;

namespace Page_17_Ex_3
{


    public class BAccKG 
    {
        string gemelType;
        int startYear; 
        string userId; 
        string accNum; 
        double balance;
        double monthlyDeposit; 
                               
        public BAccKG(string gType, int sY, string uId, string aN, double mD, double bal = 0)
        {
            this.gemelType = gType;
            this.startYear = sY;
            this.userId = uId;
            this.accNum = aN;
            this.balance = bal;
            this.monthlyDeposit = mD;
        }
        public double GetMonthlyDeposit()
        {
            return this.monthlyDeposit;
        }
        public void MonthlyDeposit(double money)
        {
            this.balance += money;
        }
        public int YearRemain()
        {// i removed the DateTime todayDate = DateTime.Now;
            int todayYear = 2023;//int todayYear = todayDate.Year();
            return (15 - (todayYear - this.startYear));//because it never worked
        }

    }



}

