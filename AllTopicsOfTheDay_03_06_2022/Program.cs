using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTopicsOfTheDay_03_06_2022
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ref
            int number = 10;//initilization required
            Console.WriteLine("number ={0} Before pasing it",number);
            Ref reff = new Ref();   
            reff.PerformCallByRefrence(ref number);
            Console.WriteLine("number ={0} After passing",number);
            //==============================
            //out
            int i;
            OutKeyword outKeyword  =  new OutKeyword();
            outKeyword.PerformOutKeyword(out i);
            Console.WriteLine("i = After passing :"+ i);
            //===================================
            //Nullable
            NullableExample nullableExample =new NullableExample();
            nullableExample.PerformNullableExample();
            //==================================
            //params argument
            ParamsArgument paramsArgument = new ParamsArgument();
            paramsArgument.PerformParamsArguments("sanjay", "rahul", "sandeep");
            //===============================================================
            TupleExample tupleExample=new TupleExample();   
            var tuple=new Tuple<string,string,string,int>("sanjay","singh","software developer",2022);
            tupleExample.PerformTupleExample();
            tupleExample.PerformTupleWithPassingTupleValueAsIdentical(tuple);
            tupleExample.PerformTupleWithPassingTupleValueAsDynamic(tuple);
            //============================================================
            UseOfStruct useOfStruct=new UseOfStruct();
            useOfStruct.PerFormStruct();
            useOfStruct.StructCanNotBeNullAssign();
            //============================================================
            //Nested class
            NestedClass nestedClass=new NestedClass();
            nestedClass.callingNeastedClass();
            //=====================================================================
            //const and read only
            ConstAndReadOnly constAndReadOnly = new ConstAndReadOnly("rahul Sharma");
            constAndReadOnly.printConstAndReadonly();
            //========================================================================
            //Checked and unchcked
            
            Checked_Unchecked checked_Unchecked = new Checked_Unchecked(); 
            checked_Unchecked.PerformChecked();
            checked_Unchecked.PerformUnChecked();
            Console.ReadLine();
        }
    }
}
