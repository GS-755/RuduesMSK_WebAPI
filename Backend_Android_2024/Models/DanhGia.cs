//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Backend_Android_2024.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DanhGia
    {
        public System.DateTime ThoiGian { get; set; }
        public int LuotThich { get; set; }
        public int IDDanhGia { get; set; }
        public string BinhLuan { get; set; }
        public int IDND { get; set; }
        public int IDSP { get; set; }
    
        public virtual NguoiDung NguoiDung { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}