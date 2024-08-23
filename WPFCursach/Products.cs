//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.ProductsInStores = new HashSet<ProductsInStores>();
            this.ProductsInSupplies = new HashSet<ProductsInSupplies>();
            this.ProductsInCheck = new HashSet<ProductsInCheck>();
        }
    
        public int IDProduct { get; set; }
        public string nameProduct { get; set; }
        public Nullable<decimal> priceProduct { get; set; }
        public decimal purchasePriceProduct { get; set; }
        public int AmountInStocksProduct { get; set; }
        public string ImagePath { get; set; }
        public Nullable<int> IDCategories { get; set; }
    
        public virtual Categories Categories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductsInStores> ProductsInStores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductsInSupplies> ProductsInSupplies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductsInCheck> ProductsInCheck { get; set; }
    }
}
