using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AccessData ;

namespace BusinessEntity
{
 public   class BCThongKeSvBE
    {
     DataConnect kn = new DataConnect();
     public DataTable showSV()
     {
         string sql = " select sv.MaSV, sv.TenSV, sv.GioiTinh, sv.SDT, sv.DiaChi, sv.Email ,sv.NgaySinh from tbl_SINHVIEN";
         DataTable dt = new DataTable();
         dt = kn.GetTable(sql);
         return dt;
     }

     public DataTable getSvByIdLop(string key)
     {
         string sql = " select sv.MaSV, sv.TenSV, sv.GioiTinh, sv.SDT, sv.DiaChi, sv.Email ,sv.NgaySinh from tbl_SINHVIEN sv , tbl_LOP lp"
                       + " where sv.MaLop = lp.MaLop and sv.MaLop ='"+key +"'  ";
         DataTable dt = new DataTable();
         dt = kn.GetTable(sql);
         return dt;
     }
    }
}
