USE SAMPLE;

--
-- Clean up DB schema
--

DROP SEQUENCE IF EXISTS Movie_MovieID_Seq;

DROP TABLE IF EXISTS Movie;
DROP TABLE IF EXISTS EmployeePhone;
DROP TABLE IF EXISTS Employee;



--
-- Create tables
-- https://www.w3schools.com/sql/sql_create_db.asp
-- https://learn.microsoft.com/en-us/sql/t-sql/data-types/data-types-transact-sql?view=sql-server-ver16
-- https://learn.microsoft.com/en-us/sql/relational-databases/tables/unique-constraints-and-check-constraints?view=sql-server-ver16
--


CREATE TABLE Employee (
EmployeeID INT IDENTITY(1,1),
SSN NCHAR(9) NOT NULL,
LastName VARCHAR(40) NOT NULL,
FirstName VARCHAR(40) NOT NULL,
StartDate DATE NOT NULL DEFAULT(getdate()),
PRIMARY KEY( EmployeeID ),
UNIQUE ( SSN ),
);

CREATE TABLE EmployeePhone (
EmployeeID INT NOT NULL,
PhoneNum NCHAR(10) NOT NULL,
PhoneType VARCHAR(10) NOT NULL,
StartTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
EndTime DATETIME,
PRIMARY KEY( EmployeeID, PhoneNum, StartTime ),
FOREIGN KEY ( EmployeeID ) REFERENCES Employee( EmployeeID ),
CONSTRAINT EmpPhonePeriod CHECK (StartTime < EndTime)
);



CREATE TABLE Movie (
MovieID INT NOT NULL,
MovieName VARCHAR(40) NOT NULL,
MovieType VARCHAR(10) NOT NULL
	CHECK( MovieType='Comedy' or MovieType='Drama' or MovieType='Action' or MovieType='Foreign' ),
Fee NUMERIC(6,2) NOT NULL,
NumOfCopy INT NOT NULL,
PRIMARY KEY( MovieID )
);

CREATE SEQUENCE Movie_MovieID_Seq START WITH 1000 INCREMENT BY 1;
