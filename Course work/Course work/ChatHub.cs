using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Coursework
{
    public class ChatHub : Hub
    {
        public async Task Send(string message, string user)
        {
            await Clients.All.SendAsync("broadcastMessage", user, message);
        }
    }
}
