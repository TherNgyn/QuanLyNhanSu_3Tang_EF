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
    
    public partial class HopDong
    {
        public HopDong()
        {
            this.NhanVien1 = new HashSet<NhanVien>();
        }
    
        public string MaHD { get; set; }
        public string MaNV { get; set; }
        public int LuongCoBan { get; set; }
        public System.DateTime NgayBD { get; set; }
        public System.DateTime NgayKT { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
        public virtual ICollection<NhanVien> NhanVien1 { get; set; }
    }
}
