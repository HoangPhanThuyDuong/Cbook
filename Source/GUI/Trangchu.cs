using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace index
{
    public partial class frm_index : Form
    {
        private Form Login;

        ClsBLL bll = new ClsBLL();
        private string Manv;
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=C#Book;Integrated Security=True");

        public frm_index(Form Login, string manv)
        {
            InitializeComponent();

            this.Login = Login;
            this.Manv = manv;
            Login.Hide();

            listSach();

            dmtheloai.Items.Add("Tất cả");

            Fillcombo();
        }

        private void frm_index_Load(object sender, EventArgs e)
        {
            StartFullScreen();

            dmkhach.Items.Add("Khách");
            dmkhach.Items.Add("Thành viên");

            lbl_user.Text = bll.getname(Manv);
        }
        private void StartFullScreen()
        {
            FormBorderStyle = FormBorderStyle.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        private void MessageShow(string msg, frm_notify.eType type)
        {
            frm_notify frm = new frm_notify();
            frm.Show(msg, type);
        }

        #region hàm 
        public void tienthua()
        {
            try
            {
                foreach (char r in txt_tongtien.Text)
                {
                    int tientra = 0;
                    if (r.Equals(txt_tienkhach))
                    {
                        txt_tientra.Text = "0";
                    }
                    else
                    {
                        tientra = int.Parse(txt_tienkhach.Text) - int.Parse(txt_tongtien.Text);
                        txt_tientra.Text = Convert.ToString(tientra);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void LoadSumMoney()
        {
            int sum = 0;
            foreach (DataGridViewRow r in DGV_donhang.Rows)
            {
                sum += int.Parse(String.Format("{0}", r.Cells[4].Value));
            }
            txt_tongtien.Text = sum.ToString();
        }
        public void add()
        {
            con.Open();
            foreach (DataGridViewRow row in DGV_donhang.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    SqlCommand insert = new SqlCommand(@"INSERT INTO [dbo].[CTHOADON]
                                (
                                    [MaHD],
                                    [MaSach]
                                    ,[SoLuong]
                                    ,[Giaban])
                                VALUES
                                    (@mahd
                                    ,@masach
                                    , @soluong
                                    , @Gia)", con);
                    insert.Parameters.AddWithValue("@mahd", DateTime.Now.ToString("ddMMyyHHmmss"));
                    insert.Parameters.AddWithValue("@masach", row.Cells[0].Value);
                    insert.Parameters.AddWithValue("@soluong", row.Cells[2].Value);
                    insert.Parameters.AddWithValue("@Gia", row.Cells[4].Value);

                    insert.ExecuteNonQuery();
                    insert.Parameters.Clear();
                }
            }
            con.Close();
        }

        public void addHD()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[HOADON]
                                                    ([MaHD]
                                                    ,[MaKH]
                                                    ,[MaNV]
                                                    ,[NgayBan])
                                                VALUES
                                                    (@mahd
                                                    ,@makh
                                                    ,@manv
                                                    ,@date)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@mahd", DateTime.Now.ToString("ddMMyyHHmmss"));
            cmd.Parameters.AddWithValue("@manv", Manv);
            cmd.Parameters.AddWithValue("@makh", txt_getguestid.Text);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void adddiem()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[KHACHHANG]
                                                SET 
	                                                [DiemTichLuy] = [DiemTichLuy] + @gia/1000
                                                from KHACHHANG
                                                WHERE KHACHHANG.MaKH = @makh ", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@makh", txt_getguestid.Text);
            cmd.Parameters.AddWithValue("@gia", txt_tongtien.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void listSach()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.SL", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DGV_product.Rows.Add(dr["MaSach"].ToString(), dr["TenSach"].ToString(), dr["TheLoai"].ToString(), dr["DonGia"].ToString(), dr["SoLuong"].ToString());
            }
            dr.Close();
            con.Close();

        }

        public void Fillcombo()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select TheLoai from THELOAI ", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string TL = reader["TheLoai"].ToString();
                dmtheloai.Items.Add(TL);
            }
            con.Close();
            if (dmtheloai.Items.Count > 1)
            {
                dmtheloai.SelectedItem = -1;
            }
        }

        public void displaygrid()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT SACH.MaSach, SACH.TenSach,
                                                SACH.TheLoai, SACH.TacGia, SACH.DonGia, QUANTONKHO.SoLuong
                                                FROM SACH INNER JOIN
                                                            QUANTONKHO ON SACH.MaSach = QUANTONKHO.MaSach
                                                WHERE SACH.TheLoai = N'"
                                                + dmtheloai.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DGV_product.Rows.Add(dr["MaSach"].ToString(), dr["TenSach"].ToString(), dr["TheLoai"].ToString(), dr["DonGia"].ToString(), dr["SoLuong"].ToString());
            }
            dr.Close();
            con.Close();

        }

        public void searchBook()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT SACH.MaSach, SACH.TenSach,
                                                SACH.TheLoai, SACH.TacGia, SACH.DonGia, QUANTONKHO.SoLuong
                                                FROM SACH INNER JOIN
                                                            QUANTONKHO ON SACH.MaSach = QUANTONKHO.MaSach
                                                WHERE SACH.TenSach = N'"
                                                + txt_namebook.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DGV_product.Rows.Add(dr["MaSach"].ToString(), dr["TenSach"].ToString(), dr["TheLoai"].ToString(), dr["DonGia"].ToString(), dr["SoLuong"].ToString());
            }
            dr.Close();
            con.Close();

        }
        #endregion


        #region Click Event

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login.Show();
            this.Close();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            frm_user form = new frm_user(false, this, Manv);
            form.ShowDialog();
        }

        private void txt_namebook_Click(object sender, EventArgs e)
        {
            txt_namebook.Text = "";
        }

        private void DGV_donhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in DGV_product.Rows)
                {
                    if (row.Cells["masach"].Value == DGV_donhang.Rows[e.RowIndex].Cells[0].Value)
                    {
                        row.Cells["sl"].Value = int.Parse(String.Format("{0}", row.Cells["sl"].Value)) + int.Parse(String.Format("{0}", DGV_donhang.Rows[e.RowIndex].Cells[2].Value));
                    }
                }
                txt_tongtien.Text = Convert.ToString(int.Parse(txt_tongtien.Text) - int.Parse(String.Format("{0}", DGV_donhang.Rows[e.RowIndex].Cells[4].Value)));
                DGV_donhang.Rows.Remove(DGV_donhang.Rows[e.RowIndex]);
            }
        }

        private void btn_AddToBill_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = DGV_product.CurrentRow;
            ArrayList row = new ArrayList();
            bool flag = false;

            row.Add(dr.Cells["masach"].Value.ToString());
            row.Add(dr.Cells["tensach"].Value.ToString());
            row.Add(1);
            row.Add(dr.Cells["dongia"].Value.ToString());
            row.Add(int.Parse(String.Format("{0}", row[2])) * int.Parse(String.Format("{0}", row[3])));
            dr.Cells["sl"].Value = int.Parse(String.Format("{0}", dr.Cells[4].Value)) - 1;

            foreach (DataGridViewRow r in DGV_donhang.Rows)
            {
                if (r.Cells[0].Value.Equals(row[0]))
                {
                    r.Cells[2].Value = int.Parse(String.Format("{0}", r.Cells[2].Value)) + int.Parse(String.Format("{0}", row[2]));
                    r.Cells[4].Value = int.Parse(String.Format("{0}", r.Cells[2].Value)) * int.Parse(String.Format("{0}", r.Cells[3].Value));
                    flag = true;
                }
                if (flag) { break; }
            }
            if (!flag)
            {
                DGV_donhang.Rows.Add(row.ToArray());
            }
            LoadSumMoney();
        }

        private void btn_cancelbill_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow r in DGV_donhang.Rows)
            {
                foreach (DataGridViewRow row in DGV_product.Rows)
                {
                    if (row.Cells["masach"].Value == r.Cells["masp"].Value)
                        row.Cells["sl"].Value = int.Parse(String.Format("{0}", row.Cells["sl"].Value)) + int.Parse(String.Format("{0}", r.Cells["soluong"].Value));
                }
            }
            DGV_donhang.Rows.Clear();
            txt_tongtien.Clear();

        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            if (dmkhach.SelectedItem.ToString() == "Thành viên")
            {
                if (txt_getguestid.Text == String.Empty || txt_tienkhach.Text == string.Empty)
                {
                    this.MessageShow("Thanh toán không thành công", frm_notify.eType.Error);
                }
                else
                {
                    add();
                    addHD();
                    adddiem();
                    this.MessageShow("Thanh toán thành công", frm_notify.eType.Success);
                    DGV_donhang.Rows.Clear();
                    txt_tienkhach.Clear();
                    txt_tientra.Text = "0";
                    txt_tongtien.Text = "0";
                }
            }
            else if (dmkhach.SelectedItem.ToString() == "Khách" && txt_tienkhach.Text == string.Empty)
            {
                this.MessageShow("Thanh toán không thành công", frm_notify.eType.Error);
            }
            else
            {
                add();
                addHD();
                adddiem();
                this.MessageShow("Thanh toán thành công", frm_notify.eType.Success);
                DGV_donhang.Rows.Clear();
                txt_tienkhach.Clear();
                txt_tientra.Text = "0";
                txt_tongtien.Text = "0";
            }
        }

        #endregion

        #region Properties

        private void btn_banhang_MouseHover(object sender, EventArgs e)
        {
            Popuptitle.Show("Bán hàng", btn_banhang);
        }

        private void btn_thongke_MouseHover(object sender, EventArgs e)
        {
            Popuptitle.Show("Thống kê", btn_thongke);
        }

        private void btn_user_MouseHover(object sender, EventArgs e)
        {
            Popuptitle.Show("Người dùng", btn_user);
        }

        private void btn_setting_MouseHover(object sender, EventArgs e)
        {
            Popuptitle.Show("Cài đặt", btn_setting);
        }

        private void btn_guestscreen_MouseHover(object sender, EventArgs e)
        {
            Popuptitle.Show("Màn hình khách hàng", btn_guestscreen);
        }

        private void btn_logout_MouseHover(object sender, EventArgs e)
        {
            Popuptitle.Show("Đăng xuất", btn_logout);
        }

        private void txt_namebook_Enter(object sender, EventArgs e)
        {
            if (txt_namebook.Text.Equals("Nhập tên sách"))
            {
                txt_namebook.Text = "";
                txt_namebook.ForeColor = Color.Blue;
            }
        }

        private void txt_namebook_Leave(object sender, EventArgs e)
        {
            if (txt_namebook.Text.Equals(String.Empty))
            {
                txt_namebook.Text = "Nhập tên sách";
                txt_namebook.ForeColor = Color.DeepSkyBlue;
            }
        }

        private void dmkhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dmkhach.SelectedIndex == 1)
            {
                lbl_guestid.Visible = true;
                txt_getguestid.Visible = true;
                lbl_guestname.Visible = true;
                txt_getguestname.Visible = true;
            }
            else
            {
                lbl_guestid.Visible = false;
                txt_getguestid.Visible = false;
                lbl_guestname.Visible = false;
                txt_getguestname.Visible = false;
            }
        }

        #endregion

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            Thongke form = new Thongke(this);
            form.ShowDialog();
        }

        private void DGV_product_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_tienkhach_TextChanged(object sender, EventArgs e)
        {
            tienthua();
        }

        private void dmtheloai_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (dmtheloai.Text == "Tất cả")
            {
                DGV_product.Rows.Clear();
                listSach();
            }
            else
            {
                DGV_product.Rows.Clear();
                displaygrid();
            }

        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            DGV_product.Rows.Clear();
            searchBook();
        }
    }
}
