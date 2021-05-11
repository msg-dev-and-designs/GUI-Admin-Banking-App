
namespace BankOfPrometheus
{
    partial class ManageUserForm
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
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Select Role",
            "Admin",
            "Manager",
            "Employee"});
            this.cmbRole.Location = new System.Drawing.Point(180, 135);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(261, 33);
            this.cmbRole.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Role:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Username:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Blue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(213, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(228, 48);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PrimaSans BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 38);
            this.label1.TabIndex = 42;
            this.label1.Text = "Manage User";
            // 
            // cmbUserName
            // 
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(180, 87);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(261, 33);
            this.cmbUserName.TabIndex = 51;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUserName_SelectedIndexChanged);
            this.cmbUserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchUser);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Blue;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(12, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(181, 48);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AdminManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(458, 249);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbUserName);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminManageUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager User";
            this.Load += new System.EventHandler(this.AdminManageUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Button btnDelete;
    }
}