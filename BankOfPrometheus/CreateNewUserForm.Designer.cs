
namespace BankOfPrometheus
{
    partial class CreateNewUserForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Role:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(185, 124);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(262, 31);
            this.txtPassword.TabIndex = 38;
            this.txtPassword.Text = "123456789";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(185, 73);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(262, 31);
            this.txtUserName.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Username:";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Blue;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(12, 237);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(435, 48);
            this.btnCreate.TabIndex = 34;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PrimaSans BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 38);
            this.label1.TabIndex = 32;
            this.label1.Text = "Create New User";
            // 
            // cmbRole
            // 
            this.cmbRole.BackColor = System.Drawing.Color.White;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Select Role",
            "Admin",
            "Manager",
            "Employee"});
            this.cmbRole.Location = new System.Drawing.Point(185, 176);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(261, 33);
            this.cmbRole.TabIndex = 41;
            this.cmbRole.Tag = "";
            // 
            // AdminCreateNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(458, 301);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminCreateNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create User";
            this.Load += new System.EventHandler(this.AdminCreateNewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRole;
    }
}