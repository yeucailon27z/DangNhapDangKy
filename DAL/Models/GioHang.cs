using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class GioHang
    {
        public GioHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int Idgh { get; set; }
        public int Idspct { get; set; }
        public int Idnd { get; set; }
        public int Soluongmua { get; set; }

        public virtual NguoiDung IdndNavigation { get; set; } = null!;
        public virtual SanPhamChiTiet IdspctNavigation { get; set; } = null!;
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
