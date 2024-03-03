using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace RadFordsApplication.Shared
{
    public static class APIHelper
    {
        private static readonly string baseURL = "https://localhost:7176/api/";

        public static async Task<string> GetAll()
        {
            using(HttpClient client = new HttpClient()) 
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "Staff")) 
                {
                    using(HttpContent content = res.Content) 
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
    }
}
