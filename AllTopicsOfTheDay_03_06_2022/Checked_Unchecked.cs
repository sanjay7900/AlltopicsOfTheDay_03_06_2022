using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTopicsOfTheDay_03_06_2022
{
    public class Checked_Unchecked
    {
        public void PerformChecked()
        {
            checked
            {
                Console.WriteLine(" I M Checking i Don not have an Runtime error ");

                Console.WriteLine(10/2);

            }

        }
        public void PerformUnChecked()
        {
            unchecked
            {
                Console.WriteLine(" I M Checking i  have a Runtime error But i did not throw  an error like(0/10) ");

                Console.WriteLine(0/10);

            }

        }
    }
}
