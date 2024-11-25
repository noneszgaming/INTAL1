using Microsoft.AspNetCore.SignalR;

using PlanningProject.Data;
using PlanningProject.Models;

namespace PlanningProject.Hubs
{
    public class PlanningHub(ApplicationDbContext context) : Hub
    {
        private readonly ApplicationDbContext _dbContext = context;


        public async Task JoinSession(string sprintId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, $"sprint_{sprintId}");
        }

        public async Task Vote(string issueKey, int points, string sprintId)
        {

            var existingTask = _dbContext.Tasks.FirstOrDefault(task => task.Task_id == issueKey);

            if (existingTask != null)
            {
                // If the task exists, update its points
                existingTask.Est_point = points;
                _dbContext.Tasks.Update(existingTask);
                await _dbContext.SaveChangesAsync();

                // Notify the group about the update
                await Clients.Group($"sprint_{sprintId}").SendAsync("ReceiveVote", issueKey, points, Context.ConnectionId);
            }
            else
            {
                // If the task does not exist, return an error to the client
                await Clients.Caller.SendAsync("Error", $"Task with issue key '{issueKey}' does not exist.");
            }

        }
    }
}
