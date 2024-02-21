using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Student
    {
        public string name;
        public string surname;
        public int age;
        public string address;
        public string phone="1234568549";


        //public void ShowText(string text)
        //{
          //  Console.WriteLine(text);
        //}

        public string GetFullName()
        {
            return name+" "+surname;
        }

        public string GetFullData()
        {
            string fullData=$"Name:{name} Surname:{surname} Age:{age}Address:{address} Phone:{phone}";
            return fullData;
        }
        




    }
}
