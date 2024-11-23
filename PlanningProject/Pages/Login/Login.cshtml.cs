using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace PlanningProject.Pages.Login
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username {  get; set; }

        
        private SqlConnection CreateConnection()
        {
            string connectionString = "Data Source=DESKTOP-1B66EN4\\SQLEXPRESS;Initial Catalog=planningpoker;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }

        public void Insert() 
        {
             SqlConnection con = CreateConnection();
            string insquery = "INSERT INTO users (username) values (@username);";
            using (SqlCommand insertCmd = new SqlCommand(insquery, con))
            {
                insertCmd.Parameters.AddWithValue("@username", Username);
                insertCmd.ExecuteNonQuery();
            }
            con.Close();
        }

        public void OnPost()
        {
            Insert();
            Console.WriteLine(Username);
        }
    }
}
