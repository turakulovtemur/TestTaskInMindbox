create table Product
(
	Id int primary key not null,
	Name nvarchar(30) not null
)

create table Category
(
	Id int primary key not null,
	Name nvarchar(30) not null
)

create table ProductCategory
(
	Id int not null,
	ProductId int foreign key references  dbo.Product(Id) ,
	CategoryId int foreign key references dbo.Category(Id),
	primary key(ProductId,CategoryId)
)

Insert into dbo.Product
values(1, 'sugar'),
(2, 'apple'),
(3, 'rice peeled'),
(4, 'brown rice');

Insert into dbo.Category("Id","Name")
values(1, 'sugar'),
(2, 'red apple'),
(3, 'green apple'),
(4, 'rice');

Insert into dbo.ProductCategory
values(1,1, 1),
(2,2, 2),
(3,2, 3),
(4,3, 4),
(5,4, 4);


select p.Name as ProductName, c.Name as CategoryName 
from Product as p
left join ProductCategory as pc on pc.ProductId=p.Id
left join Category as c on pc.categoryId=c.Id