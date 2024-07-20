using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HoaDon
    {
        public int Idhd { get; set; }
        public int Idgh { get; set; }
        public string? Tensp { get; set; }
        public decimal? Gia { get; set; }
        public byte[]? Anh { get; set; }
        public int? Soluongmua { get; set; }
        public string? Diachi { get; set; }
        public string? Sdt { get; set; }
        public string? Tennguoimua { get; set; }
        public decimal Tongtien { get; set; }
        public int Idnguoidung { get; set; }
        public DateTime Thoigian { get; set; }
        public bool Trangthai { get; set; }

        public virtual GioHang IdghNavigation { get; set; } = null!;
        public virtual NguoiDung IdnguoidungNavigation { get; set; } = null!;
    }
}
