create database Company
create table Employees(
 EmployeeID int,
 FirstName nvarchar(max),
 LastName nvarchar(max),
 Email nvarchar(max),
 PhoneNumber int,
 HireDate int,
 JobTitle nvarchar(max),
 Salary money,
 Department nvarchar(max))

 INSERT INTO Employees (EmployeeID, FirstName, LastName, Email, PhoneNumber, HireDate, JobTitle, Salary, Department)
VALUES
(1, 'Ali', 'Huseynov', 'ali.huseynov@gmail.com', 0994567890, 20200115, 'Software Developer', 2500, 'IT'),
(2, 'Leyla', 'Mammadova', 'leyla.mammadova@gmail.com', 0556784565, 20190520, 'HR Specialist', 1800, 'Human Resources'),
(3, 'Rashad', 'Aliyev', 'rashad.aliyev@gmail.com', 0774567634, 20210310, 'Accountant', 2000, 'Finance'),
(4, 'Nigar', 'Ismayilova', 'nigar.ismayilova@gmail.com', 0709895634, 20180701, 'Marketing Manager', 2700, 'Marketing'),
(5, 'Kamran', 'Guliyev', 'kamran.guliyev@gmail.com', 0512345634, 20221125, 'Sales Executive', 2200, 'Sales');

select * from Employees
select * from Employees where Salary>2000
select * from Employees where Department = 'IT'
select * from Employees order by  Salary desc
select FirstName, Salary from Employees 
select * from Employees where HireDate > 20200101;
select * from Employees where Email like '%company.az%'

select max(Salary) as MaxSalary from Employees
select min(Salary) as MinSalary from Employees
select avg(Salary) as AvgSalary from Employees
select count(*) as TotalEmployees from Employees
select sum(Salary) as TotalSalary from Employees

select Department, count(*) as EmployeeCount
from Employees group byDepartment

select Department, avg(Salary) as AvgSalary
from Employees group by Department

select Department, max(Salary) as MaxSalary from Employees group by Department

update Employees set Salary = 2800 where EmployeeID = 1
update Employees set Salary = Salary * 1.10 where Department = 'IT'
update Employees set JobTitle = 'HR Meneceri' where  FirstName = 'Leyla' AND LastName = 'Hesenova'

delete from Employees
where EmployeeID = 5

delete from Employees
where Salary < 1500

select * from Employees where FirstName LIKE '%a%'
select * from Employees where Salary BETWEEN 2000 AND 2500
select * from Employees where Department IN ('Finance', 'IT');