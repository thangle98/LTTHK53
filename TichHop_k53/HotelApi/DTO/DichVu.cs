using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelApi.DTO
{
    public class DichVu
    {
        public string idDichVu { get; set; }
        public string TenDichVu { get; set; }
        public long? DonGiaDV { get; set; }
        public string MoTa { get; set; }

    }
}