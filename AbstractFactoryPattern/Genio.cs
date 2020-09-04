/* Name: Enrique Tejeda
 * Date: 9/4/2020
 * Filename: Genio.cs
 * Description: Class inherits from the interface Dumb and modifies the function getName() and returns Genio as a string.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class Genio : Dumb
    {
        public string getName()
        {
            return "Genio";
        }
    }
}
