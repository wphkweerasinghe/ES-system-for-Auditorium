namespace ES_For_Auditorium.Admin_control
{
    partial class EventList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.eventPic = new System.Windows.Forms.PictureBox();
            this.lblEventTitle = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblEventTime = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEventPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconBackPanel = new System.Windows.Forms.Panel();
            this.panelShadow = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.eventPic)).BeginInit();
            this.iconBackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventPic
            // 
            this.eventPic.Location = new System.Drawing.Point(30, 37);
            this.eventPic.Name = "eventPic";
            this.eventPic.Size = new System.Drawing.Size(100, 100);
            this.eventPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eventPic.TabIndex = 0;
            this.eventPic.TabStop = false;
            // 
            // lblEventTitle
            // 
            this.lblEventTitle.Font = new System.Drawing.Font("Algerian", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventTitle.Location = new System.Drawing.Point(187, 37);
            this.lblEventTitle.Name = "lblEventTitle";
            this.lblEventTitle.Size = new System.Drawing.Size(533, 31);
            this.lblEventTitle.TabIndex = 1;
            this.lblEventTitle.Text = "Event Title";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(188, 80);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(56, 20);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time :";
            // 
            // lblEventTime
            // 
            this.lblEventTime.AutoSize = true;
            this.lblEventTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventTime.Location = new System.Drawing.Point(250, 80);
            this.lblEventTime.Name = "lblEventTime";
            this.lblEventTime.Size = new System.Drawing.Size(84, 20);
            this.lblEventTime.TabIndex = 3;
            this.lblEventTime.Text = "Time here";
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDate.Location = new System.Drawing.Point(554, 80);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(83, 20);
            this.lblEventDate.TabIndex = 5;
            this.lblEventDate.Text = "Date here";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(492, 80);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(55, 20);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date :";
            // 
            // lblEventPrice
            // 
            this.lblEventPrice.AutoSize = true;
            this.lblEventPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventPrice.Location = new System.Drawing.Point(302, 117);
            this.lblEventPrice.Name = "lblEventPrice";
            this.lblEventPrice.Size = new System.Drawing.Size(96, 20);
            this.lblEventPrice.TabIndex = 7;
            this.lblEventPrice.Text = "Price here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ticket Price :";
            // 
            // iconBackPanel
            // 
            this.iconBackPanel.BackColor = System.Drawing.Color.Teal;
            this.iconBackPanel.Controls.Add(this.panelShadow);
            this.iconBackPanel.Controls.Add(this.eventPic);
            this.iconBackPanel.Location = new System.Drawing.Point(0, 0);
            this.iconBackPanel.Name = "iconBackPanel";
            this.iconBackPanel.Size = new System.Drawing.Size(172, 173);
            this.iconBackPanel.TabIndex = 8;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.Silver;
            this.panelShadow.Location = new System.Drawing.Point(30, 175);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(769, 10);
            this.panelShadow.TabIndex = 1;
            // 
            // EventList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconBackPanel);
            this.Controls.Add(this.lblEventPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblEventTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblEventTitle);
            this.Name = "EventList";
            this.Size = new System.Drawing.Size(829, 173);
            this.Load += new System.EventHandler(this.EventList_Load);
            this.MouseEnter += new System.EventHandler(this.EventList_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.EventList_MouseLeave);
            this.MouseHover += new System.EventHandler(this.EventList_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.eventPic)).EndInit();
            this.iconBackPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox eventPic;
        private System.Windows.Forms.Label lblEventTitle;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblEventTime;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEventPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel iconBackPanel;
        private System.Windows.Forms.Panel panelShadow;
    }
}
