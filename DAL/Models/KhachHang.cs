using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class KhachHang
    {
        public int Idkh { get; set; }
        public string Tenkh { get; set; } = null!;
        public string? Email { get; set; }
        public string? Sdt { get; set; }
        public string? Diachi { get; set; }

        public virtual NguoiDung IdkhNavigation { get; set; } = null!;
    }
}
