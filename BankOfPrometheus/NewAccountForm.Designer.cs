
namespace BankOfPrometheus
{
    partial class NewAccountForm
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAccoutType = new System.Windows.Forms.Label();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(185, 127);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(262, 31);
            this.txtFirstName.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "First Name:";
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Blue;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(17, 438);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(429, 48);
            this.btnOpen.TabIndex = 22;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PrimaSans BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "Open New Account";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(185, 178);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(262, 31);
            this.txtLastName.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Last Name:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(185, 232);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(262, 31);
            this.txtPhoneNumber.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Phone Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(185, 281);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(262, 135);
            this.txtAddress.TabIndex = 31;
            // 
            // lblAccoutType
            // 
            this.lblAccoutType.AutoSize = true;
            this.lblAccoutType.Location = new System.Drawing.Point(24, 81);
            this.lblAccoutType.Name = "lblAccoutType";
            this.lblAccoutType.Size = new System.Drawing.Size(150, 25);
            this.lblAccoutType.TabIndex = 32;
            this.lblAccoutType.Text = "Account Type:";
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Items.AddRange(new object[] {
            "Chequing",
            "Credit"});
            this.cmbAccountType.Location = new System.Drawing.Point(185, 78);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(261, 33);
            this.cmbAccountType.TabIndex = 33;
            // 
            // AdminOpenNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(458, 505);
            this.Controls.Add(this.cmbAccountType);
            this.Controls.Add(this.lblAccoutType);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminOpenNewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Account";
            this.Load += new System.EventHandler(this.AdminOpenNewAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAccoutType;
        private System.Windows.Forms.ComboBox cmbAccountType;
    }
}