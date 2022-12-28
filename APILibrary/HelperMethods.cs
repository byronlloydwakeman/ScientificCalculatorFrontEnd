using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary
{
    public static class HelperMethods
    {
        public static string ASCIITOHEX(string ascii)
        {

            StringBuilder sb = new StringBuilder();

            byte[] inputBytes = Encoding.UTF8.GetBytes(ascii);

            foreach (byte b in inputBytes)

            {

                sb.Append(string.Format("{0:x2}", b));

            }

            return sb.ToString();

        }
    }
}
