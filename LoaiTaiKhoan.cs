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
    
    public partial class LoaiTaiKhoan
    {
        public LoaiTaiKhoan()
        {
            this.TaiKhoan = new HashSet<TaiKhoan>();
        }
    
        public string MaLoai { get; set; }
        public string Ten { get; set; }
    
        public virtual ICollection<TaiKhoan> TaiKhoan { get; set; }
    }
}
