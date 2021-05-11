
namespace BankOfPrometheus
{
    partial class DepositForm
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
            this.cmbToAccount = new System.Windows.Forms.ComboBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbToAccount
            // 
            this.cmbToAccount.FormattingEnabled = true;
            this.cmbToAccount.Location = new System.Drawing.Point(112, 67);
            this.cmbToAccount.Name = "cmbToAccount";
            this.cmbToAccount.Size = new System.Drawing.Size(334, 33);
            this.cmbToAccount.TabIndex = 11;
            this.cmbToAccount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchToAccount);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.Blue;
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnDeposit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Location = new System.Drawing.Point(160, 174);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(108, 48);
            this.btnDeposit.TabIndex = 9;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "To :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PrimaSans BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Deposit Money";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Amount :";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(112, 121);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(334, 31);
            this.txtAmount.TabIndex = 13;
            // 
            // AdminDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(458, 232);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbToAccount);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.AdminDeposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbToAccount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
    }
}