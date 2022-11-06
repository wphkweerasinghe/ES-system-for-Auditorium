namespace ES_For_Auditorium.Admin_dashbord
{
    partial class AcceptedRequests
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
            this.dgvAccepted = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccepted)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAccepted
            // 
            this.dgvAccepted.AllowUserToAddRows = false;
            this.dgvAccepted.AllowUserToDeleteRows = false;
            this.dgvAccepted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAccepted.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAccepted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccepted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccepted.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAccepted.Location = new System.Drawing.Point(0, 0);
            this.dgvAccepted.Name = "dgvAccepted";
            this.dgvAccepted.ReadOnly = true;
            this.dgvAccepted.RowHeadersWidth = 51;
            this.dgvAccepted.RowTemplate.Height = 24;
            this.dgvAccepted.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccepted.Size = new System.Drawing.Size(800, 450);
            this.dgvAccepted.TabIndex = 0;
            // 
            // AcceptedRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAccepted);
            this.Name = "AcceptedRequests";
            this.Text = "AcceptedRequests";
            this.Load += new System.EventHandler(this.AcceptedRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccepted)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAccepted;
    }
}