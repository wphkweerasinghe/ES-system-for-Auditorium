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
    public partial class MyProfile_Admin : Form
    {
        //get user id
        int id = int.Parse(Form_login.id);
        public MyProfile_Admin()
        {
            InitializeComponent();
            //Show user data
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //data save to the variables
            String name = txtName.Text;
            String email = txtEmail.Text;
            String username = txtUsername.Text;
            int studentId = int.Parse(txtStudentId.Text);
            string createPass = txtCreatePass.Text;
            string confirmPass = txtConfirmPass.Text;
            string role = ComRole.Text;
            //data validation of form
            if (name == null)
            {
                MessageBox.Show("Please enter your Name");
                txtName.Focus();
            }
            else if (email == null || !email.ToLower().Contains('@'))
            {
                MessageBox.Show("Please enter vaild Email");
                txtEmail.Focus();
            }
            else if (username == null)
            {
                MessageBox.Show("Please enter your Username");
                txtUsername.Focus();
            }
            else if (createPass == null)
            {
                MessageBox.Show("Please enter your Password ");
                txtCreatePass.Focus();
                if (createPass != confirmPass)
                {
                    MessageBox.Show("Passwords are not matching");
                    txtConfirmPass.Focus();
                }
            }
            else if (role == null)
            {
                MessageBox.Show("Please select your Role");
            }
            else if (role == "student" && studentId != 0)
            {
                MessageBox.Show("Please enter your Student ID");
                txtStudentId.Focus();
            }
            else
            {
                //Update data into database
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Lectuers\2nd year\2nd semester\ES\Final assigement\AuditoriumReservationDB.mdf';Integrated Security=True;Connect Timeout=30");
                string query = "UPDATE users SET name = '" + name + "',email = '" + email + "',student_id = '" + studentId + "',username = '" + username + "',password = '" + confirmPass + "',role = '" + role + "' WHERE id = '" + id + "';";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your profile updated succesfully!!!");
                }
                catch (SqlException msg)
                {
                    MessageBox.Show("Error!!!\n Please Try agian later");
                    Console.WriteLine(msg.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login.Form_login lg = new Login.Form_login();
            ParentForm.Hide();
            lg.Show();
        }
    }
}
