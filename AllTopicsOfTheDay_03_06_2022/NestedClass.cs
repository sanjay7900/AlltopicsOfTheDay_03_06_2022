using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTopicsOfTheDay_03_06_2022
{
    public class NestedClass
    {
       public class StudentList
        {
            List<string> students=new List<string>();
            public void printStudents()
            {
                students.Add("sanjay");
                students.Add("abhay");
                students.Add("Konni");
                students.Add("Akash");
                students.Add("Manisha");
                students.Add("Swati");
                students.Add("Gopal");
                students.Add("Hemant");
                students.Add("Yuvraj");
                students.Add("Anirudh");
                students.Add("Aryan");
                for(int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine(students[i]);
                }
            }

        }
        public void callingNeastedClass()
        {
            NestedClass.StudentList students = new NestedClass.StudentList();
            students.printStudents();
        }
    }
}
