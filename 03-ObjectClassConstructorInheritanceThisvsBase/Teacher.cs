using System;
using System.Collections.Generic;
using System.Text;

namespace _03_ObjectClassConstructorInheritanceThisvsBase
{
    internal class Teacher:Person 
    {
        public string Department;
        public string  MainSubject;
        public decimal BaseSalary;
        public int  ExperienceYears;

        public Teacher(string firstname, string lastname, int age, string email, string id,string department, string mainsubject,
        decimal basesalary, int experienceyears):base (firstname, lastname, age, email, id)
        
        {
            this.Department = department;
            this.MainSubject = mainsubject;
            this.BaseSalary = basesalary;
            this.ExperienceYears = experienceyears;
        }
       
        
        public void ShowTeacherInfo()
        {
            ShowBasicInfo();
            Console.WriteLine($"Department: {Department} MainSubject: {MainSubject} BaseSalary: {BaseSalary} ExperienceYears: {ExperienceYears}");
        }

        public decimal  CalculateSalary()
        {
            return BaseSalary + (ExperienceYears * 50);
        }
    }
}
