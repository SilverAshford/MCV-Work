CREATE DATABASE IF NOT EXISTS StudentManagementDb;
USE StudentManagementDb;

CREATE TABLE IF NOT EXISTS Departments (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    NAME VARCHAR(50) NOT NULL,
    CreationDate DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE IF NOT EXISTS Students (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Age INT NOT NULL,
    Email VARCHAR(150),
    DepartmentId INT,
    CreationDate DATETIME DEFAULT CURRENT_TIMESTAMP,

    FOREIGN KEY (DepartmentId) REFERENCES Departments(Id)
        ON DELETE SET NULL
        ON UPDATE CASCADE
);

INSERT INTO Departments (Name) VALUES ('IT'),('CyberSecurity'),('Finance'),('Sales'),('Marketing');

INSERT INTO Students (Name, Age, Email, DepartmentId) 
VALUES 
    ('Ahmed Ali', 20, 'ahmed.ali@example.com', 1),
    ('Sara Hassan', 22, 'sara.hassan@example.com', 1),
    ('Omar Khaled', 21, 'omar.khaled@example.com', 1),
    ('Mariam Amr', 20, 'mariam.amr@example.com', 1),
    ('Hassan Reda', 25, 'hassan.reda@example.com', 1),

    ('Mona Mahmoud', 23, 'mona.mahmoud@example.com', 2),
    ('Youssef Ibrahim', 18, 'youssef.ibrahim@example.com', 2),
    ('Nour El-Din', 17, 'nour.eldin@example.com', 2),
    ('Dalia Fouad', 21, 'dalia.fouad@example.com', 2),

    ('Kareem Mostafa', 21, 'kareem.mostafa@example.com', 3),
    ('Hoda Gamal', 18, 'hoda.gamal@example.com', 3),
    ('Tarek Said', 23, 'tarek.said@example.com', 3),

    ('Mostafa Samir', 22, 'mostafa.samir@example.com', 4),
    ('Rania Sherif', 16, 'rania.sherif@example.com', 4),

    ('Khaled Walid', 15, 'khaled.walid@example.com', 5);
    
SELECT
    Students.Id AS StudentId,
    Students.Name AS StudentName,
    Students.Age,
    Students.Email,
    Departments.Name AS DepartmentName
FROM Students
JOIN Departments
ON Students.DepartmentId = Departments.Id;

SELECT Name, Age FROM Students WHERE Age BETWEEN 18 AND 22 ORDER BY Age ASC;

SELECT * FROM Students WHERE Name LIKE '%Ahmed%';

SELECT 
    Students.Name AS StudentName,
    Students.Age,
    Students.Email,
    Departments.Name AS DepartmentName
FROM Students
JOIN Departments ON Students.DepartmentId = Departments.Id
WHERE Students.Name LIKE '%Example%' 
   OR Departments.Name LIKE '%Example%';
   
SELECT 
    Departments.Name AS DepartmentName,
    COUNT(Students.Id) AS StudentsCount
FROM Departments
LEFT JOIN Students ON Departments.Id = Students.DepartmentId
GROUP BY Departments.Id, Departments.Name;

SELECT 
    Departments.Name AS DepartmentName,
    COUNT(Students.Id) AS NumberOfStudents,
    AVG(Students.Age) AS AverageAge,
    MAX(Students.Age) AS OldestAge,
    MIN(Students.Age) AS YoungestAge
FROM Departments
LEFT JOIN Students ON Departments.Id = Students.DepartmentId
GROUP BY Departments.Id, Departments.Name;

SELECT 
    Departments.Name AS DepartmentName,
    COUNT(Students.Id) AS StudentCount
FROM Departments
LEFT JOIN Students ON Departments.Id = Students.DepartmentId
GROUP BY Departments.Id, Departments.Name
HAVING COUNT(Students.Id) = (
    SELECT MAX(StudentCountTable.StudentCount)
    FROM (
        SELECT COUNT(Students.Id) AS StudentCount
        FROM Departments
        LEFT JOIN Students ON Departments.Id = Students.DepartmentId
        GROUP BY Departments.Id
    ) AS StudentCountTable
)
OR COUNT(Students.Id) = (
    SELECT MIN(StudentCountTable.StudentCount)
    FROM (
        SELECT COUNT(Students.Id) AS StudentCount
        FROM Departments
        LEFT JOIN Students ON Departments.Id = Students.DepartmentId
        GROUP BY Departments.Id
    ) AS StudentCountTable
);

UPDATE Students SET Name = 'Omar Ali', Age = 24, Email = 'omar.ali@example.com', DepartmentId = 2 WHERE Id = 1;

DELETE FROM Students WHERE Id = 15;

DELIMITER //

CREATE PROCEDURE sp_InsertDepartment(
    IN DepartmentName VARCHAR(100)
)
BEGIN
    INSERT INTO Departments (Name)
    VALUES (DepartmentName);
END //

DELIMITER ;

DELIMITER //

CREATE PROCEDURE sp_InsertStudent(
    IN StudentName VARCHAR(100),
    IN Age INT,
    IN Email VARCHAR(150),
    IN DepartmentId INT
)
BEGIN
    IF EXISTS (
        SELECT 1 
        FROM Departments 
        WHERE Departments.Id = DepartmentId
    ) THEN
        INSERT INTO Students (Name, Age, Email, DepartmentId)
        VALUES (StudentName, Age, Email, DepartmentId);
    ELSE
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: DepartmentId does not exist.';
    END IF;
END //

DELIMITER ;

DELIMITER //

CREATE PROCEDURE sp_UpdateStudent(
    IN StudentId INT,
    IN StudentName VARCHAR(100),
    IN Age INT,
    IN Email VARCHAR(150),
    IN DepartmentId INT
)
BEGIN
    IF EXISTS (
        SELECT 1 
        FROM Departments 
        WHERE Departments.Id = DepartmentId
    ) THEN
        UPDATE Students
        SET 
            Name = StudentName,
            Age = Age,
            Email = Email,
            DepartmentId = DepartmentId
        WHERE Id = StudentId;
    ELSE
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Error: DepartmentId does not exist.';
    END IF;
END //

DELIMITER ;

DELIMITER //

CREATE PROCEDURE sp_DeleteStudent(
    IN StudentId INT
)
BEGIN
    DELETE FROM Students
    WHERE Id = StudentId;
END //

DELIMITER ;

DELIMITER //

CREATE PROCEDURE sp_GetAllStudents()
BEGIN
    SELECT 
        Students.Name AS StudentName,
        Students.Age,
        Students.Email,
        Departments.Name AS DepartmentName
    FROM Students
    LEFT JOIN Departments ON Students.DepartmentId = Departments.Id;
END //

DELIMITER ;

--

DELIMITER //

CREATE PROCEDURE sp_SearchStudents(
    IN SearchText VARCHAR(100)
)
BEGIN
    SELECT 
        Students.Id AS StudentId,
        Students.Name AS StudentName,
        Students.Age,
        Students.Email,
        Departments.Name AS DepartmentName
    FROM Students
    LEFT JOIN Departments ON Students.DepartmentId = Departments.Id
    WHERE Students.Name LIKE CONCAT('%', SearchText, '%')
       OR Departments.Name LIKE CONCAT('%', SearchText, '%');
END //

DELIMITER ;

--

DELIMITER //

CREATE PROCEDURE sp_GetDepartmentStatistics()
BEGIN
    SELECT 
        Departments.Name AS DepartmentName,
        COUNT(Students.Id) AS StudentCount,
        AVG(Students.Age) AS AverageAge,
        MAX(Students.Age) AS OldestAge,
        MIN(Students.Age) AS YoungestAge
    FROM Departments
    LEFT JOIN Students ON Departments.Id = Students.DepartmentId
    GROUP BY Departments.Id, Departments.Name;
END //

DELIMITER ;

--

DELIMITER //

CREATE PROCEDURE sp_GetHighestAndLowestDepartments()
BEGIN
    SELECT 
        Departments.Name AS DepartmentName,
        COUNT(Students.Id) AS StudentCount
    FROM Departments
    LEFT JOIN Students ON Departments.Id = Students.DepartmentId
    GROUP BY Departments.Id, Departments.Name
    HAVING COUNT(Students.Id) = (
        SELECT MAX(StudentCountTable.StudentCount)
        FROM (
            SELECT COUNT(Students.Id) AS StudentCount
            FROM Departments
            LEFT JOIN Students ON Departments.Id = Students.DepartmentId
            GROUP BY Departments.Id
        ) AS StudentCountTable
    )
    OR COUNT(Students.Id) = (
        SELECT MIN(StudentCountTable.StudentCount)
        FROM (
            SELECT COUNT(Students.Id) AS StudentCount
            FROM Departments
            LEFT JOIN Students ON Departments.Id = Students.DepartmentId
            GROUP BY Departments.Id
        ) AS StudentCountTable
    );
END //

DELIMITER ;

--

CREATE VIEW vw_StudentDetails AS
SELECT 
    Students.Id AS StudentId,
    Students.Name AS StudentName,
    Students.Age,
    Students.Email,
    Departments.Name AS DepartmentName
FROM Students
LEFT JOIN Departments ON Students.DepartmentId = Departments.Id;

--

CREATE VIEW vw_DepartmentStatistics AS
SELECT 
    Departments.Name AS DepartmentName,
    COUNT(Students.Id) AS StudentsCount,
    AVG(Students.Age) AS AverageAge,
    MAX(Students.Age) AS OldestAge,
    MIN(Students.Age) AS YoungestAge
FROM Departments
LEFT JOIN Students ON Departments.Id = Students.DepartmentId
GROUP BY Departments.Id, Departments.Name;

