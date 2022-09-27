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

        private List<KeyValuePair<string, string>> Types = new TypeData().Types;
        public List<List<string[]>> FileBase = new List<List<string[]>>();                 // Contains Lists with data several files
        #region May is usfull
        /*
        private string[] types = new TypeData().Types;
        private Dictionary<string, string> data = new TypeData().DictType;
        */
        /*private List<string[,]> parameters = new List<string[,]>();
        public string[,] param = new string[,] {
            {"FirstName", "read"},
            {"LastName", "read"},
            {"Patronymic", "read"},
            {"Email", "create"},
            {"Login", "create"},
            {"Password", "generate"},
            {"Date", "generate"}
        };*/
        #endregion
        public FilesDataMerge(string[] paths)
        { 
            Paths = paths;

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


    }
}
