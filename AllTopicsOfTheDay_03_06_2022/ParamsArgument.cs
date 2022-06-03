using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTopicsOfTheDay_03_06_2022
{
    public class ParamsArgument
    {
        public void  PerformParamsArguments(params string[] names)
        {
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Name{0}={1}",i,names[i]);
            }


        }
    }
}
