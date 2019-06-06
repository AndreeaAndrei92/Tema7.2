using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder strb, int index, int length)
        {
            var result = new StringBuilder();
            if (index < 0 || index > strb.Length)
            {
                throw new ArgumentException("Invalid index");
            }
            if (length > index + strb.Length || length < 0)
            {
                throw new ArgumentException("Invalid length!");
            }
            for (int pos = 0; pos < length; pos++)
            {
                result.Append(strb[index + pos]);
            }
            return result;



        }
    }
}
