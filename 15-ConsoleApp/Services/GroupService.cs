//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Text.RegularExpressions;

//namespace _15_ConsoleApp.Services
//{
//    public class GroupService
//    {
//        private List<Group> groups = new List<Group>();
//        private int idCounter = 1;

//        public void Create(string name, string teacher, string room)
//        {
//            groups.Add(new Group
//            {
//                Id = idCounter++,
//                Name = name,
//                Teacher = teacher,
//                Room = room
//            });
//        }

//        public void Update(int id, string name, string teacher, string room)
//        {
//            var group = groups.FirstOrDefault(x => x.Id == id);
//            if (group != null)
//            {
//                group.Name = name;
//                group.Teacher = teacher;
//                group.Room = room;
//            }
//        }

//        public void Delete(int id)
//        {
//            groups.RemoveAll(x => x.Id == id);
//        }

//        public Group GetById(int id)
//        {
//            return groups.FirstOrDefault(x => x.Id == id);
//        }

//        public List<Group> GetAll()
//        {
//            return groups;
//        }

//        public List<Group> GetByTeacher(string teacher)
//        {
//            return groups.Where(x => x.Teacher == teacher).ToList();
//        }

//        public List<Group> GetByRoom(string room)
//        {
//            return groups.Where(x => x.Room == room).ToList();
//        }

//        public List<Group> Search(string name)
//        {
//            return groups.Where(x => x.Name.Contains(name)).ToList();
//        }
//    }
//}


using _15_ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _15_ConsoleApp.Services
{
    public class GroupService
    {
        private List<Group> groups = new List<Group>();
        private int idCounter = 1;

        public void Create(string name, string teacher, string room)
        {
            groups.Add(new Group
            {
                Id = idCounter++,
                Name = name,
                Teacher = teacher,
                Room = room
            });
        }

        public void Update(int id, string name, string teacher, string room)
        {
            var group = groups.FirstOrDefault(x => x.Id == id);
            if (group != null)
            {
                group.Name = name;
                group.Teacher = teacher;
                group.Room = room;
            }
        }

        public void Delete(int id)
        {
            groups.RemoveAll(x => x.Id == id);
        }

        public Group GetById(int id)
        {
            return groups.FirstOrDefault(x => x.Id == id);
        }

        public List<Group> GetAll()
        {
            return groups;
        }

        public List<Group> GetByTeacher(string teacher)
        {
            return groups.Where(x => x.Teacher == teacher).ToList();
        }

        public List<Group> GetByRoom(string room)
        {
            return groups.Where(x => x.Room == room).ToList();
        }

        public List<Group> Search(string name)
        {
            return groups
                .Where(x => x.Name.ToLower().Contains(name.ToLower()))
                .ToList();
        }
    }
}
