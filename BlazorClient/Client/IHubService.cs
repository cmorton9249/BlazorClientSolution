using BlazorClient.Shared;
using System.Threading.Tasks;

namespace BlazorClient.Client
{
    public interface IHubService
    {
        Task SendChat(ChatModel chat);
        Task StartHub();
    }
}