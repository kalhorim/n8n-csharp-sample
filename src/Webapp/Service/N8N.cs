using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Webapp.Models;

namespace Webapp.Service
{
    public class N8N
    {
        private string n8nUrl = "http://localhost:5678/";
        public async Task<T> Exec<T>(string webhookPath, object data, bool isTest = false)
        {
            
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(n8nUrl);
                webhookPath = isTest ? "webhook-test/" : "webhook/" + webhookPath;
                var result = await client.PostAsJsonAsync(webhookPath, data);
                if (!result.IsSuccessStatusCode)
                {
                    throw new Exception(JsonConvert.SerializeObject(result));
                }
                var response = await result.Content.ReadAsAsync<List<WfResponse<T>>>();
                return response.FirstOrDefault().body;
            }
        }
    }
}
