using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AccessData;

namespace BusinessEntity
{
  public  class GiaoVienBE
    {
      DataConnect da = new DataConnect();
      public DataTable ShowGV() 
      {
          string sql = "select * from tbl_GIAOVIEN";
          DataTable dt = new DataTable();
          dt = da.GetTable(sql);
      return dt;
      }
    }
}
