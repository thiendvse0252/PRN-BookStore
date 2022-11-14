using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Repository {
    public static class DataConnect {
        public static string GetConnectionString() {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("setting.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:BookStore"];
            return strConn;
        }
    }
}
