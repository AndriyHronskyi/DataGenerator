using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataGenerator
{
    public class TypeData : ITypeData
    {
        public static List<string> Data { get; set; } = new List<string>();

        /*  Це для UserGenerate
        public TypeData(IEnumerable<string> data)
        {
            Data.AddRange(data);
        }
        */

        /*
         * param[string[paramName,paramStatus]]
         * string[ paremeter name, parameter status ]
         * List - collection parameters, which have status for understanding how it wiil be processed
         * 
         * */
        public static List<KeyValuePair<string, string>> Types { get; set; } = new List<KeyValuePair<string, string>>()
        /*{
            new KeyValuePair<string, string>("FirstName", "read"),
            new KeyValuePair<string, string>("LastName", "read"),
            new KeyValuePair<string, string>("Patronymic", "read"),
            new KeyValuePair<string, string>("Email", "create"),
            new KeyValuePair<string, string>("Login", "create"),
            new KeyValuePair<string, string>("Password", "generate"),
            new KeyValuePair<string, string>("Date", "generate")
        }*/;


        public TypeData() {  }

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

        public virtual void Generate() { }
        
    }
}
