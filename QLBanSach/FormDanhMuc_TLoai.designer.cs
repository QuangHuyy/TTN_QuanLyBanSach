namespace QLBanSach
{
    partial class FormDanhMuc_TLoai
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxTenDM = new System.Windows.Forms.ComboBox();
            this.textBoxMaDM = new System.Windows.Forms.TextBox();
            this.dataGridViewDanhMuc = new System.Windows.Forms.DataGridView();
            this.buttonThemDM = new System.Windows.Forms.Button();
            this.buttonSuaDM = new System.Windows.Forms.Button();
            this.buttonXoaDM = new System.Windows.Forms.Button();
            this.buttonTimDM = new System.Windows.Forms.Button();
            this.buttonResetDM = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxDM_TL = new System.Windows.Forms.ComboBox();
            this.comboBoxTenTL = new System.Windows.Forms.ComboBox();
            this.dataGridViewTheLoai = new System.Windows.Forms.DataGridView();
            this.textBoxMaTL = new System.Windows.Forms.TextBox();
            this.buttonSuaTL = new System.Windows.Forms.Button();
            this.buttonXoaTL = new System.Windows.Forms.Button();
            this.buttonTimTL = new System.Windows.Forms.Button();
            this.buttonRessetTL = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonThemTL = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhMuc)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.comboBoxTenDM);
            this.groupBox1.Controls.Add(this.textBoxMaDM);
            this.groupBox1.Controls.Add(this.dataGridViewDanhMuc);
            this.groupBox1.Controls.Add(this.buttonThemDM);
            this.groupBox1.Controls.Add(this.buttonSuaDM);
            this.groupBox1.Controls.Add(this.buttonXoaDM);
            this.groupBox1.Controls.Add(this.buttonTimDM);
            this.groupBox1.Controls.Add(this.buttonResetDM);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH MỤC";
            // 
            // comboBoxTenDM
            // 
            this.comboBoxTenDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTenDM.FormattingEnabled = true;
            this.comboBoxTenDM.Location = new System.Drawing.Point(154, 80);
            this.comboBoxTenDM.Name = "comboBoxTenDM";
            this.comboBoxTenDM.Size = new System.Drawing.Size(157, 28);
            this.comboBoxTenDM.TabIndex = 25;
            // 
            // textBoxMaDM
            // 
            this.textBoxMaDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaDM.Location = new System.Drawing.Point(154, 25);
            this.textBoxMaDM.Name = "textBoxMaDM";
            this.textBoxMaDM.Size = new System.Drawing.Size(157, 26);
            this.textBoxMaDM.TabIndex = 24;
            // 
            // dataGridViewDanhMuc
            // 
            this.dataGridViewDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhMuc.Location = new System.Drawing.Point(356, 23);
            this.dataGridViewDanhMuc.Name = "dataGridViewDanhMuc";
            this.dataGridViewDanhMuc.RowHeadersWidth = 51;
            this.dataGridViewDanhMuc.Size = new System.Drawing.Size(386, 188);
            this.dataGridViewDanhMuc.TabIndex = 23;
            this.dataGridViewDanhMuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhMuc_CellContentClick);
            this.dataGridViewDanhMuc.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhMuc_CellContentClick);
            // 
            // buttonThemDM
            // 
            this.buttonThemDM.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonThemDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemDM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonThemDM.Location = new System.Drawing.Point(34, 129);
            this.buttonThemDM.Name = "buttonThemDM";
            this.buttonThemDM.Size = new System.Drawing.Size(75, 28);
            this.buttonThemDM.TabIndex = 22;
            this.buttonThemDM.Text = "Thêm";
            this.buttonThemDM.UseVisualStyleBackColor = false;
            this.buttonThemDM.Click += new System.EventHandler(this.buttonThemDM_Click);
            // 
            // buttonSuaDM
            // 
            this.buttonSuaDM.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonSuaDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuaDM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSuaDM.Location = new System.Drawing.Point(34, 184);
            this.buttonSuaDM.Name = "buttonSuaDM";
            this.buttonSuaDM.Size = new System.Drawing.Size(75, 28);
            this.buttonSuaDM.TabIndex = 21;
            this.buttonSuaDM.Text = "Sửa";
            this.buttonSuaDM.UseVisualStyleBackColor = false;
            this.buttonSuaDM.Click += new System.EventHandler(this.buttonSuaDM_Click);
            // 
            // buttonXoaDM
            // 
            this.buttonXoaDM.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonXoaDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaDM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonXoaDM.Location = new System.Drawing.Point(133, 132);
            this.buttonXoaDM.Name = "buttonXoaDM";
            this.buttonXoaDM.Size = new System.Drawing.Size(75, 28);
            this.buttonXoaDM.TabIndex = 20;
            this.buttonXoaDM.Text = "Xóa";
            this.buttonXoaDM.UseVisualStyleBackColor = false;
            this.buttonXoaDM.Click += new System.EventHandler(this.buttonXoaDM_Click);
            // 
            // buttonTimDM
            // 
            this.buttonTimDM.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonTimDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimDM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTimDM.Location = new System.Drawing.Point(133, 184);
            this.buttonTimDM.Name = "buttonTimDM";
            this.buttonTimDM.Size = new System.Drawing.Size(75, 28);
            this.buttonTimDM.TabIndex = 19;
            this.buttonTimDM.Text = "Tìm";
            this.buttonTimDM.UseVisualStyleBackColor = false;
            this.buttonTimDM.Click += new System.EventHandler(this.buttonTimDM_Click);
            // 
            // buttonResetDM
            // 
            this.buttonResetDM.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonResetDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetDM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonResetDM.Location = new System.Drawing.Point(236, 134);
            this.buttonResetDM.Name = "buttonResetDM";
            this.buttonResetDM.Size = new System.Drawing.Size(75, 28);
            this.buttonResetDM.TabIndex = 18;
            this.buttonResetDM.Text = "Reset";
            this.buttonResetDM.UseVisualStyleBackColor = false;
            this.buttonResetDM.Click += new System.EventHandler(this.buttonResetDM_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(14, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tên danh mục";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã danh mục";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.comboBoxDM_TL);
            this.groupBox2.Controls.Add(this.comboBoxTenTL);
            this.groupBox2.Controls.Add(this.dataGridViewTheLoai);
            this.groupBox2.Controls.Add(this.textBoxMaTL);
            this.groupBox2.Controls.Add(this.buttonSuaTL);
            this.groupBox2.Controls.Add(this.buttonXoaTL);
            this.groupBox2.Controls.Add(this.buttonTimTL);
            this.groupBox2.Controls.Add(this.buttonRessetTL);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonThemTL);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 253);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THỂ LOẠI";
            // 
            // comboBoxDM_TL
            // 
            this.comboBoxDM_TL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDM_TL.FormattingEnabled = true;
            this.comboBoxDM_TL.Location = new System.Drawing.Point(150, 115);
            this.comboBoxDM_TL.Name = "comboBoxDM_TL";
            this.comboBoxDM_TL.Size = new System.Drawing.Size(157, 28);
            this.comboBoxDM_TL.TabIndex = 27;
            // 
            // comboBoxTenTL
            // 
            this.comboBoxTenTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTenTL.FormattingEnabled = true;
            this.comboBoxTenTL.Location = new System.Drawing.Point(150, 70);
            this.comboBoxTenTL.Name = "comboBoxTenTL";
            this.comboBoxTenTL.Size = new System.Drawing.Size(157, 28);
            this.comboBoxTenTL.TabIndex = 26;
            // 
            // dataGridViewTheLoai
            // 
            this.dataGridViewTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTheLoai.Location = new System.Drawing.Point(356, 19);
            this.dataGridViewTheLoai.Name = "dataGridViewTheLoai";
            this.dataGridViewTheLoai.RowHeadersWidth = 51;
            this.dataGridViewTheLoai.Size = new System.Drawing.Size(386, 215);
            this.dataGridViewTheLoai.TabIndex = 23;
            // 
            // textBoxMaTL
            // 
            this.textBoxMaTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaTL.Location = new System.Drawing.Point(150, 30);
            this.textBoxMaTL.Name = "textBoxMaTL";
            this.textBoxMaTL.Size = new System.Drawing.Size(157, 26);
            this.textBoxMaTL.TabIndex = 25;
            // 
            // buttonSuaTL
            // 
            this.buttonSuaTL.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonSuaTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuaTL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSuaTL.Location = new System.Drawing.Point(30, 211);
            this.buttonSuaTL.Name = "buttonSuaTL";
            this.buttonSuaTL.Size = new System.Drawing.Size(75, 28);
            this.buttonSuaTL.TabIndex = 22;
            this.buttonSuaTL.Text = "Sửa";
            this.buttonSuaTL.UseVisualStyleBackColor = false;
            this.buttonSuaTL.Click += new System.EventHandler(this.buttonSuaTL_Click);
            // 
            // buttonXoaTL
            // 
            this.buttonXoaTL.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonXoaTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaTL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonXoaTL.Location = new System.Drawing.Point(129, 165);
            this.buttonXoaTL.Name = "buttonXoaTL";
            this.buttonXoaTL.Size = new System.Drawing.Size(75, 28);
            this.buttonXoaTL.TabIndex = 21;
            this.buttonXoaTL.Text = "Xóa";
            this.buttonXoaTL.UseVisualStyleBackColor = false;
            this.buttonXoaTL.Click += new System.EventHandler(this.buttonXoaTL_Click);
            // 
            // buttonTimTL
            // 
            this.buttonTimTL.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonTimTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimTL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTimTL.Location = new System.Drawing.Point(129, 211);
            this.buttonTimTL.Name = "buttonTimTL";
            this.buttonTimTL.Size = new System.Drawing.Size(75, 28);
            this.buttonTimTL.TabIndex = 20;
            this.buttonTimTL.Text = "Tìm";
            this.buttonTimTL.UseVisualStyleBackColor = false;
            this.buttonTimTL.Click += new System.EventHandler(this.buttonTimTL_Click);
            // 
            // buttonRessetTL
            // 
            this.buttonRessetTL.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonRessetTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRessetTL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRessetTL.Location = new System.Drawing.Point(232, 167);
            this.buttonRessetTL.Name = "buttonRessetTL";
            this.buttonRessetTL.Size = new System.Drawing.Size(75, 28);
            this.buttonRessetTL.TabIndex = 19;
            this.buttonRessetTL.Text = "Reset";
            this.buttonRessetTL.UseVisualStyleBackColor = false;
            this.buttonRessetTL.Click += new System.EventHandler(this.buttonRessetTL_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(23, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên thể loại";
            // 
            // buttonThemTL
            // 
            this.buttonThemTL.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonThemTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemTL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonThemTL.Location = new System.Drawing.Point(30, 162);
            this.buttonThemTL.Name = "buttonThemTL";
            this.buttonThemTL.Size = new System.Drawing.Size(75, 28);
            this.buttonThemTL.TabIndex = 11;
            this.buttonThemTL.Text = "Thêm";
            this.buttonThemTL.UseVisualStyleBackColor = false;
            this.buttonThemTL.Click += new System.EventHandler(this.buttonThemTL_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "Tên thể loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(23, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã thể loại";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkCyan;
            this.label15.Location = new System.Drawing.Point(23, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "Tên danh mục";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(23, 33);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 17);
            this.label22.TabIndex = 0;
            this.label22.Text = "Mã thể loại";
            // 
            // FormDanhMuc_TLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDanhMuc_TLoai";
            this.Text = "Bảng Thể Loại";
            this.Load += new System.EventHandler(this.DanhMuc_TLoai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhMuc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheLoai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxTenDM;
        private System.Windows.Forms.TextBox textBoxMaDM;
        private System.Windows.Forms.DataGridView dataGridViewDanhMuc;
        private System.Windows.Forms.Button buttonThemDM;
        private System.Windows.Forms.Button buttonSuaDM;
        private System.Windows.Forms.Button buttonXoaDM;
        private System.Windows.Forms.Button buttonTimDM;
        private System.Windows.Forms.Button buttonResetDM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxDM_TL;
        private System.Windows.Forms.ComboBox comboBoxTenTL;
        private System.Windows.Forms.TextBox textBoxMaTL;
        private System.Windows.Forms.DataGridView dataGridViewTheLoai;
        private System.Windows.Forms.Button buttonSuaTL;
        private System.Windows.Forms.Button buttonXoaTL;
        private System.Windows.Forms.Button buttonTimTL;
        private System.Windows.Forms.Button buttonRessetTL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonThemTL;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label22;
    }
}