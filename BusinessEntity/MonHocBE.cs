﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AccessData;

namespace BusinessEntity
{
    public class MonHocBE
    {
        DataConnect da = new DataConnect();

        public DataTable ShowMH()
        {
            string sql = "select * from tbl_MONHOC";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public void DeleteMH(string maMH)
        {
            string sql = "delete from tbl_MONHOC where MaMH = '"+maMH+"'";
            da.ExcuteNonQuery(sql);
        }

        public void InsertMH(string maMH,string tenMH, string maGV)
    {
        string sql = " insert into tbl_MONHOC values ('" + maMH+ "', '" + tenMH + "','" + maGV + "' )";
        da.ExcuteNonQuery(sql);
    }

        public void Update(string madk, string maMH, string tenMH ,string maGV)
        {
            string sql = " update tbl_MONHOC set MaMH = '"+maMH+"' , TenMH = '"+tenMH+"',MaGV ='"+maGV+"' where MaMH ='"+madk+"'";
            da.ExcuteNonQuery(sql);
        }

        public DataTable SearchByID(string key)
        {
         
            string sql = "select * from tbl_MONHOC where MaMH like N'%"+key+"%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public DataTable SearchByName(string key)
        {
            string sql = "select * from tbl_MONHOC where TenMH like N'%" + key + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

         public DataTable SearchMonHocByIdGV(string key)
        {
            string sql = " select mh.MaMH,mh.TenMH ,mh.MaGV from tbl_MONHOC mh ,tbl_GIAOVIEN gv "
                         + "Where mh.MaGV = gv.MaGV and mh.MaGV like '%"+key+"%' " ;
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    
    }
}
