using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator
{
    public static class DataFormat
    {
        private static string[] strings;
        public static string[] MSSQL_Format(string input1 = "", string input2 = "")
        {
            if (input1 != "" || input2 != "")
            {
                if (input1 != "" && input2 != "")
                {
                    strings = input1.Split(' ');
                }
            }
            else
            {
                Console.WriteLine("DataFormat.MSSQL_Format() gets empty strings!!");
            }
            string[] result = new string[strings.Length];
            return result;
        }
    }
}
