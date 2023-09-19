using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Practice.Service
{
    public class HomeSarvice
    {

        static HttpClient client = new HttpClient();
        public async Task<string> GetProductAsync()
        {
            string p = "";
            HttpResponseMessage response = await client.GetAsync("");
            if (response.IsSuccessStatusCode)
            {
                p = await response.Content.ReadAsStringAsync();
            }
            return p;
        }
    }
}
