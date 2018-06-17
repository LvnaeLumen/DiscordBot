
using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;

using Discord.Commands;
using System.Threading.Tasks;

using Discord.Commands;
using Discord.WebSocket;
using Discord.Net;

using Guard2._0.Modules;


namespace Guard2._0
{
    class Program
    {
        DiscordSocketClient _client;
        CommandHandler _handler;

        static void Main(string[] args)
        => new Program().StartAsync().GetAwaiter().GetResult();
        //потому что иначе работает через жопу
        
        public async Task StartAsync()
        {
            Config.bot.token = "MzQyNDE2NzM3NTIzODU5NDU3.DftMZQ.VU3Tuy0MX30Pm3rC7fXaGZg7_B4";
            //if (Config.bot.token == "" || Config.bot.token == null) return;
            //Console.WriteLine("Token");
            _client = new DiscordSocketClient(new DiscordSocketConfig
            {
                LogLevel = LogSeverity.Verbose,
                WebSocketProvider = Discord.Net.Providers.WS4Net.WS4NetProvider.Instance
            });       
            
            _client.Log += Log;   

            _handler = new CommandHandler();
            await _handler.InitializeAsync(_client);
            await _client.LoginAsync(TokenType.Bot, Config.bot.token);
            await _client.StartAsync();
            await _client.SetGameAsync("тотальное уничтожение");
            Global.Client = _client;
            _client.Ready += Cnsl.SendMessage; //подключение консоли.

            await Task.Delay(-1);
        }
        
        private async Task MyInitializeFunction()
        {
            Console.WriteLine("It's time to PURGE");
            //Console.WriteLine(_client.());
        }

        private async Task Log(LogMessage msg)
        {
            System.Console.WriteLine(msg.Message);           
        }
    }
}
