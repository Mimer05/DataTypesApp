using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesApp
{
    class DataTypesProgram
{
        static void Main(string[] args)
        {
           //to print char unicode text
         Console.OutputEncoding = System.Text.Encoding.Unicode;
         //The date today
         Console.WriteLine(DateTime.Now.ToString("\t\t     MM/dd/yy ۩")); 
         Console.WriteLine("\t********** ѽ  APPLE STORE ѽ ************");
            //User input Pieces of apple, and the total price 
         Console.Write("\tEnter the pieces of apple: ");
          int NumberOfPieces = Convert.ToInt32(Console.ReadLine()); Console.Beep();
         Console.Write("\tEnter total price of " + NumberOfPieces + " apples(s): ");
           double TotalPrice = Convert.ToDouble(Console.ReadLine()); Console.Beep();
           int ConvertedPrice = Convert.ToInt32 (Math.Floor(TotalPrice));

         //printing the total price, original price, converted price
         Console.WriteLine("\tThe total price of " + NumberOfPieces + " apples(s) is " + TotalPrice);
         Console.WriteLine("\t===================================="); Console.Beep();
         Console.WriteLine("\tThe value of original price is " + TotalPrice); 
         Console.WriteLine("\tThe value of converted price is " + ConvertedPrice);
         Console.WriteLine("\t====================================");
         Console.WriteLine("\t♪ Press any key to exit  ♪");
         Console.ReadKey();
        }
 }
}
