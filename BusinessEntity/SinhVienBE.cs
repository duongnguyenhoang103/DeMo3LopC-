using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AccessData;

namespace BusinessEntity
{
   public class SinhVienBE
    {
       DataConnect da = new DataConnect();

       public string MaSV { get;set;}
       public string TenSV { get; set; }
       public string GioiTinh { get; set; }
       public int SDT { get; set; }
       public DateTime NgaySinh  { get; set; }

       public string MaLop { get; set; }


       public DataTable GetAllSV()
       {
           string sql = " select * from tbl_SINHVIEN";
           DataTable dt = new DataTable();
           dt = da.GetTable(sql);
           return dt;
       }

       public void DeleteSV(string maSV)
       {
           string sql = "delete tbl_SINHVIEN where MaSV = '" + maSV + "' ";
           da.ExcuteNonQuery(sql);
       }
       public void InsertSV(string masv, string tensv, string gioitinh, int sdt, DateTime ngaysinh, string malop)
       {
           string sql = " INSERT INTO tbl_SINHVIEN VALUES ('" + masv + "', '" + tensv + "',N'" + gioitinh + "','" + sdt + "','" + ngaysinh + "','" + malop + "') ";

           //string sql = " insert tbl_SINHVIEN values ('" + masv + "', '" + tensv + "','" + gioitinh + "','" + sdt + "', '" + ngaysinh.ToShortDateString() + "', '" + malop + "',)";
           da.ExcuteNonQuery(sql);
       }



       public void UpdateSV(string madk,string masv, string tensv, string gioitinh, int sdt, DateTime ngaysinh, string malop)
       {
           string sql = " Update tbl_SINHVIEN SET MaSV ='"+masv+"', TenSV ='"+tensv+"', GioiTinh= N'"+gioitinh+"', SDT='"+sdt +"', NgaySinh='"+ngaysinh +"', MaLop ='"+malop+"' WHERE MaSV ='"+madk+"' ";
           da.ExcuteNonQuery(sql);
       }

       public DataTable GetSVByIdMaLop (string key)
       {
           
           string sql = " select Distinct sv.MaSV,sv.TenSV,sv.GioiTinh,sv.SDT,sv.NgaySinh,sv.MaLop from tbl_SINHVIEN  sv ,tbl_LOP lp "
                           + " Where sv.MaLop = lp.MaLop and sv.MaLop like N'%"+key+"%' ";

           DataTable dt = new DataTable();
           dt = da.GetTable(sql);
           return dt;
       }

       public DataTable GetSVByIdTenLop(string key)
       {
          string sql = " select Distinct sv.MaSV,sv.TenSV,sv.GioiTinh,sv.SDT,sv.NgaySinh,sv.MaLop from tbl_SINHVIEN  sv ,tbl_LOP lp "
                           + " Where sv.MaLop = lp.MaLop and lp.TenLop like N'%"+key+"%' ";
           DataTable dt = new DataTable();
           dt = da.GetTable(sql);
           return dt;
       }
    }
}
