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
    
    public partial class ProductsInCheck
    {
        public int IDPIC { get; set; }
        public Nullable<int> IDCheckPIC { get; set; }
        public Nullable<int> IDProductPIC { get; set; }
        public Nullable<int> IDPaintingColorPIC { get; set; }
        public Nullable<decimal> pricePIC { get; set; }
    
        public virtual Checks Checks { get; set; }
        public virtual PaintingColors PaintingColors { get; set; }
        public virtual Products Products { get; set; }
    }
}
