using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Discord.Net;


namespace Guard2._0.Modules
{
    public class Misc : ModuleBase<SocketCommandContext>
    {
        [Command("hi")]
        public async Task hi([Remainder]string message)
        {
            //
                var embed = new EmbedBuilder();
                embed.WithDescription(message);
                embed.WithDescription(message);
                embed.WithColor(new Color(255, 0, 0));
            //Emoji emoji = "<:thinking:";

                await Context.Channel.SendMessageAsync("", false, embed);
            //}
        }

        [Command("Kick")]
        [RequireUserPermission(GuildPermission.KickMembers)]
        [RequireBotPermission(GuildPermission.KickMembers)]
        public async Task Kick2()
        {
            await Context.Channel.SendMessageAsync("<thinking> Биомрази будут почищены");
        }
       
        [Command("teleph")]
        public async Task hello()
        {
            await Context.Channel.SendMessageAsync("<:telephone_reciever:>");
        }

        [Command("чисти", RunMode = RunMode.Async)]
        public async Task delete(int count)
        {
            if (Context.User.Id == 304997307798126593)
            {
                var messages = await Context.Channel.GetMessagesAsync(count + 1).Flatten();
                // var messagesPurge = messages.Where(m => m.Timestamp.Date >= DateTime.Now - TimeSpan.FromDays(14));
                await Context.Channel.DeleteMessagesAsync(messages);
            }
            else
            {
                await Context.Channel.SendMessageAsync("хрен тебе, биомразь");
            }
           
        }

        public async Task Announce() // 1
        {
            /*
            DiscordSocketClient _client = new DiscordSocketClient(); // 2
            ulong id = 123456789012345678; // 3
            var chnl = _client.GetChannel(id) as IMessageChannel; // 4
            await chnl.SendMessageAsync("Announcement!"); // 5

            ulong ServerId = 307901408034684929;

            ulong ChannelId = 336546768156229634;


            if (_client.GetGuild(307901408034684929).GetTextChannel(336546768156229634) != null)
            {
                //var chnl = _client.GetGuild(ServerId).GetTextChannel(ChannelId) as IMessageChannel;
                //await chnl.SendMessageAsync("Announcement!");
                Console.WriteLine("Announcment");
            }
            else
            {
                Console.WriteLine("Announcment Error");
            }*/
        }



        //455447374421032981
        //455447374421032981
        //<:himemism:321707859031359498>
    }

    
}