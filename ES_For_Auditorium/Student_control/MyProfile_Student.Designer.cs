namespace ES_For_Auditorium.User_dashbord
{
    partial class MyProfile_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyProfile_Student));
            this.panelContainer = new System.Windows.Forms.Panel();
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
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContainer.BackgroundImage")));
            this.panelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContainer.Controls.Add(this.btnUpdate);
            this.panelContainer.Controls.Add(this.ComRole);
            this.panelContainer.Controls.Add(this.btnLogout);
            this.panelContainer.Controls.Add(this.lblRole);
            this.panelContainer.Controls.Add(this.txtConfirmPass);
            this.panelContainer.Controls.Add(this.lblConfirmPass);
            this.panelContainer.Controls.Add(this.txtCreatePass);
            this.panelContainer.Controls.Add(this.lblCreatePassword);
            this.panelContainer.Controls.Add(this.txtUsername);
            this.panelContainer.Controls.Add(this.lblUsername);
            this.panelContainer.Controls.Add(this.txtStudentId);
            this.panelContainer.Controls.Add(this.lblStudentId);
            this.panelContainer.Controls.Add(this.txtEmail);
            this.panelContainer.Controls.Add(this.lblEmail);
            this.panelContainer.Controls.Add(this.txtName);
            this.panelContainer.Controls.Add(this.lblName);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(732, 533);
            this.panelContainer.TabIndex = 2;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(543, 431);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 40);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ComRole
            // 
            this.ComRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComRole.FormattingEnabled = true;
            this.ComRole.Items.AddRange(new object[] {
            "Student",
            "Admin",
            "MIC",
            "Top Manager"});
            this.ComRole.Location = new System.Drawing.Point(121, 370);
            this.ComRole.Name = "ComRole";
            this.ComRole.Size = new System.Drawing.Size(207, 28);
            this.ComRole.TabIndex = 46;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(213, 431);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 40);
            this.btnLogout.TabIndex = 47;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblRole
            // 
            this.lblRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(118, 330);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(76, 16);
            this.lblRole.TabIndex = 45;
            this.lblRole.Text = "User Role *";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.Location = new System.Drawing.Point(427, 266);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(207, 27);
            this.txtConfirmPass.TabIndex = 44;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Location = new System.Drawing.Point(424, 237);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(123, 16);
            this.lblConfirmPass.TabIndex = 43;
            this.lblConfirmPass.Text = "Confirm Password *";
            // 
            // txtCreatePass
            // 
            this.txtCreatePass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCreatePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatePass.Location = new System.Drawing.Point(121, 266);
            this.txtCreatePass.Name = "txtCreatePass";
            this.txtCreatePass.Size = new System.Drawing.Size(207, 27);
            this.txtCreatePass.TabIndex = 42;
            this.txtCreatePass.UseSystemPasswordChar = true;
            // 
            // lblCreatePassword
            // 
            this.lblCreatePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCreatePassword.AutoSize = true;
            this.lblCreatePassword.Location = new System.Drawing.Point(118, 237);
            this.lblCreatePassword.Name = "lblCreatePassword";
            this.lblCreatePassword.Size = new System.Drawing.Size(118, 16);
            this.lblCreatePassword.TabIndex = 41;
            this.lblCreatePassword.Text = "Create Password *";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(427, 180);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(207, 27);
            this.txtUsername.TabIndex = 40;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(424, 151);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 16);
            this.lblUsername.TabIndex = 39;
            this.lblUsername.Text = "Username *";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentId.Location = new System.Drawing.Point(121, 180);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(207, 27);
            this.txtStudentId.TabIndex = 38;
            // 
            // lblStudentId
            // 
            this.lblStudentId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(118, 151);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(68, 16);
            this.lblStudentId.TabIndex = 37;
            this.lblStudentId.Text = "Student ID";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(427, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 27);
            this.txtEmail.TabIndex = 36;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(424, 61);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 16);
            this.lblEmail.TabIndex = 35;
            this.lblEmail.Text = "Email *";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(121, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 27);
            this.txtName.TabIndex = 34;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(118, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 16);
            this.lblName.TabIndex = 33;
            this.lblName.Text = "Name *";
            // 
            // MyProfile_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(732, 533);
            this.Controls.Add(this.panelContainer);
            this.MinimumSize = new System.Drawing.Size(750, 580);
            this.Name = "MyProfile_Student";
            this.Text = "MyProfile";
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox ComRole;
        private System.Windows.Forms.Button btnLogout;
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
    }
}