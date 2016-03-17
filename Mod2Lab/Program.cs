using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Practice Question 1
            //Console.WriteLine("Please enter a string to be displayed: ");
            //string inputText = Console.ReadLine();
            //Console.WriteLine("**** " + inputText + "! ****");

            //Console.ReadLine();

            // Practice Quesiton 2

            //Console.WriteLine("Please enter a numeric value: ");
            //int numInput = int.Parse(Console.ReadLine());

            //Console.WriteLine(numInput * 2);

            //Console.ReadLine();

            // Lab

            Console.Write("Please enter the price of the house: ");
            string housePrice = Console.ReadLine();

            int price = int.Parse(housePrice);

            Console.Write("Enter the number of years on the mortgage: ");
            int years = int.Parse(Console.ReadLine());

            Console.Write("Enter the interest percentage: ");
            string inputReader = Console.ReadLine();
            int interestPercent = int.Parse(inputReader);

            double interestRate = 1 + (interestPercent / 100.0);

            double total = price * Math.Pow(interestRate, years);

            Console.WriteLine("The total cost of the home: " + total);

            Console.ReadLine();

        }
    }
}
