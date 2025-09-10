// HW1a Sales Total

// Your Name: Bailey Johnson
// Did you seek help ? If yes, specify the helper or web link here: Max Ngo

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sales tax rate stored in a variable 
           const double SalesTaxRate = 0.085;

            //Promot user for item 
            Console.WriteLine("What is the product name of the item you are purchasing?");
            String item = Console.ReadLine();

            //Promot for quainity 
            Console.WriteLine("How many items of the product are you purchsing?");
            int quantity = int.Parse(Console.ReadLine());

            //How much is the item
            Console.WriteLine("What is the price for each " + item);
            double price = double.Parse(Console.ReadLine());

            //subtotal
            double subtotal = (price * quantity);
            //rounding: Variable = Math.Round(Variable, Decimal Places)
            subtotal = Math.Round(subtotal, 2);
            Console.WriteLine("Your subtotal for your bill is $" + subtotal);

            //sales tax
            double salestax = (SalesTaxRate * subtotal);
            salestax= Math.Round(salestax, 2);
            Console.WriteLine("Your sales tax for the bill is $" + salestax);

            //sales total
            double salestotal = (subtotal + salestax);
            salestotal=Math.Round(salestotal, 2);
            Console.WriteLine("Your total for the bill is $" + salestotal);
        }
    }
}
