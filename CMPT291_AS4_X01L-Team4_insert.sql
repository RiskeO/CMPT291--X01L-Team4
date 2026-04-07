USE CMP291Project;

--
-- Remove test data
--

DELETE Actor_Rate;
DELETE Rental_Record;
DELETE Actor_Appear;
DELETE Actor;
DELETE Customer_Queue;
DELETE Movie;
DELETE Customer_Phone;
DELETE Customer;
DELETE Employee_Phone;
DELETE Employee;



--
-- Add test data
--

--INSERT INTO <target_table> SELECT <columns> FROM <source_table>
--INSERT INTO table_name (column1, column2, column3, ...)
	--VALUES (value1, value2, value3, ...),
	--	(value1, value2, value3, ...);
--select getDate();

INSERT INTO Employee (EmployeeID, SSN, LastName, FirstName, Email, PasswordHash, Salt, StartDate)
	VALUES ( NEXT VALUE FOR Employee_EmployeeID_Seq, '111222333', 'Smith', 'John', 'JSmith@email.com', 0x18E640BD86BB691F7C0CE81CF693E8CE5415E5AF01B079D3E275905BCBD44A4C,  0xA7F3C91E4B82D6F10A5E73BC29D4816F, '2024-10-29');

INSERT INTO Employee_Phone (EmployeeID, PhoneNum, PhoneType)
	VALUES( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		'7807654321', 'Home' );


INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, 
		PostalCode, Email, AccountNum, CreditCardNum, CreditCardExp, CreditCardCvv)
	VALUES ( NEXT VALUE FOR Customer_CustomerID_Seq, 'Last1', 'Customer1', 
		'11101 111st', 'Edmonton', 'AB', 'A1A1A1', 'cust1@gmail.com', 'ABC001', 
		'1111222233334444', '1027', '111');

INSERT INTO Customer_Phone (CustomerID, PhoneNum, PhoneType)
	VALUES ( (SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com'),
		'7801111111', 'Home' );

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, 
		PostalCode, Email, AccountNum, CreditCardNum, CreditCardExp, CreditCardCvv)
	VALUES ( NEXT VALUE FOR Customer_CustomerID_Seq, 'Last2', 'Customer2', 
		'11102 112st', 'Edmonton', 'AB', 'A1A1A2', 'cust2@gmail.com', 'ABC002', 
		'1111222233334442', '1227', '112');

INSERT INTO Customer_Phone (CustomerID, PhoneNum, PhoneType)
	VALUES ( (SELECT CustomerID FROM Customer WHERE Email = 'cust2@gmail.com'),
		'7801111112', 'Home' );


INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy)
	VALUES ( 'Die Hard', 'Action', 3.5, 5 );

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy)
	VALUES ('Die Hard 2', 'Action', 4.5, 1 );

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy)
	VALUES ( 'Die Hard 3', 'Action', 5.5, 3 );


INSERT INTO Actor (Name, Gender, DateOfBirth)
	VALUES ( 'Bruce Wills', 'M', '1955-03-19' )

INSERT INTO Actor_Appear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard'),
		(SELECT ActorID FROM Actor WHERE Name = 'Bruce Wills') )

INSERT INTO Actor_Appear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 2'),
		(SELECT ActorID FROM Actor WHERE Name = 'Bruce Wills') )

INSERT INTO Actor_Appear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 3'),
		(SELECT ActorID FROM Actor WHERE Name = 'Bruce Wills') )


INSERT INTO Customer_queue
	VALUES ( (SELECT CustomerID FROM Customer WHERE FirstName = 'Customer1'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 2'), 1)

INSERT INTO Customer_queue
	VALUES ( (SELECT CustomerID FROM Customer WHERE FirstName = 'Customer1'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 3'), 1)

INSERT INTO Customer_queue
	VALUES ( (SELECT CustomerID FROM Customer WHERE FirstName = 'Customer2'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 2'), 2)

INSERT INTO Customer_queue
	VALUES ( (SELECT CustomerID FROM Customer WHERE FirstName = 'Customer2'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 3'), 2)



INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard'), 5 )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard'), 5, '2026-01-01' )

INSERT INTO Actor_Rate (RentalRecordID, ActorID, ActorRate)
	VALUES ( (SELECT RentalRecordID FROM Rental_Record
		WHERE EmployeeID = (SELECT EmployeeID FROM Employee WHERE SSN = '111222333')
		AND CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com')
		AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard')
		AND CheckoutTime = '2026-01-01'),
		(SELECT ActorID FROM Actor_Appear  
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




