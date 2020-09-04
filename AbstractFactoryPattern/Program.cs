/* Name: Enrique Tejeda
 * Date: 9/4/2020
 * Filename: Program.cs
 * Description: Program has a loop that cycles each phone manufacturer and prints the smart and dumb phone of each manufacturer. 
 */

using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneTypeChecker products;
            for(int i = 0; i < 4; i++)
            {
                products = new PhoneTypeChecker((Manufacturers)i);
                products.CheckProducts();
                Console.WriteLine();
            }
        }
    }
}
