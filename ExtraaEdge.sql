create table Brand(BId int primary key identity(1,1),BName varchar(25),Description varchar(20))

create table Mobile(Id  int primary key identity(1,1),BId int,Model varchar(50),Description varchar(300),
Price decimal(10,2)constraint fkmobilebrandid foreign key(BId) references Brand(BId));

create table Customer(CustId int primary key identity(1,1),CustName varchar(30),Email varchar(80),PhoneNo varchar(10), Address varchar(150));

create table Purchase(PId int primary key identity(1,1),CustId int,Id int,PurchaseDate date,PurPrice decimal(10,2),Discount decimal(10,2),
FinalPrice decimal(10,2),
constraint fkpurchasecustid foreign key(CustId) references Customer(CustId),
constraint fkpurchasemobileid foreign key(Id) references Mobile(Id) )

insert into Brand values('Apple','Android smart phone')
insert into Brand values('Redmi','Android smart phone')

select * from Brand
