using System.ComponentModel.DataAnnotations;

namespace PlanningProject.Models
{
    public class DbSprint
    {
        [Key]
        public required int Sprint_id {  get; set; }
        public string? Description {  get; set; }
        public string? Start_date { get; set; }
        public string? End_date {  get; set; }
        public bool Status {  get; set; }
    }
}
