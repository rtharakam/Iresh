//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OIvn.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Model
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Model()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int Model_Id { get; set; }
        public string Model_SKU { get; set; }
        public Nullable<int> Model_Type { get; set; }
        public string Model_Name { get; set; }
        public Nullable<int> Model_SubType { get; set; }
        public Nullable<int> Model_Manufaturer { get; set; }
    
        public virtual ProductType ProductType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
        public virtual Manufature Manufature { get; set; }
    }
}