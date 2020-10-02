using BlazorClient.Shared;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClient.Server.Hubs
{
    public class ChatHub : Hub
    {

        public async Task AddChat(ChatModel chat)
        {
            await Clients.All.SendAsync("ChatReceived", chat);
        }
    }
}
