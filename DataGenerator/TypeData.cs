using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataGenerator
{
    public class TypeData
    {
        public List<string> Data { get; set; } = new List<string>();

        /*  Це для UserGenerate
        public TypeData(IEnumerable<string> data)
        {
            Data.AddRange(data);
        }
        */

        //Store types of data
        public string[] Types = new string[] {"FirstName",
                                                    "LastName",
                                                    "Patronymic",
                                                    "Email",
                                                    "Login",
                                                    "Password",
                                                    "Date"};

        public Dictionary<string, string> DictType = new Dictionary<string, string>()
        {
            {"FirstName", "read"},
            {"LastName", "read"},
            {"Patronymic", "read"},
            {"Email", "create"},
            {"Login", "create"},
            {"Password", "generate"},
            {"Date", "generate"}
        };
        public List<KeyValuePair<string, string>> Dataa { get; set; } = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("FirstName", "read"),
            new KeyValuePair<string, string>("LastName", "read"),
            new KeyValuePair<string, string>("Patronymic", "read"),
            new KeyValuePair<string, string>("Email", "create"),
            new KeyValuePair<string, string>("Login", "create"),
            new KeyValuePair<string, string>("Password", "generate"),
            new KeyValuePair<string, string>("Date", "generate")
        };
        //заповнити і провірити чи спрацює індексація елементів


        public TypeData() { }

        //універсальна реалзація
        public virtual void MakeUnick()
        {
            //перевірка
            foreach (string dat in Data)
            {
                if (dat.Equals(Data))   //Якшо елемент не унікальний(а нам треба шоб унікальний), то викидуєм його і генеруєм наново
                {
                    Data.Remove(dat);
                    Generate();
                }
            }
        }
        public virtual void Generate()
        {
            /*Thread.Sleep(10);
            var prePass = random.Next(10000, 999999).ToString();

            if (prePass.Equals(passwords))
            {
                Thread.Sleep(30);
                Generate();
            }
            else
            {
                passwords.Add(prePass);
            }*/
        }
    }
}
