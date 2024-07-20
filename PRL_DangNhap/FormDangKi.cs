using BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PRL_DangNhap
{
    public partial class FormDangKi : Form
    {
        private DangKiServices service;
        public FormDangKi()
        {
            service = new DangKiServices();
            InitializeComponent();
        }

        private void FormDangKi_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;
            string diachi = txtDiaChi.Text;
            string taikhoan = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            string xacnhan = txtXacNhanMK.Text;
            bool isRegistered = service.DangKi(ten, sdt, email, diachi, taikhoan, matkhau);
            if (matkhau != xacnhan)
            {
                MessageBox.Show("Vui lòng xác nhận đúng mật khẩu");
            }

            if (isRegistered)
            {
                MessageBox.Show("Đăng ký thành công!");
                FormDangNhap f = new FormDangNhap();
                f.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
            }
        }
    }
}
