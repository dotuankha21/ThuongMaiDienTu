//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThuongMaiDienTu.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Quan_Huyen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Quan_Huyen()
        {
            this.Xa_Phuong = new HashSet<Xa_Phuong>();
        }
    
        public string MaQH { get; set; }
        public string MaTinh { get; set; }
        public string TenHuyen { get; set; }
    
        public virtual Tinh_ThanhPho Tinh_ThanhPho { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Xa_Phuong> Xa_Phuong { get; set; }
    }
}
