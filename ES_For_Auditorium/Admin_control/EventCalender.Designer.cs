namespace ES_For_Auditorium.Admin_dashbord
{
    partial class EventCalender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelEventList = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelEventList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEventList
            // 
            this.panelEventList.AutoScroll = true;
            this.panelEventList.AutoSize = true;
            this.panelEventList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelEventList.Controls.Add(this.flowLayoutPanel1);
            this.panelEventList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEventList.Location = new System.Drawing.Point(0, 0);
            this.panelEventList.Name = "panelEventList";
            this.panelEventList.Size = new System.Drawing.Size(1102, 653);
            this.panelEventList.TabIndex = 0;
            this.panelEventList.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEventList_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1102, 653);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // EventCalender
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1102, 653);
            this.Controls.Add(this.panelEventList);
            this.MinimumSize = new System.Drawing.Size(1120, 700);
            this.Name = "EventCalender";
            this.Text = "EventCalender";
            this.Load += new System.EventHandler(this.EventCalender_Load);
            this.panelEventList.ResumeLayout(false);
            this.panelEventList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEventList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}