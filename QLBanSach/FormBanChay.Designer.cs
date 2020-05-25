namespace QLBanSach
{
    partial class FormBanChay
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
            this.textbanchay = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH CÁC SÁCH BÁN CHẠY NĂM";
            // 
            // textbanchay
            // 
            this.textbanchay.Location = new System.Drawing.Point(773, 58);
            this.textbanchay.Name = "textbanchay";
            this.textbanchay.Size = new System.Drawing.Size(200, 22);
            this.textbanchay.TabIndex = 1;
            this.textbanchay.TextChanged += new System.EventHandler(this.Textbanchay_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSach,
            this.TenTL,
            this.TenSeries,
            this.TenDG,
            this.TenTG,
            this.TenNN,
            this.TiLe});
            this.dataGridView1.Location = new System.Drawing.Point(52, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(932, 341);
            this.dataGridView1.TabIndex = 2;
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 125;
            // 
            // TenTL
            // 
            this.TenTL.HeaderText = "Thể loại";
            this.TenTL.MinimumWidth = 6;
            this.TenTL.Name = "TenTL";
            this.TenTL.Width = 125;
            // 
            // TenSeries
            // 
            this.TenSeries.HeaderText = "Tập";
            this.TenSeries.MinimumWidth = 6;
            this.TenSeries.Name = "TenSeries";
            this.TenSeries.Width = 125;
            // 
            // TenDG
            // 
            this.TenDG.HeaderText = "Dịch giả";
            this.TenDG.MinimumWidth = 6;
            this.TenDG.Name = "TenDG";
            this.TenDG.Width = 125;
            // 
            // TenTG
            // 
            this.TenTG.HeaderText = "Tác giả";
            this.TenTG.MinimumWidth = 6;
            this.TenTG.Name = "TenTG";
            this.TenTG.Width = 125;
            // 
            // TenNN
            // 
            this.TenNN.HeaderText = "Ngôn ngữ";
            this.TenNN.MinimumWidth = 6;
            this.TenNN.Name = "TenNN";
            this.TenNN.Width = 125;
            // 
            // TiLe
            // 
            this.TiLe.HeaderText = "Số lượng bán / Số lượng nhập";
            this.TiLe.MinimumWidth = 6;
            this.TiLe.Name = "TiLe";
            this.TiLe.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(664, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "( Sách bán chạy tại cửa hàng khi số lượng bán/ số lượng nhập >10 )";
            // 
            // FormBanChay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1062, 643);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textbanchay);
            this.Controls.Add(this.label1);
            this.Name = "FormBanChay";
            this.Text = "Thống kê sách bán chạy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbanchay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiLe;
        private System.Windows.Forms.Label label2;
    }
}