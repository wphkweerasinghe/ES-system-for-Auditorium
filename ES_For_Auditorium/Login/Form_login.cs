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
using System.Security.Cryptography;

namespace ES_For_Auditorium.Login
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get data for local variables
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            //check data validation
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Lectuers\2nd year\2nd semester\ES\Final assigement\AuditoriumReservationDB.mdf';Integrated Security=True;Connect Timeout=30");
            String selectQ = "SELECT * FROM users WHERE username = '"+username+"' AND password = '"+password+"';";
            SqlCommand cmd = new SqlCommand(selectQ, con);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            
            try
            {
                con.Open();
                DA.Fill(dt);
                int i = cmd.ExecuteNonQuery();
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    MessageBox.Show("Successfully loged in");
                    //check user role
                    String role = row["role"].ToString();
                    Console.WriteLine(role);
                    switch (role)
                    {
                        case "Student":
                            {
                                User_dashbord.User_dashbord form = new User_dashbord.User_dashbord();
                                form.Show();
                                this.Hide();
                                break;
                            }
                        case "Admin":
                            {
                                Admin_dashbord.Admin_dashbord frm = new Admin_dashbord.Admin_dashbord();
                                frm.Show();
                                this.Hide();
                                break;
                            }
                    }

                }
                else
                {
                    MessageBox.Show("Please enter Correct Username and Password");
                    txtUsername.Focus();
                }
            }catch(SqlException msg)
            {
                MessageBox.Show("Error!!! \n Please Try agian later");
            }
            finally
            {
                con.Close();
            }
        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Login.RegistrationForm frm = new Login.RegistrationForm();
            frm.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
