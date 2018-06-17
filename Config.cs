using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guard2._0
{
    class Config
    {
        private const string configFolder = "Resources";
        private const string configFile = "config.json";

        public static BotConfig bot;
        static Config()
        {
            //Проверка наличия файла
            if (!Directory.Exists(configFolder))
                Directory.CreateDirectory(configFolder);
            if(!File.Exists(configFolder+ "/" + configFile))
            {
                bot = new BotConfig();
                string json = JsonConvert.SerializeObject(bot, Formatting.Indented);
                File.WriteAllText(configFolder + "/" + configFile, json);
            }
            else
            {
                string json = File.ReadAllText(configFolder + "/" + configFile);
                bot = JsonConvert.DeserializeObject<BotConfig>(json);
            }
        }
    }

    public struct BotConfig
    {
        public string token;
        //MzQyNDE2NzM3NTIzODU5NDU3.Dfs4Og.z9PcBtA82ojkgKnmeh56_S9w6jM
        public string cmdPrefixl; 
        //= "-";
    }
}
