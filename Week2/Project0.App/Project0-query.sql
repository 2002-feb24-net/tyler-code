CREATE TABLE Customer_Order (
    Order_ID INT NOT NULL PRIMARY KEY identity,
	Product VARCHAR(30),
	Price DECIMAL,
	Quanity INT,
);

ALTER TABLE Customer_order
	ADD Customer_Name VARCHAR(40)

SELECT * FROM Customer_Order

ALTER TABLE Customer
DROP COLUMN Customer_Order

CREATE TABLE Product (
	Product_ID INT NOT NULL PRIMARY KEY IDENTITY,
	NAME VARCHAR(30),
);



SELECT * FROM Product

CREATE TABLE Products_Choices(
	Product_ID INT NOT NULL PRIMARY KEY IDENTITY,
	Product VARCHAR(20),
	Price DECIMAL,
);

CREATE TABLE Store (
    Store_ID INT NOT NULL PRIMARY KEY identity,
	Store_Name VARCHAR(20),
	Street VARCHAR(30),
	City VARCHAR(20),
	State VARCHAR(15),
	Zip INT,
);

SELECT * FROM Customer_Order