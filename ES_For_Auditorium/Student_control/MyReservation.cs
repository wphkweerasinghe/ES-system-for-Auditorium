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
            //Show data from table
            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Lectuers\2nd year\2nd semester\ES\Final assigement\AuditoriumReservationDB.mdf';Integrated Security=True;Connect Timeout=30";
            String select = "SELECT reservation.id, event.name, reservation.seat_no FROM reservation, event WHERE reservation.event_id = event.id";

            SqlDataAdapter adapter = new SqlDataAdapter(select, conString);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "reservation_Details");
            dgvReservations.DataSource = ds.Tables["reservation_Details"];
        }
    }
}
