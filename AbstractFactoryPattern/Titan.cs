/* Name: Enrique Tejeda
 * Date: 9/4/2020
 * Filename: Titan.cs
 * Description: Class inherits from the interface Smart and modifies the function getName() and returns Titan as a string.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class Titan : Smart
    {
        public string getName()
        {
            return "Titan";
        }
    }
}
