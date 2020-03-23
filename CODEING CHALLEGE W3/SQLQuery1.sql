
CREATE TABLE Customer (
ID INT NOT NULL UNIQUE IDENTITY,
Firstname VARCHAR(15),
Lastname VARCHAR(20),
CardNumber INT
);


Create TABLE Products(
ID INT NOT NULL UNIQUE IDENTITY,
Name VARCHAR(75),
Price MONEY
);

CREATE TABLE Orders(
ID INT NOT NULL UNIQUE IDENTITY,
ProductID INT,
CustomerID INT,

FOREIGN KEY (ProductID) REFERENCES Products(ID),

FOREIGN KEY (CustomerID) REFERENCES Customer(ID)
);

--1
INSERT INTO Customer
VALUES('Tyler', 'Claypool', 12345789874);
INSERT INTO Customer
VALUES('Tristan', 'Claypool', 5487976431);
INSERT INTO Customer
VALUES('Lisa', 'Heshimer', 121345646488);


INSERT INTO Orders
	VALUES(100, 1);
INSERT INTO Orders
	VALUES(200, 2);
INSERT INTO Orders
	VALUES(300, 3);

INSERT INTO Products
	VALUES ('French Fries', 3.99);
INSERT INTO Products
	VALUES ('10 pc Chicken Nuggets', 3.99);
INSERT INTO Products
	VALUES ('Bottle of Water', 3.99);

--2
INSERT INTO Products
	VALUES ('iPhone', 200.00);

--32
INSERT INTO Customer
VALUES('Tina', 'Smith', 23892772928);

--4
INSERT INTO Orders
	VALUES(400, 4);

--5
SELECT * FROM Orders
	WHERE Orders.CustomerID = 4

--6
SELECT * FROM Orders
WHERE Orders.ProductID = 4;

--7
UPDATE Products
SET
	Price = 250.00
WHERE
	Products.ID = 4;