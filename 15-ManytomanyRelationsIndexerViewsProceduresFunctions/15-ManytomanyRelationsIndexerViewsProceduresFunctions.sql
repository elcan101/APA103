CREATE DATABASE CompanyMM;
USE CompanyMM;

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    BirthDate DATE,
    Email VARCHAR(100) UNIQUE NOT NULL,
   
    CONSTRAINT chk_Age CHECK (BirthDate < '2008-01-01')
);

CREATE TABLE Projects (
    ProjectID INT PRIMARY KEY IDENTITY(1,1),
    ProjectName VARCHAR(100) NOT NULL,
    StartDate DATE NOT NULL,
    EndDate DATE,
    CONSTRAINT chk_Dates CHECK (EndDate IS NULL OR EndDate >= StartDate)
);

CREATE TABLE EmployeeProjects (
    EmployeeID INT,
    ProjectID INT,
    AssignedDate DATE DEFAULT GETDATE(),
    PRIMARY KEY (EmployeeID, ProjectID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID) ON DELETE CASCADE,
    FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID) ON DELETE CASCADE
);

INSERT INTO Employees (FirstName, LastName, BirthDate, Email) VALUES
('Əli', 'Məmmədov', '1990-05-15', 'ali@company.com'),
('Leyla', 'Həsənova', '1995-08-20', 'leyla@company.com'),
('Anar', 'Quliyev', '1988-12-10', 'anar@company.com'),
('Nigar', 'Rzayeva', '1992-03-25', 'nigar@company.com'),
('Vüqar', 'Əliyev', '1993-07-07', 'vuqar@company.com');


INSERT INTO Projects (ProjectName, StartDate, EndDate) VALUES
('E-Hökumət Portalı', '2023-01-01', '2024-12-31'),
('Mobil Bankçılıq', '2023-06-01', NULL),
('Logistika Sistemi', '2024-01-15', '2025-06-01');


INSERT INTO EmployeeProjects (EmployeeID, ProjectID) VALUES
(1, 1), (1, 2), (1, 3), -- Əli 3 layihədə (HAVING yoxlaması üçün)
(2, 1), (2, 2),
(3, 3),
(4, 2);

SELECT * FROM Employees;

SELECT * FROM Projects;

SELECT e.FirstName, e.LastName, p.ProjectName 
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects p ON ep.ProjectID = p.ProjectID;

SELECT p.ProjectName, COUNT(ep.EmployeeID) AS EmployeeCount
FROM Projects p
LEFT JOIN EmployeeProjects ep ON p.ProjectID = ep.ProjectID
GROUP BY p.ProjectID, p.ProjectName;

SELECT e.FirstName, e.LastName, COUNT(ep.ProjectID) AS ProjectCount
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
GROUP BY e.EmployeeID,e.FirstName, e.LastName
HAVING COUNT(ep.ProjectID) > 2;
-- 6. View
GO
CREATE VIEW EmployeeProjectView AS
SELECT e.EmployeeID, (e.FirstName + ' ' + e.LastName) AS FullName, 
       p.ProjectID, p.ProjectName, ep.AssignedDate
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects p ON ep.ProjectID = p.ProjectID;
GO

CREATE PROCEDURE sp_AssignEmployeeToProject @empId INT, @projId INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM EmployeeProjects WHERE EmployeeID = @empId AND ProjectID = @projId)
    BEGIN
        INSERT INTO EmployeeProjects (EmployeeID, ProjectID) VALUES (@empId, @projId);
    END
END;
GO

CREATE FUNCTION fn_GetProjectCount(@empId INT) 
RETURNS INT
AS
BEGIN
    DECLARE @p_count INT;
    SELECT @p_count = COUNT(*) FROM EmployeeProjects WHERE EmployeeID = @empId;
    RETURN @p_count;
END;

GO
SELECT FirstName, LastName, dbo.fn_GetProjectCount(EmployeeID) as ActiveProjects FROM Employees;

EXEC sp_AssignEmployeeToProject @empId = 5, @projId = 2;

SELECT * FROM EmployeeProjectView WHERE EmployeeID = 5;

DELETE FROM EmployeeProjects WHERE EmployeeID = 2;
SELECT * FROM EmployeeProjects WHERE EmployeeID = 2;