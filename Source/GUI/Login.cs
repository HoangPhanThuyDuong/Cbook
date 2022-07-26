using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;

namespace index
{
    public partial class Login : Form
    {
        ClsBLL bll = new ClsBLL();
        private string manv;

        public Login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=C#Book;Integrated Security=True");
            con.Open();
            string tk = txt_account.Text;
            string mk = txt_password.Text;
            if (tk == "admin")
            {
                string sql = @"select * from QUANLITAIKHOAN where USERNAME ='" + tk + "' and PASSWORD= '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    string manv = dta["MaNV"].ToString();
                    MessageBox.Show("Đăng nhập thành công!! Bạn sẽ chuyển hướng đến trang chủ!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bll.themngay(tk);
                    frm_user Mainsystem = new frm_user(true, this, manv);
                    Mainsystem.Show();
                }
            }
            else
            {
                string sql = @"select * from QUANLITAIKHOAN where USERNAME ='" + tk + "' and PASSWORD= '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    string manv = dta["MaNV"].ToString();
                    MessageBox.Show("Đăng nhập thành công!! Bạn sẽ chuyển hướng đến trang chủ!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bll.themngay(tk);
                    frm_index Mainsystem = new frm_index(this,manv);
                    Mainsystem.Show();
                }
                else MessageBox.Show("Sai mật khẩu hoặc tên tài khoản!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }

        }

        //private void btn_log_Click(object sender, EventArgs e)
        //{
        //    frm_index Mainsystem = new frm_index(this);
        //    Mainsystem.Show();
        //}
    }
}
