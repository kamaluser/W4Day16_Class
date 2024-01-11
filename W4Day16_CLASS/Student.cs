using System;
using System.Collections.Generic;
using System.Text;

namespace W4Day16_CLASS
{
    internal class Student
    {


        public Student(string fullName, DateTime birthDate, int groupNo, int point)
        {
            FullName = fullName;
            BirthDate = birthDate;
            GroupNo = groupNo;
            Point = point;
        }

        public string FullName;
        public DateTime BirthDate;
        public int GroupNo;
        public int Point;

        public void ShowInfo()
        {
            Console.WriteLine("Fullname: " + FullName);
            Console.WriteLine("Birth Date: " + BirthDate.ToShortDateString());
            Console.WriteLine("Group Number: " + GroupNo);
            Console.WriteLine("Point: " + Point);
        }


        


        
    }
}
