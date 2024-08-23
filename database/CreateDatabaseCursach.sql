create database Cетьћагазинов—антехники
GO
use Cетьћагазинов—антехники

create table Categories(
	IDCategorie int identity (1,1) primary key,
	nameCategories varchar(255)
)

create table Stores(
	IDStore int identity (1,1) primary key,
	adressStore varchar(255)
)

create table Products(
	IDProduct int identity (1,1) primary key,
	nameProduct varchar(255) unique,
	priceProduct money,
	purchasePriceProduct money not null,
	AmountInStocksProduct int not null,
	ImagePath nvarchar(255),
	IDCategories int foreign key references Categories(IDCategorie)
)

create table ProductsInStores(
	IDPIS int identity (1,1) primary key,
	IDProductsPIS int foreign key references Products(IDProduct) ON DELETE CASCADE,
	IDStorePIS int foreign key references Stores(IDStore),
	AmountPIS int not null
)

create table Provider(
	IDProvider int identity (1,1) primary key,
	nameProvider varchar(255) not null,
	contactDetailsProvider varchar(255) not null,
	phoneProvider varchar(11) not null,
)

create table Supplies(
	IDSupplie int identity (1,1) primary key,
	IDProviderSupplie int foreign key references Provider(IDProvider) ON DELETE CASCADE,
	dateAndTimeSupplie datetime default getdate(),
	priceSupplie money
)

create table ProductsInSupplies(
	IDPISupplies int identity (1,1) primary key,
	IDProductPISupplies int foreign key references Products(IDProduct) ON DELETE CASCADE,
	IDSuppliesPISupplies int foreign key references Supplies(IDSupplie) ON DELETE CASCADE,
	amountPISupplies int not null
)

create table JobTitle(
	IDJT int identity (1,1) primary key,
	nameJT varchar(255) not null,
	loginJT nvarchar(255) not null, 
	passwordJT nvarchar(255) not null
)

create table Employees(
	IDEmployee int identity (1,1) primary key,
	nameEmployee varchar(255) not null,
	phoneEmployee varchar(11) not null,
	adressEmployee varchar(255) not null,
	experienceEmployee int not null,
	IDStoreEmployee int foreign key references Stores(IDStore),
	IDCategoriesEmployee int foreign key references Categories(IDCategorie),
	IDJobTitleEmployee int foreign key references JobTitle(IDJT) default 2
)

create table PaintingColors(
	IDPC int identity (1,1) primary key,
	namePC varchar(255) not null,
	pricePC money
)

create table Checks(
	IDCheck int identity (1,1) primary key,
	priceCheck money,
	dateAndTimeCheck datetime default getdate(),
	IDEmployeeCheck int foreign key references Employees(IDEmployee) ON DELETE CASCADE
)

create table ProductsInCheck(
	IDPIC int identity (1,1) primary key,
	IDCheckPIC int foreign key references Checks(IDCheck),
	IDProductPIC int foreign key references Products(IDProduct) ON DELETE CASCADE,
	IDPaintingColorPIC int foreign key references PaintingColors(IDPC),
	pricePIC money
)



SELECT @@VERSION