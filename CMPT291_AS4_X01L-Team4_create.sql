USE CMP291Project;

--
-- Clean up DB schema
--

DROP SEQUENCE IF EXISTS Employee_EmployeeID_Seq;
DROP SEQUENCE IF EXISTS Customer_CustomerID_Seq;
DROP SEQUENCE IF EXISTS Movie_MovieID_Seq;

DROP TABLE IF EXISTS Rate_Actor;
DROP TABLE IF EXISTS Queue_Up;
DROP TABLE IF EXISTS Orders;
DROP TABLE IF EXISTS Appeared_In;
DROP TABLE IF EXISTS Actor;
DROP TABLE IF EXISTS Movie;
DROP TABLE IF EXISTS Customer_Phone;
DROP TABLE IF EXISTS Customer;
DROP TABLE IF EXISTS Employee_Phone;
DROP TABLE IF EXISTS Employee;
GO

CREATE TABLE Employee (
Employee_ID INT NOT NULL,
SSN NCHAR(9) NOT NULL,
Last_Name VARCHAR(40) NOT NULL,
First_Name VARCHAR(40) NOT NULL,
Address_Name VARCHAR(40) NOT NULL,
City VARCHAR(40) NOT NULL,
State_Name VARCHAR(40) NOT NULL,
Zip_Code VARCHAR(40) NOT NULL,
Start_Date DATE NOT NULL DEFAULT(getdate()),
PRIMARY KEY( Employee_ID ),
UNIQUE ( SSN ),
);

CREATE SEQUENCE Employee_EmployeeID_Seq START WITH 1000 INCREMENT BY 1;

CREATE TABLE Employee_Phone (
Employee_ID INT NOT NULL,
Phone_Num NCHAR(10) NOT NULL,
Phone_Type VARCHAR(10) NOT NULL,
Start_Time DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
End_Time DATETIME,
PRIMARY KEY( Employee_ID, Phone_Num, Start_Time ),
FOREIGN KEY ( Employee_ID ) REFERENCES Employee( Employee_ID ),
CONSTRAINT Emp_Phone_Period CHECK (Start_Time < End_Time)
);

CREATE TABLE Customer (
Customer_ID INT NOT NULL,
Last_Name VARCHAR(40) NOT NULL,
First_Name VARCHAR(40) NOT NULL,
Address_Name VARCHAR(40) NOT NULL,
City VARCHAR(40) NOT NULL,
State_Name VARCHAR(40) NOT NULL,
Zip_Code VARCHAR(40) NOT NULL,
Email_Address VARCHAR(40) NOT NULL,
Account_Number NCHAR(10) NOT NULL,
Account_Creation_Date DATE NOT NULL DEFAULT(getdate()),
Credit_Card_Number NCHAR(16),
PRIMARY KEY(Customer_ID)
);

CREATE SEQUENCE Customer_CustomerID_Seq START WITH 1000 INCREMENT BY 1;

CREATE TABLE Customer_Phone (
Customer_ID INT NOT NULL,
Phone_Num NCHAR(10) NOT NULL,
Phone_Type VARCHAR(10) NOT NULL,
PRIMARY KEY( Customer_ID, Phone_Num ),
FOREIGN KEY( Customer_ID ) REFERENCES Customer( Customer_ID )
);

CREATE TABLE Movie(
	Movie_ID INT IDENTITY(1,1) PRIMARY KEY,
	Movie_Name VARCHAR(255) NOT NULL,
	Fee DECIMAL(10,2) NOT NULL,
	Copy_Num INT NOT NULL ,
	Copy_Rented INT NOT NULL default 0,
	Rating DECIMAL(3,2) NOT NULL,
	Available AS (Copy_Num - Copy_Rented) Persisted,
	CONSTRAINT  chk_Rating CHECK (Rating >= 0 AND Rating <= 10),
	CONSTRAINT  chk_Copy CHECK (Copy_Num >= 0 AND Copy_Rented >= 0 AND Copy_Rented <= Copy_Num),
	CONSTRAINT  chk_Fee CHECK (Fee >= 0)
);

CREATE TABLE Actor (
ActorID INT IDENTITY(1,1),
LastName VARCHAR(40) NOT NULL,
FirstName VARCHAR(40) NOT NULL,
Gender VARCHAR(10) NOT NULL
	CHECK( Gender=‘Male’ OR Gender=‘Female’),
DateOfBirth DATE NOT NULL,
PRIMARY KEY( ActorID )
);

CREATE TABLE AppearedIn (
ActorID INT NOT NULL,
MovieID INT NOT NULL,
PRIMARY KEY( ActorID, MovieID ),
FOREIGN KEY( ActorID ) REFERENCES Actor( ActorID ),
FOREIGN KEY( MovieID ) REFERENCES Movie( MovieID )
);

CREATE TABLE RateActor (
ActorID INT NOT NULL,
OrderID INT NOT NULL,
PRIMARY KEY ( ActorID, OrderID )
FOREIGN KEY ( ActorID ) REFERENCES Actor( ActorID ),
FOREIGN KEY ( OrderID ) REFERENCES Order( OrderID )
);