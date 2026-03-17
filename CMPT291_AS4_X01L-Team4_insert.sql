USE Proj2026W;

--
-- Remove test data
--

DELETE ActorRate;
DELETE RentalRecord;
DELETE ActorAppear;
DELETE Actor;
DELETE CustomerQueue;
DELETE Movie;
DELETE CustomerPhone;
DELETE Customer;
DELETE EmployeePhone;
DELETE Employee;



--
-- Add test data
--

--INSERT INTO <target_table> SELECT <columns> FROM <source_table>
--INSERT INTO table_name (column1, column2, column3, ...)
	--VALUES (value1, value2, value3, ...),
	--	(value1, value2, value3, ...);
--select getDate();


INSERT INTO Employee (EmployeeID, SSN, LastName, FirstName, StartDate)
	VALUES ( NEXT VALUE FOR Employee_EmployeeID_Seq, '111222333', 'Smith', 'John', '2024-10-29');

INSERT INTO EmployeePhone (EmployeeID, PhoneNum, PhoneType)
	VALUES( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		'7807654321', 'Home' );


INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, 
		PostalCode, Email, AccountNum, CreditCardNum, CreditCardExp, CreditCardCvv)
	VALUES ( NEXT VALUE FOR Customer_CustomerID_Seq, 'Customer1', 'Last1', 
		'11101 111st', 'Edmonton', 'AB', 'A1A1A1', 'cust1@gmail.com', 'ABC001', 
		'1111222233334444', '1027', '111');

INSERT INTO CustomerPhone (CustomerID, PhoneNum, PhoneType)
	VALUES ( (SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com'),
		'7801111111', 'Home' );


INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy)
	VALUES ( 'Die Hard', 'Action', 3.5, 5 );

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy)
	VALUES ('Die Hard 2', 'Action', 4.5, 4 );

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy)
	VALUES ( 'Die Hard 3', 'Action', 5.5, 3 );


INSERT INTO Actor (Name, Gender, DateOfBrith)
	VALUES ( 'Bruce Wills', 'M', '1955-03-19' )

INSERT INTO ActorAppear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard'),
		(SELECT ActorID FROM Actor WHERE Name = 'Bruce Wills') )

INSERT INTO ActorAppear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 2'),
		(SELECT ActorID FROM Actor WHERE Name = 'Bruce Wills') )

INSERT INTO ActorAppear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 3'),
		(SELECT ActorID FROM Actor WHERE Name = 'Bruce Wills') )


INSERT INTO Customerqueue
	VALUES ( (SELECT CustomerID FROM Customer WHERE LastName = 'Customer1'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 2'), 2)

INSERT INTO Customerqueue
	VALUES ( (SELECT CustomerID FROM Customer WHERE LastName = 'Customer1'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 3'), 3)


INSERT INTO RentalRecord (EmployeeID, CustomerID, MovieID, MovieRate)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard'), 5 )

INSERT INTO RentalRecord (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard'), 5, '2026-01-01' )

INSERT INTO ActorRate (RentalRecordID, ActorID, ActorRate)
	VALUES ( (SELECT RentalRecordID FROM RentalRecord
		WHERE EmployeeID = (SELECT EmployeeID FROM Employee WHERE SSN = '111222333')
		AND CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com')
		AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard')
		AND CheckoutTime = '2026-01-01'),
		(SELECT ActorID FROM ActorAppear  
		WHERE ActorID = (SELECT ActorID from Actor WHERE Name = 'Bruce Wills')
		AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard')), 
		5 )


--SELECT * FROM EmployeePhone;
--SELECT * FROM Customer;
--SELECT * FROM CustomerPhone;
--SELECT * FROM Movie;
--SELECT * FROM CustomerQueue;
--SELECT * FROM Actor;
--SELECT * FROM ActorAppear;
--SELECT * FROM RentalRecord;
--SELECT * FROM ActorRate;




