namespace QLBanSach
{
    partial class FormDichGia
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hienThiDichGia = new System.Windows.Forms.Button();
            this.textTenDG = new System.Windows.Forms.TextBox();
            this.dataGridViewDichGia = new System.Windows.Forms.DataGridView();
            this.textMaDG = new System.Windows.Forms.TextBox();
            this.timDichGia = new System.Windows.Forms.Button();
            this.themDichGia = new System.Windows.Forms.Button();
            this.xoaDichGia = new System.Windows.Forms.Button();
            this.suaDichGia = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDichGia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(810, 561);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.hienThiDichGia);
            this.groupBox1.Controls.Add(this.textTenDG);
            this.groupBox1.Controls.Add(this.dataGridViewDichGia);
            this.groupBox1.Controls.Add(this.textMaDG);
            this.groupBox1.Controls.Add(this.timDichGia);
            this.groupBox1.Controls.Add(this.themDichGia);
            this.groupBox1.Controls.Add(this.xoaDichGia);
            this.groupBox1.Controls.Add(this.suaDichGia);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(2, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 535);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.label5.Location = new System.Drawing.Point(27, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên dịch giả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.label6.Location = new System.Drawing.Point(27, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mã dịch giả";
            // 
            // hienThiDichGia
            // 
            this.hienThiDichGia.BackColor = System.Drawing.Color.LightSalmon;
            this.hienThiDichGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hienThiDichGia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hienThiDichGia.Location = new System.Drawing.Point(689, 22);
            this.hienThiDichGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hienThiDichGia.Name = "hienThiDichGia";
            this.hienThiDichGia.Size = new System.Drawing.Size(92, 43);
            this.hienThiDichGia.TabIndex = 10;
            this.hienThiDichGia.Text = "Reset";
            this.hienThiDichGia.UseVisualStyleBackColor = false;
            this.hienThiDichGia.Click += new System.EventHandler(this.hienThiDichGia_Click_1);
            // 
            // textTenDG
            // 
            this.textTenDG.Location = new System.Drawing.Point(155, 96);
            this.textTenDG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textTenDG.Name = "textTenDG";
            this.textTenDG.Size = new System.Drawing.Size(283, 29);
            this.textTenDG.TabIndex = 3;
            // 
            // dataGridViewDichGia
            // 
            this.dataGridViewDichGia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewDichGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDichGia.Location = new System.Drawing.Point(31, 184);
            this.dataGridViewDichGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewDichGia.Name = "dataGridViewDichGia";
            this.dataGridViewDichGia.RowHeadersWidth = 51;
            this.dataGridViewDichGia.RowTemplate.Height = 24;
            this.dataGridViewDichGia.Size = new System.Drawing.Size(753, 264);
            this.dataGridViewDichGia.TabIndex = 9;
            this.dataGridViewDichGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDichGia_CellContentClick_1);
            // 
            // textMaDG
            // 
            this.textMaDG.Location = new System.Drawing.Point(155, 25);
            this.textMaDG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textMaDG.Name = "textMaDG";
            this.textMaDG.Size = new System.Drawing.Size(283, 29);
            this.textMaDG.TabIndex = 4;
            // 
            // timDichGia
            // 
            this.timDichGia.BackColor = System.Drawing.Color.LightSalmon;
            this.timDichGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timDichGia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.timDichGia.Location = new System.Drawing.Point(576, 87);
            this.timDichGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timDichGia.Name = "timDichGia";
            this.timDichGia.Size = new System.Drawing.Size(82, 43);
            this.timDichGia.TabIndex = 8;
            this.timDichGia.Text = "Tìm kiếm";
            this.timDichGia.UseVisualStyleBackColor = false;
            this.timDichGia.Click += new System.EventHandler(this.timDichGia_Click_1);
            // 
            // themDichGia
            // 
            this.themDichGia.BackColor = System.Drawing.Color.LightSalmon;
            this.themDichGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themDichGia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.themDichGia.Location = new System.Drawing.Point(467, 23);
            this.themDichGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.themDichGia.Name = "themDichGia";
            this.themDichGia.Size = new System.Drawing.Size(82, 41);
            this.themDichGia.TabIndex = 5;
            this.themDichGia.Text = "Thêm";
            this.themDichGia.UseVisualStyleBackColor = false;
            this.themDichGia.Click += new System.EventHandler(this.themDichGia_Click_1);
            // 
            // xoaDichGia
            // 
            this.xoaDichGia.BackColor = System.Drawing.Color.LightSalmon;
            this.xoaDichGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaDichGia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.xoaDichGia.Location = new System.Drawing.Point(576, 22);
            this.xoaDichGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xoaDichGia.Name = "xoaDichGia";
            this.xoaDichGia.Size = new System.Drawing.Size(82, 41);
            this.xoaDichGia.TabIndex = 7;
            this.xoaDichGia.Text = "Xóa";
            this.xoaDichGia.UseVisualStyleBackColor = false;
            this.xoaDichGia.Click += new System.EventHandler(this.xoaDichGia_Click_1);
            // 
            // suaDichGia
            // 
            this.suaDichGia.BackColor = System.Drawing.Color.LightSalmon;
            this.suaDichGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaDichGia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.suaDichGia.Location = new System.Drawing.Point(465, 86);
            this.suaDichGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.suaDichGia.Name = "suaDichGia";
            this.suaDichGia.Size = new System.Drawing.Size(85, 43);
            this.suaDichGia.TabIndex = 6;
            this.suaDichGia.Text = "Sửa";
            this.suaDichGia.UseVisualStyleBackColor = false;
            this.suaDichGia.Click += new System.EventHandler(this.suaDichGia_Click_1);
            // 
            // FormDichGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(810, 561);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDichGia";
            this.Text = "FormDichGia";
            this.Load += new System.EventHandler(this.FormDichGia_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDichGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button hienThiDichGia;
        private System.Windows.Forms.DataGridView dataGridViewDichGia;
        private System.Windows.Forms.Button timDichGia;
        private System.Windows.Forms.Button xoaDichGia;
        private System.Windows.Forms.Button suaDichGia;
        private System.Windows.Forms.Button themDichGia;
        private System.Windows.Forms.TextBox textMaDG;
        private System.Windows.Forms.TextBox textTenDG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}