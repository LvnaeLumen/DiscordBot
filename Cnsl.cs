using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace Guard2._0
{
   
    internal static class Cnsl
    {
        private static SocketTextChannel channel;

        internal static async Task SendMessage()
        {
            ulong GuildID = 307901408034684929;
            ulong ChannelID = 307901408034684929;




            if (Global.Client.GetGuild(GuildID).GetTextChannel(ChannelID) != null)
            {

                //
                channel = Global.Client.GetGuild(GuildID).GetTextChannel(ChannelID);
                System.Console.WriteLine("Direct reading success");
                bool bs = true;
                while (bs)
                {
                    string message = System.Console.ReadLine();
                    bs = (message != "off");
                    if (bs)
                    {
                        await channel.SendMessageAsync(message);
                        
                    }
                    else
                    {
                        await Global.Client.StopAsync();
                    }
                }
                
            }
            else
            {
                System.Console.WriteLine("Direct reading failed");
            }
           
        }
    }
}
