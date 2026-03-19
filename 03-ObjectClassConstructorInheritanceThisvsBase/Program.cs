using _03_ObjectClassConstructorInheritanceThisvsBase;

Student student1 = new Student(
    "Ali",
    "Mammadov",
    20,
    "ali@mail.com",
    "S001",
    "ST1001",
    "Computer Science",
    88.5,
    3
);

Student student2 = new Student(
    "Elcan",
    "Aliyev",
    21,
    "elcan@mail.com",
    "S002",
    "ST1002",
    "Information Technology",
    92.0,
    4
);

Student student3 = new Student(
    "Murad",
    "Huseynov",
    19,
    "murad@mail.com",
    "S003",
    "ST1003",
    "Software Engineering",
    68.5,
    2
);

Console.WriteLine(student1.CalculateScholarship());
Console.WriteLine(student2.CalculateScholarship());
Console.WriteLine(student3.CalculateScholarship());




Teacher teacher1 = new Teacher(
    "Rashad",
    "Aliyev",
    45,
    "rashad@mail.com",
    "T001",
    "Computer Science",
    "Programming",
    900,
    15
);

Teacher teacher2 = new Teacher(
    "Ali",
    "Aliyev",
    38,
    "sevda@mail.com",
    "T002",
    "Information Technology",
    "Database",
    850,
    8
);
Console.WriteLine(teacher1.ShowTeacherInfo);
Console.WriteLine(teacher1.CalculateSalary());
Console.WriteLine(teacher2.CalculateSalary());


Administrator admin = new Administrator("Nigar", "Aliyeva", 40, "nigar@mail.com", "A001", "Dekan", "IT Department", 5);
