using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AccessData;

namespace BusinessEntity
{
  public class LopBE
    {
      DataConnect da = new DataConnect();

      public DataTable ShowLop()
      {
          string sql = " select  * from tbl_LOP";
          DataTable dt = new DataTable();
          dt = da.GetTable(sql);
        

              return dt;
      }

      public void DeleteLop(string malop)
      {
          string sql = "delete tbl_LOP where MaLop = '" + malop + "' ";
          da.ExcuteNonQuery(sql);
      }

      public void InsertLop(string malop, string tenlop)
      {
          string sql = " insert into tbl_LOP Values(N'" +malop+ "',N'" +tenlop+ "')";
          da.ExcuteNonQuery(sql);
          // them  N phong truong hop la unicode
      }
   
      public void UpdateLop(string madk, string maLop, string tenLop)
      {
          ////string sql = "update tbl_LOP set MaLop = N'" + malop + "', TenLop = N'" + tenlop + "' WHERE MaLop = N'" + malopdk + "'";
          ////da.ExcuteNonQuery(sql);

          string sql = " update tbl_LOP set MaLop = '" + maLop + "' , TenLop = '" + tenLop + "' where MaLop ='" + madk + "'";
            da.ExcuteNonQuery(sql);
      

      }

      public DataTable SearchLopBy(string keywork)
      {
          //string sql = "select * from tbl_LOP WHERE MaLop like N'%"+keywork+"%' or TenLop like N'%"+keywork+"%' "; 
          string sql = "select * from tbl_LOP WHERE MaLop like N'%"+keywork+"%' "; 
          DataTable dt = new DataTable();
          dt = da.GetTable(sql);
          return dt;
      }
    }
}
