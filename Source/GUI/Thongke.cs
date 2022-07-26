using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections;

namespace index
{
    public partial class Thongke : Form
    {
        Form pa;
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=C#Book;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;

        public Thongke(Form f)
        {
            this.pa = f;
            pa.Hide();
            InitializeComponent();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            pa.Show();
            this.Close();
        }

        private void Thongke_Load(object sender, EventArgs e)
        {
            chart_dt.Series["Nhập vào"].Points.AddXY("Quý 1", 10000000);
            chart_dt.Series["Nhập vào"].Points.AddXY("Quý 2", 12000000);
            chart_dt.Series["Nhập vào"].Points.AddXY("Quý 3", 15000000);
            chart_dt.Series["Nhập vào"].Points.AddXY("Quý 4", 20000000);
            chart_dt.Series["Bán ra"].Points.AddXY("Quý 1", 5000000);
            chart_dt.Series["Bán ra"].Points.AddXY("Quý 2", 8000000);
            chart_dt.Series["Bán ra"].Points.AddXY("Quý 1", 10000000);
            chart_dt.Series["Bán ra"].Points.AddXY("Quý 2", 14000000);

            chart_tl.Series["Category"].Points.AddXY("Truyện tranh màu", 40);
            chart_tl.Series["Category"].Points.AddXY("Truyện ngắn", 25);
            chart_tl.Series["Category"].Points.AddXY("Sách khoa học", 25);
            chart_tl.Series["Category"].Points.AddXY("Sách văn học", 10);

            con.Open();
            cmd = new SqlCommand("st_Thongke", con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                baocao.Rows.Add(reader["Month"].ToString(), reader["year"].ToString(), reader["Tong"].ToString(), reader["Tien"].ToString());
            }
            reader.Close();
            con.Close();
        }

        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < baocao.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = baocao.Columns[i].HeaderText;
            }
            for (int i = 0; i < baocao.Rows.Count; i++)
            {
                for (int j = 0; j < baocao.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = baocao.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Connect.xlsx";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2013 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportExcel(saveFileDialog.FileName);
                MessageBox.Show("Xuất File thành công");
            }
        }
    }
}
