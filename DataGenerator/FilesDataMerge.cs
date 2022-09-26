using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator
{
    public class FilesDataMerge : TypeData
    {
        private string[] Paths { get; set; } = new string[0];
        private string input = "";
        private int index = 1;

        private string[] types = new TypeData().Types;
        private Dictionary<string, string> data = new TypeData().DictType;

        /*
         * param[string[paramName,paramStatus]]
         * string[ paremeter name, parameter status ]
         * List - collection parameters, which have status for understanding how it wiil be processed
         * 
         * */
        private List<string[,]> parameters = new List<string[,]>();
        public string[,] param = new string[,] {
            {"FirstName", "read"},
            {"LastName", "read"},
            {"Patronymic", "read"},
            {"Email", "create"},
            {"Login", "create"},
            {"Password", "generate"},
            {"Date", "generate"}
        };

        public FilesDataMerge(string[] paths)
        { 
            Paths = paths;

            parameters.Add(param);//!!!! перевірити чи передає параметри в список

        //parameters.Add(,);
        }

        public string MergeFiles()
        {
            string resString = "";     //або массив із набором параметрів

            foreach (string path in Paths)
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.UTF8))
                {
                    if (index == 1)
                    {
                        index++;
                    }
                    else
                    {
                        resString += ",('";
                        index++;
                    }
                    while ((input = sr.ReadLine()) != null)
                    {
                        string[] subs = input.Split(' ');
                        for (int i = 0; i < subs.Length; i++)
                        {
                            //data.TryGetValue(data[i],)
                        }
                    }
                }
            }
            /*
             *Зробити шоб перебирало параметри і якшо "read" - то зчитуєм з файлу
             *Інакше просто ставим затичку, або генеруєм значення
             *
             *
             */

            
            return resString;
        }
    }
}
