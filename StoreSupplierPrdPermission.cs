//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class StoreSupplierPrdPermission
    {
        public int StoreId { get; set; }
        public int SupplierId { get; set; }
        public string PreoductId { get; set; }
        public int permisionNumImport { get; set; }
        public Nullable<System.DateTime> permissionDate { get; set; }
        public Nullable<int> permissionNumExport { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Store Store { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
