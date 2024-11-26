using System.ComponentModel.DataAnnotations;

namespace PlanningProject.Models
{
    public class DbSprint(int sprint_id)
    {
        [Key]
        public int Sprint_id { get; set; } = sprint_id;
    }
}