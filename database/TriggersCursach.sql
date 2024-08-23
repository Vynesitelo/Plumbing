use Cетьћагазинов—антехники

GO
create trigger InsertPriceSupplies
On ProductsInSupplies
for update, insert
as
declare @IDSupplies int, @PriceProduct money, @ID int, @amount int, @price money
set @ID = (select IDPISupplies from inserted)
set @IDSupplies = (select IDSuppliesPISupplies from inserted)
set @Price = (select sum(Products.purchasePriceProduct*amountPISupplies)
			from Products join ProductsInSupplies on ProductsInSupplies.IDProductPISupplies = Products.IDProduct 
			where IDSuppliesPISupplies = @IDSupplies)
begin 
update Supplies
set priceSupplie = @Price
where IDSupplie = @IDSupplies
end
GO

create trigger InsertPriceCheck
On ProductsInCheck
for update, insert
as
declare @IDCheck int, @PriceProduct money
set @IDCheck = (select IDCheckPIC from inserted)
set @PriceProduct = (select sum(Products.priceProduct+PaintingColors.pricePC)
					from Products join ProductsInCheck on ProductsInCheck.IDProductPIC = Products.IDProduct
					join PaintingColors on PaintingColors.IDPC = ProductsInCheck.IDPaintingColorPIC
					where ProductsInCheck.IDCheckPIC = @IDCheck)
begin 
update ProductsInCheck
set pricePIC = @PriceProduct
where @IDCheck = IDCheckPIC
update Checks
set priceCheck = @PriceProduct
where IDCheck = @IDCheck
end
