using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace Guard2._0
{
    class Utilities
    {
        private static Dictionary<string, string> alerts;
        static Utilities()
        {
            string json = File.ReadAllText("SystemLang/alerts.json");
            var data = JsonConvert.DeserializeObject<dynamic>(json);
            //сраная магия
            alerts = data.ToObject<Dictionary<string, string>>();
            //а тут вообще чертов шаманизм

        }
        public static string GetAlert(string key)
        {
            if (alerts.ContainsKey(key)) return alerts[key];
            return "";
        }
    }
}
