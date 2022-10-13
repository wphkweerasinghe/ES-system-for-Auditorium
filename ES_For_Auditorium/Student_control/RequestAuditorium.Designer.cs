namespace ES_For_Auditorium.User_dashbord
{
    partial class RequestAuditorium
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
            this.panelRequest = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRequest
            // 
            this.panelRequest.Controls.Add(this.btnClear);
            this.panelRequest.Controls.Add(this.btnSubmit);
            this.panelRequest.Controls.Add(this.txtPrice);
            this.panelRequest.Controls.Add(this.label1);
            this.panelRequest.Controls.Add(this.txtDuration);
            this.panelRequest.Controls.Add(this.lblDuration);
            this.panelRequest.Controls.Add(this.txtTime);
            this.panelRequest.Controls.Add(this.lblTime);
            this.panelRequest.Controls.Add(this.dateTimePicker);
            this.panelRequest.Controls.Add(this.lblDate);
            this.panelRequest.Controls.Add(this.txtEventName);
            this.panelRequest.Controls.Add(this.lblEventName);
            this.panelRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRequest.Location = new System.Drawing.Point(0, 0);
            this.panelRequest.Name = "panelRequest";
            this.panelRequest.Size = new System.Drawing.Size(852, 462);
            this.panelRequest.TabIndex = 0;
            this.panelRequest.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRequest_Paint);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(426, 83);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(173, 76);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(201, 27);
            this.txtEventName.TabIndex = 1;
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(32, 83);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(100, 20);
            this.lblEventName.TabIndex = 0;
            this.lblEventName.Text = "Event Name";
            this.lblEventName.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(568, 74);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker.TabIndex = 3;
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(173, 146);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(201, 27);
            this.txtTime.TabIndex = 5;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(32, 153);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(46, 20);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time";
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(567, 146);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(201, 27);
            this.txtDuration.TabIndex = 7;
            this.txtDuration.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(426, 153);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(73, 20);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "Duration";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(173, 210);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(201, 27);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ticket Price";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(547, 328);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(221, 36);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit Request";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(212, 328);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(162, 36);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // RequestAuditorium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 462);
            this.Controls.Add(this.panelRequest);
            this.Name = "RequestAuditorium";
            this.Text = "RequestAuditorium";
            this.panelRequest.ResumeLayout(false);
            this.panelRequest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRequest;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
    }
}