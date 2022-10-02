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

        //hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh
        private List<KeyValuePair<string, string>> Types1 = Types;


        public List<List<string[]>> FileBase = new List<List<string[]>>();                 // Contains Lists with data several files
        private List<KeyValuePair<string, int>> TypesIn = new List<KeyValuePair<string, int>>();        //List with info in which order we got data from files

        public FilesDataMerge(string[] paths, List<KeyValuePair<string, int>> TypesInput)
        { 
            Paths = paths;
            TypesIn = TypesInput;


            #region Test construction
            Console.WriteLine(Types[0]);
            Console.WriteLine(Types[0].Key);
            if (Types[0].Value == "read")
            {
                Console.WriteLine(Types[0].Value);
                Console.WriteLine("value 'read1'");
            }
            else
            {
                Console.WriteLine("value not 'read'");
            }
            //*----------------------------------------------
            #endregion

        }
        
        //Files reader
        //Merge files

        //   Selecting data from several files and put it into FileBase(List<List<string[]>>)
        //   Filebase(File(string[parameter]))
        public void FilesSelect()
        {
            foreach (string path in Paths)
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.UTF8))
                {
                    List<string[]> FileBuffer = new List<string[]>();  //Contains fields of one file

                    while ((input = sr.ReadLine()) != null)
                    {
                        //divide fields
                        string[] subs = input.Split(' ');         //subs contsins parameters of one string  
                        
                        FileBuffer.Add(subs);
                    }
                    FileBase.Add(FileBuffer);
                }
            }
        }

        /*
         *  DataFilling()
         *
         *  Using TypeData().Types
         *  Using clases like Login, RandomDate, Password for generating parameters 
         * with  List<KeyValuePair<string, string>>, where "key" : login, passwod, date  
         * and value: generate, create etc!
         *
         ***/
        public void Parameters() { }
    }
}
