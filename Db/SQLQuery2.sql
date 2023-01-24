create table Positions(
id int identity primary key,
duty nvarchar(250),
DependOn int
)
select p1.duty,p2.duty 'Depend On' From Positions p1
Left Join
Positions p2
ON
p1.DependOn=p2.id

--Cross Join
Create Table Product(
id int identity primary key,
 Name nvarchar(250) Not Null,
)
Create Table Sizes(
id int identity primary key,
 size nvarchar(10) Not Null,
)
Select Name, size From Product
cross join
Sizes