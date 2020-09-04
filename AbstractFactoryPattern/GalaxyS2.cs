/* Name: Enrique Tejeda
 * Date: 9/4/2020
 * Filename: GalaxyS2.cs
 * Description: Class inherits from the interface Smart and modifies the function getName() and returns GalaxyS2 as a string.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class GalaxyS2 : Smart
    {
        public string getName()
        {
            return "GalaxyS2";
        }
    }
}
