using System;

namespace Page_17_Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter customer user ID:");
            string uId = Console.ReadLine();
            Console.WriteLine("Please enter customer bank account number:");
            string accId = Console.ReadLine();
            Console.WriteLine("Please enter bank account branch num:");
            int brNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter bank num:");
            int baNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter account starting balance:");
            int bal = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter account allowed minus:");
            int minus = int.Parse(Console.ReadLine());

            BAccOV ov1 = new BAccOV(uId, accId, brNum, baNum, bal, minus);

            Console.WriteLine("Please enter customer gemel account type:");
            string gT = Console.ReadLine();
            Console.WriteLine("Please enter customer gemel account num:");
            string gNum = Console.ReadLine();
            Console.WriteLine("Please enter gemel monthly deposit:");
            double mD = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter gemel start year");
            int sY = int.Parse(Console.ReadLine());

            //string gType, int sY, string uId, string aN, double mD, double bal=0)
            BAccKG kg1 = new BAccKG(gT, sY, uId, gNum, mD);
            double mDep = kg1.GetMonthlyDeposit();
            bool bSucc = ov1.Withdraw(mDep);
            if (bSucc)
            {
                kg1.MonthlyDeposit(mDep);
            }
            else
            {
                Console.WriteLine("your gemel account is at risk of closing");
            }

        }
    }
}