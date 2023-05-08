using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatalonShopUITest.Utilities
{
    public static class CommonVariables
    {
        public static string jsonFile = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Utilities", "appConfig.json"));
        static dynamic config = JsonConvert.DeserializeObject(jsonFile);

        public static string baseUrl = config.BaseUrl;
    }
}
