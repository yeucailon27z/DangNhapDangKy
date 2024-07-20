using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SanPhamChiTiet
    {
        public SanPhamChiTiet()
        {
            GioHangs = new HashSet<GioHang>();
        }

        public int Idspct { get; set; }
        public int Idsp { get; set; }
        public int Soluong { get; set; }

        public virtual SanPham IdspNavigation { get; set; } = null!;
        public virtual ICollection<GioHang> GioHangs { get; set; }
    }
}
