using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiPostManager {

    public static class ServerConfig {

        public static string MongoDBConnectionString {
            get {
                return "mongodb+srv://gKaucic:test123@myfirstcluster-2zpvc.gcp.mongodb.net/test?retryWrites=true&w=majority";
            }
        }

        public static string MaxiImagePostURL {
            get {
                return "http://localhost:3000/uploadImage";
            }
        }
    }
}
