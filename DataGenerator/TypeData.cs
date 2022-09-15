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

        protected string[] Types = new string[20];    //Store types of data

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
