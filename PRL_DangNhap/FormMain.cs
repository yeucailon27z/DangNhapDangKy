using PRL_DangNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class FormMain : Form
    {
        public bool isThoat = true;
        public FormMain()
        {
            InitializeComponent();
        }
        public event EventHandler DangXuat;
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat) { Application.Exit(); }

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (isThoat) { Application.Exit(); }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
