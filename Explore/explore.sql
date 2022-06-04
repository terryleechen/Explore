use explore;
drop table Branch_Phone;
drop table Branch;


CREATE TABLE Branch (
	BID NCHAR(4) PRIMARY KEY,
	Address_1 NCHAR(50),
	Address_2 NCHAR(50) NULL,
	City NCHAR(20),
	Province NCHAR(2),
	Postal_code NCHAR(6)
);

CREATE TABLE Branch_Phone (
	BID NCHAR(4) FOREIGN KEY REFERENCES Branch(BID),
	Phone NCHAR(10) PRIMARY KEY
);

CREATE TABLE Type (
	Type_ID NCHAR(2) PRIMARY KEY,
	Type_Name NCHAR(20),
	Price_Per_Day NUMERIC(5,0),
	Price_Per_Week NUMERIC(5,0),
	Price_Per_Month NUMERIC(5,0),
	Change_Branch_Fee NUMERIC(5,0),
	Late_Fee NUMERIC(5,0)
);


CREATE TABLE Car (
	Car_ID NCHAR(7) PRIMARY KEY,
	BID NCHAR(4) FOREIGN KEY REFERENCES Branch(BID),
	Type_ID NCHAR(2) FOREIGN KEY REFERENCES Type(Type_ID),
	Year NUMERIC(4),
	Brand NCHAR(10),
	Model NCHAR(10),
	Mileage NUMERIC(7)
);

CREATE TABLE Customer (
	CID NCHAR(7) PRIMARY KEY,
	First_Name NCHAR(20),
	Last_Name NCHAR(20),
	Gender NCHAR(1),
	DOB NUMERIC(8,0),
	Membership NUMERIC(1),
	Address_1 NCHAR(50),
	Address_2 NCHAR(50) NULL,
	City NCHAR(20),
	Province NCHAR(2),
	Postal_code NCHAR(6),
	Email NCHAR(50),
	Preferred_Branch NCHAR(4) FOREIGN KEY REFERENCES Branch(BID) NULL,
);
