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
                            /*
                             Цикл в якому індекс (int i) => parameters[i] перевіряється відповідним методом
                             
                             */
                              
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
            
            Console.ReadLine();
        }
    }
}
