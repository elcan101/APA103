using System;
using System.Collections.Generic;
using System.Text;

namespace _03_ObjectClassConstructorInheritanceThisvsBase
{
    internal class Person
    {
        string FirstName;
        string LastName;
        int Age;
        string Email;
        string Id;


        public Person(string firstname,string lastname, int age, string email,string id)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Age = age;
            this.Email = email;
            this.Id = id;
        }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public void ShowBasicInfo()
        {
            Console.WriteLine($"Firstname: {FirstName} Lastname: {LastName} Age: {Age} Email: {Email} Id: {Id}");
        }
    }

    
}
