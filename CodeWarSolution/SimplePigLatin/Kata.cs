using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePigLatin
{
    public class Kata
    {
        public static string PigIt(string str)
        {
            StringBuilder result = new StringBuilder();
            const string suffix = "ay";
            const string space = " ";

            foreach (var item in str.Split(space))
            {
                if (item.Trim().Length == 1)
                {
                    if (Char.IsLetter(item[0]))
                    {
                        result.Append(item).Append(suffix).Append(space);
                    }
                    else
                    {
                        result.Append(item).Append(space);
                    }
                }
                else
                {
                    var firstString = item.Substring(0, 1);
                    var remainingString = item.Substring(1);
                    if (char.IsLetter(item[0]))
                    {
                        result.Append(remainingString).Append(firstString).Append(suffix).Append(space);
                    }
                    else
                    {
                        result.Append(item).Append(space);
                    }
                }
            }
            
            return result.ToString().Trim();
        }
    }
}
