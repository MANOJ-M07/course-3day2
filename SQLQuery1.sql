use ProductsDb
create table Product
(id int primary key identity,
Name nvarchar(50) not null,
Price float not null)

insert into Product values ('e-notebook',55000)
insert into Product values ('mobile-1',55000)
insert into Product values ('earpods',3000)

select * from Product