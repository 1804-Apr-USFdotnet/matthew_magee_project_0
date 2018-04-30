
CREATE DATABASE CodingChallenge2;
GO
USE CodingChallenge2;
GO
CREATE TABLE CodingChallenge2.dbo.Products
    (
      ID int NOT NULL PRIMARY KEY,
	  Name VARCHAR(100),
	  Price FLOAT
    );

CREATE TABLE CodingChallenge2.dbo.Customers
    (
      ID INT NOT NULL PRIMARY KEY,
	  Firstname VARCHAR(100),
	  Lastname VARCHAR(100),
	  CardNumber VARCHAR(100)
    );

CREATE TABLE CodingChallenge2.dbo.Orders
    (
      ID INT,
	  ProductID int FOREIGN KEY REFERENCES dbo.Products(ID),
	  CustomerID int FOREIGN KEY REFERENCES dbo.Customers(ID)
    );


INSERT INTO dbo.Products (ID, Name, Price)
VALUES (1,'Muffler', 45.99);
INSERT INTO dbo.Products (ID, Name, Price)
VALUES (2,'Shock', 34.99);
INSERT INTO dbo.Products (ID, Name, Price)
VALUES (3,'Steering Wheel', 99.99);

INSERT INTO dbo.Customers (ID, Firstname, Lastname, CardNumber)
VALUES (1,'John','Smith', '123456789');
INSERT INTO dbo.Customers (ID, Firstname, Lastname, CardNumber)
VALUES (2,'Janet','Magee', '123536789');
INSERT INTO dbo.Customers (ID, Firstname, Lastname, CardNumber)
VALUES (3,'Jacob','Mupmphrey', '847564746');

INSERT INTO dbo.Orders (ID, ProductID, CustomerID)
VALUES(1, 2, 3)
INSERT INTO dbo.Orders (ID, ProductID, CustomerID)
VALUES(2, 2, 1)
INSERT INTO dbo.Orders (ID, ProductID, CustomerID)
VALUES(3, 2, 1)

INSERT INTO dbo.Products (ID, Name, Price)
VALUES (4,'iPhone', 200.00);

INSERT INTO dbo.Customers (ID, Firstname, Lastname, CardNumber)
VALUES (4,'Tina','Smith', '463746573');

INSERT INTO dbo.Orders (ID, ProductID, CustomerID)
VALUES(4, 4, 4)

INSERT INTO dbo.Orders (ID, ProductID, CustomerID)
VALUES(4, 4, 4)

SELECT Firstname, Lastname, CustomerID FROM Orders
Left Join dbo.Customers	
ON Customers.ID = Orders.CustomerID
WHERE Firstname = 'Tina';

 SELECT Name, SUM(Price) AS 'TotalSales' FROM Products
 Inner Join Orders
 ON ProductID = Products.ID
 WHERE Name = 'iPhone'
 GROUP BY ProductID, Name;

UPDATE Products
SET Price = 250.00
WHERE Name = 'iPhone';

