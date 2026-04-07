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
	-- Password: password

INSERT INTO Employee (EmployeeID, SSN, LastName, FirstName, Email, PasswordHash, Salt, StartDate)
	VALUES ( NEXT VALUE FOR Employee_EmployeeID_Seq, '222333444', 'Johnson', 'Emily', 'EJohnson@email.com', 0x2D152AC277B2CF70E0FC6E1FFF3FF9446C920CFDA219BEF46C17352B36595971,  0x4E57B1EB0624EF3D2159FD8351000687, '2025-01-10');
	-- Password: EmilyJ

INSERT INTO Employee (EmployeeID, SSN, LastName, FirstName, Email, PasswordHash, Salt, StartDate)
	VALUES ( NEXT VALUE FOR Employee_EmployeeID_Seq, '333444555', 'Brown', 'Michael', 'MBrown@email.com', 0xE2955A38DADF19A1A059AB2F49D412355622666DABDC216BF344FC54213F8D48,  0xE4190C104C8C91187B00580E887D91F8, '2025-02-15');
	--Password: testing123!@

INSERT INTO Employee_Phone (EmployeeID, PhoneNum, PhoneType)
	VALUES( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		'7807654321', 'Home' );

INSERT INTO Employee_Phone (EmployeeID, PhoneNum, PhoneType)
	VALUES( (SELECT EmployeeID FROM Employee WHERE SSN = '222333444'),
		'7802222222', 'Cell' );

INSERT INTO Employee_Phone (EmployeeID, PhoneNum, PhoneType)
	VALUES( (SELECT EmployeeID FROM Employee WHERE SSN = '333444555'),
		'7803333333', 'Work' );


INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, 
		PostalCode, Email, AccountNum, CreditCardNum, CreditCardExp, CreditCardCvv)
	VALUES ( NEXT VALUE FOR Customer_CustomerID_Seq, 'Last1', 'Customer1', 
		'11101 111st', 'Edmonton', 'AB', 'A1A1A1', 'cust1@gmail.com', 'ABC001', 
		'1111222233334444', '1027', '111');

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, 
		PostalCode, Email, AccountNum, CreditCardNum, CreditCardExp, CreditCardCvv)
	VALUES ( NEXT VALUE FOR Customer_CustomerID_Seq, 'Last2', 'Customer2', 
		'22202 112st', 'Edmonton', 'AB', 'B2B2B2', 'cust2@gmail.com', 'ABC002', 
		'2222333344445555', '1128', '222');

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, 
		PostalCode, Email, AccountNum, CreditCardNum, CreditCardExp, CreditCardCvv)
	VALUES ( NEXT VALUE FOR Customer_CustomerID_Seq, 'Last3', 'Customer3',  
		'33303 113st', 'St. Albert', 'AB', 'C3C3C3', 'cust3@gmail.com', 'ABC007', 
		'3333444455556666', '0129', '333');

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, 
		PostalCode, Email, AccountNum, CreditCardNum, CreditCardExp, CreditCardCvv)
	VALUES ( NEXT VALUE FOR Customer_CustomerID_Seq, 'Last4', 'Customer4',  
		'44404 114st', 'Sherwood Park', 'AB', 'D4D4D4', 'cust4@gmail.com', 'ABC004', 
		'4444555566667777', '0227', '444');

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, 
		PostalCode, Email, AccountNum, CreditCardNum, CreditCardExp, CreditCardCvv)
	VALUES ( NEXT VALUE FOR Customer_CustomerID_Seq, 'Lee', 'Chris', 
		'55505 115st', 'Edmonton', 'AB', 'E5E5E5', 'chrislee1@gmail.com', 'ABC005', 
		'5555666677778888', '0328', '555');

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, 
		PostalCode, Email, AccountNum, CreditCardNum, CreditCardExp, CreditCardCvv)
	VALUES ( NEXT VALUE FOR Customer_CustomerID_Seq, 'Lee', 'Chris', 
		'66606 116st', 'Edmonton', 'AB', 'F6F6F6', 'chrislee2@gmail.com', 'ABC006', 
		'6666777788889999', '0428', '666');

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, 
		PostalCode, Email, AccountNum, CreditCardNum, CreditCardExp, CreditCardCvv)
	VALUES ( NEXT VALUE FOR Customer_CustomerID_Seq, 'Taylor', 'Jordan', 
		'77707 117st', 'Leduc', 'AB', 'G7G7G7', 'jordantaylor@gmail.com', 'ABC003', 
		'7777888899990000', '0528', '777');


