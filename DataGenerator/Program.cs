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
            string Path2 = "E:\\Education\\DataRead\\emails.txt";
            
            try
            {
                using (StreamReader sr = new StreamReader(Path1, System.Text.Encoding.UTF8))
                {
                    using (StreamReader _sr3 = new StreamReader(Path2, System.Text.Encoding.UTF8))
                    {
                        string input = null;
                        string input1 = null;
                        var koma = 1;

                        while ((input = sr.ReadLine()) != null && (input1 = _sr3.ReadLine()) != null)
                        {
                            char[] outFIO = new char[input.Length];
                            string inputFIO = new string(outFIO);

                            //open VALUE
                            if (koma == 1)
                            {
                                Console.Write("('");
                                koma++;
                            }
                            else
                            {
                                Console.Write(",('");
                            }

                            using (StringReader sr2 = new StringReader(input))
                            {
                                //late algorithm
                                for (int i = 0; i < outFIO.Length; i++)
                                {
                                    sr2.Read(outFIO, i, 1);

                                    if (Char.IsSeparator(outFIO[i]))
                                    {
                                        Console.Write("', '");
                                    }
                                    else
                                    {
                                        Console.Write(outFIO[i]);
                                    }
                                }

                            }


                            //______Emails File
                            char[] outEmails = new char[input.Length / 2];
                            UserGenerate User = new UserGenerate();

                            string[] subs = input1.Split(' ');
                            User.SetUsername(subs[0], subs[1]);

                            //output
                            Console.Write($"', '{User.email}', '{User.login}', '{User.GetPassword()}','{User.GetDate()}'");

                            Console.Write(")");   //close VALUE
                            Console.WriteLine();
                        }
                    }
                    
                }
            }
            catch (FileNotFoundException e1)
            {
                Console.WriteLine(e1.Message);
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
            }
            Console.ReadLine();
        }
    }
}
