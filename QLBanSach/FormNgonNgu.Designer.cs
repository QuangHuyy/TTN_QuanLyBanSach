namespace QLBanSach
{
    partial class FormNgonNgu
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
            this.btntimkiemngonngu = new System.Windows.Forms.Button();
            this.btnxoangonngu = new System.Windows.Forms.Button();
            this.suangonngu = new System.Windows.Forms.Button();
            this.btnthemngonngu = new System.Windows.Forms.Button();
            this.texttennn = new System.Windows.Forms.TextBox();
            this.textmann = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewngonngu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewngonngu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btntrung);
            this.groupBox1.Controls.Add(this.btntimkiemngonngu);
            this.groupBox1.Controls.Add(this.btnxoangonngu);
            this.groupBox1.Controls.Add(this.suangonngu);
            this.groupBox1.Controls.Add(this.btnthemngonngu);
            this.groupBox1.Controls.Add(this.texttennn);
            this.groupBox1.Controls.Add(this.textmann);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NGÔN NGỮ";
            // 
            // btntrung
            // 
            this.btntrung.Location = new System.Drawing.Point(555, 241);
            this.btntrung.Name = "btntrung";
            this.btntrung.Size = new System.Drawing.Size(161, 36);
            this.btntrung.TabIndex = 11;
            this.btntrung.Text = "Kiểm tra trùng";
            this.btntrung.UseVisualStyleBackColor = true;
            this.btntrung.Click += new System.EventHandler(this.Btntrung_Click);
            // 
            // btntimkiemngonngu
            // 
            this.btntimkiemngonngu.Location = new System.Drawing.Point(424, 241);
            this.btntimkiemngonngu.Name = "btntimkiemngonngu";
            this.btntimkiemngonngu.Size = new System.Drawing.Size(101, 36);
            this.btntimkiemngonngu.TabIndex = 10;
            this.btntimkiemngonngu.Text = "Tìm kiếm";
            this.btntimkiemngonngu.UseVisualStyleBackColor = true;
            this.btntimkiemngonngu.Click += new System.EventHandler(this.Btntimkiemngonngu_Click);
            // 
            // btnxoangonngu
            // 
            this.btnxoangonngu.Location = new System.Drawing.Point(298, 241);
            this.btnxoangonngu.Name = "btnxoangonngu";
            this.btnxoangonngu.Size = new System.Drawing.Size(90, 33);
            this.btnxoangonngu.TabIndex = 9;
            this.btnxoangonngu.Text = "Xóa";
            this.btnxoangonngu.UseVisualStyleBackColor = true;
            this.btnxoangonngu.Click += new System.EventHandler(this.Btnxoangonngu_Click);
            // 
            // suangonngu
            // 
            this.suangonngu.Location = new System.Drawing.Point(165, 240);
            this.suangonngu.Name = "suangonngu";
            this.suangonngu.Size = new System.Drawing.Size(89, 34);
            this.suangonngu.TabIndex = 8;
            this.suangonngu.Text = "Sửa";
            this.suangonngu.UseVisualStyleBackColor = true;
            this.suangonngu.Click += new System.EventHandler(this.Suangonngu_Click);
            // 
            // btnthemngonngu
            // 
            this.btnthemngonngu.Location = new System.Drawing.Point(37, 240);
            this.btnthemngonngu.Name = "btnthemngonngu";
            this.btnthemngonngu.Size = new System.Drawing.Size(83, 33);
            this.btnthemngonngu.TabIndex = 7;
            this.btnthemngonngu.Text = "Thêm";
            this.btnthemngonngu.UseVisualStyleBackColor = true;
            this.btnthemngonngu.Click += new System.EventHandler(this.Btnthemngonngu_Click);
            // 
            // texttennn
            // 
            this.texttennn.Location = new System.Drawing.Point(245, 131);
            this.texttennn.Name = "texttennn";
            this.texttennn.Size = new System.Drawing.Size(188, 30);
            this.texttennn.TabIndex = 6;
            // 
            // textmann
            // 
            this.textmann.Location = new System.Drawing.Point(245, 80);
            this.textmann.Name = "textmann";
            this.textmann.Size = new System.Drawing.Size(188, 30);
            this.textmann.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(34, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên ngôn ngữ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(40, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã ngôn ngữ";
            // 
            // dataGridViewngonngu
            // 
            this.dataGridViewngonngu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.dataGridViewngonngu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewngonngu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewngonngu.Location = new System.Drawing.Point(57, 412);
            this.dataGridViewngonngu.Name = "dataGridViewngonngu";
            this.dataGridViewngonngu.RowHeadersWidth = 51;
            this.dataGridViewngonngu.RowTemplate.Height = 24;
            this.dataGridViewngonngu.Size = new System.Drawing.Size(880, 155);
            this.dataGridViewngonngu.TabIndex = 10;
            // 
            // FormNgonNgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 643);
            this.Controls.Add(this.dataGridViewngonngu);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNgonNgu";
            this.Text = "Bảng Ngôn Ngữ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewngonngu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textmann;
        private System.Windows.Forms.TextBox texttennn;
        private System.Windows.Forms.Button btnthemngonngu;
        private System.Windows.Forms.Button suangonngu;
        private System.Windows.Forms.Button btnxoangonngu;
        private System.Windows.Forms.Button btntimkiemngonngu;
        private System.Windows.Forms.DataGridView dataGridViewngonngu;
        private System.Windows.Forms.Button btntrung;
    }
}