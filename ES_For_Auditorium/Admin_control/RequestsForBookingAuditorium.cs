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
    public partial class RequestsForBookingAuditorium : Form
    {
        public RequestsForBookingAuditorium()
        {
            InitializeComponent();
            //Show data from table
            String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Lectuers\2nd year\2nd semester\ES\Final assigement\AuditoriumReservationDB.mdf';Integrated Security=True;Connect Timeout=30";
            String select = "SELECT * FROM event";

            SqlDataAdapter adapter = new SqlDataAdapter(select,conString);
            DataSet ds = new DataSet();

            adapter.Fill(ds,"event_Details");
            dgvEvent.DataSource = ds.Tables["event_Details"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvEvent.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvEvent.CurrentRow.Cells[1].Value.ToString();
            txtTime.Text = dgvEvent.CurrentRow.Cells[2].Value.ToString();
            txtDate.Text = dgvEvent.CurrentRow.Cells[3].Value.ToString();
            txtDuration.Text = dgvEvent.CurrentRow.Cells[4].Value.ToString();
            txtPrice.Text = dgvEvent.CurrentRow.Cells[8].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
