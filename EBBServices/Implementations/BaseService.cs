using System;
using System.Net.Http;
using EBBModels.Models;
using Newtonsoft.Json;

namespace EBBServices.Implementations
{
   public abstract class BaseService
    {
        private const string ApiUrl = "https://localhost:44394/api/";

        protected T Get<T>(string secondPartOfURL)
        {
            string apiUrl = ApiUrl + secondPartOfURL;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var stringTask = client.GetStringAsync(apiUrl);
                stringTask.Wait();
                var s = JsonConvert.DeserializeObject<string>(stringTask.Result);
                return JsonConvert.DeserializeObject<T>(s);

                // return default(T);
            }
        }

        protected Response Post<T>(string secondPartOfURL, T model)
        {
            string apiUrl = ApiUrl + secondPartOfURL;
            var resp = new Response() { IsSuccess = true };
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string stringData = JsonConvert.
SerializeObject(model);
                var contentData = new StringContent
            (stringData, System.Text.Encoding.UTF8,
            "application/json");
                HttpResponseMessage response = client.PostAsync
            (apiUrl, contentData).Result;
                var msg = response.Content.
              ReadAsStringAsync().Result;
                var s = JsonConvert.DeserializeObject<string>(msg);
                return JsonConvert.DeserializeObject<Response>(s);
            }
        }
    }
}
