using DAL.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class NguoiDungRepositories
    {
        QuanLyBanHangContext repo;
        public NguoiDungRepositories()
        {
            repo = new QuanLyBanHangContext();
        }
        public bool ValidateUser(string username, string password)
        {
            return repo.NguoiDungs.Any(u => u.Username == username && u.Password == password);
        }
    }
}
