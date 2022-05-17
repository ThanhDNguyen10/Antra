USE AdventureWorks2019
GO

SELECT ProductID, Name, Color, ListPrice from Production.Product

SELECT ProductID, Name, Color, ListPrice from Production.Product where ListPrice != 0

select ProductID, Name, Color, ListPrice from Production.Product where Color is not null

select ProductID, Name, Color, ListPrice from Production.Product where Color is not null and ListPrice > 0

select Name +' '+ Color from Production.Product where Color is not null

--6 
select 'NAME: '+Name+' -- '+  Color from Production.Product where Color IN ('Black','Silver') and Name LIKE '%Crankarm%' or Name LIKE '%Chainring%'

select ProductID, Name from Production.Product where ProductID between 400 and 500

select ProductID, Name, Color from Production.Product where Color IN ('Black','Blue')

--9
select * from Production.Product where Name LIKE 'S%'

--10
select Name, ListPrice from Production.Product where Name LIKE 'A%' OR Name LIKE 'S%' order by Name

select * from Production.Product where Name LIKE 'SPO[^K]%' order by Name

--12
select ProductSubcategoryID, Color from Production.Product where ProductSubcategoryID is not null and Color is not null
--12 With IsNull()
select isnull(ProductSubcategoryID,0) ProductCategoryID,isnull(Color,'Blank') from Production.Product