INSERT INTO Customer_Phone (CustomerID, PhoneNum, PhoneType)
	VALUES ( (SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com'),
		'7801111111', 'Home' );

INSERT INTO Customer_Phone (CustomerID, PhoneNum, PhoneType)
	VALUES ( (SELECT CustomerID FROM Customer WHERE Email = 'cust2@gmail.com'),
		'7802221111', 'Cell' );


INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy)
	VALUES ( 'Die Hard', 'Action', 3.5, 5 );

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy)
	VALUES ('Die Hard 2', 'Action', 4.5, 1 );

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy)
	VALUES ( 'Die Hard 3', 'Action', 5.5, 3 );

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy)
	VALUES ( 'John Wick', 'Action', 4.5, 5 );

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy)
	VALUES ( 'Mad Max Fury Road', 'Action', 4.5, 5 );
INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy)
	VALUES ( 'The Notebook', 'Drama', 3.5, 4 );

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy)
	VALUES ( 'Titanic', 'Drama', 3.5, 4 );

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy)
	VALUES ( 'The Conjuring', 'Drama', 4.0, 3 );

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy)
	VALUES ( 'Insidious', 'Drama', 4.0, 3 );

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy)
	VALUES ( 'Toy Story', 'Comedy', 3.0, 6 );

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy)
	VALUES ( 'Finding Nemo', 'Comedy', 3.0, 6 );

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy)
	VALUES ( 'Interstellar', 'Foreign', 5.5, 4 );

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy)
	VALUES ( 'Inception', 'Foreign', 5.5, 4 );


INSERT INTO Actor (Name, Gender, DateOfBirth)
	VALUES ( 'Bruce Wills', 'M', '1955-03-19' )

INSERT INTO Actor (Name, Gender, DateOfBirth)
	VALUES ( 'Keanu Reeves', 'M', '1964-09-02' )

INSERT INTO Actor (Name, Gender, DateOfBirth)
	VALUES ( 'Tom Hardy', 'M', '1977-09-15' )

INSERT INTO Actor (Name, Gender, DateOfBirth)
	VALUES ( 'Ryan Gosling', 'M', '1980-11-12' )

INSERT INTO Actor (Name, Gender, DateOfBirth)
	VALUES ( 'Kate Winslet', 'F', '1975-10-05' )

INSERT INTO Actor (Name, Gender, DateOfBirth)
	VALUES ( 'Patrick Wilson', 'M', '1973-07-03' )

INSERT INTO Actor (Name, Gender, DateOfBirth)
	VALUES ( 'Tom Hanks', 'M', '1956-07-09' )

INSERT INTO Actor (Name, Gender, DateOfBirth)
	VALUES ( 'Matthew McConaughey', 'M', '1969-11-04' )

INSERT INTO Actor (Name, Gender, DateOfBirth)
	VALUES ( 'Leonardo DiCaprio', 'M', '1974-11-11' )

INSERT INTO Actor_Appear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard'),
		(SELECT ActorID FROM Actor WHERE Name = 'Bruce Wills') )

INSERT INTO Actor_Appear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 2'),
		(SELECT ActorID FROM Actor WHERE Name = 'Bruce Wills') )

INSERT INTO Actor_Appear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 3'),
		(SELECT ActorID FROM Actor WHERE Name = 'Bruce Wills') )
