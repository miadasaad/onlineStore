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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.StoreSupplierPrdPermissions = new HashSet<StoreSupplierPrdPermission>();
            this.StoreUnits = new HashSet<StoreUnit>();
        }
    
        public string code { get; set; }
        public string ProductName { get; set; }
        public int StoreId { get; set; }
        public Nullable<System.DateTime> productionDate { get; set; }
        public Nullable<System.DateTime> prdDuration { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreSupplierPrdPermission> StoreSupplierPrdPermissions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreUnit> StoreUnits { get; set; }
    }
}
