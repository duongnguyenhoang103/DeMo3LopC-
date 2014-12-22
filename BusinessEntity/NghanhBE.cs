using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccessData;
using System.Data;

namespace BusinessEntity
{
   public  class NghanhBE
    {
        DataConnect kn = new DataConnect();

        public DataTable ShowNghanh()
        {
            string sql = " select  * from tbl_NGHANH";
            DataTable dt = new DataTable();
            dt = kn.GetTable(sql);
            return dt;
        }

          public void InsertNghanh(string maNghanh, string tenNghanh, int soLop, string maKhoa, int sdt, string email, string diaChi)
       {
           string sql = " INSERT INTO tbl_NGHANH VALUES ('"+maNghanh+"', N'"+tenNghanh+"',N'"+soLop+"', '"+maKhoa +"', '"+sdt+"','"+email+"', N'" +diaChi+"') ";        
            kn.ExcuteNonQuery(sql);
       }

        public void UpdateNghanh(string madk, string maNghanh, string tenNghanh, int soLop, string maKhoa, int sdt, string email, string diaChi)
       {
           string sql = " Update tbl_NGHANH SET MaNghanh ='"+maNghanh+"', TenNghanh =N'"+tenNghanh +"', SoLop= '"+soLop+"', MaKhoa='"+maKhoa+"', SDT='"+sdt+"', Email ='"+email+"' , DiaChi =N'"+diaChi+"' WHERE MaNghanh ='"+madk+"' ";
           kn.ExcuteNonQuery(sql);
       }

        public void DeleteNganh(string maNganh)
        {
            string sql = "delete tbl_NGHANH where MaNghanh = '" + maNganh + "' ";
            kn.ExcuteNonQuery(sql);
        }
       public DataTable GetSVByIdMaNghanh (string key)
       {

           string sql = " select Distinct sv.MaSV,sv.TenSV,sv.GioiTinh,sv.SDT, sv.DiaChi, sv.Email ,sv.NgaySinh,sv.MaLop from tbl_SINHVIEN  sv ,tbl_LOP lp "
                           + " Where sv.MaLop = lp.MaLop and sv.MaLop like N'%"+key+"%' ";
           DataTable dt = new DataTable();
           dt = kn.GetTable(sql);
           return dt;
       }

       public DataTable GetNghanhByTenNghanh(string key)
       {
          string sql = " select Distinct sv.MaSV,sv.TenSV,sv.GioiTinh,sv.SDT,sv.DiaChi, sv.Email ,sv.NgaySinh,sv.MaLop from tbl_SINHVIEN  sv ,tbl_LOP lp "
                           + " Where sv.MaLop = lp.MaLop and lp.TenLop like N'%"+key+"%' ";
           DataTable dt = new DataTable();
           dt = kn.GetTable(sql);
           return dt;
       }
    
         
    }
}
