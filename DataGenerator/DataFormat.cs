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

        //    Має упаковувати все у вигляді string, що містить sql запит
        //    Можливо зробити шоб отримував TypeData.Types , або List<string[]>, де string[] - готові строчки з данними
        public static string[] MSSQL_Format(List<string> input)
        {
            
            //Console.WriteLine("DataFormat.MSSQL_Format() gets empty strings!!");
            

            //
            string[] result = new string[strings.Length];
            return result;
        }
    }
}
