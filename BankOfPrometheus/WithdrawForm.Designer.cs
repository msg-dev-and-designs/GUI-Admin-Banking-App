
namespace BankOfPrometheus
{
    partial class WithdrawForm
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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFromAccount = new System.Windows.Forms.ComboBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(115, 121);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(334, 31);
            this.txtAmount.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Amount :";
            // 
            // cmbFromAccount
            // 
            this.cmbFromAccount.FormattingEnabled = true;
            this.cmbFromAccount.Location = new System.Drawing.Point(115, 67);
            this.cmbFromAccount.Name = "cmbFromAccount";
            this.cmbFromAccount.Size = new System.Drawing.Size(334, 33);
            this.cmbFromAccount.TabIndex = 17;
            this.cmbFromAccount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchFromAccount);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.Blue;
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnWithdraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Location = new System.Drawing.Point(163, 174);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(114, 48);
            this.btnWithdraw.TabIndex = 16;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "From :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PrimaSans BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "Withdraw Money";
            // 
            // WithdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(458, 232);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFromAccount);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "WithdrawForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.AdminWithdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFromAccount;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}