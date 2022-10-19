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

namespace ES_For_Auditorium.Admin_dashbord
{
    public partial class Admin_dashbord : Form
    {
        //Filds
        private Button currentButton;
        private Form activeForm;
        public Admin_dashbord()
        {
            InitializeComponent();
            lblUsername.Text = Form_login.uname;
        }
        private void ActivateButton(Object btnSender)
        {
            if (btnSender == null)
            {
                if (currentButton != (Button)btnSender)
                {
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.White;
                }
            }
        }
        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            { activeForm.Close(); }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(childForm);
            this.panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnEventCalender_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EventCalender(), sender);
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RequestsForBookingAuditorium(), sender);
        }

        private void btnAcceptedRequests_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AcceptedRequests(), sender);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MyProfile_Admin(), sender);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            
        }
    }
}
