using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_For_Auditorium.Admin_control
{
    public partial class EventList : UserControl
    {
        public EventList()
        {
            InitializeComponent();
        }

        #region Properties

        private String _title;
        private String _time;
        private String _date;
        private String _price;
        private Image _icon;
        private Color _iconBackColor;

        public String Title
        {
            get { return _title; }
            set { _title = value; lblEventTitle.Text = value; }
        }

        public String Time
        {
            get { return _time; }
            set { _time = value; lblEventTime.Text = value; }
        }

        public String Date
        {
            get { return _date; }
            set { _date = value; lblEventDate.Text = value; }
        }

        public String Price
        {
            get { return _price; }
            set { _price = value; lblEventPrice.Text = value; }
        }

        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; eventPic.Image = value; }
        }
        
        public Color IconBackColor
        {
            get { return _iconBackColor; }
            set { _iconBackColor = value; }
        }


        #endregion

        private void EventList_Load(object sender, EventArgs e)
        {

        }

        private void EventList_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void EventList_MouseHover(object sender, EventArgs e)
        {

        }

        private void EventList_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
