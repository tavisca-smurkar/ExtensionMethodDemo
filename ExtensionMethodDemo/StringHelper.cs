using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
   public static class StringHelper
    {
        public static string ChangeTheCaseOfFirstLetter(this string oldString)
        {
            if (oldString.Length != 0)
            {
                char[] newString = oldString.ToCharArray();
                newString[0] = char.IsUpper(newString[0]) ? char.ToLower(newString[0]) : char.ToUpper(newString[0]);
                return new string(newString);
            }

            
            return oldString;
           
        }
    }
}
