use explore;
drop table Branch;

CREATE TABLE Branch (
	BID nchar(4) primary key,
	Address_1 nchar(50),
	Adress_2 nchar(50) NULL,
	City nchar(20),
	Province nchar(2),
	Postal_code nchar(6)
);