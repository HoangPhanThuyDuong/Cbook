using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace DAL
{
    public class ClsDAL
    {
        SqlConnection con = new SqlConnection(@"Data Source =.\sqlexpress; Initial Catalog = C#Book;Integrated Security=True");

        public void themsach(string masach, string tensach, string theloai, string tacgia, int gia, int conlai)
        {
            string sql = @"INSERT INTO [dbo].[SACH]
                            ([MaSach]
                            ,[TenSach]
                            ,[TheLoai]
                            ,[TacGia]
                            ,[DonGia]
                            ,[ConLai])
                            VALUES
                            (@masach
                            ,@tensach
                            ,@theloai
                            ,@tacgia
                            ,@gia
                            ,@sl)";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con)
            {
                CommandType = CommandType.Text
            };
            cmd.Parameters.AddWithValue("@masach", masach);
            cmd.Parameters.AddWithValue("@tensach", tensach);
            cmd.Parameters.AddWithValue("@theloai", theloai);
            cmd.Parameters.AddWithValue("@tacgia", tacgia);
            cmd.Parameters.AddWithValue("@gia", gia);
            cmd.Parameters.AddWithValue("@sl", conlai);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void themngay(string user)
        {
            string sql = @"UPDATE [dbo].[QUANLITAIKHOAN]
                            SET 
                            [LichSuDN] = @date
                            WHERE USERNAME = @user";

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("dd/MM/yyyy \t HH/mm/ss"));
            cmd.Parameters.AddWithValue("@user", user);
            cmd.ExecuteNonQuery ();
            con.Close();

        }

        public string getname(string manv)
        {
            string sql = @"select TenNV from NHANVIEN where MaNV=@manv";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@manv", manv);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string s = reader["TenNV"].ToString();
            con.Close();

            return s;

        }

        public void addBook(string masach, string name , string theloai, string nametg, int gia)
        {
            string sql = @"INSERT INTO [dbo].[SACH]
                            ([MaSach]
                            ,[TenSach]
                            ,[TheLoai]
                            ,[TacGia]
                            ,[DonGia])
                            VALUES
                            (@ma
                            ,@ten
                            ,@theloai
                            ,@tacgia
                            ,@gia)";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ma", masach);
            cmd.Parameters.AddWithValue("@ten", name);
            cmd.Parameters.AddWithValue("@theloai", theloai);
            cmd.Parameters.AddWithValue("@tacgia", nametg);
            cmd.Parameters.AddWithValue("@gia", gia);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void addSL(string masach, int sl)
        {
            string sql = @"INSERT INTO [dbo].[QUANTONKHO]
                            ([MaSach]
                            ,[SoLuong])
                            VALUES
                            (@ma
                            ,@sl)";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ma", masach);
            cmd.Parameters.AddWithValue("@sl", sl);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void delBook(string ma)
        {
            string sql = @"DELETE FROM [dbo].[SACH]
                         WHERE @ma=MaSach";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ma", ma);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void delSL(string ma)
        {
            string sql = @"DELETE FROM [dbo].[QUANTONKHO]
                         WHERE @ma=MaSach";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ma", ma);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateBook(string masach, string name, string theloai, string nametg, int gia)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[SACH]
                                                SET 
                                                [TenSach] = @ten
                                                ,[TheLoai] = @tl
                                                ,[TacGia] = @tg
                                                ,[DonGia] = @dg
                                                WHERE MaSach=@ma", con);
            cmd.CommandType=CommandType.Text;
            cmd.Parameters.AddWithValue("@ma", masach);
            cmd.Parameters.AddWithValue("@ten", name);
            cmd.Parameters.AddWithValue("@tl", theloai);
            cmd.Parameters.AddWithValue("@tg", nametg);
            cmd.Parameters.AddWithValue("@dg", gia);
            cmd.ExecuteNonQuery();
            con.Close();   

        }

        public void UpdateSL(string ma, int sl)
        {
            con.Open();
            SqlCommand cmd=new SqlCommand(@"UPDATE [dbo].[QUANTONKHO]
                                                SET
                                                [SoLuong] = @sl
                                                WHERE @ma=MaSach",con);
            cmd.CommandType=CommandType.Text;
            cmd.Parameters.AddWithValue("@ma",ma);
            cmd.Parameters.AddWithValue("@sl", sl);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void AddNV(string ma, string ten,string gt, string dt, string diachi,DateTime date)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[NHANVIEN]
                                                        ([MaNV]
                                                        ,[TenNV]
                                                        ,[GioiTinh]
                                                        ,[DienThoai]
                                                        ,[DiaChi]
                                                        ,[NgaySinh])
                                                        VALUES
                                                        (@ma
                                                        ,@ten
                                                        ,@gt
                                                        ,@dt
                                                        ,@dc
                                                        ,@date)", con);
            cmd.CommandType= CommandType.Text;
            cmd.Parameters.AddWithValue("@ma", ma);
            cmd.Parameters.AddWithValue("@ten", ten);
            cmd.Parameters.AddWithValue("@gt", gt);
            cmd.Parameters.AddWithValue("@dt", dt);
            cmd.Parameters.AddWithValue("@dc", diachi);
            cmd.Parameters.Add("@date", SqlDbType.Date ).Value = date.Date;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void editNV(string ma, string ten, string gt, string dt, string diachi, DateTime date)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[NHANVIEN]
                                                SET [MaNV] = @ma
                                                ,[TenNV] = @ten
                                                ,[GioiTinh] = @gt
                                                ,[DienThoai] = @dt
                                                ,[DiaChi] = @dc
                                                ,[NgaySinh] = @date
                                                WHERE [MaNV] = @ma", con);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ma", ma);
            cmd.Parameters.AddWithValue("@ten", ten);
            cmd.Parameters.AddWithValue("@gt", gt);
            cmd.Parameters.AddWithValue("@dt", dt);
            cmd.Parameters.AddWithValue("@dc", diachi);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date.Date;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void delNV(string ma)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[NHANVIEN]
                                                WHERE @ma=MaNV", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ma", ma);
            cmd.ExecuteNonQuery();
            con.Close();
        }


    }
}
