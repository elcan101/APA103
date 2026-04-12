//using _15_ConsoleApp.Models;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;

//namespace _15_ConsoleApp.Services
//{
//    public class StudentService
//    {
//        private List<Student> students = new List<Student>();
//        private int idCounter = 1;

//        public void Create(string name, string surname, int age, int groupId)
//        {
//            students.Add(new Student
//            {
//                Id = idCounter++,
//                Name = name,
//                Surname = surname,
//                Age = age,
//                GroupId = groupId
//            });
//        }

//        public void Update(int id, string name, string surname, int age)
//        {
//            var student = students.FirstOrDefault(x => x.Id == id);
//            if (student != null)
//            {
//                student.Name = name;
//                student.Surname = surname;
//                student.Age = age;
//            }
//        }

//        public void Delete(int id)
//        {
//            students.RemoveAll(x => x.Id == id);
//        }

//        public Student GetById(int id)
//        {
//            return students.FirstOrDefault(x => x.Id == id);
//        }

//        public List<Student> GetByAge(int age)
//        {
//            return students.Where(x => x.Age == age).ToList();
//        }

//        public List<Student> GetByGroupId(int groupId)
//        {
//            return students.Where(x => x.GroupId == groupId).ToList();
//        }

//        public List<Student> Search(string text)
//        {
//            return students
//                .Where(x => x.Name.Contains(text) || x.Surname.Contains(text))
//                .ToList();
//        }
//    }
//}


using _15_ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _15_ConsoleApp.Services
{
    public class StudentService
    {
        private List<Student> students = new List<Student>();
        private int idCounter = 1;

        public void Create(string name, string surname, int age, int groupId)
        {
            students.Add(new Student
            {
                Id = idCounter++,
                Name = name,
                Surname = surname,
                Age = age,
                GroupId = groupId
            });
        }

        public void Update(int id, string name, string surname, int age)
        {
            var student = students.FirstOrDefault(x => x.Id == id);
            if (student != null)
            {
                student.Name = name;
                student.Surname = surname;
                student.Age = age;
            }
        }

        public void Delete(int id)
        {
            students.RemoveAll(x => x.Id == id);
        }

        public Student GetById(int id)
        {
            return students.FirstOrDefault(x => x.Id == id);
        }

        public List<Student> GetByAge(int age)
        {
            return students.Where(x => x.Age == age).ToList();
        }

        public List<Student> GetByGroupId(int groupId)
        {
            return students.Where(x => x.GroupId == groupId).ToList();
        }

        public List<Student> Search(string text)
        {
            return students
                .Where(x =>
                    x.Name.ToLower().Contains(text.ToLower()) ||
                    x.Surname.ToLower().Contains(text.ToLower()))
                .ToList();
        }
    }
}