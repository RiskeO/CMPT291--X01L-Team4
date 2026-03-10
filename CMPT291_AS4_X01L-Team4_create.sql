DROP TABLE [Movie]
GO
create Table Movie(
	MovieID int IDENTITY(1,1) Primary Key,
	MovieName varchar(255) not null,
	Fee decimal(10,2) not null,
	CopyNum int not null ,
	CopyRented int not null default 0,
	Rating decimal(3,2) not null,
	Available as (CopyNum - CopyRented) Persisted,
	Constraint  chk_Rating check (Rating >= 0 and Rating <= 10),
	Constraint  chk_Copy check (CopyNum >= 0 and CopyRented >= 0 and CopyRented <= CopyNum),
	Constraint  chk_Fee check (Fee >= 0)
)
