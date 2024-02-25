USE TestTaskMindbox;

SELECT ProductName, CategoryName FROM ProductsCategories
RIGHT JOIN Products ON Products.Id = ProductsCategories.ProductId
LEFT JOIN Categories ON Categories.Id = ProductsCategories.CategoryId