INSERT INTO Actor_Appear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'John Wick'),
		(SELECT ActorID FROM Actor WHERE Name = 'Keanu Reeves') )

INSERT INTO Actor_Appear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'Mad Max Fury Road'),
		(SELECT ActorID FROM Actor WHERE Name = 'Tom Hardy') )

INSERT INTO Actor_Appear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'The Notebook'),
		(SELECT ActorID FROM Actor WHERE Name = 'Ryan Gosling') )

INSERT INTO Actor_Appear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'Titanic'),
		(SELECT ActorID FROM Actor WHERE Name = 'Kate Winslet') )

INSERT INTO Actor_Appear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'Titanic'),
		(SELECT ActorID FROM Actor WHERE Name = 'Leonardo DiCaprio') )

INSERT INTO Actor_Appear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'The Conjuring'),
		(SELECT ActorID FROM Actor WHERE Name = 'Patrick Wilson') )

INSERT INTO Actor_Appear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'Insidious'),
		(SELECT ActorID FROM Actor WHERE Name = 'Patrick Wilson') )

INSERT INTO Actor_Appear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'Toy Story'),
		(SELECT ActorID FROM Actor WHERE Name = 'Tom Hanks') )

INSERT INTO Actor_Appear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'Finding Nemo'),
		(SELECT ActorID FROM Actor WHERE Name = 'Tom Hanks') )

INSERT INTO Actor_Appear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'Interstellar'),
		(SELECT ActorID FROM Actor WHERE Name = 'Matthew McConaughey') )

INSERT INTO Actor_Appear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'Inception'),
		(SELECT ActorID FROM Actor WHERE Name = 'Leonardo DiCaprio') )


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


INSERT INTO Customer_queue
	VALUES ( (SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC002'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'John Wick'), 1)

INSERT INTO Customer_queue
	VALUES ( (SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC003'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Interstellar'), 1)

INSERT INTO Customer_queue
	VALUES ( (SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC005'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Titanic'), 2)

INSERT INTO Customer_queue
	VALUES ( (SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC006'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Titanic'), 2)

INSERT INTO Customer_queue
	VALUES ( (SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC007'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Conjuring'), 1)


INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard'), 5 )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard'), 5, '2026-01-01' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC001'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 2'), 4, '2026-01-05' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC001'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 3'), 5, '2026-01-08' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '222333444'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC002'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'John Wick'), 5, '2026-02-02' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '222333444'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC002'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Mad Max Fury Road'), 4, '2025-02-10' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '333444555'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC003'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Interstellar'), 5, '2025-03-03' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '333444555'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC003'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Inception'), 5, '2026-03-10' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC004'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Conjuring'), 4, '2026-04-01' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '222333444'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC004'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Insidious'), 4, '2026-04-03' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '333444555'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC005'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Titanic'), 5, '2026-04-10' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC006'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Titanic'), 5, '2026-04-11' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '222333444'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC007'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Notebook'), 4, '2026-04-12' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '333444555'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC002'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'John Wick'), 5, '2026-05-02' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC003'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Interstellar'), 5, '2026-05-03' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '222333444'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC004'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Toy Story'), 5, '2026-05-04' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '333444555'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC005'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Titanic'), 5, '2026-05-05' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC006'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Titanic'), 5, '2026-05-06' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '222333444'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC007'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Finding Nemo'), 4, '2026-05-07' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '333444555'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC002'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'John Wick'), 5, '2026-06-01' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC003'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Interstellar'), 5, '2026-06-02' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '222333444'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC004'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Toy Story'), 5, '2026-06-03' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '333444555'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC005'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Titanic'), 5, '2026-06-04' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC006'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Titanic'), 5, '2026-06-05' )

INSERT INTO Rental_Record (EmployeeID, CustomerID, MovieID, MovieRate, CheckoutTime)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '222333444'),
		(SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC007'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Finding Nemo'), 4, '2026-06-06' )


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

