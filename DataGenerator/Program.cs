using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Path1 = "E:\\Education\\DataRead\\fio.txt";
            //string Path2 = "E:\\Education\\DataRead\\emails.txt";

            try
            {
                using (StreamReader sr = new StreamReader(Path1, System.Text.Encoding.UTF8))
                {
                    string input = null;
                    while ((input = sr.ReadLine()) != null)
                    {
                        //char c = input.ToCharArray()[0];



                        Console.WriteLine(input);
                    }
                }
                Console.ReadLine();
            }
            catch (FileNotFoundException e1)
            {
                Console.WriteLine(e1.Message);
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
            }
        }
    }
}
