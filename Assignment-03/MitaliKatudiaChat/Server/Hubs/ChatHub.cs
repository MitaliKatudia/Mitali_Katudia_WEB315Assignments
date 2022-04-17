using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace MitaliKatudiaChat.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

         public Task SendMessageToOthers(string user)
        {
            return Clients.Others.SendAsync( user, "isTypingSomething");
        }
    }
}