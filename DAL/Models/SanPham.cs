using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            SanPhamChiTiets = new HashSet<SanPhamChiTiet>();
        }

        public int Idsp { get; set; }
        public string Tensp { get; set; } = null!;
        public decimal Gia { get; set; }
        public byte[]? Anh { get; set; }

        public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }
    }
}
