/* Name: Enrique Tejeda
 * Date: 9/4/2020
 * Filename: Asha.cs
 * Description: Class inherits from the interface Dumb and modifies the function getName() and returns Asha as a string.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class Asha : Dumb
    {
        public string getName()
        {
            return "Asha";
        }

    }
}
