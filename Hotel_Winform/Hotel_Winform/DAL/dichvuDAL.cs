using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net.Http;
using System.Net.Http.Headers;
using Hotel_Winform.DTO;

namespace Hotel_Winform.DAL
{
    class dichvuDAL
    {
        public DataTable GetDichVu()
        {
            HttpClient client = new HttpClient();
            StringBaseAdd s = new StringBaseAdd();
            client.BaseAddress = new Uri(s.url);
            HttpResponseMessage response = client.GetAsync("api/dichvu").Result;
            List<dichvuDTO> data = response.Content.ReadAsAsync<List<dichvuDTO>>().Result;
            ListToDatatable convert = new ListToDatatable();
            return convert.ToDataTable(data);
        }
    }
}
