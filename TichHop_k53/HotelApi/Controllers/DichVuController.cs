using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using HotelApi.DAL;
using HotelApi.DTO;

namespace HotelApi.Controllers
{
    public class DichVuController : ApiController
    {
        // GET api/dichvu/
        public List<DichVu> Get()
        {
            DichvuDAL dal = new DichvuDAL();
            return dal.LayDSDV();
        }
        // GET api/dichvu/4 (cái này ví dụ cho tìm kiếm khi nhập vào mã dịch vụ nhé)
        public DichVu Get(string maDV)
        {
            DichvuDAL dal = new DichvuDAL();
            return dal.LayDVTheoMa(maDV);
        }

        // POST api/dichvu(cái này là thêm tương ứng vs post)
        public void Post(string idDV, string tenDV, long donGia, string moTa)
        {
            DichvuDAL dal = new DichvuDAL();
            dal.ThemDV(idDV, tenDV,donGia,moTa);//  ko cần return chỉ có get mới return
        }

        // PUT api/dichvu/  (cái này là sửa nhé ứng vs put)
        public void Put(string idDV, string tenDV, long donGia, string moTa)
        {
            DichvuDAL dal = new DichvuDAL();
            dal.SuaDV(idDV, tenDV, donGia, moTa);//  ko return chỉ có get mới return
        }

        // DELETE api/dichvu/ (xóa ko cần làm nhé)
        public void Delete(int id)
        {

        }
    }
}
