using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_For_Auditorium.User_dashbord
{
    public partial class MyReservation : Form
    {
        public MyReservation()
        {
            InitializeComponent();
            ShowReservations();
        }
        public void ShowReservations()
        {
            int user_id = int.Parse(Login.Form_login.id);
            Console.WriteLine(user_id);
            //Show data from table
            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Lectuers\2nd year\2nd semester\ES\Final assigement\AuditoriumReservationDB.mdf';Integrated Security=True;Connect Timeout=30";
            String select = "SELECT reservation.id, event.name, reservation.seat_no, users.username, event.time, event.date FROM reservation INNER JOIN event ON reservation.event_id = event.id INNER JOIN users ON reservation.user_id = users.id WHERE reservation.user_id = '" + user_id + "'";

            SqlDataAdapter adapter = new SqlDataAdapter(select, conString);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "reservation_Details");
            dgvReservations.DataSource = ds.Tables["reservation_Details"];
        }

        private void dgvReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvReservations.CurrentRow.Cells[0].Value.ToString();
            txtEventName.Text = dgvReservations.CurrentRow.Cells[1].Value.ToString();
            txtSeat.Text = dgvReservations.CurrentRow.Cells[2].Value.ToString();
            txtUsername.Text = dgvReservations.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = txtID.Text + "\n" +
                txtEventName.Text + "\n" +
                txtSeat.Text + "\n" +
                txtUsername.Text;
            GenerateQR(data);
        }

        public void GenerateQR(string data)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            pictureBoxQR.Image = qrCode.GetGraphic(20);
        }
    }
}
