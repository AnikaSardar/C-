/****** This SQL queries create tables and inserts data into those table ******/


/****** Create ProductCategories table ******/
CREATE TABLE ProductCategories (
	ProductCategoryID INT IDENTITY(1,1) PRIMARY KEY,
	ProductCategoryName VARCHAR(50) NOT NULL
);


/****** Create CustomerCategories table ******/
CREATE TABLE CustomerCategories (
	CustomerCategoryID INT IDENTITY(1,1) PRIMARY KEY,
	CustomerCategoryName VARCHAR(50) NOT NULL,
	DiscountRate DECIMAL(18,3) NOT NULL
);

/****** Create Admins table ******/
CREATE TABLE Admins (
    AdminID INT IDENTITY(1,1) PRIMARY KEY,
	FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Phone VARCHAR(15) NOT NULL,
    Email VARCHAR(100) NOT NULL,
);


/****** Create Admins Credentials Table ******/
CREATE TABLE AdminCredentials (
	AdminID INT NOT NULL,
	Username VARCHAR(100) NOT NULL,
    Passwords VARCHAR(100) NOT NULL
	FOREIGN KEY (AdminID) REFERENCES Admins(AdminID)
);

/****** Create Customers table ******/
CREATE TABLE Customers (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
	CustomerCategoryID INT NOT NULL, 
	AdminID INT NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Phone VARCHAR(15) NOT NULL,
    Email VARCHAR(100) NOT NULL,
	FOREIGN KEY (CustomerCategoryID) REFERENCES CustomerCategories(CustomerCategoryID),
	FOREIGN KEY (AdminID) REFERENCES Admins(AdminID)
);


