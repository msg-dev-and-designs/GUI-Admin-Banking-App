
namespace BankOfPrometheus
{
    partial class TransactionsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTransId = new System.Windows.Forms.TextBox();
            this.cmbTransactionType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtTransId
            // 
            this.txtTransId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransId.Location = new System.Drawing.Point(13, 21);
            this.txtTransId.Name = "txtTransId";
            this.txtTransId.Size = new System.Drawing.Size(272, 31);
            this.txtTransId.TabIndex = 1;
            this.txtTransId.TextChanged += new System.EventHandler(this.txtTransId_TextChanged);
            // 
            // cmbTransactionType
            // 
            this.cmbTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTransactionType.FormattingEnabled = true;
            this.cmbTransactionType.Items.AddRange(new object[] {
            "All",
            "Cr",
            "Dr"});
            this.cmbTransactionType.Location = new System.Drawing.Point(551, 21);
            this.cmbTransactionType.Name = "cmbTransactionType";
            this.cmbTransactionType.Size = new System.Drawing.Size(82, 33);
            this.cmbTransactionType.TabIndex = 2;
            this.cmbTransactionType.SelectedIndexChanged += new System.EventHandler(this.cmbTransactionType_SelectedIndexChanged);
            // 
            // TransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(645, 398);
            this.Controls.Add(this.cmbTransactionType);
            this.Controls.Add(this.txtTransId);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TransactionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminTransactions";
            this.Load += new System.EventHandler(this.AdminTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTransId;
        private System.Windows.Forms.ComboBox cmbTransactionType;
    }
}