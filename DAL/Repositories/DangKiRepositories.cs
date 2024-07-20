using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class DangKiRepositories
    {
        private QuanLyBanHangContext context;
        public DangKiRepositories()
        {
            context = new QuanLyBanHangContext();
        }
        public bool DangKi(string ten, string sdt, string email,string diachi,string username, string password)
        {
            if (context.NguoiDungs.Any(u => u.Username == username))
            {
                return false;
            }

            var newUser = new NguoiDung
            {
                Username = username,
                Password = password
            };
            var newKhachHang = new KhachHang
            {
                Tenkh = ten,
                Sdt = sdt,
                Email = email,
                Diachi = diachi,
            };

            context.NguoiDungs.Add(newUser);
            context.KhachHangs.Add(newKhachHang);
            context.SaveChanges();
            return true;
        }
    }
}
