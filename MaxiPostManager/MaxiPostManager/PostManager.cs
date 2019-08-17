using System.Net.Http;
using Newtonsoft.Json;

namespace MaxiPostManager {

    public static class PostManager {

        static bool init = false;

        private static HttpClient client;

        public static void Init() {

            if (init == true) {
                return;
            }

            client = new HttpClient();
        }

        public static void AddPost(Post post) {

            HttpContent postContent = new StringContent(JsonConvert.SerializeObject(post), System.Text.Encoding.UTF8, "application/json");

            client.PostAsync(ServerConfig.MaxiPostURL, postContent);
        }
    }

    public class Post {

        public string Title { get; protected set; }
        public string Content { get; protected set; }
        public string Image64 { get; protected set; }

        public long Date { get; protected set; }

        public Post(string title, string content, string img64) {

            Title = title;
            Content = content;
            Image64 = img64;

            Date = System.DateTimeOffset.Now.ToUnixTimeSeconds();
        }
    }
}
