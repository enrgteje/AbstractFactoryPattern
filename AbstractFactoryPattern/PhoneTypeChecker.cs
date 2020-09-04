/* Name: Enrique Tejeda
 * Date: 9/4/2020
 * Filename: PhoneTypeChecker.cs
 * Description: Class has an enum with the phone manufacturers and sets the object Manufacturers m to the right factory. In the switch,
 *              it will print the dumb and smart phone for each manufacturer. If the manufacturer isn't the one that is listed then it will
 *              print to the console that the manufacturer doesn't exist.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class PhoneTypeChecker
    {
        Manufacturers manu;
        PhoneFactory factory;
        public PhoneTypeChecker(Manufacturers m)
        {
            manu = m;
        }
        public void CheckProducts()
        {
            switch (manu)
            {
                case 0:
                    factory = new SamsungFactory();
                    Console.WriteLine("Dumb Phone by Samsung:");
                    Console.WriteLine(factory.GetDumb().getName());
                    Console.WriteLine("Smart Phone by Samsung:");
                    Console.WriteLine(factory.GetSmart().getName());
                    break;
                case (Manufacturers)1:
                    factory = new HTCFactory();
                    Console.WriteLine("Dumb Phone by HTC:");
                    Console.WriteLine(factory.GetDumb().getName());
                    Console.WriteLine("Smart Phone by HTC:");
                    Console.WriteLine(factory.GetSmart().getName());
                    break;
                case (Manufacturers)2:
                    factory = new NokiaFactory();
                    Console.WriteLine("Dumb Phone by Nokia:");
                    Console.WriteLine(factory.GetDumb().getName());
                    Console.WriteLine("Smart Phone by Nokia:");
                    Console.WriteLine(factory.GetSmart().getName());
                    break;
                default:
                    Console.WriteLine("Phone doesn't exist");
                    break;
            }
        }

    }
}

enum Manufacturers { SAMSUNG, HTC, NOKIA }
