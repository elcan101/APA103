create database Company

 create table Employees(
 Id int , 
 Name nvarchar(max), 
 Surname nvarchar(max),
 Age int, 
 Salary DECIMAL(10,2),
 Position NVARCHAR(50),
 IsDeleted BIT,
 CityId INT,
 FOREIGN KEY (CityId) REFERENCES Cities(Id)
);

CREATE TABLE Cities (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50),
    CountryId INT,
    FOREIGN KEY (CountryId) REFERENCES Countries(Id));

    CREATE TABLE Countries (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50)
    );

    SELECT e.Name, e.Surname,c.Name AS City, co.Name AS Country
FROM Employees e JOIN Cities c ON e.CityId = c.Id JOIN Countries co ON c.CountryId = co.Id;

SELECT e.Name, co.Name AS Country
FROM Employees e JOIN Cities c ON e.CityId = c.Id JOIN Countries co ON c.CountryId = co.Id
WHERE e.Salary > 2000;

SELECT c.Name AS City, co.Name AS Country
FROM Cities c JOIN Countries co ON c.CountryId = co.Id;

SELECT  Name,Surname, Age, Salary,Position, IsDeleted, CityId
FROM Employees WHERE Position = 'Reseption';

SELECT e.Name,e.Surname,c.Name AS City,co.Name AS Country
FROM Employees e JOIN Cities c ON e.CityId = c.Id
JOIN Countries co ON c.CountryId = co.Id WHERE e.IsDeleted = 1;