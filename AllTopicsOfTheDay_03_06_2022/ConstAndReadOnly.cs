using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTopicsOfTheDay_03_06_2022
{
    public class ConstAndReadOnly
    {
        const string ConstString= "sanjay singh";// at the compile time
        const double pi = 3.14;
        public readonly string readonlydata;
        public  ConstAndReadOnly(string readString)
        {
            readonlydata = readString;
        }
        public void printConstAndReadonly()
        {
            Console.WriteLine("const string "+ConstString);
            Console.WriteLine("const double "+pi);
            Console.WriteLine("read only" +readonlydata);
           // readonlydata = null; it gives an error
        }

    }
}
