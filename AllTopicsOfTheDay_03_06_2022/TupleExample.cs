using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AllTopicsOfTheDay_03_06_2022
{
    internal class TupleExample
    {
        public void PerformTupleExample()
        {
            var student = new Tuple<string,string,string,int>("sanjay","singh","Developer",2022);
            Console.WriteLine("Print the tuple");
            Console.WriteLine("First Name="+student.Item1);
            Console.WriteLine("Last Nmae= "+student.Item2);
            Console.WriteLine("Designation = " + student.Item3);
            Console.WriteLine("Year= "+student.Item4);

        }
        public void PerformTupleWithPassingTupleValueAsIdentical(Tuple<string,string,string,int> student)
        {
            Console.WriteLine("Print the tuple With Passing Arguments As identical datatype");
            Console.WriteLine("First Name=" + student.Item1);
            Console.WriteLine("Last Nmae= " + student.Item2);
            Console.WriteLine("Designation = " + student.Item3);
            Console.WriteLine("Year= " + student.Item4);

        }
        public void PerformTupleWithPassingTupleValueAsDynamic(dynamic student)
        {
            Console.WriteLine("Print the tuple With Passing Arguments As Dynamic type");
            Console.WriteLine("First Name=" + student.Item1);
            Console.WriteLine("Last Nmae= " + student.Item2);
            Console.WriteLine("Designation = " + student.Item3);
            Console.WriteLine("Year= " + student.Item4); 

        }


    }
}
