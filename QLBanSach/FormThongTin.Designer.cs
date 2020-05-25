namespace QLBanSach
{
    partial class FormThongTin
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
            this.btntrung = new System.Windows.Forms.Button();
            this.dataGridViewtacgia = new System.Windows.Forms.DataGridView();
            this.btntimkiemtacgia = new System.Windows.Forms.Button();
            this.btnxoatacgia = new System.Windows.Forms.Button();
            this.btnsuatacgia = new System.Windows.Forms.Button();
            this.btnthemtacgia = new System.Windows.Forms.Button();
            this.texttentg = new System.Windows.Forms.TextBox();
            this.textmatg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtacgia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btntrung);
            this.groupBox1.Controls.Add(this.dataGridViewtacgia);
            this.groupBox1.Controls.Add(this.btntimkiemtacgia);
            this.groupBox1.Controls.Add(this.btnxoatacgia);
            this.groupBox1.Controls.Add(this.btnsuatacgia);
            this.groupBox1.Controls.Add(this.btnthemtacgia);
            this.groupBox1.Controls.Add(this.texttentg);
            this.groupBox1.Controls.Add(this.textmatg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 579);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TÁC GIẢ";
            // 
            // btntrung
            // 
            this.btntrung.Location = new System.Drawing.Point(631, 215);
            this.btntrung.Name = "btntrung";
            this.btntrung.Size = new System.Drawing.Size(154, 36);
            this.btntrung.TabIndex = 9;
            this.btntrung.Text = "Kiểm tra trùng";
            this.btntrung.UseVisualStyleBackColor = true;
            this.btntrung.Click += new System.EventHandler(this.Btntrung_Click);
            // 
            // dataGridViewtacgia
            // 
            this.dataGridViewtacgia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.dataGridViewtacgia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewtacgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtacgia.Location = new System.Drawing.Point(74, 316);
            this.dataGridViewtacgia.Name = "dataGridViewtacgia";
            this.dataGridViewtacgia.RowHeadersWidth = 51;
            this.dataGridViewtacgia.RowTemplate.Height = 24;
            this.dataGridViewtacgia.Size = new System.Drawing.Size(797, 156);
            this.dataGridViewtacgia.TabIndex = 8;
            // 
            // btntimkiemtacgia
            // 
            this.btntimkiemtacgia.Location = new System.Drawing.Point(481, 215);
            this.btntimkiemtacgia.Name = "btntimkiemtacgia";
            this.btntimkiemtacgia.Size = new System.Drawing.Size(104, 35);
            this.btntimkiemtacgia.TabIndex = 7;
            this.btntimkiemtacgia.Text = "Tìm kiếm";
            this.btntimkiemtacgia.UseVisualStyleBackColor = true;
            this.btntimkiemtacgia.Click += new System.EventHandler(this.Btntimkiemtacgia_Click);
            // 
            // btnxoatacgia
            // 
            this.btnxoatacgia.Location = new System.Drawing.Point(349, 215);
            this.btnxoatacgia.Name = "btnxoatacgia";
            this.btnxoatacgia.Size = new System.Drawing.Size(86, 34);
            this.btnxoatacgia.TabIndex = 6;
            this.btnxoatacgia.Text = "Xóa";
            this.btnxoatacgia.UseVisualStyleBackColor = true;
            this.btnxoatacgia.Click += new System.EventHandler(this.Btnxoatacgia_Click);
            // 
            // btnsuatacgia
            // 
            this.btnsuatacgia.Location = new System.Drawing.Point(203, 215);
            this.btnsuatacgia.Name = "btnsuatacgia";
            this.btnsuatacgia.Size = new System.Drawing.Size(100, 34);
            this.btnsuatacgia.TabIndex = 5;
            this.btnsuatacgia.Text = "Sửa";
            this.btnsuatacgia.UseVisualStyleBackColor = true;
            this.btnsuatacgia.Click += new System.EventHandler(this.Btnsuatacgia_Click);
            // 
            // btnthemtacgia
            // 
            this.btnthemtacgia.Location = new System.Drawing.Point(74, 213);
            this.btnthemtacgia.Name = "btnthemtacgia";
            this.btnthemtacgia.Size = new System.Drawing.Size(86, 33);
            this.btnthemtacgia.TabIndex = 4;
            this.btnthemtacgia.Text = "Thêm";
            this.btnthemtacgia.UseVisualStyleBackColor = true;
            this.btnthemtacgia.Click += new System.EventHandler(this.Btnthemtacgia_Click);
            // 
            // texttentg
            // 
            this.texttentg.Location = new System.Drawing.Point(379, 108);
            this.texttentg.Name = "texttentg";
            this.texttentg.Size = new System.Drawing.Size(188, 26);
            this.texttentg.TabIndex = 3;
            // 
            // textmatg
            // 
            this.textmatg.Location = new System.Drawing.Point(379, 64);
            this.textmatg.Name = "textmatg";
            this.textmatg.Size = new System.Drawing.Size(188, 26);
            this.textmatg.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(160, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tác giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(160, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tác giả";
            // 
            // FormThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 643);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormThongTin";
            this.Text = "Bảng Tác Giả";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtacgia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntimkiemtacgia;
        private System.Windows.Forms.Button btnxoatacgia;
        private System.Windows.Forms.Button btnsuatacgia;
        private System.Windows.Forms.Button btnthemtacgia;
        private System.Windows.Forms.TextBox texttentg;
        private System.Windows.Forms.TextBox textmatg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewtacgia;
        private System.Windows.Forms.Button btntrung;
    }
}