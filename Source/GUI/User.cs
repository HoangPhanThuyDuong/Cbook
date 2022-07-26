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
    public partial class frm_user : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=C#Book;Integrated Security=True");

        private string Manv;
        private bool Admin = false;
        private Form form;

        ClsBLL bll = new ClsBLL();
        public frm_user()
        {
            InitializeComponent();
            DefaultMode();
            timef.Interval = 1000;
            timef.Start();
        }

        public frm_user(bool IsAdmin, Form f, string manv)
        {
            this.Manv = manv;
            this.Admin = IsAdmin;
            this.form = f;
            InitializeComponent();
            DefaultMode();
            timef.Interval = 1000;
            timef.Start();
            if (Admin)
            {
                form.Hide();
                btn_admin_ctrl.Visible = true;
                txt_user.Text = bll.getname(Manv);
                txt_roles.Text = "Administrator";
            }
            else
            {
                btn_admin_ctrl.Visible = false;
                txt_user.Text = bll.getname(Manv);
                txt_roles.Text = "Nhân viên bán hàng";
            }
        }
        #region Function
        public void listSach()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.SL", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sach_DGV.Rows.Add(dr["MaSach"].ToString(), dr["TenSach"].ToString(), dr["TacGia"].ToString(),
                    dr["TheLoai"].ToString(), dr["DonGia"].ToString(), dr["SoLuong"].ToString());
            }
            dr.Close();
            con.Close();
        }

        public void QLTK()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from QUANLITAIKHOAN", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                qltk_DGV_account.Rows.Add(dr["USERNAME"].ToString(), dr["PASSWORD"].ToString(),
                    dr["MaNV"].ToString(), dr["Roles"].ToString(), dr["TinhTrang"].ToString(), dr["LichSuDN"].ToString());
            }
            dr.Close();
            con.Close();
        }

        public void QLNV()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from NHANVIEN", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                qlnd_DGV_user.Rows.Add(dr["MaNV"].ToString(), dr["TenNV"].ToString(), dr["GioiTinh"].ToString(), dr["DienThoai"].ToString()
                    , dr["DiaChi"].ToString(), dr["NgaySinh"].ToString());
            }
            dr.Close();
            con.Close();
        }
        #endregion
        private void DefaultMode()
        {
            panel_qlnd.Dock = DockStyle.None;
            panel_qltk.Dock = DockStyle.None;
            panel_sach.Dock = DockStyle.None;
            panel_user.Dock = DockStyle.None;
            panel_xemsach.Dock = DockStyle.None;
            panel_changepass.Dock = DockStyle.None;

            panel_qlnd.Visible = false;
            panel_qltk.Visible = false;
            panel_sach.Visible = false;
            panel_user.Visible = false;
            panel_xemsach.Visible = false;
            panel_changepass.Visible = false;

            picture_btn_cp.Visible = false;
            picture_btn_qlnd.Visible = false;
            picture_btn_qltk.Visible = false;
            picture_btn_sach.Visible = false;
            picture_btn_user.Visible = false;
            picture_btn_xemsach.Visible = false;
        }

        #region Button_Click

        private void btn_user_Click(object sender, EventArgs e)
        {
            if (panel_user.Dock == DockStyle.Fill)
            {
                DefaultMode();
            }
            else
            {
                DefaultMode();
                panel_user.Dock = DockStyle.Fill;
                panel_user.Visible = true;
                picture_btn_user.Visible = true;
            }
        }

        private void btn_qlnv_Click(object sender, EventArgs e)
        {
            if (panel_qlnd.Dock == DockStyle.Fill)
            {
                DefaultMode();
            }
            else
            {
                DefaultMode();
                panel_qlnd.Dock = DockStyle.Fill;
                panel_qlnd.Visible = true;
                picture_btn_qlnd.Visible = true;
            }
        }

        private void btn_sach_Click(object sender, EventArgs e)
        {
            if (panel_sach.Dock == DockStyle.Fill)
            {
                DefaultMode();
            }
            else
            {
                DefaultMode();
                panel_sach.Dock = DockStyle.Fill;
                panel_sach.Visible = true;
                picture_btn_sach.Visible = true;
            }
        }

        private void btn_changepass_Click(object sender, EventArgs e)
        {
            if (panel_changepass.Dock == DockStyle.Fill)
            {
                DefaultMode();
            }
            else
            {
                DefaultMode();
                panel_changepass.Dock = DockStyle.Fill;
                panel_changepass.Visible = true;
                picture_btn_cp.Visible = true;
            }
        }

        private void btn_qltk_Click(object sender, EventArgs e)
        {
            if (panel_qltk.Dock == DockStyle.Fill)
            {
                DefaultMode();
            }
            else
            {
                DefaultMode();
                panel_qltk.Dock = DockStyle.Fill;
                panel_qltk.Visible = true;
                picture_btn_qltk.Visible = true;
            }
        }

        private void btn_admin_ctrl_Click(object sender, EventArgs e)
        {
            if (panel_admin_ctrl.Visible == true)
            {
                panel_admin_ctrl.Visible = false;
                picture_btn_admin.Visible = false;
            }
            else
            {
                panel_admin_ctrl.Visible = true;
                picture_btn_admin.Visible = true;
            }
            qltk_DGV_account.Rows.Clear();
            sach_DGV.Rows.Clear();
            qlnd_DGV_user.Rows.Clear();


            QLTK();

            listSach();

            QLNV();
        }

        private void btn_xemsach_Click(object sender, EventArgs e)
        {
            if (panel_xemsach.Dock == DockStyle.Fill)
            {
                DefaultMode();
            }
            else
            {
                DefaultMode();
                panel_xemsach.Dock = DockStyle.Fill;
                panel_xemsach.Visible = true;
                picture_btn_xemsach.Visible = true;
            }
        }

        #endregion

        private void timef_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString("dd/MM/yyyy \t HH:mm:ss");
        }

        private void sach_btn_add_Click(object sender, EventArgs e)
        {
            bll.themsach(sach_txt_masach.Text, sach_txt_tensach.Text, sach_txt_theloai.Text, sach_txt_tacgia.Text, int.Parse(sach_txt_gia.Text), int.Parse(sach_txt_sl.Text));
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát??", "Thông báo!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (Admin)
                {
                    form.Show();
                    this.Close();
                }
                else
                    this.Close();
            }
            else
            {
                return;
            }
        }



        private void sach_DGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = sach_DGV.CurrentRow;
            sach_txt_masach.Text = dr.Cells["masach"].Value.ToString();
            sach_txt_tacgia.Text = dr.Cells["tacgia"].Value.ToString();
            sach_txt_tensach.Text = dr.Cells["tensach"].Value.ToString();
            sach_txt_theloai.Text = dr.Cells["theloai"].Value.ToString();
            sach_txt_gia.Text = dr.Cells["dongia"].Value.ToString();
            sach_txt_sl.Text = dr.Cells["sl"].Value.ToString();
        }

        private void qlnd_DGV_user_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = qlnd_DGV_user.CurrentRow;
            qlnd_txt_manv.Text = dr.Cells["ma"].Value.ToString();
            qlnd_txt_hoten.Text = dr.Cells["tennv"].Value.ToString();
            qlnd_txt_dt.Text = dr.Cells["dt"].Value.ToString();
            qlnd_txt_address.Text = dr.Cells["diachi"].Value.ToString();
            dpker_ngaysinh.Value = DateTime.Parse(dr.Cells["date"].Value.ToString());
            if (dr.Cells["gt"].Value.ToString().Equals("True"))
            {
                qlnd_rbtn_male.Checked = true;
            }
            else
                qlnd_rbtn_female.Checked = true;
        }

        private void cp_btn_acp_Click_1(object sender, EventArgs e)
        {
            string oldpass = cp_txt_op.Text;
            string pass = cp_txt_np.Text;
            SqlDataAdapter sda = new SqlDataAdapter("select PASSWORD from QUANLITAIKHOAN Where PASSWORD = '" + oldpass + "'", con); ;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                if (cp_txt_np.Text == cp_txt_xn.Text)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE QUANLITAIKHOAN SET PASSWORD = '" + pass + "' where PASSWORD= '" + oldpass + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Mật khẩu thay đổi thành công!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mật khẩu dưới khác mật khẩu trên!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cp_btn_cancel_Click(object sender, EventArgs e)
        {
            cp_txt_np.Clear();
            cp_txt_op.Clear();
            cp_txt_xn.Clear();
        }

        private void panel_user_Paint(object sender, PaintEventArgs e)
        {
            con.Open();
            string sql = "select * from NHANVIEN where NHANVIEN.MaNV=@manv";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@manv", Manv);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            user_txt_manv.Text = reader["MaNV"].ToString();
            user_txt_hoten.Text = reader["TenNV"].ToString();
            if (reader["GioiTinh"].ToString() == "True")
            {
                user_txt_gioitinh.Text = "Nam";
            }
            else
                user_txt_gioitinh.Text = "Nữ";
            user_txt_dt.Text = reader["DienThoai"].ToString();
            user_txt_date.Text = DateTime.Parse(reader["NgaySinh"].ToString()).ToString("dd/MM/yyyy");
            reader.Close();

            con.Close();
        }

        private void sach_btn_add_Click_1(object sender, EventArgs e)
        {
            bll.addBook(sach_txt_masach.Text, sach_txt_tensach.Text, sach_txt_theloai.Text, sach_txt_tacgia.Text, int.Parse(sach_txt_gia.Text));
            bll.addSL(sach_txt_masach.Text, int.Parse(sach_txt_sl.Text));
            MessageBox.Show("Thêm thành công!!");
            sach_txt_gia.Clear();
            sach_txt_sl.Clear();
            sach_txt_masach.Clear();
            sach_txt_tacgia.Clear();
            sach_txt_theloai.Clear();
            sach_txt_tensach.Clear();
            sach_DGV.Rows.Clear();
            listSach();
        }

        private void sach_btn_sua_Click(object sender, EventArgs e)
        {
            bll.UpdateBook(sach_txt_masach.Text, sach_txt_tensach.Text, sach_txt_theloai.Text, sach_txt_tacgia.Text, int.Parse(sach_txt_gia.Text));
            bll.UpdateSL(sach_txt_masach.Text, int.Parse(sach_txt_sl.Text));
            MessageBox.Show("Sửa thành công!!");
            sach_txt_gia.Clear();
            sach_txt_sl.Clear();
            sach_txt_masach.Clear();
            sach_txt_tacgia.Clear();
            sach_txt_theloai.Clear();
            sach_txt_tensach.Clear();
            sach_DGV.Rows.Clear();
            listSach();
        }

        private void sach_btn_xoa_Click(object sender, EventArgs e)
        {
            bll.delBook(sach_txt_masach.Text);
            bll.delSL(sach_txt_masach.Text);
            MessageBox.Show("Xóa thành công!!");
            sach_txt_gia.Clear();
            sach_txt_sl.Clear();
            sach_txt_masach.Clear();
            sach_txt_tacgia.Clear();
            sach_txt_theloai.Clear();
            sach_txt_tensach.Clear();
            sach_DGV.Rows.Clear();
            listSach();
        }

        private void qlnd_btn_add_Click(object sender, EventArgs e)
        {
            if (qlnd_rbtn_male.Checked == true)
            {
                bll.AddNV(qlnd_txt_manv.Text, qlnd_txt_hoten.Text, "True", qlnd_txt_dt.Text, qlnd_txt_address.Text,dpker_ngaysinh.Value);
            }
            else
            {
                bll.AddNV(qlnd_txt_manv.Text, qlnd_txt_hoten.Text, "False", qlnd_txt_dt.Text, qlnd_txt_address.Text, dpker_ngaysinh.Value);
            }
            MessageBox.Show("Thêm thành công!!");
            qlnd_txt_manv.Clear();
            qlnd_txt_hoten.Clear();
            qlnd_txt_dt.Clear();
            qlnd_txt_address.Clear();
            qlnd_rbtn_female.Checked = false;
            qlnd_rbtn_male.Checked = false;
            qlnd_DGV_user.Rows.Clear();
            QLNV();
        }

        private void qlnd_btn_sua_Click(object sender, EventArgs e)
        {
            if (qlnd_rbtn_male.Checked == true)
            {
                bll.editNV(qlnd_txt_manv.Text, qlnd_txt_hoten.Text, "True", qlnd_txt_dt.Text, qlnd_txt_address.Text, dpker_ngaysinh.Value);
            }
            else
            {
                bll.editNV(qlnd_txt_manv.Text, qlnd_txt_hoten.Text, "False", qlnd_txt_dt.Text, qlnd_txt_address.Text, dpker_ngaysinh.Value);
            }
            MessageBox.Show("Sửa thành công!!");
            qlnd_txt_manv.Clear();
            qlnd_txt_hoten.Clear();
            qlnd_txt_dt.Clear();
            qlnd_txt_address.Clear();
            qlnd_rbtn_female.Checked = false;
            qlnd_rbtn_male.Checked = false;
            qlnd_DGV_user.Rows.Clear();
            QLNV();
        }

        private void qlnd_btn_xoa_Click(object sender, EventArgs e)
        {
            bll.delNV(qlnd_txt_manv.Text);
            MessageBox.Show("Xóa thành công!!");
            qlnd_txt_manv.Clear();
            qlnd_txt_hoten.Clear();
            qlnd_txt_dt.Clear();
            qlnd_txt_address.Clear();
            qlnd_rbtn_female.Checked=false;
            qlnd_rbtn_male.Checked = false;
            qlnd_DGV_user.Rows.Clear();
            QLNV();
        }
    }
}
