using BlazorClient.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClient.Client
{
    public class HubService : IHubService
    {
        private HubConnection _hubConnection;
        private NavigationManager _navigationManager;

        public HubService(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }

        public EventHandler<ChatModel> OnChatReceived;

        public async Task StartHub()
        {
            _hubConnection = new HubConnectionBuilder().WithUrl(_navigationManager.BaseUri + "chat").Build();

            await _hubConnection.StartAsync();

            _hubConnection.On<ChatModel>("ChatReceived", (chat) =>
            {
                Console.WriteLine(chat);
                OnChatReceived.Invoke(this, chat);
            });

        }

        public async Task SendChat(ChatModel chat)
        {
            await _hubConnection.SendAsync("AddChat", chat);
        }
    }
}
