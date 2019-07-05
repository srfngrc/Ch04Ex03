using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04Ex03srfn
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            const string myName = "karli";
            const string sexyName = "angelina";
            const string sillyName = "ploppy";
            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            switch (name.ToLower())
            {
                case myName:
                    Console.WriteLine("You have the same name as me!");
                    break;
                case sexyName:
                    Console.WriteLine("My, what a sexy name you have!");
                    break;
                case sillyName:
                    Console.WriteLine("That's a very silly name.");
                    break;
            }
            Console.WriteLine("Hello {0}!", name);
            Console.ReadKey();
            */

            double balance, interestRate, targetBalance;
            Console.WriteLine("What is your current balance?");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your current annual interest rate (in %)?");
            interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
            Console.WriteLine("What balance would you like to have?");
            targetBalance = Convert.ToDouble(Console.ReadLine());
            int totalYears = 0;

            while (balance < targetBalance)
            {
            balance *= interestRate;
            ++totalYears;
            }
            Console.WriteLine("In {0} year{1} you'll have a balance of {2}.",
            totalYears, totalYears == 1 ? "": "s", balance);
            if (totalYears == 0)
            Console.WriteLine(
            "To be honest, you really didn't need to use this calculator.");
            Console.ReadKey();
        }
    }
}
