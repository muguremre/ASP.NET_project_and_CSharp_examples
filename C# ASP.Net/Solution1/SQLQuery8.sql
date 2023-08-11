--Select
Select ContactName Adi, CompanyName Şirket, City Şehir from Customers

Select * from Customers where City='London'

Select * from Customers where City='London' or City='Berlin'

select * from Products where CategoryID =1 or CategoryID=2

select * from Products where  categoryID = 1 and UnitPrice >10

select *from Products order by CategoryID, ProductName

select *from Products order by UnitPrice desc

Select COUNT(*) ADET from Products where CategoryID = 1

select CategoryId, COUNT(*) from products group by CategoryId