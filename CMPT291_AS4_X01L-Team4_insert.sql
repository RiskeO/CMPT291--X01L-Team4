delete Rate_Actor;
delete Queue_Up;
delete Orders;
delete Appeared_In;
delete Actor;
delete Movie;
delete Customer_Phone;
delete Customer;
delete Employee_Phone;
delete Employee;

ALTER SEQUENCE Employee_Employee_ID_Seq RESTART WITH 1000;
ALTER SEQUENCE Customer_Customer_ID_Seq RESTART WITH 1000;
ALTER SEQUENCE Movie_Movie_ID_Seq RESTART WITH 1000;
ALTER SEQUENCE Orders_Order_ID_Seq RESTART WITH 1000;
DBCC CHECKIDENT ('Actor', RESEED, 0);

/* Employee */
insert into Employee (Employee_ID, SSN, Last_Name, First_Name, Address_Name, City, State_Name, Zip_Code)
values (next value for Employee_Employee_ID_Seq, '123456789', 'Johnson', 'Emily', '789 Oak St', 'Edmonton', 'Alberta', '54321');

insert into Employee (Employee_ID, SSN, Last_Name, First_Name, Address_Name, City, State_Name, Zip_Code)
values (next value for Employee_Employee_ID_Seq, '987654321', 'Williams', 'Michael', '321 Pine St', 'Calgary', 'Alberta', '98765');

/* Employee Phone */
insert into Employee_Phone (Employee_ID, Phone_Num, Phone_Type, Start_Time, End_Time)
values (1000, '7801234567', 'Mobile', default, NULL);

insert into Employee_Phone (Employee_ID, Phone_Num, Phone_Type, Start_Time, End_Time)
values (1000, '7807654321', 'Home', default, NULL);

/* Customer */
insert into Customer (Customer_ID, Last_Name, First_Name, Address_Name, City, State_Name, Zip_Code, Email_Address, Account_Number, Credit_Card_Number)
values (next value for Customer_Customer_ID_Seq, 'Smith', 'John', '123 Main St', 'Edmonton', 'Alberta', '12345', 'unknown@email.com', 'ACCT000001', '1111222233334444');

insert into Customer (Customer_ID, Last_Name, First_Name, Address_Name, City, State_Name, Zip_Code, Email_Address, Account_Number, Credit_Card_Number)
values (next value for Customer_Customer_ID_Seq, 'Doe', 'Jane', '456 Elm St', 'Calgary', 'Alberta', '67890', 'JaneD@email.com', 'ACCT000002', '5555666677778888');

/* Customer Phone */
insert into Customer_Phone values (1000, '7801112222', 'Mobile');
insert into Customer_Phone values (1001, '7803334444', 'Home');

/* Movie */
insert into Movie (Movie_ID, Movie_Name, Movie_Type, Fee, Copy_Num, Copy_Rented, Movie_Rating)
values (next value for Movie_Movie_ID_Seq, 'The Shawshank Redemption', 'Drama', 3.99, 5, 1, 5);

insert into Movie (Movie_ID, Movie_Name, Movie_Type, Fee, Copy_Num, Copy_Rented, Movie_Rating)
values (next value for Movie_Movie_ID_Seq, 'The Godfather', 'Drama', 4.99, 4, 2, 5);

insert into Movie (Movie_ID, Movie_Name, Movie_Type, Fee, Copy_Num, Copy_Rented, Movie_Rating)
values (next value for Movie_Movie_ID_Seq, 'The Dark Knight', 'Action', 4.49, 6, 3, 5);

/* Actor */
insert into Actor (Last_Name, First_Name, Gender, Date_Of_Birth) values ('Freeman', 'Morgan', 'Male', '1937-06-01');
insert into Actor (Last_Name, First_Name, Gender, Date_Of_Birth) values ('Brando', 'Marlon', 'Male', '1924-04-03');
insert into Actor (Last_Name, First_Name, Gender, Date_Of_Birth) values ('Stone', 'Emma', 'Female', '1974-01-30');

/* Appeared In */
insert into Appeared_In values (1, 1000);
insert into Appeared_In values (2, 1000);
insert into Appeared_In values (3, 1001);
insert into Appeared_In values (3, 1002);

/* Orders */
insert into Orders (Order_ID, Customer_ID, Employee_ID, Movie_ID, Checkout_Date, Return_Date, Movie_Rating)
values (next value for Orders_Order_ID_Seq, 1000, 1000, 1000, '2024-01-03 11:00:00', '2024-01-05 11:00:00', 5);

insert into Orders (Order_ID, Customer_ID, Employee_ID, Movie_ID, Checkout_Date, Return_Date, Movie_Rating)
values (next value for Orders_Order_ID_Seq, 1001, 1001, 1001, '2024-01-04 12:00:00', NULL, NULL);

/* Queue Up */
insert into Queue_Up (Customer_ID, Movie_ID) values (1000, 1002);
insert into Queue_Up (Customer_ID, Movie_ID) values (1001, 1000);

/* Rate Actor */
insert into Rate_Actor values (1, 1000, 5);
insert into Rate_Actor values (1, 1001, 4);

select * from Actor;