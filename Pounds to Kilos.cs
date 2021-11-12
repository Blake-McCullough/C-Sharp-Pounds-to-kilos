using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Made By Blake McCullough
//Discord - Spoiled_Kitten#4911
//Github - https://github.com/Blake-McCullough/
//Email - privblakemccullough@protonmail.com


namespace Pounds_to_Kilos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declaring Variables */

            double pounds = 0;
            double kilos = 0;
            double convAmount = 2.2;
            string input = "";


            /* Gather pounds from user*/

            Console.Write("Please Enter an amount in pounds:  ");
            input = Console.ReadLine();

            /*Converts string input into numerical variable*/

            pounds = double.Parse(input);

            /*Converted to kilos*/

            kilos = pounds / convAmount;

            /* Rounds to 2 decimal places */

            kilos = Math.Round(kilos, 2);

            /* Displaying output to user*/

            Console.Write(pounds +" pounds is equal to " + kilos+ " kilos.");

            /* Prevents from closing immediately*/
            Console.ReadLine();
        }
    }
}
