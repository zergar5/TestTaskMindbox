USE TestTaskMindbox;

CREATE TABLE Products
(
    Id INT PRIMARY KEY IDENTITY,
    ProductName NVARCHAR(20) NOT NULL UNIQUE,
)

CREATE TABLE Categories
(
    Id INT PRIMARY KEY IDENTITY,
    CategoryName NVARCHAR(20) NOT NULL UNIQUE,
)

CREATE TABLE ProductsCategories
(
    ProductId INT REFERENCES Products (Id),
	CategoryId INT REFERENCES Categories (Id)
	UNIQUE(ProductId, CategoryId)
)

INSERT INTO Products 
VALUES 
('Product1'),
('Product2'),
('Product3'),
('Product4')

INSERT INTO Categories
VALUES 
('Category1'),
('Category2'),
('Category3')

INSERT INTO ProductsCategories
VALUES 
(1, 1),
(2, 1),
(2, 2),
(3, 3)