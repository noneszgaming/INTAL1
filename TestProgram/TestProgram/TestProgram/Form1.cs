using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Net.Http.Headers;

namespace TestProgram
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        private SqlConnection CreateConnection()
        {
            string connectionString = "Data Source=DESKTOP-1B66EN4\\SQLEXPRESS;Initial Catalog=planningpoker;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }

        private void Vote_button(object sender, EventArgs e)
        {
            SqlConnection con = CreateConnection();
            con.Open();

            String Ellen = vote_textBox.Text;
            string query = "Select count(1) from users where username = @username;";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@username", Ellen);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Már létezik");
                }
                else
                {
                    string insquery = "INSERT INTO users (username) values (@username);";
                    using (SqlCommand insertCmd = new SqlCommand(insquery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@username", Ellen);
                        insertCmd.ExecuteNonQuery(); 
                    }

                }
                
            }
            con.Close();  
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = CreateConnection();
            con.Open();
            String Ellen = Login_textBox.Text;
            string query = "Select count(1) from users where username = @username;";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@username", Ellen);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Létezik");
                    username_label.Text = Ellen;
                }
                else
                {

                    MessageBox.Show("Nem létezik");

                }

            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            SqlConnection con = CreateConnection();
            con.Open();

            //4 prepare sql query
            string Query = "Select * from users";
            SqlCommand cmd = new SqlCommand(Query, con);

            //5 execute query (c# sqlcommand class)
            var reader = cmd.ExecuteReader();

            dataGridView1.Columns.Add("user_id", "User ID");
            dataGridView1.Columns.Add("username", "username");
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["user_id"], reader["username"]);
            }
            //6 close connection (c# sqlconnection close)
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //UPDATE users SET username = 'new_username' WHERE id = 1;
            //select id from users where username = 'label1.Text'

            SqlConnection con = CreateConnection();
            con.Open();
            string username = username_label.Text;
            string newname = update_textBox.Text;
            string userId = null;
            string queryId = "SELECT user_id FROM users WHERE username = @username";
            using (SqlCommand cmd = new SqlCommand(queryId, con))
            {
                cmd.Parameters.AddWithValue("@username", username);
                
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userId = reader["user_id"].ToString();
                    }
                }
            }
            string queryUpdate = "update users SET username = @username WHERE user_id = @id;";
            using (SqlCommand cmd = new SqlCommand(queryUpdate, con))
            {
                cmd.Parameters.AddWithValue("@username", newname);
                cmd.Parameters.AddWithValue("@id", userId);
                int rowsAffected = cmd.ExecuteNonQuery();
                username_label.Text = update_textBox.Text;
            }

            con.Close();
        }
    }
}