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

            

            string Result = "('";
            //List<TypeData> Result = new List<TypeData>();
            //Data:
            //      -FirstName
            //      -LastName
            //      -Patronymic
            //      -Email
            //      -Login
            //      -Password
            //      -Date.Data
            #region Basic realisation
            /*
           try
           {
               using (StreamReader sr = new StreamReader(Path1, System.Text.Encoding.UTF8))
               {
                   using (StreamReader _sr3 = new StreamReader(Path2, System.Text.Encoding.UTF8))
                   {
                       string input = null;
                       string input1 = null;
                       List<string> passwords = new List<string>();
                       var koma = 1;


                       while ((input = sr.ReadLine()) != null && (input1 = _sr3.ReadLine()) != null)
                       {
                           //char[] outFIO = new char[input.Length];
                           //string inputFIO = new string(outFIO);
                           UserGenerate User = new UserGenerate();

                           //open VALUE
                           if (koma == 1)
                           {
                               koma++;
                           }
                           else
                           {
                               Result += ",('";
                               koma++;
                           }

                           // subs1 contains: firstName, lastName, patronymic
                           string[] subs1 = input.Split(' ');  

                           Result += subs1[0] + "', '" + subs1[1] + "', '" + subs1[2] + "'";

                           //______Emails File                            

                           string[] subs = input1.Split(' ');
                           User.SetUsername(subs[0], subs[1]);

                           do
                           {
                               User.SetPassword();
                               passwords.Add(User.password);
                               if (koma <= 2)
                                   break;
                           } while (User.password.Equals(passwords));

                           //output

                           Result += ", '" + User.email + "', '" + User.login + "', '" + User.password + "','" + User.GetDate() + "'";
                           //додати провірки значень

                            //Цикл в якому індекс (int i) => parameters[i] перевіряється відповідним методом



                           Result += ")" + "\n"; //close VALUE + start new string
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

           string Date = DateTime.Now.ToString();
           string[] dat = Date.Split(' ');

           //React time Format
           dat[1].Trim();
           dat[1] = dat[1].Replace(':', '.');
           dat[1] = dat[1].Remove(5);              //remowe miliseconds numbers

           string filename = "E:\\Education\\DataRead\\"+ dat[1] +"_" + dat[0] + ".result.txt";

           using (FileStream fstream = new FileStream(filename,FileMode.Create))
           {
               //Convert string into bites
               byte[] buffer = Encoding.UTF8.GetBytes(Result);

               //Write data in file
               fstream.Write(buffer, 0, buffer.Length);
               Console.WriteLine($"Text writed in file: {filename}");
           }
           */
            #endregion

            #region New realisation

            string[] Paths = new string[10];  //unitary container for multiple file paths
            
            
            List<KeyValuePair<string, int>> TypesInput = new List<KeyValuePair<string, int>>()
            {
                new KeyValuePair<string, int>("FirstName", 1),
                new KeyValuePair<string, int>("LastName", 1),
                new KeyValuePair<string, int>("Patronymic", 1),
                new KeyValuePair<string, int>("Email", 2),
                new KeyValuePair<string, int>("Login", 2),
            };        //What categories data we have in each file

            List<KeyValuePair<string, string>> TypesOutput = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("FirstName", "read"),
                new KeyValuePair<string, string>("LastName", "read"),
                new KeyValuePair<string, string>("Patronymic", "read"),
                new KeyValuePair<string, string>("Email", "create"),
                new KeyValuePair<string, string>("Login", "create"),
                new KeyValuePair<string, string>("Password", "generate"),
                new KeyValuePair<string, string>("Date", "generate")
            };   //What we should do (generate, read or create) with every output category

            TypeData.Types = TypesOutput;




            #endregion

            #region User Console
            
            Console.WriteLine("Hello! This is a program for generating multiple strings querry.");
            Console.WriteLine("*");
            Console.WriteLine("*");
            Console.WriteLine("1. Write full paths of files and parameters which they contain \n (It can be a names of fields in database)");
            Console.WriteLine("*");

            int index = 0;
            do
            {
                bool exitCondition = false;
                if (index > 0)
                { 
                    Console.WriteLine("Go next stage?  1 - Next; Enter - add another file");
                    
                    try
                    {
                        string buf0 = Convert.ToString(Console.ReadLine());
                        if (buf0.Contains("1"))
                        {
                            exitCondition = true;
                            break;
                        }
                    }
                    catch (Exception e1)
                    {
                        Console.WriteLine("Incorrect answer. Try again!");
                        
                        throw;
                    }
                }
                index++;

                Console.WriteLine($"1.{index } File path:");
                string buf = Convert.ToString(Console.ReadLine());
                //checking to Copy
                if (index > 1)
                {
                    while (Paths.Contains(buf))
                    {
                        Console.WriteLine("\n You have already aded path for this file!!!!");
                        Console.WriteLine("Add another file path, or press Enter - to next stage");
                        Console.WriteLine($"1.{index} File path:");
                        buf = Convert.ToString(Console.ReadLine());
                        if (buf.Equals(""))
                        {
                            exitCondition = true;
                            break;
                        }
                    }
                }


                if (exitCondition)
                    break;
               
                Paths[index - 1] = buf;   //add file path

                Console.WriteLine("");
            } while (index < 11);

            Console.WriteLine("-");
            Console.WriteLine("-");
            Console.WriteLine("-");
            Console.WriteLine("Test input!!!");
            Console.WriteLine("-");
            foreach (var item in Paths)
            {
                Console.WriteLine(item);
            }
            #endregion

            /*
            #region Test area


            Paths[0] = Path1;
            Paths[1] = Path2;

            //Зробити автоматичну передачу параметрів
            //TypeData Td = new TypeData();
            //Td.Types.Add(new KeyValuePair<string, string>("FirstName1", "read"));

            
            FilesDataMerge files = new FilesDataMerge(Paths, TypesInput);
            
            


            #endregion
            */
            Console.ReadLine();
        }
    }
}
