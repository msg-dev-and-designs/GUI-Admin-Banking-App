
namespace BankOfPrometheus
{
    partial class ManageAccountForm
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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAccountType = new System.Windows.Forms.TextBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(185, 332);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(262, 135);
            this.txtAddress.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "Address:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(185, 283);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(262, 31);
            this.txtPhoneNumber.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Phone Number:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(185, 229);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(262, 31);
            this.txtLastName.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(185, 178);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(262, 31);
            this.txtFirstName.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "First Name:";
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.BackColor = System.Drawing.Color.Blue;
            this.btnDeactivate.FlatAppearance.BorderSize = 0;
            this.btnDeactivate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnDeactivate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeactivate.ForeColor = System.Drawing.Color.White;
            this.btnDeactivate.Location = new System.Drawing.Point(21, 482);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(156, 48);
            this.btnDeactivate.TabIndex = 34;
            this.btnDeactivate.Text = "De-activate";
            this.btnDeactivate.UseVisualStyleBackColor = false;
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
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
            this.label1.Location = new System.Drawing.Point(87, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 38);
            this.label1.TabIndex = 32;
            this.label1.Text = "Manage Account";
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.BackColor = System.Drawing.Color.Blue;
            this.btnUpdateAccount.FlatAppearance.BorderSize = 0;
            this.btnUpdateAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnUpdateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAccount.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAccount.Location = new System.Drawing.Point(189, 482);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(258, 48);
            this.btnUpdateAccount.TabIndex = 43;
            this.btnUpdateAccount.Text = "Update";
            this.btnUpdateAccount.UseVisualStyleBackColor = false;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(184, 79);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(262, 31);
            this.txtAccountNumber.TabIndex = 45;
            this.txtAccountNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchAccount);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 25);
            this.label7.TabIndex = 44;
            this.label7.Text = "Account Number:";
            // 
            // txtAccountType
            // 
            this.txtAccountType.Location = new System.Drawing.Point(185, 127);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.ReadOnly = true;
            this.txtAccountType.Size = new System.Drawing.Size(262, 31);
            this.txtAccountType.TabIndex = 47;
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(29, 130);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(150, 25);
            this.lblAccountType.TabIndex = 46;
            this.lblAccountType.Text = "Account Type:";
            // 
            // ManageAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(458, 559);
            this.Controls.Add(this.txtAccountType);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnUpdateAccount);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeactivate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ManageAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Account";
            this.Load += new System.EventHandler(this.AdminManageAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAccountType;
        private System.Windows.Forms.Label lblAccountType;
    }
}