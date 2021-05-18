using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using HotelApi.DTO;

namespace HotelApi.DAL
{
    public class DichvuDAL
    {
        dbcontext db = new dbcontext();
        public List<DichVu>  LayDSDV()
        {
            List<DichVu> dv = new List<DichVu>();
            dv = db.Query<DichVu>("select *from DichVu");
            return dv;
        }

        public DichVu LayDVTheoMa(string maDV)
        {
            string query = string.Format("SELECT *from DichVu where idDichVu = '{0}'",maDV);
            List<DichVu> dv = new List<DichVu>();
            dv = db.Query<DichVu>(query);
            if (dv.Count == 0)
                return null;
            else
                return dv[0];
        }

        public void ThemDV(string idDV, string tenDV, long donGia, string moTa)
        {
            string query = string.Format(" INSERT dbo.DichVu(idDichVu, TenDichVu, DonGiaDV,MoTa) VALUES({0},{1},{2},{3})",
                                        idDV, tenDV, donGia, moTa);
            db.ExecuteNonQuery(query);
        }
        public void SuaDV(string idDV, string tenDV, long donGia, string moTa)
        {
            string query = string.Format(" UPDATE DichVu set TenDichVu = {1}, DonGiaDV = {2}, MoTa = {3} where idDichVu = {0}",
                                        idDV, tenDV, donGia, moTa);
            db.ExecuteNonQuery(query);
        }


    }
}