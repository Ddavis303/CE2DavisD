//Dillon Davis
//22MAY2024 ddavis126@cnm.edu
//Class Example, Classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples22MAY2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Student[] students = new Student[5]; 

            for(int i = 0; i < students.Length; i++) 
            {
                students[i] = new Student();            
            }

            //unable to access directly because they are now set to private
            //student1._firstName = "Joe";
            //student2._lastName = "Smith";

            student1.SetFirstName("Bob");
            students[0] = student1;
            //students[0].SetAge(25);
            Console.WriteLine(students[0].GetFirstName());
            students[0].SetAge();

            foreach(Student element in students)
            {
                if(element.GetFirstName() == null)
                {
                    //do nothing
                }
                else
                {
                    Console.WriteLine(element.GetFirstName());
                }
            }
        }
    }
}
