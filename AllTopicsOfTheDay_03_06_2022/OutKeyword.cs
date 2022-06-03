using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTopicsOfTheDay_03_06_2022
{
    public class OutKeyword
    {
        public void PerformOutKeyword(out int i)
        {
            //name = null;//If we Comment out the This line It Will Gives an Error  ...
            //Because We Have to assign the Variable if we use with out keyword
            i= 10;
            //i++;

        }
    }
}
