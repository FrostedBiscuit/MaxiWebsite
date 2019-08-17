using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiPostManager {

    public static class ServerConfig {

        public static string MaxiPostURL {
            get {
                return "http://localhost:3000/uploadPost"; // Change this for production
            }
        }
    }
}
