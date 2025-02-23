﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFCursach
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CетьМагазиновСантехникиEntities : DbContext
    {
        public CетьМагазиновСантехникиEntities()
            : base("name=CетьМагазиновСантехникиEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Checks> Checks { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<JobTitle> JobTitle { get; set; }
        public virtual DbSet<PaintingColors> PaintingColors { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductsInCheck> ProductsInCheck { get; set; }
        public virtual DbSet<ProductsInStores> ProductsInStores { get; set; }
        public virtual DbSet<ProductsInSupplies> ProductsInSupplies { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<Stores> Stores { get; set; }
        public virtual DbSet<Supplies> Supplies { get; set; }
    
        public virtual int AddAndDeleteSupplies(Nullable<int> @params, Nullable<int> iDProviderSupplie, Nullable<int> iDProductPIS, Nullable<int> amountPIS, Nullable<int> iDSuppliesVS)
        {
            var paramsParameter = @params.HasValue ?
                new ObjectParameter("Params", @params) :
                new ObjectParameter("Params", typeof(int));
    
            var iDProviderSupplieParameter = iDProviderSupplie.HasValue ?
                new ObjectParameter("IDProviderSupplie", iDProviderSupplie) :
                new ObjectParameter("IDProviderSupplie", typeof(int));
    
            var iDProductPISParameter = iDProductPIS.HasValue ?
                new ObjectParameter("IDProductPIS", iDProductPIS) :
                new ObjectParameter("IDProductPIS", typeof(int));
    
            var amountPISParameter = amountPIS.HasValue ?
                new ObjectParameter("amountPIS", amountPIS) :
                new ObjectParameter("amountPIS", typeof(int));
    
            var iDSuppliesVSParameter = iDSuppliesVS.HasValue ?
                new ObjectParameter("IDSuppliesVS", iDSuppliesVS) :
                new ObjectParameter("IDSuppliesVS", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddAndDeleteSupplies", paramsParameter, iDProviderSupplieParameter, iDProductPISParameter, amountPISParameter, iDSuppliesVSParameter);
        }
    
        public virtual int AddCheck(Nullable<int> idEmployee, Nullable<int> idColor, string nameProduct)
        {
            var idEmployeeParameter = idEmployee.HasValue ?
                new ObjectParameter("idEmployee", idEmployee) :
                new ObjectParameter("idEmployee", typeof(int));
    
            var idColorParameter = idColor.HasValue ?
                new ObjectParameter("idColor", idColor) :
                new ObjectParameter("idColor", typeof(int));
    
            var nameProductParameter = nameProduct != null ?
                new ObjectParameter("nameProduct", nameProduct) :
                new ObjectParameter("nameProduct", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddCheck", idEmployeeParameter, idColorParameter, nameProductParameter);
        }
    
        public virtual int AddEditAndDeleteEmployees(Nullable<int> @params, string nameEmployee, string phoneEmployee, string adressEmployee, Nullable<int> expEmployee, Nullable<int> iDStoreEmployee, Nullable<int> iDCategories)
        {
            var paramsParameter = @params.HasValue ?
                new ObjectParameter("Params", @params) :
                new ObjectParameter("Params", typeof(int));
    
            var nameEmployeeParameter = nameEmployee != null ?
                new ObjectParameter("nameEmployee", nameEmployee) :
                new ObjectParameter("nameEmployee", typeof(string));
    
            var phoneEmployeeParameter = phoneEmployee != null ?
                new ObjectParameter("phoneEmployee", phoneEmployee) :
                new ObjectParameter("phoneEmployee", typeof(string));
    
            var adressEmployeeParameter = adressEmployee != null ?
                new ObjectParameter("adressEmployee", adressEmployee) :
                new ObjectParameter("adressEmployee", typeof(string));
    
            var expEmployeeParameter = expEmployee.HasValue ?
                new ObjectParameter("expEmployee", expEmployee) :
                new ObjectParameter("expEmployee", typeof(int));
    
            var iDStoreEmployeeParameter = iDStoreEmployee.HasValue ?
                new ObjectParameter("IDStoreEmployee", iDStoreEmployee) :
                new ObjectParameter("IDStoreEmployee", typeof(int));
    
            var iDCategoriesParameter = iDCategories.HasValue ?
                new ObjectParameter("IDCategories", iDCategories) :
                new ObjectParameter("IDCategories", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddEditAndDeleteEmployees", paramsParameter, nameEmployeeParameter, phoneEmployeeParameter, adressEmployeeParameter, expEmployeeParameter, iDStoreEmployeeParameter, iDCategoriesParameter);
        }
    
        public virtual int AddEditAndDeleteProducts(Nullable<int> @params, string name, Nullable<decimal> price, Nullable<decimal> purchasePriceProduct, Nullable<int> amountInStocksProduct, Nullable<int> iDCategories, string imagePath, Nullable<int> iDStore, Nullable<int> amount)
        {
            var paramsParameter = @params.HasValue ?
                new ObjectParameter("Params", @params) :
                new ObjectParameter("Params", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(decimal));
    
            var purchasePriceProductParameter = purchasePriceProduct.HasValue ?
                new ObjectParameter("purchasePriceProduct", purchasePriceProduct) :
                new ObjectParameter("purchasePriceProduct", typeof(decimal));
    
            var amountInStocksProductParameter = amountInStocksProduct.HasValue ?
                new ObjectParameter("AmountInStocksProduct", amountInStocksProduct) :
                new ObjectParameter("AmountInStocksProduct", typeof(int));
    
            var iDCategoriesParameter = iDCategories.HasValue ?
                new ObjectParameter("IDCategories", iDCategories) :
                new ObjectParameter("IDCategories", typeof(int));
    
            var imagePathParameter = imagePath != null ?
                new ObjectParameter("ImagePath", imagePath) :
                new ObjectParameter("ImagePath", typeof(string));
    
            var iDStoreParameter = iDStore.HasValue ?
                new ObjectParameter("IDStore", iDStore) :
                new ObjectParameter("IDStore", typeof(int));
    
            var amountParameter = amount.HasValue ?
                new ObjectParameter("amount", amount) :
                new ObjectParameter("amount", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddEditAndDeleteProducts", paramsParameter, nameParameter, priceParameter, purchasePriceProductParameter, amountInStocksProductParameter, iDCategoriesParameter, imagePathParameter, iDStoreParameter, amountParameter);
        }
    
        public virtual int AddEditAndDeleteProviders(Nullable<int> @params, string nameProvider, string contactDetails, string phoneProvider)
        {
            var paramsParameter = @params.HasValue ?
                new ObjectParameter("Params", @params) :
                new ObjectParameter("Params", typeof(int));
    
            var nameProviderParameter = nameProvider != null ?
                new ObjectParameter("nameProvider", nameProvider) :
                new ObjectParameter("nameProvider", typeof(string));
    
            var contactDetailsParameter = contactDetails != null ?
                new ObjectParameter("contactDetails", contactDetails) :
                new ObjectParameter("contactDetails", typeof(string));
    
            var phoneProviderParameter = phoneProvider != null ?
                new ObjectParameter("phoneProvider", phoneProvider) :
                new ObjectParameter("phoneProvider", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddEditAndDeleteProviders", paramsParameter, nameProviderParameter, contactDetailsParameter, phoneProviderParameter);
        }
    
        public virtual ObjectResult<ViewProductsOnCategories_Result> ViewProductsOnCategories(Nullable<int> iDCategories, Nullable<int> iDStores, string search, string sort)
        {
            var iDCategoriesParameter = iDCategories.HasValue ?
                new ObjectParameter("IDCategories", iDCategories) :
                new ObjectParameter("IDCategories", typeof(int));
    
            var iDStoresParameter = iDStores.HasValue ?
                new ObjectParameter("IDStores", iDStores) :
                new ObjectParameter("IDStores", typeof(int));
    
            var searchParameter = search != null ?
                new ObjectParameter("Search", search) :
                new ObjectParameter("Search", typeof(string));
    
            var sortParameter = sort != null ?
                new ObjectParameter("sort", sort) :
                new ObjectParameter("sort", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ViewProductsOnCategories_Result>("ViewProductsOnCategories", iDCategoriesParameter, iDStoresParameter, searchParameter, sortParameter);
        }
    }
}
