using GMToolset.Services.Models.QuickBattleManager;
using Microsoft.AspNetCore.SignalR;

namespace GMToolset.Presentation.Hubs
{
    public class QuickSessionHub : Hub
    {
        public async Task SendMessage(Participant participant)
        {
            await Clients.All.SendAsync("ReceiveMessage", participant);
        }
    }
}
