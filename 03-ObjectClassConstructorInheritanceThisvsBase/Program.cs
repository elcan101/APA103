

using System;
using _03_ObjectClassConstructorInheritanceThisvsBase;

// 1. Obyektlərin yaradılması
Student s1 = new Student("Ali", "Mammadov", 20, "ali@mail.com", "S001", "ST1001", "CS", 88.5, 3);
Student s2 = new Student("Elcan", "Aliyev", 21, "elcan@mail.com", "S002", "ST1002", "IT", 92.0, 4);
Student s3 = new Student("Murad", "Huseynov", 19, "murad@mail.com", "S003", "ST1003", "SE", 68.5, 2);

Teacher t1 = new Teacher("Rashad", "Aliyev", 45, "rashad@mail.com", "T001", "CS", "Programming", 800, 15);
Teacher t2 = new Teacher("Sevda", "Veliyeva", 38, "sevda@mail.com", "T002", "IT", "Database", 850, 8);

Administrator admin = new Administrator("Nigar", "Aliyeva", 40, "nigar@mail.com", "A001", "Dekan", "Admin", 5);

Console.WriteLine("--- Tələbələr ---");
Student[] students = { s1, s2, s3 };
foreach (var s in students)
{
    s.ShowStudentInfo();
    Console.WriteLine($"Təqaüd: {s.CalculateScholarship()} AZN");
    Console.WriteLine("----------------");
}

Console.WriteLine("\n--- Müəllimlər ---");
Teacher[] teachers = { t1, t2 };
foreach (var t in teachers)
{
    t.ShowTeacherInfo();
    Console.WriteLine($"Ümumi Maaş: {t.CalculateSalary()} AZN");
    Console.WriteLine("----------------");
}

Console.WriteLine("\n--- İdarəçi ---");
admin.ShowAdminInfo();
admin.GrantAccess(s1);

double totalScholarship = s1.CalculateScholarship() + s2.CalculateScholarship() + s3.CalculateScholarship();
decimal totalSalary = t1.CalculateSalary() + t2.CalculateSalary();

Console.WriteLine($"\n============================");
Console.WriteLine($"Ümumi Təqaüd Xərci: {totalScholarship} AZN");
Console.WriteLine($"Ümumi Maaş Xərci: {totalSalary} AZN");
Console.WriteLine($"============================");