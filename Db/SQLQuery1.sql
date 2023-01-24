Create Table Students(
Id int identity primary key,
Name nvarchar(50) NOT NULL,
Surname nvarchar(50) Default ('XXX'),
Email nvarchar(250)Unique,
Age int check(Age>0)
)
insert into Students(Name, Surname,Email,Age)
Values('Nijat','Asgarov','mr.nijat.asgarov@gmail.com',27)
Select *From Students