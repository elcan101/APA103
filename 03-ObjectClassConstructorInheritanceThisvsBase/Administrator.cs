using System;
using System.Collections.Generic;
using System.Text;

namespace _03_ObjectClassConstructorInheritanceThisvsBase
{
    internal class Administrator:Person
    {
     public  string Position;
     public string Department;
     public int AccessLevel;

        public Administrator(string firstname, string lastname, int age, string email, string id,string position,string department,int accesslevel):base(firstname, lastname, 
            age, email, id )
        {
            this.Position = position;
            this.Department = department;
            this.AccessLevel = accesslevel;
        }
//        ShowAdminInfo() - İdarəçi məlumatlarını göstərir
//GrantAccess(Student student) - Tələbəyə sistem girişi verir(console mesajı çap edir)
        public void ShowAdminInfo()
        {
            ShowBasicInfo();
            Console.WriteLine($"Position: {Position} Department: {Department} AccessLevel1: {AccessLevel}");
        }


        public void GrantAccess(Student student)
        {
            Console.WriteLine($"Administrator {GetFullName()} gave system access to student {student.StudentNumber}");
        }
    }
}
