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
                    var koma = 1;

                    while ((input = sr.ReadLine()) != null)
                    {
                        char[] outFIO = new char[input.Length];
                        
                        bool _fFlag = false;
                        bool _sFlag = false;

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
                            
                            for (int i = 0; i < outFIO.Length; i++)
                            {

                                /*if (_fFlag == _sFlag == false)
                                {
                                    sr2.Read(outFName, i, 1);
                                }
                                else if (_fFlag == true && _sFlag == false)
                                {
                                    sr2.Read(outLName, i, 1);
                                }
                                */
                                sr2.Read(outFIO, i, 1);

                                if (Char.IsSeparator(outFIO[i]))
                                {
                                    /*Console.Write("-");
                                    if (_fFlag == false)
                                    {
                                        _fFlag = true;
                                    }
                                    else if (_fFlag == true)
                                    {
                                        _sFlag = true;
                                    }*/

                                    Console.Write("', '");
                                }
                                else
                                {
                                    Console.Write(outFIO[i]);
                                }
                            }
                            
                            
                        }
                        Console.Write("')");   //close VALUE
                        Console.WriteLine();
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
