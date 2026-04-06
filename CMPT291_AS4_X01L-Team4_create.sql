USE CMP291Project;

--
-- Clean up DB schema
--

DROP SEQUENCE IF EXISTS Customer_CustomerID_Seq;
DROP SEQUENCE IF EXISTS Employee_EmployeeID_Seq;

DROP TABLE IF EXISTS Actor_Rate;
DROP TABLE IF EXISTS Rental_Record;
DROP TABLE IF EXISTS Actor_Appear;
DROP TABLE IF EXISTS Actor;
DROP TABLE IF EXISTS Customer_Queue;
DROP TABLE IF EXISTS Movie;
DROP TABLE IF EXISTS Customer_Phone;
DROP TABLE IF EXISTS Customer;
DROP TABLE IF EXISTS Employee_Phone;
DROP TABLE IF EXISTS Employee;



--
-- Create tables
-- https://www.w3schools.com/sql/sql_create_db.asp
-- https://learn.microsoft.com/en-us/sql/t-sql/data-types/data-types-transact-sql?view=sql-server-ver16
-- https://learn.microsoft.com/en-us/sql/relational-databases/tables/unique-constraints-and-check-constraints?view=sql-server-ver16
--


CREATE TABLE Employee (
EmployeeID INT,
SSN NCHAR(9) NOT NULL,
LastName VARCHAR(40) NOT NULL,
FirstName VARCHAR(40) NOT NULL,
Email VARCHAR(64) NOT NULL,
PasswordHash VARBINARY(64) NOT NULL,
Salt VARBINARY(16) NOT NULL,
Address VARCHAR(40),
City VARCHAR(40),
Province NCHAR(2),
PostalCode NCHAR(6),
StartDate DATE NOT NULL,
PRIMARY KEY( EmployeeID ),
UNIQUE ( SSN, StartDate )
);


CREATE SEQUENCE Employee_EmployeeID_Seq START WITH 1000 INCREMENT BY 1;


CREATE TABLE Employee_Phone (
EmployeeID INT NOT NULL,
PhoneNum NCHAR(10) NOT NULL,
PhoneType VARCHAR(10) NOT NULL,
StartTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
EndTime DATETIME,
PRIMARY KEY( EmployeeID, PhoneNum, StartTime ),
FOREIGN KEY ( EmployeeID ) REFERENCES Employee( EmployeeID ),
CONSTRAINT EmpPhonePeriod CHECK (StartTime < EndTime)
);


CREATE TABLE Customer (
CustomerID INT,
LastName VARCHAR(40) NOT NULL,
FirstName VARCHAR(40) NOT NULL,
Address VARCHAR(40),
City VARCHAR(40),
Province NCHAR(2),
PostalCode NCHAR(6),
Email VARCHAR(40) NOT NULL,
AccountNum NCHAR(10) NOT NULL,
CreditCardNum NCHAR(16) NOT NULL,
CreditCardExp NCHAR(4) NOT NULL,
CreditCardCvv NCHAR(3) NOT NULL,
CreationDate DATE NOT NULL DEFAULT CURRENT_TIMESTAMP,
PRIMARY KEY( CustomerID )
);

CREATE SEQUENCE Customer_CustomerID_Seq START WITH 1000 INCREMENT BY 1;

CREATE TABLE Customer_Phone (
CustomerID INT NOT NULL,
PhoneNum NCHAR(10) NOT NULL,
PhoneType VARCHAR(10) NOT NULL,
StartTime DATETIME NOT NULL DEFAULT(getdate()),
EndTime DATETIME,
PRIMARY KEY( CustomerID, PhoneNum, StartTime ),
FOREIGN KEY ( CustomerID ) REFERENCES Customer( CustomerID ),
CONSTRAINT CustPhonePeriod CHECK (StartTime < EndTime)
);


CREATE TABLE Movie (
MovieID INT NOT NULL IDENTITY(1,1),
MovieName VARCHAR(40) NOT NULL,
MovieType VARCHAR(10) NOT NULL
	CHECK( MovieType='Comedy' or MovieType='Drama' or MovieType='Action' or MovieType='Foreign' ),
Fee NUMERIC(6,2) NOT NULL,
NumOfCopy INT NOT NULL,
NumOfRented INT NOT NULL DEFAULT 0,
PRIMARY KEY( MovieID )
);


CREATE TABLE Customer_Queue (
CustomerID INT NOT NULL,
MovieID INT NOT NULL,
SortNum INT NOT NULL,
PRIMARY KEY ( CustomerID, MovieID ),
UNIQUE ( CustomerID, SortNum ),
FOREIGN KEY ( CustomerID ) REFERENCES Customer( CustomerID ),
FOREIGN KEY ( MovieID ) REFERENCES Movie( MovieID )
);



CREATE TABLE Actor (
ActorID INT IDENTITY(1,1),
Name VARCHAR(100) NOT NULL,
Gender NCHAR(1) NOT NULL CHECK( Gender='M' or Gender='F' ),
DateOfBirth Date NOT NULL,
PRIMARY KEY( ActorID )
);

CREATE TABLE Actor_Appear (
MovieID INT NOT NULL,
ActorID INT NOT NULL,
PRIMARY KEY ( MovieID, ActorID ),
FOREIGN KEY ( MovieID ) REFERENCES Movie( MovieID ),
FOREIGN KEY ( ActorID ) REFERENCES Actor( ActorID )
);



CREATE TABLE Rental_Record (
RentalRecordID INT IDENTITY(1,1),
EmployeeID INT NOT NULL,
CustomerID INT NOT NULL,
MovieID INT NOT NULL,
CheckoutTime DATETIME NOT NULL DEFAULT(getdate()),
ReturnTime DATETIME,
MovieRate INT CHECK (MovieRate BETWEEN 1 AND 5),
PRIMARY KEY( RentalRecordID ),
FOREIGN KEY ( EmployeeID ) REFERENCES Employee( EmployeeID ),
FOREIGN KEY ( CustomerID ) REFERENCES Customer( CustomerID ),
FOREIGN KEY ( MovieID ) REFERENCES Movie( MovieID )
);


CREATE TABLE Actor_Rate (
RentalRecordID INT NOT NULL,
ActorID INT NOT Null,
ActorRate INT NOT NULL CHECK (ActorRate BETWEEN 1 AND 5),
PRIMARY KEY( RentalRecordID, ActorID ),
FOREIGN KEY ( RentalRecordID ) REFERENCES Rental_Record( RentalRecordID ),
FOREIGN KEY ( ActorID ) REFERENCES Actor( ActorID )
);



