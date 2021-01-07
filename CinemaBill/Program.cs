using System;

namespace CinemaBill
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Welcome  to Shoprite Cinema. \n Cost per Cinema is 5$. \n Kindly insert your cash : ");

            double cash = Convert.ToInt32(Console.ReadLine());

            if (cash < 5)
            {
                System.Console.WriteLine("That's Not Enough Money... Ticket per Cinema is 5$!");
            }

            else if (cash == 5)
            {
                System.Console.WriteLine("Here'e is your ticket, Do have a nice time");
            }
            else
            {
                double change = cash - 5;
                System.Console.WriteLine("That's some huge amount, \n Here's your ticket and " + change + "$ change");

                Console.ReadLine();


            }
        }

    }
}
