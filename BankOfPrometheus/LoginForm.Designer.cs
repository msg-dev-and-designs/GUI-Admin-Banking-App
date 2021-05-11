
namespace BankOfPrometheus
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.headingLabel = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.Teal;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.Silver;
            this.tbPassword.Location = new System.Drawing.Point(377, 121);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(223, 28);
            this.tbPassword.TabIndex = 14;
            this.tbPassword.Text = "password";
            this.tbPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clearTextBox);
            this.tbPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Logging);
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.Teal;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.Silver;
            this.tbUsername.Location = new System.Drawing.Point(377, 66);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(223, 28);
            this.tbUsername.TabIndex = 13;
            this.tbUsername.Text = "username";
            this.tbUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clearTextBox);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.headingLabel);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 312);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(91, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 164);
            this.label2.TabIndex = 1;
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("PrimaSans BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(3, 34);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(350, 38);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "Bank of Prometheus";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLogin.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogin.Location = new System.Drawing.Point(404, 195);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(168, 40);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "------------------------------------------------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "------------------------------------------------------------------------";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(600, 306);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}