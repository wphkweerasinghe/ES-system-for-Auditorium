﻿namespace ES_For_Auditorium.Admin_dashbord
{
    partial class MyProfile_Admin
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
            this.panel_container = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.ComRole = new System.Windows.Forms.ComboBox();
            this.btnLogout = new System.Windows.Forms.Button();
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
            this.panel_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_container
            // 
            this.panel_container.Controls.Add(this.btnUpdate);
            this.panel_container.Controls.Add(this.ComRole);
            this.panel_container.Controls.Add(this.btnLogout);
            this.panel_container.Controls.Add(this.lblRole);
            this.panel_container.Controls.Add(this.txtConfirmPass);
            this.panel_container.Controls.Add(this.lblConfirmPass);
            this.panel_container.Controls.Add(this.txtCreatePass);
            this.panel_container.Controls.Add(this.lblCreatePassword);
            this.panel_container.Controls.Add(this.txtUsername);
            this.panel_container.Controls.Add(this.lblUsername);
            this.panel_container.Controls.Add(this.txtStudentId);
            this.panel_container.Controls.Add(this.lblStudentId);
            this.panel_container.Controls.Add(this.txtEmail);
            this.panel_container.Controls.Add(this.lblEmail);
            this.panel_container.Controls.Add(this.txtName);
            this.panel_container.Controls.Add(this.lblName);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 0);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(845, 513);
            this.panel_container.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(592, 402);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 40);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(262, 402);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 40);
            this.btnLogout.TabIndex = 31;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            // MyProfile_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 513);
            this.Controls.Add(this.panel_container);
            this.Name = "MyProfile_Admin";
            this.Text = "MyProfile";
            this.Load += new System.EventHandler(this.MyProfile_Load);
            this.panel_container.ResumeLayout(false);
            this.panel_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_container;
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnLogout;
    }
}