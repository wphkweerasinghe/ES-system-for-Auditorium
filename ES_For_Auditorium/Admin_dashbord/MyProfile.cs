using ES_For_Auditorium.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ES_For_Auditorium.Admin_dashbord
{
    public partial class MyProfile : Form
    {
        public MyProfile()
        {
            InitializeComponent();
            //Show user data
            int id = int.Parse(Form_login.id);
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Lectuers\2nd year\2nd semester\ES\Final assigement\AuditoriumReservationDB.mdf';Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE id = '" + id + "';", conn);
            try
            {
                conn.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    txtName.Text = dataReader["name"].ToString();
                    txtEmail.Text = dataReader["email"].ToString();
                    txtUsername.Text = dataReader["username"].ToString();
                    txtStudentId.Text = dataReader["student_id"].ToString();
                    txtCreatePass.Text = dataReader["password"].ToString();
                    txtConfirmPass.Text = dataReader["password"].ToString();
                    ComRole.Text = dataReader["role"].ToString();
                }
            }
            catch(SqlException msg)
            {
                MessageBox.Show("Please Try agian !!!");
                Console.WriteLine(msg.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void MyProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
