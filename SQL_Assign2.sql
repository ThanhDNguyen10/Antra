--1. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the following.
select c.Name Country, s.Name Province from Person.StateProvince s JOIN Person.CountryRegion c ON s.CountryRegionCode = c.CountryRegionCode
--2. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada.
select c.Name Country, s.Name Province from Person.StateProvince s JOIN Person.CountryRegion c ON s.CountryRegionCode = c.CountryRegionCode where c.Name in ('Germany','Canada')
--3. List all Products that has been sold at least once in last 25 years.
select DISTINCT p.ProductID, p.ProductName from Products p JOIN [Order Details] od ON p.ProductID = od.ProductID JOIN Orders o ON o.OrderID = od.OrderID where OrderDate > '1997-05-18' order by p.ProductID
--4. List top 5 locations (Zip Code) where the products sold most in last 25 years.
select top 5 o.ShipPostalCode, count(o.ShipPostalCode) NumZipCount from Products p JOIN [Order Details] od ON p.ProductID = od.ProductID JOIN Orders o ON o.OrderID = od.OrderID where o.OrderDate > '1997-05-18' group by o.ShipPostalCode order by NumZipCount desc

--5. List all city names and number of customers in that city.    
select City, Count(City) NumOfCusts from Customers group by City
--6. List city names which have more than 2 customers, and number of customers in that city
select City, Count(City) NumOfCusts from Customers group by City having count(City) >2
--7. Display the names of all customers  along with the  count of products they bought
select c.ContactName, count(od.Quantity) ProdCount from Customers c JOIN Orders o on c.CustomerID=o.CustomerID JOIN [Order Details] od ON od.OrderID = o.OrderID group by c.ContactName
select c.ContactName, sum(od.Quantity) ProdCount from Customers c JOIN Orders o on c.CustomerID=o.CustomerID JOIN [Order Details] od ON od.OrderID = o.OrderID group by c.ContactName
--8. Display the customer ids who bought more than 100 Products with count of products
select c.CustomerID, sum(od.Quantity) ProdCount from Customers c JOIN Orders o on c.CustomerID=o.CustomerID JOIN [Order Details] od ON od.OrderID = o.OrderID group by c.CustomerID having sum(Quantity) >100
--9. List all of the possible ways that suppliers can ship their products. Display the results as below   Supplier Company Name           Shipping Company Name
select DISTINCT su.CompanyName [Supplier Company Name], sh.CompanyName [Shipping Company Name] from Suppliers su JOIN Products p ON su.SupplierID = p.SupplierID 
JOIN [Order Details] od on p.ProductID = od.ProductID JOIN Orders o ON o.OrderID = od.OrderID JOIN Shippers sh ON sh.ShipperID = o.ShipVia 
order by [Supplier Company Name] 
--10. Display the products order each day. Show Order date and Product Name
select OrderDate, ProductName from Products p JOIN [Order Details] od ON p.ProductID = od.ProductID JOIN Orders o ON o.OrderID = od.OrderID 
--11. Displays pairs of employees who have the same job title.
select FirstName, LastName, Title from Employees Where Title in (Select Title from Employees group by Title Having count(Title)>=2)
--12. Display all the Managers who have more than 2 employees reporting to them.
select count(e.ReportsTo) NumReportTo, m.FirstName as ManagerName FROM Employees e INNER JOIN Employees m ON e.ReportsTo = m.EmployeeID
GROUP BY m.FirstName
HAVING COUNT(e.ReportsTo) > 1
--13. Display the customers and suppliers by city. The results should have the following columns City Name Contact Name,Type (Customer or Supplier)
select c.ContactName, c.CompanyName, c.City, c.Relationship from [Customer and Suppliers by City] c order by c.City

--14. List all cities that have both Employees and Customers.
select DISTINCT City from Employees where City IN (select City from Customers)
--15. List all cities that have Customers but no Employee.
    --Use subquery
select DISTINCT City from Customers where City  NOT IN (select City from Employees)
	--No subquery
select DIstinct c.City from Customers c, Employees e Where c.City != e.City

--16. List all products and their total order quantities throughout all orders.
select p.ProductName, SUM(od.Quantity) TotalQuantity from [Order Details] od JOIN Products p ON p.ProductID = od.ProductID group by ProductName order by ProductName 
--17. List all Customer Cities that have at least two customers.
	--Use UNION
select city from Customers a group by city having count(city)>=2 UNION select City from Customers b group by city having count(city)>=2
--select City from Customers UNION select  from 
	--Use subquery no union
select DISTINCT City from Customers where City IN (select City from Customers group by City having count(City)>=2)
--18. List all Customer Cities that have ordered at least two different kinds of products.
select c.City, od.OrderID, count(ProductID) NumProd from Customers c left join Orders o on o.CustomerID = c.CustomerID left join [Order Details] od on od.OrderID = o.OrderID group by c.City, od.OrderID having od.OrderID 
is not null and count(ProductID) >1 order by c.City
select c.City, count(ProductID) NumProd from Customers c left join Orders o on o.CustomerID = c.CustomerID left join [Order Details] od on od.OrderID = o.OrderID 
group by c.City having count(ProductID) >1 order by c.City
--19. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
select top 5 p.ProductName, avg(p.UnitPrice) AvgPrice, c.City, od.Quantity from Products p JOIN [Order Details] od on p.ProductID = od.ProductID JOIN Orders o on o.OrderID = od.OrderID JOIN Customers c
on c.CustomerID = o.CUstomerID group by p.ProductName, c.City, od.Quantity having od.Quantity >100
select top 5 p.ProductName, avg(p.UnitPrice) AvgPrice, c.City, SUM(od.Quantity) MostQuantity from Products p JOIN [Order Details] od on p.ProductID = od.ProductID JOIN Orders o on o.OrderID = od.OrderID JOIN Customers c
on c.CustomerID = o.CUstomerID group by p.ProductName, c.City
--20. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)
select top 1 ShipCity,c.City, MAX(od.Quantity) MostQuantity from Orders o JOIN [Order Details] od on o.OrderID = od.OrderID JOIN Customers c on c.CustomerID = o.CustomerID where exists
(select ShipCity,count(ShipCity) from Orders group by ShipCity) group by Shipcity, c.City

select top 1 ShipCity,c.City 
FROM (select top 1 ShipCity,c.City, sum(od.Quantity) TotalQuantity from Orders o JOIN [Order Details] od on o.OrderID = od.OrderID JOIN Customers c on c.CustomerID = o.CustomerID group by ShipCity, c.city) c
where exists (select top 1 ShipCity,c.City, max(ShipCity) MCity from Orders o JOIN [Order Details] od on o.OrderID = od.OrderID JOIN Customers c on c.CustomerID = o.CustomerID group by ShipCity, c.city)

--21. How do you remove the duplicates record of a table?
--Delete from Employees Where conditions
