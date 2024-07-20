using BUS.Services;
using PRL;

namespace PRL_DangNhap
{
    public partial class FormDangNhap : Form
    {
        private LoginServices service;
        public FormDangNhap()
        {
            service = new LoginServices();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool isValid = service.Login(username, password);
            if (username.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };
            if (password.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };
            if (isValid)
            {
                txtUsername.Clear();
                txtPassword.Clear();
                FormMain f = new FormMain();
                f.Show();
                this.Hide();
                f.DangXuat += F_DangXuat;
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }


        }

        private void F_DangXuat(object? sender, EventArgs e)
        {
            (sender as FormMain).isThoat = false;
            (sender as FormMain).Close();
            this.Show();
        }

        private void FormDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblDangKi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKi f = new FormDangKi();
            f.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}