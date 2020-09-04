/* Name: Enrique Tejeda
 * Date: 9/4/2020
 * Filename: PhoneFactory.cs
 * Description: Interfaces establishes the functions public Smart GetSmart() and public Dumb GetDumb() to be overwritten by smart and dumb
 *              phones. 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    interface PhoneFactory
    {
        public Smart GetSmart();
        public Dumb GetDumb();
    }
}
