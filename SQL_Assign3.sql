--1. Create a view named “view_product_order_[your_last_name]”, list all products and total ordered quantity for that product.
create view view_product_order_nguyen as select ProductName, Sum(Quantity) TotalQuantity from Products p JOIn [Order Details] od ON p.ProductID = od.ProductID group by ProductName
select*from view_product_order_nguyen
--2. Create a stored procedure “sp_product_order_quantity_[your_last_name]” that accept product id as an input and total quantities of order as output parameter.
create proc sp_product_order_quantity_nguyen @prodID int, @total int out 
as 
begin select @total = sum(Quantity) from [Order Details] where ProductID = @prodID end

begin 
declare @total int 
exec sp_product_order_quantity_nguyen 11, @total out 
print @total end

DROP PROCEDURE sp_product_order_city_nguyen; 
--3. Create a stored procedure “sp_product_order_city_[your_last_name]” that accept product name as an input and top 5 cities that ordered most that product combined with the total quantity of that product ordered from that city as output.
create proc sp_product_order_city_nguyen @ProductName nvarchar(40), @CityTotalOrdered nvarchar(40) out
as
begin select top 5 o.ShipCity, p.ProductID, sum(Quantity) TotalOrdered from Orders o JOIN [Order Details] od on o.OrderID = od.OrderID JOIN Products p on p.ProductID = od.ProductID 
where ProductName = @ProductName group by o.ShipCity, p.ProductID group by sum(Quantity) DESC
end

begin 
declare @CityTotleOrdered nvarchar(40) 
exec sp_product_order_city_nguyen 'Chai', @CityTotleOrdered out 
print @CityTotleOrdered end

--4. Create 2 new tables “people_your_last_name” “city_your_last_name”. City table has two records: {Id:1, City: Seattle}, {Id:2, City: Green Bay}.
--People has three records: {id:1, Name: Aaron Rodgers, City: 2}, {id:2, Name: Russell Wilson, City:1}, {Id: 3, Name: Jody Nelson, City:2}. 
--Remove city of Seattle. If there was anyone from Seattle, put them into a new city “Madison”. 
--Create a view “Packers_your_name” lists all people from Green Bay. If any error occurred, no changes should be made to DB. (after test) Drop both tables and view.
create table people_nguyen (id int primary key, name nvarchar(40), cityid int FOREIGN KEY REFERENCES city_nguyen(id))
create table city_nguyen (id int primary key, city nvarchar(40))

insert into people_nguyen values (1,'Aaron Rodgers',2)
insert into people_nguyen values (2,'Russell Wilson',1)
insert into people_nguyen values (3,'Jody Nelson',2)

insert into city_nguyen values (1,'Seattle')
insert into city_nguyen values (2,'Green Bay')

Update city_nguyen set city = 'Madison' where city ='Seattle'

create view Packers_nguyen as select name from people_nguyen p join city_nguyen c on c.id = p.cityid where city = 'Green Bay'
select*from Packers_nguyen

select*from city_nguyen

drop table people_nguyen
drop table city_nguyen
drop view Packers_nguyen

--5. Create a stored procedure “sp_birthday_employees_[you_last_name]” that creates a new table “birthday_employees_your_last_name” and fill it with all employees that have a birthday on Feb. 
--(Make a screen shot) drop the table. Employee table should not be affected.
create proc sp_birthday_employees_nguyen as
begin
create table birthday_employees_nguyen (id int primary key not null, name nvarchar(40), dob date)
insert into birthday_employees_nguyen values (1, 'Jason', '2000-02-01')
insert into birthday_employees_nguyen values (2, 'Mary', '1990-02-05')
insert into birthday_employees_nguyen values (3, 'Peter', '1980-02-11')
end

drop table birthday_employees_nguyen
--6. How do you make sure two tables have the same data?
--Use UNION, if the output rows number is the same with the orginal tables then they have the same data
