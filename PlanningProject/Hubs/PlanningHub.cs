using Microsoft.AspNetCore.SignalR;

namespace PlanningProject.Hubs
{
    public class PlanningHub : Hub
    {
        public async Task JoinSession(string sprintId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, $"sprint_{sprintId}");
        }

        public async Task Vote(string issueKey, int points, string sprintId)
        {
            await Clients.Group($"sprint_{sprintId}").SendAsync("ReceiveVote", issueKey, points, Context.ConnectionId);
        }
    }
}
