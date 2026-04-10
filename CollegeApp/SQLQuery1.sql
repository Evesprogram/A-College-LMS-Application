USE SchoolDB;
ALTER TABLE Student
ADD CourseID INT;

UPDATE s
SET s.CourseID = c.CourseID
FROM Student s
INNER JOIN Course c ON s.CourseName = c.CourseName;

SELECT * FROM Student;
SELECT * FROM Course;
SELECT * FROM Module;
SELECT * FROM Department;
SELECT * FROM Lecturer;

UPDATE Student
SET CourseID = 1
WHERE FirstName = 'Lisa';

UPDATE Student
SET CourseID = 4
WHERE FirstName = 'Sebastian';

SELECT StudentID, FirstName FROM Student;
UPDATE Student
SET CourseID = 2
WHERE StudentID = 4;

INSERT INTO Student (StudentID, FirstName, LastName, Age, CourseName)
VALUES (5, 'Lisa', 'Smith', 20, 'Information Technology'),
       (6, 'Sebastian', 'Meyer', 22, 'Business Management');
-- Create new table correctly
CREATE TABLE Student_New
(
    StudentID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Age INT,
    CourseName VARCHAR(50),
    CourseID INT
);
SET IDENTITY_INSERT Student_New ON;

INSERT INTO Student_New (StudentID, FirstName, LastName, Age, CourseName, CourseID)
SELECT StudentID, FirstName, LastName, Age, CourseName, CourseID
FROM Student;

SET IDENTITY_INSERT Student_New OFF;

DROP TABLE Student;
EXEC sp_rename 'Student_New', 'Student';

INSERT INTO Department (DepartmentID,DepartmentName, Building)
VALUES 
(4,'Information Technology', 'Block A'),
(5,'Business Management', 'Block B'),
(6,'Engineering', 'Block C');

INSERT INTO Course (CourseName, DepartmentID)
VALUES 
('Software Development', 1),
('Networking', 1),
('Marketing', 2),
('Human Resources', 2),
('Mechanical Engineering', 3),
('Electrical Engineering', 3);

INSERT INTO Module (ModuleName)
VALUES 
('Programming 1'),
('Programming 2'),
('Database Systems'),
('Networking Fundamentals'),
('Digital Marketing'),
('HR Management'),
('Thermodynamics');

SELECT * FROM Department
