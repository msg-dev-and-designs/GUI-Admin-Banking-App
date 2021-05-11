
namespace BankOfPrometheus
{
    partial class ChangePasswordForm
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
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(159, 174);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.PasswordChar = '*';
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(289, 31);
            this.txtConfirmNewPassword.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Confirm New:";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(159, 69);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(289, 31);
            this.txtOldPassword.TabIndex = 2;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(159, 120);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(289, 31);
            this.txtNewPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "New:";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Blue;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(159, 231);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(108, 48);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Old:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PrimaSans BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 38);
            this.label1.TabIndex = 23;
            this.label1.Text = "Change Password";
            // 
            // AdminChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(458, 292);
            this.Controls.Add(this.txtConfirmNewPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.AdminChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}