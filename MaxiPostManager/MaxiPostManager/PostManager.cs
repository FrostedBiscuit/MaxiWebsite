using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace MaxiPostManager {

    public static class PostManager {

        public static Post[] posts;

        static bool init = false;

        private static Action onPostsLoadedCallback;

        private static HttpClient client;

        public static void Init() {

            if (init == true) {
                return;
            }

            client = new HttpClient();

            RefreshPosts();
        }

        public static void AddPost(Post post) {

            HttpContent postContent = new StringContent(JsonConvert.SerializeObject(post), System.Text.Encoding.UTF8, "application/json");

            client.PostAsync(ServerConfig.MaxiPostURL, postContent);
        }

        public static void UpdatePost(Post post) {

            HttpContent postContent = new StringContent(JsonConvert.SerializeObject(post), System.Text.Encoding.UTF8, "application/json");

            HttpRequestMessage request = new HttpRequestMessage(new HttpMethod("PATCH"), ServerConfig.MaxiPatchURL) { Content = postContent };

            client.SendAsync(request);
        }

        static public async void RefreshPosts() {

            string postsJSON = await client.GetStringAsync(ServerConfig.MaxiGetURL).ConfigureAwait(false);

            posts = JsonConvert.DeserializeObject<Post[]>(postsJSON);

            if (onPostsLoadedCallback != null) {
                onPostsLoadedCallback();
            }

            for (int i = 0; i < posts.Length; i++) {

                Console.WriteLine(posts[i].ToString());
            }
        }

        public static void RegisterOnPostsLoadCallback(Action cb) {

            onPostsLoadedCallback += cb;
        }

        public static void UnregisterOnPostsLoadCallback(Action cb) {

            onPostsLoadedCallback -= cb;
        }

    }

    public class Post {
        
        [JsonProperty("Title")]
        public string Title { get; set; }
        [JsonProperty("Content")]
        public string Content { get; set; }
        [JsonProperty("Image64")]
        public string Image64 { get; set; }

        [JsonProperty("ID")]
        public int ID { get; protected set; }

        [JsonProperty("Date")]
        public long Date { get; set; }

        public Post(string title, string content, string img64) {
            
            Title = title;
            Content = content;
            Image64 = img64;

            Date = System.DateTimeOffset.Now.ToUnixTimeSeconds();
        }

        public override string ToString() {
            return $"Title: {Title}, Content: {Content}, Date: {Date}, Image: {Image64 != null}";
        }
    }
}
