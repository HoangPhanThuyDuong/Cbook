using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class ClsBLL
    {
        ClsDAL dal = new ClsDAL();
        public void themsach(string masach, string tensach, string theloai, string tacgia, int gia, int conlai)
        {
            dal.themsach(masach, tensach, theloai, tacgia, gia, conlai);
        }

        public void themngay(string user)
        {
            dal.themngay(user);
        }

        public string getname(string manv)
        {
            return dal.getname(manv);
        }

        public void addBook(string masach, string name, string theloai, string nametg, int gia)
        {
            dal.addBook(masach,name,theloai,nametg,gia);
        }

        public void addSL(string masach, int sl)
        {
            dal.addSL(masach, sl);
        }

        public void delBook(string ma)
        {
            dal.delBook(ma);
        }

        public void delSL(string ma)
        {
            dal.delSL(ma);
        }

        public void UpdateBook(string masach, string name, string theloai, string nametg, int gia)
        {
            dal.UpdateBook(masach, name, theloai, nametg, gia);
        }

        public void UpdateSL(string ma, int sl)
        {
            dal.UpdateSL(ma, sl);
        }

        public void AddNV(string ma, string ten, string gt, string dt, string diachi, DateTime date)
        {
            dal.AddNV(ma,ten,gt,dt,diachi,date);
        }

        public void editNV(string ma, string ten, string gt, string dt, string diachi, DateTime date)
        {
            dal.editNV(ma,ten,gt,dt,diachi,date);
        }

        public void delNV(string ma)
        {
            dal.delNV(ma);
        }
    }
}
