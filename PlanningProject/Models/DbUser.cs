using System.ComponentModel.DataAnnotations;

namespace PlanningProject.Models
{
    public class DbUser(string username)
    {
        [Key]
        public int User_id { get; set; }

        public string Username { get; set; } = username;
    }
}
