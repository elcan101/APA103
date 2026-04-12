//using _15_ConsoleApp.Services;

//namespace _15_ConsoleApp
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//                GroupService groupService = new GroupService();
//                StudentService studentService = new StudentService();

//                while (true)
//                {
//                    Console.WriteLine("1.Create Group");
//                    Console.WriteLine("8.Create Student");

//                    int choice = int.Parse(Console.ReadLine());

//                    switch (choice)
//                    {
//                        case 1:
//                            Console.Write("Name: ");
//                            var name = Console.ReadLine();

//                            Console.Write("Teacher: ");
//                            var teacher = Console.ReadLine();

//                            Console.Write("Room: ");
//                            var room = Console.ReadLine();

//                            groupService.Create(name, teacher, room);
//                            break;

//                        case 8:
//                            Console.Write("Name: ");
//                            var sName = Console.ReadLine();

//                            Console.Write("Surname: ");
//                            var sSurname = Console.ReadLine();

//                            Console.Write("Age: ");
//                            int age = int.Parse(Console.ReadLine());

//                            Console.Write("GroupId: ");
//                            int gid = int.Parse(Console.ReadLine());

//                            studentService.Create(sName, sSurname, age, gid);
//                            break;
//                    }
//                }
//            }
//        }
//    }


using _15_ConsoleApp.Services;
using System;

namespace _15_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupService groupService = new GroupService();
            StudentService studentService = new StudentService();

            while (true)
            {
                Console.WriteLine("\n1.Create Group");
                Console.WriteLine("2.Get All Groups");
                Console.WriteLine("3.Search Group");
                Console.WriteLine("4.Create Student");
                Console.WriteLine("5.Get Students By Group");
                Console.WriteLine("6.Search Student");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Name: ");
                        var name = Console.ReadLine();

                        Console.Write("Teacher: ");
                        var teacher = Console.ReadLine();

                        Console.Write("Room: ");
                        var room = Console.ReadLine();

                        groupService.Create(name, teacher, room);
                        break;

                    case 2:
                        var groups = groupService.GetAll();
                        foreach (var g in groups)
                            Console.WriteLine($"{g.Id} {g.Name} {g.Teacher} {g.Room}");
                        break;

                    case 3:
                        Console.Write("Search: ");
                        var searchG = Console.ReadLine();
                        var gResult = groupService.Search(searchG);
                        foreach (var g in gResult)
                            Console.WriteLine(g.Name);
                        break;

                    case 4:
                        Console.Write("Name: ");
                        var sName = Console.ReadLine();

                        Console.Write("Surname: ");
                        var sSurname = Console.ReadLine();

                        Console.Write("Age: ");
                        int age = int.Parse(Console.ReadLine());

                        Console.Write("GroupId: ");
                        int gid = int.Parse(Console.ReadLine());

                        studentService.Create(sName, sSurname, age, gid);
                        break;

                    case 5:
                        Console.Write("GroupId: ");
                        int gId = int.Parse(Console.ReadLine());

                        var students = studentService.GetByGroupId(gId);
                        foreach (var s in students)
                            Console.WriteLine($"{s.Name} {s.Surname}");
                        break;

                    case 6:
                        Console.Write("Search: ");
                        var sText = Console.ReadLine();

                        var sResult = studentService.Search(sText);
                        foreach (var s in sResult)
                            Console.WriteLine($"{s.Name} {s.Surname}");
                        break;
                }
            }
        }
    }
}