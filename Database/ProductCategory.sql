USE StudyDB;

-- �������� �� ������������ �� ������� "��������� ���� ������"
-- ������� ��� ������� - Product � Category
-- ��� ��� ���������� ����������� ����� ������-��-������, ���� ������� 3-�� ������� ProductsByCategory

SELECT P.[Name] As 'Product', C.[Name] AS 'Category'
FROM Product AS P 
LEFT JOIN ProductsByCategory AS PC 
	ON PC.ProductId = P.Id
LEFT JOIN Category AS C
	ON PC.CategoryId = C.Id