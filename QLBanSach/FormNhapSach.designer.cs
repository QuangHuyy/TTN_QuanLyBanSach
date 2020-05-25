namespace QLBanSach
{
    partial class FormNhapSach
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
            this.dataGridViewSach = new System.Windows.Forms.DataGridView();
            this.textBoxGiaBan = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSua = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxNXB = new System.Windows.Forms.ComboBox();
            this.comboBoxSeries = new System.Windows.Forms.ComboBox();
            this.textBoxNamXB = new System.Windows.Forms.TextBox();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.textBoxMaSach = new System.Windows.Forms.TextBox();
            this.textBoxTenSach = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSach
            // 
            this.dataGridViewSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSach.Location = new System.Drawing.Point(43, 326);
            this.dataGridViewSach.Name = "dataGridViewSach";
            this.dataGridViewSach.RowHeadersWidth = 51;
            this.dataGridViewSach.Size = new System.Drawing.Size(734, 213);
            this.dataGridViewSach.TabIndex = 19;
            this.dataGridViewSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSach_CellContentClick);
            this.dataGridViewSach.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSach_CellContentClick);
            // 
            // textBoxGiaBan
            // 
            this.textBoxGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGiaBan.Location = new System.Drawing.Point(189, 101);
            this.textBoxGiaBan.Name = "textBoxGiaBan";
            this.textBoxGiaBan.Size = new System.Drawing.Size(251, 22);
            this.textBoxGiaBan.TabIndex = 9;
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonThem.Location = new System.Drawing.Point(530, 128);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(101, 38);
            this.buttonThem.TabIndex = 10;
            this.buttonThem.Text = "THÊM";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(48, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số lượng :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(48, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Giá bán :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSua.Location = new System.Drawing.Point(530, 184);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(101, 37);
            this.buttonSua.TabIndex = 11;
            this.buttonSua.Text = "SỬA";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(48, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Năm xuất bản :";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReset.Location = new System.Drawing.Point(530, 243);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(101, 47);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(48, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(48, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sách:";
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTimKiem.Location = new System.Drawing.Point(673, 184);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(101, 37);
            this.buttonTimKiem.TabIndex = 16;
            this.buttonTimKiem.Text = "TÌM KẾM";
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(48, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = " Serries :";
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonXoa.Location = new System.Drawing.Point(673, 128);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(101, 38);
            this.buttonXoa.TabIndex = 17;
            this.buttonXoa.Text = "XÓA";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(48, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhà xuất bản :";
            // 
            // comboBoxNXB
            // 
            this.comboBoxNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNXB.FormattingEnabled = true;
            this.comboBoxNXB.Location = new System.Drawing.Point(189, 187);
            this.comboBoxNXB.Name = "comboBoxNXB";
            this.comboBoxNXB.Size = new System.Drawing.Size(251, 24);
            this.comboBoxNXB.TabIndex = 19;
            // 
            // comboBoxSeries
            // 
            this.comboBoxSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSeries.FormattingEnabled = true;
            this.comboBoxSeries.Location = new System.Drawing.Point(189, 265);
            this.comboBoxSeries.Name = "comboBoxSeries";
            this.comboBoxSeries.Size = new System.Drawing.Size(251, 24);
            this.comboBoxSeries.TabIndex = 21;
            // 
            // textBoxNamXB
            // 
            this.textBoxNamXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamXB.Location = new System.Drawing.Point(189, 224);
            this.textBoxNamXB.Name = "textBoxNamXB";
            this.textBoxNamXB.Size = new System.Drawing.Size(251, 22);
            this.textBoxNamXB.TabIndex = 24;
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoLuong.Location = new System.Drawing.Point(189, 145);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(251, 22);
            this.textBoxSoLuong.TabIndex = 1;
            // 
            // textBoxMaSach
            // 
            this.textBoxMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaSach.Location = new System.Drawing.Point(189, 27);
            this.textBoxMaSach.Name = "textBoxMaSach";
            this.textBoxMaSach.Size = new System.Drawing.Size(251, 22);
            this.textBoxMaSach.TabIndex = 25;
            // 
            // textBoxTenSach
            // 
            this.textBoxTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenSach.Location = new System.Drawing.Point(189, 62);
            this.textBoxTenSach.Name = "textBoxTenSach";
            this.textBoxTenSach.Size = new System.Drawing.Size(251, 22);
            this.textBoxTenSach.TabIndex = 26;
            // 
            // FormNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 561);
            this.Controls.Add(this.textBoxTenSach);
            this.Controls.Add(this.textBoxMaSach);
            this.Controls.Add(this.textBoxNamXB);
            this.Controls.Add(this.dataGridViewSach);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.comboBoxSeries);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGiaBan);
            this.Controls.Add(this.comboBoxNXB);
            this.Controls.Add(this.textBoxSoLuong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhapSach";
            this.Text = "Cập nhật sách";
            this.Load += new System.EventHandler(this.FormCapNhatSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewSach;
        private System.Windows.Forms.TextBox textBoxGiaBan;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxNXB;
        private System.Windows.Forms.ComboBox comboBoxSeries;
        private System.Windows.Forms.TextBox textBoxNamXB;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.TextBox textBoxMaSach;
        private System.Windows.Forms.TextBox textBoxTenSach;
    }
}

