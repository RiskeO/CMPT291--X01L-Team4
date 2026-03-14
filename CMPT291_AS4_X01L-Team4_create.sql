USE CMP291Project;

--
-- Clean up DB schema
--

DROP SEQUENCE IF EXISTS Orders_Order_ID_Seq;
DROP SEQUENCE IF EXISTS Actor_Actor_ID_Seq;
DROP SEQUENCE IF EXISTS Employee_Employee_ID_Seq;
DROP SEQUENCE IF EXISTS Customer_Customer_ID_Seq;
DROP SEQUENCE IF EXISTS Movie_Movie_ID_Seq;

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
Start_Date DATETIME NOT NULL DEFAULT(getdate()),
PRIMARY KEY( Employee_ID ),
UNIQUE ( SSN )
);

CREATE SEQUENCE Employee_Employee_ID_Seq START WITH 1000 INCREMENT BY 1;

CREATE TABLE Employee_Phone (
Employee_ID INT NOT NULL,
Phone_Num NCHAR(10) NOT NULL,
Phone_Type VARCHAR(10) NOT NULL,
Start_Time DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
End_Time DATETIME NULL,
PRIMARY KEY( Employee_ID, Phone_Num, Start_Time ),
FOREIGN KEY ( Employee_ID ) REFERENCES Employee( Employee_ID ),
CONSTRAINT Emp_Phone_Period CHECK (End_Time IS NULL OR Start_Time < End_Time)
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
Account_Creation_Date DATETIME NOT NULL DEFAULT(getdate()),
Credit_Card_Number NCHAR(16),
PRIMARY KEY(Customer_ID)
);

CREATE SEQUENCE Customer_Customer_ID_Seq START WITH 1000 INCREMENT BY 1;

CREATE TABLE Customer_Phone (
Customer_ID INT NOT NULL,
Phone_Num NCHAR(10) NOT NULL,
Phone_Type VARCHAR(10) NOT NULL,
PRIMARY KEY( Customer_ID, Phone_Num ),
FOREIGN KEY( Customer_ID ) REFERENCES Customer( Customer_ID )
);

CREATE TABLE Movie(
	Movie_ID INT NOT NULL PRIMARY KEY,
	Movie_Name VARCHAR(255) NOT NULL,
	Movie_Type VARCHAR(20) NOT NULL,
	Fee DECIMAL(10,2) NOT NULL,
	Copy_Num INT NOT NULL ,
	Copy_Rented INT NOT NULL default 0,
	Movie_Rating INT NOT NULL,
	Available AS (Copy_Num - Copy_Rented) Persisted,
	CONSTRAINT  chk_Rating CHECK (Movie_Rating >= 1 AND Movie_Rating <= 5),
	CONSTRAINT  chk_Copy CHECK (Copy_Num >= 0 AND Copy_Rented >= 0 AND Copy_Rented <= Copy_Num),
	CONSTRAINT  chk_Fee CHECK (Fee >= 0),
	CONSTRAINT  chk_Movie_Type CHECK (Movie_Type IN ('Comedy', 'Action', 'Drama', 'Foreign'))
	);

CREATE SEQUENCE Movie_Movie_ID_Seq START WITH 1000 INCREMENT BY 1;

CREATE TABLE Actor (
Actor_ID INT IDENTITY(1,1),
Last_Name VARCHAR(40) NOT NULL,
First_Name VARCHAR(40) NOT NULL,
Gender VARCHAR(10) NOT NULL
	CHECK( Gender='Male' OR Gender='Female'),
Date_Of_Birth DATETIME NOT NULL,
PRIMARY KEY( Actor_ID )
);

CREATE TABLE Appeared_In (
Actor_ID INT NOT NULL,
Movie_ID INT NOT NULL,
PRIMARY KEY( Actor_ID, Movie_ID ),
FOREIGN KEY( Actor_ID ) REFERENCES Actor( Actor_ID ),
FOREIGN KEY( Movie_ID ) REFERENCES Movie( Movie_ID )
);

CREATE TABLE Orders (
Order_ID INT NOT NULL,
Customer_ID INT NOT NULL,
Employee_ID INT NOT NULL,
Movie_ID INT NOT NULL,
Checkout_Date DATETIME NOT NULL DEFAULT(getdate()),
Return_Date DATETIME NULL,
Movie_Rating INT
	CHECK( (Movie_Rating >= 1 AND Movie_Rating <= 5) OR Movie_Rating IS NULL),
PRIMARY KEY ( Order_ID ),
FOREIGN KEY ( Customer_ID ) REFERENCES Customer( Customer_ID ),
FOREIGN KEY ( Employee_ID ) REFERENCES Employee( Employee_ID ),
FOREIGN KEY ( Movie_ID ) REFERENCES Movie( Movie_ID )
);

CREATE TABLE Rate_Actor (
Actor_ID INT NOT NULL,
Order_ID INT NOT NULL,
Actor_Rate INT
	CHECK( (Actor_Rate >= 1 AND Actor_Rate <= 5) OR Actor_Rate IS NULL),
PRIMARY KEY ( Actor_ID, Order_ID ),
FOREIGN KEY ( Actor_ID ) REFERENCES Actor( Actor_ID ),
FOREIGN KEY ( Order_ID ) REFERENCES Orders( Order_ID )
);


CREATE SEQUENCE Orders_Order_ID_Seq START WITH 1000 INCREMENT BY 1;

CREATE TABLE Queue_Up (
Customer_ID INT NOT NULL,
Movie_ID INT NOT NULL,
Sort_Order INT IDENTITY(1,1),
PRIMARY KEY ( Customer_ID, Sort_Order ),
UNIQUE ( Customer_ID, Movie_ID ),
FOREIGN KEY ( Customer_ID ) REFERENCES Customer( Customer_ID ),
FOREIGN KEY ( Movie_ID ) REFERENCES Movie( Movie_ID )
);
