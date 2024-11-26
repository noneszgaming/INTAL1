using System.ComponentModel.DataAnnotations;

namespace PlanningProject.Models
{
    public class DbTask
    {
        [Key]
        public required string Task_id { get; set; }
        public required int User_id { get; set; }
        public required int Sprint_id { get; set; }
        public required string Description { get; set; }
        public required double Est_point { get; set; }
        public bool Status { get; set; }
    }
}
