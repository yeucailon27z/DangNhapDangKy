using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class DangKiServices
    {
        private DangKiRepositories repo;
        public DangKiServices()
        {
            repo = new DangKiRepositories();
        }
        public bool DangKi(string ten, string sdt, string email, string diachi, string username, string password)
        {
            // Thêm các logic nghiệp vụ nếu cần
            return repo.DangKi(ten,sdt,email,diachi,username,password);
        }

    }
}
