//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNhanSu_3Tang_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChucVu
    {
        public ChucVu()
        {
            this.NhanVien = new HashSet<NhanVien>();
        }
    
        public string MaCV { get; set; }
        public string TenCV { get; set; }
    
        public virtual ICollection<NhanVien> NhanVien { get; set; }
    }
}
