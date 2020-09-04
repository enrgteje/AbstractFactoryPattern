/* Name: Enrique Tejeda
 * Date: 9/4/2020
 * Filename: Lumia.cs
 * Description: Class inherits from the interface Smart and modifies the function getName() and returns Lumia as a string.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class Lumia : Smart
    {
        public string getName()
        {
            return "Lumia";
        }
    }
}
