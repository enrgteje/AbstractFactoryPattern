/* Name: Enrique Tejeda
 * Date: 9/4/2020
 * Filename: SamsungFactory.cs
 * Description: Class inherits the functions from the interface PhoneFactory and creates an object. It returns an object that is holding
 *              a string of the dumbPhone or smartPhone.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class SamsungFactory : PhoneFactory
    {
        public Dumb GetDumb()
        {
            Dumb dumbPhone;
            return dumbPhone = new Genio();
        }

        public Smart GetSmart()
        {
            Smart smartPhone;
            return smartPhone = new GalaxyS2();
        }
    }
}
