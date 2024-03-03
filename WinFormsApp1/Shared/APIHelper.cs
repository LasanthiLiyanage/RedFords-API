using Azure;
using Newtonsoft.Json;
using RedFords_API.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadFordsApp.Shared
{
    public static class APIHelper
    {
        private static readonly string baseURL = "https://localhost:7176/api/";

        public static async Task<string> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "Staff"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<StaffDto> Post(StaffDto staffDto)
        {
            using (HttpClient client = new HttpClient())
            {
                var test = JsonConvert.SerializeObject(staffDto);
                var content = new StringContent(test, Encoding.UTF8, "application/json");

                using (HttpResponseMessage res = await client.PostAsync(baseURL + "Staff/CreateStaff", content))
                {
                    using (HttpContent cont = res.Content)
                    {
                        string data = await cont.ReadAsStringAsync();
                        if (data != null)
                        {
                            return staffDto;
                        }
                    }
                }
            }
            return staffDto;
        }

        public static async Task<StaffDto> Put(Guid id ,StaffDto staffDto)
        {          

            using (HttpClient client = new HttpClient())
            {
                var test = JsonConvert.SerializeObject(staffDto);
                var content = new StringContent(test, Encoding.UTF8, "application/json");

                using(HttpResponseMessage res = await client.PutAsync(baseURL + "/Staff/Edit/" + id, content))
                {
                    using (HttpContent cont = res.Content)
                    {
                        string data = await cont.ReadAsStringAsync();
                        if (data != null)
                        {
                            return staffDto;
                        }
                    }
                }                
            }            
            return staffDto;
        }

        public static async Task<string> Delete(Guid id)
        {

            using (HttpClient client = new HttpClient())
            {               

                using (HttpResponseMessage res = await client.DeleteAsync(baseURL + "Staff/Delete/" + id))
                {
                    using (HttpContent cont = res.Content)
                    {
                        string data = await cont.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }
    }
}
