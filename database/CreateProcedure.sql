Use Cетьћагазинов—антехники 
go

create procedure ViewProductsOnCategories(@IDCategories int, @IDStores int,@Search varchar(255),@sort varchar(50))
as

begin 
	if(@IDCategories != 11 and @IDStores != 11 and @sort = 1)
		begin
		select Products.nameProduct, Products.priceProduct, Products.AmountInStocksProduct, Products.ImagePath
		from ProductsInStores
		join Products on ProductsInStores.IDProductsPIS = Products.IDProduct
		join Categories on Categories.IDCategorie = Products.IDCategories
		where IDCategorie = @IDCategories and ProductsInStores.IDStorePIS = @IDStores and Products.nameProduct like '%' + @Search + '%'
		order by Products.priceProduct asc
		end
	else if(@IDCategories != 11 and @IDStores != 11 and @sort = 2)
		begin
		select Products.nameProduct, Products.priceProduct, Products.AmountInStocksProduct, Products.ImagePath
		from ProductsInStores
		join Products on ProductsInStores.IDProductsPIS = Products.IDProduct
		join Categories on Categories.IDCategorie = Products.IDCategories
		where IDCategorie = @IDCategories and ProductsInStores.IDStorePIS = @IDStores and Products.nameProduct like '%' + @Search + '%'
		order by Products.priceProduct desc
		end
	else if(@IDCategories != 11 and @IDStores != 11 and @sort = 3)
		begin
		select Products.nameProduct, Products.priceProduct, Products.AmountInStocksProduct, Products.ImagePath
		from ProductsInStores
		join Products on ProductsInStores.IDProductsPIS = Products.IDProduct
		join Categories on Categories.IDCategorie = Products.IDCategories
		where IDCategorie = @IDCategories and ProductsInStores.IDStorePIS = @IDStores and Products.nameProduct like '%' + @Search + '%'
		end
	else if(@IDCategories!=11 and @sort = 1)
		begin
		begin
		select Products.nameProduct, Products.priceProduct, Products.AmountInStocksProduct, Products.ImagePath
		from ProductsInStores
		join Products on ProductsInStores.IDProductsPIS = Products.IDProduct
		join Categories on Categories.IDCategorie = Products.IDCategories
		where IDCategorie = @IDCategories and Products.nameProduct like '%' + @Search + '%'
		order by Products.priceProduct asc
		end
		end
	else if(@IDCategories!=11 and @sort = 2)
		begin
		select Products.nameProduct, Products.priceProduct, Products.AmountInStocksProduct, Products.ImagePath
		from ProductsInStores
		join Products on ProductsInStores.IDProductsPIS = Products.IDProduct
		join Categories on Categories.IDCategorie = Products.IDCategories
		where IDCategorie = @IDCategories and Products.nameProduct like '%' + @Search + '%'
		order by Products.priceProduct desc
		end
	else if(@IDStores!=11 and @sort = 1)
		begin
		select Products.nameProduct, Products.priceProduct, Products.AmountInStocksProduct, Products.ImagePath
		from ProductsInStores
		join Products on ProductsInStores.IDProductsPIS = Products.IDProduct
		join Categories on Categories.IDCategorie = Products.IDCategories
		where ProductsInStores.IDStorePIS = @IDStores and Products.nameProduct like '%' + @Search + '%'
		order by Products.priceProduct asc
		end
	else if(@IDCategories!=11 and @sort = 3)
		begin
		select Products.nameProduct, Products.priceProduct, Products.AmountInStocksProduct, Products.ImagePath
		from ProductsInStores
		join Products on ProductsInStores.IDProductsPIS = Products.IDProduct
		join Categories on Categories.IDCategorie = Products.IDCategories
		where IDCategorie = @IDCategories and Products.nameProduct like '%' + @Search + '%'
		end
	else if(@IDStores!=11 and @sort = 2)
		begin
		select Products.nameProduct, Products.priceProduct, Products.AmountInStocksProduct, Products.ImagePath
		from ProductsInStores
		join Products on ProductsInStores.IDProductsPIS = Products.IDProduct
		join Categories on Categories.IDCategorie = Products.IDCategories
		where ProductsInStores.IDStorePIS = @IDStores and Products.nameProduct like '%' + @Search + '%'
		order by Products.priceProduct desc
		end
	else if(@IDStores!=11 and @sort = 3)
		begin
		select Products.nameProduct, Products.priceProduct, Products.AmountInStocksProduct, Products.ImagePath
		from ProductsInStores
		join Products on ProductsInStores.IDProductsPIS = Products.IDProduct
		join Categories on Categories.IDCategorie = Products.IDCategories
		where ProductsInStores.IDStorePIS = @IDStores and Products.nameProduct like '%' + @Search + '%'
		end
	else if(@sort = 2)
		begin
		select Products.nameProduct, Products.priceProduct, Products.AmountInStocksProduct, Products.ImagePath
		from Categories full join Products on Products.IDProduct = Categories.IDCategorie
		where Products.nameProduct like '%' + @Search + '%'
		order by Products.priceProduct desc
		end
	else
		begin
		select Products.nameProduct, Products.priceProduct, Products.AmountInStocksProduct, Products.ImagePath
		from Categories full join Products on Products.IDProduct = Categories.IDCategorie
		where Products.nameProduct like '%' + @Search + '%'
		order by Products.priceProduct asc
		end
