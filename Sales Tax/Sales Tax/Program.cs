using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Tax
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare variables
            double purchaseAmount;
            double stateTax;
            double countyTax;
            double totalSales;
           

            //Prompt for amount to purchase
            Console.WriteLine("What is the amount of your purchase?");

            //Get purchase amount
            purchaseAmount = Convert.ToDouble(Console.ReadLine());

            //Display purchaseAmount
            Console.WriteLine(" The amount of your purchase is : {0} ", purchaseAmount);

            //intialize county tax
            countyTax = purchaseAmount * .02; 

            //display countyTax
            Console.WriteLine(" Your county tax is: {0} ", countyTax );

            //Intialize stateTax
            stateTax = purchaseAmount * .04;

            //Calculate and display state sales tax
            Console.WriteLine("Your state sales tax is: {0} ", stateTax);

            
            //intialize totalSales
            totalSales = purchaseAmount + countyTax + stateTax;
            
     
            //Total Sales
            Console.WriteLine("Your total purchase amount is: {0}", totalSales);


            Console.ReadKey();


        }
    }
}
