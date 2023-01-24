Create Table Employee(
id int identity primary key,
name nvarchar(50) Not Null,
Surname nvarchar(50) Not Null,
Age int,
)
--union burada her iki datani birlesdirdik ama eyni olan datalari 1 defe gosteririk id qeyd etmirik buna gore
Select name, surname,Age From Employee
Union
Select name, surname,Age From OldEmployee
--Except right terefdeki left terefde eyni olmayan datani saxlayir.
Select name, surname,Age From Employee
Except
Select name, surname,Age From OldEmployee
--intersect her iki terefde eyni olan datalari saxlayir, id qeyd etmedik cunki id qeyd etsek eyni olmur.
Select name, surname,Age From Employee
intersect
Select name, surname,Age From OldEmployee
--Count, Group by bir table deki yaslarin, ballarin ve s necedene eyni olanini sayir.
Select Count(Age)'Age',Age From Employee
Group by
Age
--sonra buna group by-a Having keywordu ile sert yaziriq
Select Count(Age)'Age',Age From Employee
Group by
Age
Having
Count(Age)>1 

