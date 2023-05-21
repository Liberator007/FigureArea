USE StudyDB;

-- Диграмаа БД представлена на рисунке "Диаграмма базы данных"
-- Имеется две таблицы - Product и Category
-- Так как необходимо реализовать связь многие-ко-многим, была создана 3-ья таблица ProductsByCategory

SELECT P.[Name] As 'Product', C.[Name] AS 'Category'
FROM Product AS P 
LEFT JOIN ProductsByCategory AS PC 
	ON PC.ProductId = P.Id
LEFT JOIN Category AS C
	ON PC.CategoryId = C.Id