using System;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MaxiPostManager {

    public static class ImageUploader {

        //const string URL = "http://localhost:3000/api/imgUpload";

        private static HttpClient client = new HttpClient();

        public static async Task<string> PostImage(string imgPath) {

            string img64 = Convert.ToBase64String(File.ReadAllBytes(imgPath));

            Dictionary<string, string> encodedImg = new Dictionary<string, string> {
                {"image64", img64 }
            };

            HttpContent content = new StringContent(JsonConvert.SerializeObject(encodedImg), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(ServerConfig.MaxiImagePostURL, content);

            string responseContent = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<dynamic>(responseContent).serverImgDir;
        }
    }
}
