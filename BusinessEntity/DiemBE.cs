using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccessData;
using System.Data ;
namespace BusinessEntity
{
  public   class DiemBE
    {
      DataConnect kn = new DataConnect();

      public DataTable showDiem()
      {
          string sql = "select distinct d.MaSV, d.MaLop, d.MaMH,d.DiemTP,d.DiemThi,d.LanThi,d.HocKi,d.SoTietNghi  from tbl_DIEM d";
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
          return dt;
      }

      public void insertDiem(string maSV, string maLop, string maMH,float diemTP,float diemT,int lanThi,int hocKi, int soTietN)
      {
          string sql = "insert into tbl_DIEM (MaSV,MaLop,MaMH,DiemTP,DiemThi,LanThi,HocKi,SoTietNghi)  values( '" + maSV + "','" + maLop + "','" + maMH + "','" + diemTP + "','" + diemT + "','" + lanThi + "','" + hocKi + "','" + soTietN + "')";
          kn.ExcuteNonQuery(sql); 
      }

      public void updateDiem(string madkSV,string madkL, string madkMH,string madkLanThi,
          string maSV, string maLop, string maMH, float diemTP, float diemT, int lanThi, int hocKi, int soTietN)
      {
          string sql = "update tbl_DIEM set MaSV = '" + maSV + "', MaLop='" + maLop + "',MaMH='" + maMH + "',DiemTP='" + diemTP + "',DiemThi='" + diemT + "',LanThi='" + lanThi + "',HocKi='" + hocKi + "',SoTietNghi='" + soTietN + "' "
                      + "  where MaSV='" + madkSV + "' and  MaLop='" + madkL + "' and MaMH = '" + madkMH + "'  and LanThi = '" + madkLanThi + "'   ";
          kn.ExcuteNonQuery(sql);
      }

      public void deleteDiemByMaM(string maSV ,string maL, string maMH ,string lanthi)
      {
          string sql = "delete tbl_DIEM where  MaSV = '" + maSV + "' and MaLop ='" + maL  + "' and MaMH ='" + maMH + "'and LanThi='"+lanthi +"'  ";
          kn.ExcuteNonQuery(sql);
      }

      public DataTable getDiemByIdSV(string key)
      {
          string sql = "select distinct d.MaSV, d.MaLop, d.MaMH,d.DiemTP,d.DiemThi,d.LanThi,d.HocKi,d.SoTietNghi  from tbl_DIEM d"
                      + " where d.MaSV = '"+key +"' ";
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
          return dt;
      }

      public DataTable getDiemByIdLop(string key)
      {
          string sql = "select distinct d.MaSV, d.MaLop, d.MaMH,d.DiemTP,d.DiemThi,d.LanThi,d.HocKi,d.SoTietNghi  from tbl_DIEM d"
                      + " where d.MaLop = '" + key + "' ";
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
          return dt;
      }

      public DataTable getDiemByAll(string key)
      {
          string sql = "select distinct d.MaSV, d.MaLop, d.MaMH,d.DiemTP,d.DiemThi,d.LanThi,d.HocKi,d.SoTietNghi  from tbl_DIEM d"
                      + " where d.MaLop = '" + key + "'or d.MaSV='"+key +"' or d.MaMH ='"+key +"' ";
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
          return dt;
      }

      public DataTable getDiemByMaSV(string key)
      {
          string sql = "select distinct d.MaSV, d.MaLop, d.MaMH,d.DiemTP,d.DiemThi,d.LanThi,d.HocKi,d.SoTietNghi  from tbl_DIEM d"
                      + " where d.MaSV like '%" + key + "%' ";
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
          return dt;
      }

      public DataTable getDiemByMaLop(string key)
      {
          string sql = "select distinct d.MaSV, d.MaLop, d.MaMH,d.DiemTP,d.DiemThi,d.LanThi,d.HocKi,d.SoTietNghi  from tbl_DIEM d"
                      + " where d.MaLop like '%" + key + "%' ";
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
          return dt;
      }

      public DataTable getDiemByTatCa(string key)
      {
          string sql = "select distinct d.MaSV, d.MaLop, d.MaMH,d.DiemTP,d.DiemThi,d.LanThi,d.HocKi,d.SoTietNghi  from tbl_DIEM d, tbl_MonHoc mh"
                      + " where d.MaLop like '%" + key + "%'or d.MaSV like '%" + key + "%' or d.MaMH like '%" + key + "%'or d.MaMH = mh.MaMH and mh.TenMH like '%"+key+"%' ";
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
          return dt;
      }

    }
}
