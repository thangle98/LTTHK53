
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Net.Http.Headers;
using HotelManager.DTO;

namespace HotelManager.DAL
{
    class dichvuDAL
    {
        public DataTable GetDichVu()
        {
            HttpClient client = new HttpClient();
            StringBaseAdd s = new StringBaseAdd();
            client.BaseAddress = new Uri(s.url);
            HttpResponseMessage response = client.GetAsync("api/dichvu").Result;
            List<DichVu> data = response.Content.ReadAsAsync<List<DichVu>>().Result;
            ListToDatatable convert = new ListToDatatable();
            return convert.ToDataTable(data);

        }
        public async void insertBillInfo(string idDV, string tenDV, long donGia, string moTa)
        {
            HttpClient client = new HttpClient();
            StringBaseAdd s = new StringBaseAdd();
            client.BaseAddress = new Uri(s.url);
            client.DefaultRequestHeaders.Accept.Clear();

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
       
            HttpResponseMessage responsePost = await client.PostAsync(String.Format("api/dichvu?idDV={0}&&tenDV={1}&&donGia={2}&&moTa={3}", idDV, tenDV, donGia, moTa),null);

        }
        public async void editBillInfo(string idDV, string tenDV, long donGia, string moTa)
        {
            HttpClient client = new HttpClient();
            StringBaseAdd s = new StringBaseAdd();
            client.BaseAddress = new Uri(s.url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        
            HttpResponseMessage responsePost = await client.PutAsync(String.Format("api/dichvu?idDV={0}&&tenDV={1}&&donGia={2}&&moTa={3}", idDV, tenDV, donGia, moTa), null);

        }
        public async void DeleteBillInfo(int idBill, int idMenu)
        {
          

        }
    }
}
