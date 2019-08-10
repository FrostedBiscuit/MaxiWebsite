using System;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace MaxiPostManager {

    public static class PostManager {

        static IMongoDatabase db;

        static bool init = false;

        public static void Init() {

            if (init == true) {
                return;
            }

            init = true;

            MongoClient client = new MongoClient(ServerConfig.MongoDBConnectionString);

            db = client.GetDatabase("MaxiPosts");
        }

        public static void InsertPost(Post post) {

            IMongoCollection<Post> collection = db.GetCollection<Post>("Posts");

            collection.InsertOne(post);
        }
    }

    public class Post {

        [BsonId]
        public Guid ID { get; protected set; }

        public string Title { get; protected set; }
        public string Content { get; protected set; }
        public string ServersideImageDir { get; protected set; }

        public Post(string title, string content, string serversideImgDir) {

            Title = title;
            Content = content;
            ServersideImageDir = serversideImgDir;
        }
    }
}
