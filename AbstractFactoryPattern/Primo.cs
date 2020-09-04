/* Name: Enrique Tejeda
 * Date: 9/4/2020
 * Filename: Primo.cs
 * Description: Class inherits from the interface Dumb and modifies the function getName() and returns Primo as a string.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class Primo : Dumb
    {
        public string getName()
        {
            return "Primo";
        }
    }
}