INSERT INTO Actor_Rate (RentalRecordID, ActorID, ActorRate)
	VALUES ( (SELECT RentalRecordID FROM Rental_Record
		WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC002')
		AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'John Wick')
		AND CheckoutTime = '2026-02-02'),
		(SELECT ActorID FROM Actor_Appear  
		WHERE ActorID = (SELECT ActorID from Actor WHERE Name = 'Keanu Reeves')
		AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'John Wick')), 
		5 )

INSERT INTO Actor_Rate (RentalRecordID, ActorID, ActorRate)
	VALUES ( (SELECT RentalRecordID FROM Rental_Record
		WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC002')
		AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Mad Max Fury Road')
		AND CheckoutTime = '2026-02-10'),
		(SELECT ActorID FROM Actor_Appear  
		WHERE ActorID = (SELECT ActorID from Actor WHERE Name = 'Tom Hardy')
		AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Mad Max Fury Road')), 
		4 )

INSERT INTO Actor_Rate (RentalRecordID, ActorID, ActorRate)
	VALUES ( (SELECT RentalRecordID FROM Rental_Record
		WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC003')
		AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Interstellar')
		AND CheckoutTime = '2026-03-03'),
		(SELECT ActorID FROM Actor_Appear  
		WHERE ActorID = (SELECT ActorID from Actor WHERE Name = 'Matthew McConaughey')
		AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Interstellar')), 
		5 )

INSERT INTO Actor_Rate (RentalRecordID, ActorID, ActorRate)
	VALUES ( (SELECT RentalRecordID FROM Rental_Record
		WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC004')
		AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'The Conjuring')
		AND CheckoutTime = '2026-04-01'),
		(SELECT ActorID FROM Actor_Appear  
		WHERE ActorID = (SELECT ActorID from Actor WHERE Name = 'Patrick Wilson')
		AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'The Conjuring')), 
		4 )

INSERT INTO Actor_Rate (RentalRecordID, ActorID, ActorRate)
	VALUES ( (SELECT RentalRecordID FROM Rental_Record
		WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC005')
		AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Titanic')
		AND CheckoutTime = '2026-04-10'),
		(SELECT ActorID FROM Actor_Appear  
		WHERE ActorID = (SELECT ActorID from Actor WHERE Name = 'Kate Winslet')
		AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Titanic')), 
		5 )

INSERT INTO Actor_Rate (RentalRecordID, ActorID, ActorRate)
	VALUES ( (SELECT RentalRecordID FROM Rental_Record
		WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC006')
		AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Titanic')
		AND CheckoutTime = '2026-04-11'),
		(SELECT ActorID FROM Actor_Appear  
		WHERE ActorID = (SELECT ActorID from Actor WHERE Name = 'Leonardo DiCaprio')
		AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Titanic')), 
		5 )

INSERT INTO Actor_Rate (RentalRecordID, ActorID, ActorRate)
	VALUES ( (SELECT RentalRecordID FROM Rental_Record
		WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC007')
		AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'The Notebook')
		AND CheckoutTime = '2026-04-12'),
		(SELECT ActorID FROM Actor_Appear  
		WHERE ActorID = (SELECT ActorID from Actor WHERE Name = 'Ryan Gosling')
		AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'The Notebook')), 
		4 )

INSERT INTO Actor_Rate (RentalRecordID, ActorID, ActorRate)
	VALUES ( (SELECT RentalRecordID FROM Rental_Record
		WHERE CustomerID = (SELECT CustomerID FROM Customer WHERE AccountNum = 'ABC004')
		AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Toy Story')
		AND CheckoutTime = '2026-05-04'),
		(SELECT ActorID FROM Actor_Appear  
		WHERE ActorID = (SELECT ActorID from Actor WHERE Name = 'Tom Hanks')
		AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Toy Story')), 
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