/****** Create Customer Credentials Table ******/
CREATE TABLE CustomerCredentials (
	CustomerID INT NOT NULL,
	Username VARCHAR(100) NOT NULL,
    Passwords VARCHAR(100) NOT NULL,
	FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

/****** Create Products table ******/
CREATE TABLE Products (
    ProductCode CHAR(10)  PRIMARY KEY,
	ProductCategoryID INT NOT NULL, 
	ProductName VARCHAR(50) NOT NULL,
	UnitPrice MONEY NOT NULL, 
	OnHandQuantity INT NOT NULL,
	FOREIGN KEY (ProductCategoryID) REFERENCES ProductCategories(ProductCategoryID)
);


/****** Create Invoices table ******/
CREATE TABLE Invoices (
	InvoiceID INT IDENTITY(1,1) PRIMARY KEY, 
	CustomerID INT NOT NULL,
	InvoiceDate DATETIME NOT NULL,
	ProductTotal Money NOT NULL, 
	SalesTax Money NOT NULL,
	Shipping Money NOT NULL,
	InvoiceTotal Money NOT NULL,
	FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);


/****** Create InvoiceDetails table ******/
CREATE TABLE InvoiceLineItems (
	InvoiceID INT,
	ProductCode CHAR (10),
	CustomerCategoryID INT NOT NULL,
	UnitPrice MONEY NOT NULL, 
	Quantity INT NOT NULL,
	ItemTotal MONEY NOT NULL,
	PRIMARY KEY(InvoiceID, ProductCode),
	FOREIGN KEY (CustomerCategoryID) REFERENCES CustomerCategories(CustomerCategoryID),
	FOREIGN KEY (InvoiceID) REFERENCES Invoices(InvoiceID),
    FOREIGN KEY (ProductCode) REFERENCES Products(ProductCode)
);


/****** ProductCategories data ******/
INSERT INTO 
	ProductCategories (ProductCategoryName)
VALUES 
	('Men'), ('Women'), ('Kids'),('Fictional'), ('Non-Fictional'); 


/****** CustomerCategories data ******/
INSERT INTO 
	CustomerCategories (CustomerCategoryName, DiscountRate) 
VALUES 
	('Senior Citizen', 0.05), ('Student', 0.04), ('Family', 0.03),('Military', 0.035), ('First-Time Buyer', 0.045);

/****** Admins data ******/
INSERT INTO 
	Admins(FirstName, LastName, Phone, Email)
VALUES 
	('Lutonsky', 'Christopher', 7153555670, 'chrisLut@gmail.com'),
	('Nichols', 'Nadine', 8165835064, 'nicholasNadine@gmail.com'),
	('Goldman', 'Balsam', 8165835063, 'goldmanBalsam@gmail.com'),
	('Yuk', 'Young', 7156555670, 'yukYoung@gmail.com'),
	('Ruz', 'Rik', 7153575680, 'ruzRik@gmail.com');

/****** AdminsCredentials Data ******/
INSERT INTO 
	AdminCredentials(AdminID, Username, Passwords)
VALUES 
		(1, 'chrisLutonsky', 'chris123#'),
		(2, 'nadineNichols', 'nadine456@'),
		(3, 'goldBalsam', 'balsam#78'),
		(4, 'yukYoung', 'young@457'),
		(5, 'ruzRik', 'ruzRik@41!');

/****** Customers data ******/
INSERT INTO 
	Customers(FirstName, LastName,  CustomerCategoryID, Phone, Email, AdminID) 
Values 
	('Mary', 'Jane', 2, 7153334567, 'maryJane@gmail.com', 1), --admins id think
	('Larry', 'Theiss', 1, 7153334568, 'larryTheiss@gmail.com', 1),
	('Sam', 'Basala', 3, 8154334567, 'samBasala@gmail.com', 3),  
	('Lorie', 'Leiss', 5,  7153364668, 'LorieLeiss@gmail.com', 2),
	('Chris', 'Johnsen', 3, 7153434668, 'chrisJohnsen@gmail.com', 4),
	('Chris', 'Jonathan', 1, 7152334663, 'chrisJohnathan@gmail.com', 5);

/****** CustomerCredentials Data ******/
INSERT INTO 
	CustomerCredentials (CustomerID, Username, Passwords) 
VALUES 
	(1,'maryJane', 'mary123#'),
	(2, 'larryTheiss', 'Larry@456'),
	(3, 'samBasala', 'Basala#78'),
	(4, 'lorieLeiss', 'LLiss@457'),
	(5, 'chrisJohnsen', 'CJSEN@41!'),
	(6, 'chrisJonathan', 'crisJoth@n457');


/****** Products data ******/
INSERT INTO 
	Products (ProductCode, ProductName, ProductCategoryID, UnitPrice, OnHandQuantity) 
VALUES 
	('THF', 'Treasure Hunt', 4, 10.00, 2126),
	('TTF', 'Tank Top', 2, 5.00, 2136),
	('FSM', 'Formal Long Sleeved Shirts', 1, 25.00, 2146),
	('FSF', 'Formal Long Sleeved Shirts', 2, 24.00, 2146),
	('FPM', 'Formal Pants', 1, 25.00, 2146),
	('FPF', 'Formal Pants', 3, 25.00, 2146),
	('JNM', 'Skinny Jeans', 2, 45.00, 215), 
	('JNF', 'Skinny Jeans', 1, 45.00, 216);


/****** Invoices data ******/
INSERT INTO 
	Invoices (CustomerID, InvoiceDate, ProductTotal, SalesTax, Shipping, InvoiceTotal)
Values 
	(1, CAST(N'2024-04-11T00:00:00.000' AS DateTime), 15.00, 0.75, 2.25, 18.00),
	(3, CAST(N'2024-04-11T00:00:00.000' AS DateTime), 59.00, 2.95, 3.25, 65.2),
	(4, CAST(N'2024-04-11T00:00:00.000' AS DateTime), 55.00, 2.75, 3.05, 70.80),
	(5, CAST(N'2024-04-11T00:00:00.000' AS DateTime), 90.00, 2.75, 4.5, 96.80),
	(6, CAST(N'2024-04-11T00:00:00.000' AS DateTime), 90.00, 2.75, 4.5, 96.80);


/****** InvoiceDetails data ******/
INSERT INTO 
	InvoiceLineItems (InvoiceID, ProductCode, CustomerCategoryID, UnitPrice, Quantity, ItemTotal)
VALUES 
	(1, 'TTF', 2, 5.00, 3, 15.00), 
	(2, 'THF', 3, 10.00, 1, 10.00),
	(2, 'FSM', 3, 25.00, 1, 25.00), 
	(2, 'FSF', 3, 24.00, 1, 24.00),
	(3, 'TTF', 5, 5.00, 1, 5.00), 
	(3, 'FPM', 5, 25.00, 1, 25.00), 
	(3, 'FPF', 5, 25.00, 1, 25.00), 
	(4, 'JNM', 3, 45.00, 1, 45.00), 
	(4, 'JNF', 3, 45.00, 1, 45.00), 
	(5, 'JNF', 1, 45.00, 2, 90.00);


/****** Display all data from the tables ******/
SELECT * FROM Admins 
SELECT * FROM AdminCredentials
SELECT * FROM CustomerCategories
SELECT * FROM Customers
SELECT * FROM ProductCategories
SELECT * FROM Products
SELECT * FROM Invoices
SELECT * FROM InvoiceLineItems
SELECT * FROM CustomerCredentials