end
go

create procedure AddEditAndDeleteProducts(@Params int, @name varchar(255), @price money, @purchasePriceProduct money, @AmountInStocksProduct int, @IDCategories int, @ImagePath nvarchar(255),@IDStore int, @amount int)
as

begin
if(@Params = 1)
begin 
insert into Products(nameProduct,priceProduct,purchasePriceProduct,AmountInStocksProduct,IDCategories,ImagePath)
values(@name,@price,@purchasePriceProduct,@AmountInStocksProduct,@IDCategories,@ImagePath)
declare @IDProduct int = (select IDProduct from Products where nameProduct = @name)
insert into ProductsInStores(IDProductsPIS,IDStorePIS,AmountPIS)
values(@IDProduct, @IDStore, @amount)
end
else if(@Params = 2)
begin
update Products
set priceProduct = @price, purchasePriceProduct = @purchasePriceProduct, AmountInStocksProduct = @AmountInStocksProduct, IDCategories = @IDCategories,ImagePath = @ImagePath
where nameProduct = @name
end
else if(@Params = 3)
begin
delete Products
where nameProduct = @name
end
end
go

create procedure AddCheck(@idEmployee int,  @idColor int, @nameProduct varchar(255))
as
declare @idChecks int, @idProduct int
begin
insert into Checks(IDEmployeeCheck)
values(@idEmployee)
set @idChecks = (select IDCheck from Checks where dateAndTimeCheck = GETDATE())
set @idProduct = (select IDProduct from Products where nameProduct=@nameProduct)
insert into ProductsInCheck(IDCheckPIC, IDPaintingColorPIC, IDProductPIC)
values(@idChecks, @idColor, @idProduct)
end
go

create procedure AddEditAndDeleteProviders(@Params int, @nameProvider varchar(255), @contactDetails varchar(255), @phoneProvider varchar(11))
as

begin
if(@Params = 1)
begin 
insert into Provider(nameProvider,contactDetailsProvider,phoneProvider)
values(@nameProvider,@contactDetails,@phoneProvider)
end
else if(@Params = 2)
begin
update Provider
set contactDetailsProvider = @contactDetails, phoneProvider = @phoneProvider
where nameProvider = @nameProvider
end
else if(@Params = 3)
begin
delete Provider
where nameProvider = @nameProvider
end
end
go

create procedure AddAndDeleteSupplies(@Params int, @IDProviderSupplie int, @IDProductPIS int, @amountPIS int, @IDSuppliesVS int)
as

begin
if(@Params = 1)
begin 
insert into Supplies(IDProviderSupplie)
values(@IDProviderSupplie)
declare @IDSupplies int = (select TOP(1) IDSupplie from Supplies order by IDSupplie desc)
insert into ProductsInSupplies(IDProductPISupplies,IDSuppliesPISupplies,amountPISupplies)
values(@IDProductPIS,@IDSupplies,@amountPIS)
end
else if(@Params = 2)
begin
delete ProductsInSupplies
where IDSuppliesPISupplies = @IDSuppliesVS
delete Supplies
where IDSupplie = @IDSuppliesVS
end
end
go

create procedure AddEditAndDeleteEmployees(@Params int,@nameEmployee varchar(255),@phoneEmployee varchar(11), @adressEmployee varchar(255), @expEmployee int,@IDStoreEmployee int, @IDCategories int)
as

begin
if(@Params = 1)
begin 
insert into Employees(nameEmployee,phoneEmployee,adressEmployee,experienceEmployee,IDStoreEmployee,IDCategoriesEmployee)
values(@nameEmployee,@phoneEmployee,@adressEmployee,@expEmployee,@IDStoreEmployee,@IDCategories)
end
else if(@Params = 2)
begin
update Employees
set phoneEmployee = @phoneEmployee, adressEmployee = @adressEmployee,experienceEmployee = @expEmployee,IDCategoriesEmployee = @IDCategories
where nameEmployee = @nameEmployee
end
else if(@Params = 3)
begin
delete Employees
where nameEmployee = @nameEmployee
end
end
go