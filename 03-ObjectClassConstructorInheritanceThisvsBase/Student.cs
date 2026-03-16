using System;
using System.Collections.Generic;
using System.Text;

namespace _03_ObjectClassConstructorInheritanceThisvsBase
{
    internal class Student: Person 
    {
      public string  StudentNumber;
      public string Faculty;
      public double GPA;
      public int Year;

        public Student(string firstname, string lastname, int age, string email, string id,
                       string studentnumber, string faculty, double gpa, int year)
            : base(firstname, lastname, age, email, id)
        {
            this.StudentNumber = studentnumber;
            this.Faculty = faculty;
            this.GPA=gpa;
            this.Year = year;
        }

        public void ShowStudentInfo()
        {

            Console.WriteLine($"Student Number: {StudentNumber} Faculty: {Faculty} GPA: {GPA} Year: {Year}");
          
        }

        public double CalculateScholarship()
        {
            if (GPA >= 90)
            {
                return 500 ;
            } else if (GPA >= 80)
            {
                return 350 ;
            }else if (GPA >= 70)
            {
                return 200 ;
            }
            else
            {
                return 0 ;
            }
        }
    }
}
