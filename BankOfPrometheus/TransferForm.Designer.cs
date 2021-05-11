
namespace BankOfPrometheus
{
    partial class TransferForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.cmbFromAccount = new System.Windows.Forms.ComboBox();
            this.cmbToAccount = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PrimaSans BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transfer Money";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "From :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "To :";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Blue;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnTransfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(163, 219);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(108, 48);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // cmbFromAccount
            // 
            this.cmbFromAccount.FormattingEnabled = true;
            this.cmbFromAccount.Location = new System.Drawing.Point(112, 62);
            this.cmbFromAccount.Name = "cmbFromAccount";
            this.cmbFromAccount.Size = new System.Drawing.Size(334, 33);
            this.cmbFromAccount.TabIndex = 4;
            this.cmbFromAccount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchFromAccount);
            // 
            // cmbToAccount
            // 
            this.cmbToAccount.FormattingEnabled = true;
            this.cmbToAccount.Location = new System.Drawing.Point(112, 111);
            this.cmbToAccount.Name = "cmbToAccount";
            this.cmbToAccount.Size = new System.Drawing.Size(334, 33);
            this.cmbToAccount.TabIndex = 5;
            this.cmbToAccount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchToAccount);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(112, 165);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(334, 31);
            this.txtAmount.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Amount :";
            // 
            // AdminTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(458, 281);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbToAccount);
            this.Controls.Add(this.cmbFromAccount);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AdminTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.AdminTransfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.ComboBox cmbFromAccount;
        private System.Windows.Forms.ComboBox cmbToAccount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label4;
    }
}