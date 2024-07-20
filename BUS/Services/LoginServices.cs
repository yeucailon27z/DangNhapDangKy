using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class LoginServices
    {
        private NguoiDungRepositories repo;
        public LoginServices()
        {
            repo = new NguoiDungRepositories();
        }
        public bool Login(string username, string password)
        {
            // Thêm các logic nghiệp vụ nếu cần
            return repo.ValidateUser(username, password);
        }
    }
}
