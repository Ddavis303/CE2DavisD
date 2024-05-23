using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples22MAY2024
{
    internal class Student
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        //mutators
        #region Mutators
        public void SetFirstName(string firstName)
        {
            _firstName = firstName;
        }
        public void SetAge(int age) 
        {
            _age = age;
        }

        public void SetAge()
        {
            int userInput = -1;

            try
            {
                Console.Write("Please enter the students age (ie 24): ");
                userInput = int.Parse(Console.ReadLine());
                _age = userInput;
            }
            catch (FormatException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (Exception exc) 
            {
                Console.WriteLine(exc.StackTrace);
            }

        }
        #endregion

        //accessors 
        #region Accessors
        public string GetFirstName() 
        {
            return _firstName;
        }
        #endregion

    }
}
