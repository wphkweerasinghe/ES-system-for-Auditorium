namespace ES_For_Auditorium.Admin_dashbord
{
    partial class MyProfile
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
            this.lblTittle = new System.Windows.Forms.Label();
            this.PanelTittle = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.ComRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtCreatePass = new System.Windows.Forms.TextBox();
            this.lblCreatePassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.PanelTittle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(327, 26);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(172, 38);
            this.lblTittle.TabIndex = 1;
            this.lblTittle.Text = "My Profile";
            // 
            // PanelTittle
            // 
            this.PanelTittle.Controls.Add(this.lblTittle);
            this.PanelTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTittle.Location = new System.Drawing.Point(0, 0);
            this.PanelTittle.Name = "PanelTittle";
            this.PanelTittle.Size = new System.Drawing.Size(851, 100);
            this.PanelTittle.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ComRole);
            this.panel1.Controls.Add(this.lblRole);
            this.panel1.Controls.Add(this.txtConfirmPass);
            this.panel1.Controls.Add(this.lblConfirmPass);
            this.panel1.Controls.Add(this.txtCreatePass);
            this.panel1.Controls.Add(this.lblCreatePassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.txtStudentId);
            this.panel1.Controls.Add(this.lblStudentId);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 518);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 100);
            this.panel2.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(592, 33);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 30);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(262, 33);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 30);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Log Out";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // ComRole
            // 
            this.ComRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComRole.FormattingEnabled = true;
            this.ComRole.Items.AddRange(new object[] {
            "Student",
            "Admin",
            "MIC",
            "Top Manager"});
            this.ComRole.Location = new System.Drawing.Point(170, 341);
            this.ComRole.Name = "ComRole";
            this.ComRole.Size = new System.Drawing.Size(207, 28);
            this.ComRole.TabIndex = 30;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(167, 301);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(76, 16);
            this.lblRole.TabIndex = 29;
            this.lblRole.Text = "User Role *";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.Location = new System.Drawing.Point(476, 237);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(207, 27);
            this.txtConfirmPass.TabIndex = 28;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Location = new System.Drawing.Point(473, 208);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(123, 16);
            this.lblConfirmPass.TabIndex = 27;
            this.lblConfirmPass.Text = "Confirm Password *";
            // 
            // txtCreatePass
            // 
            this.txtCreatePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatePass.Location = new System.Drawing.Point(170, 237);
            this.txtCreatePass.Name = "txtCreatePass";
            this.txtCreatePass.Size = new System.Drawing.Size(207, 27);
            this.txtCreatePass.TabIndex = 26;
            this.txtCreatePass.UseSystemPasswordChar = true;
            // 
            // lblCreatePassword
            // 
            this.lblCreatePassword.AutoSize = true;
            this.lblCreatePassword.Location = new System.Drawing.Point(167, 208);
            this.lblCreatePassword.Name = "lblCreatePassword";
            this.lblCreatePassword.Size = new System.Drawing.Size(118, 16);
            this.lblCreatePassword.TabIndex = 25;
            this.lblCreatePassword.Text = "Create Password *";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(476, 151);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(207, 27);
            this.txtUsername.TabIndex = 24;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(473, 122);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 16);
            this.lblUsername.TabIndex = 23;
            this.lblUsername.Text = "Username *";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentId.Location = new System.Drawing.Point(170, 151);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(207, 27);
            this.txtStudentId.TabIndex = 22;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(167, 122);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(68, 16);
            this.lblStudentId.TabIndex = 21;
            this.lblStudentId.Text = "Student ID";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(476, 61);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 27);
            this.txtEmail.TabIndex = 20;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(473, 32);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 16);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email *";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(170, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 27);
            this.txtName.TabIndex = 18;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(167, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 16);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name *";
            // 
            // MyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelTittle);
            this.Name = "MyProfile";
            this.Text = "MyProfile";
            this.Load += new System.EventHandler(this.MyProfile_Load);
            this.PanelTittle.ResumeLayout(false);
            this.PanelTittle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Panel PanelTittle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ComRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.TextBox txtCreatePass;
        private System.Windows.Forms.Label lblCreatePassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
    }
}