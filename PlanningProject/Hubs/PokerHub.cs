using Microsoft.AspNetCore.SignalR;

namespace PlanningProject.Hubs
{
    public class PokerHub : Hub
    {
        public async Task JoinPokerSession(int sprintId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, $"Sprint_{sprintId}");
            await Clients.Group($"Sprint_{sprintId}").SendAsync("UserJoined", Context.ConnectionId);
        }

        public async Task LeavePokerSession(int sprintId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, $"Sprint_{sprintId}");
            await Clients.Group($"Sprint_{sprintId}").SendAsync("UserLeft", Context.ConnectionId);
        }
    }
}
