﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ES_For_Auditorium.Login
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEmail.Clear();
            txtStudentId.Clear();
            txtUsername.Clear();
            txtCreatePass.Clear();
            txtConfirmPass.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //create local variables for entered data
            String name = txtName.Text;
            String email = txtEmail.Text;
            String stuId = txtStudentId.Text;
            String username = txtUsername.Text;
            String createPass = txtCreatePass.Text;
            String confirmPass = txtConfirmPass.Text;
            String role = ComRole.Text;
            int studentId = 0;

            //data validation of form
            if (name == null)
            {
                MessageBox.Show("Please enter your Name");
                txtName.Focus();
            }
            if (email == null || !email.ToLower().Contains('@'))
            {
                MessageBox.Show("Please enter vaild Email");
                txtEmail.Focus();
            }
            if (stuId == null)
            {
                MessageBox.Show("Please enter your Student ID");
                txtStudentId.Focus();
                try
                {
                    studentId = Convert.ToInt32(stuId);
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message);
                    txtStudentId.Focus();
                }
            }
            if (username == null)
            {
                MessageBox.Show("Please enter your Username");
                txtUsername.Focus();
            }
            if (createPass == null)
            {
                MessageBox.Show("Please enter your Password ");
                txtCreatePass.Focus();
                if(createPass != confirmPass)
                {
                    MessageBox.Show("Passwords are not matching");
                    txtConfirmPass.Focus();
                }
            }
            if (role == null)
            {
                MessageBox.Show("Please select your Role");
            }

            //Insert data into database
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Lectuers\2nd year\2nd semester\ES\Final assigement\AuditoriumReservationDB.mdf';Integrated Security=True;Connect Timeout=30");
            string query = "INSERT INTO users (name,email,student_id,username,password,role) VALUES('" + name + "','" + email + "','" + studentId + "','" + username + "','" + confirmPass + "','" + role + "' );";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("You are succesfully Registered !!!");
            }
            catch(SqlException msg)
            {
                MessageBox.Show("Error!!!\n Please Try agian later");
                Console.WriteLine(msg.Message);
            }
            finally
            {
                con.Close();
            }
            Form_login frm = new Form_login();
            frm.Show();
            this.Close();
        }
    }
}
