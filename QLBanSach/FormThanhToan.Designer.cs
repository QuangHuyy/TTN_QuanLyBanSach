namespace QLBanSach
{
    partial class FormThanhToan
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblList = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.txtGiven = new System.Windows.Forms.TextBox();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.dataGridViewCheckout = new System.Windows.Forms.DataGridView();
            this.ColumnCheckoutID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblCheckout = new System.Windows.Forms.Label();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.ColumnSearchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSearchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSearchPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelS = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.labelT3 = new System.Windows.Forms.Label();
            this.labelGiven = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelT1 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 48);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(175, 620);
            this.listView1.TabIndex = 5;
            this.listView1.TileSize = new System.Drawing.Size(100, 50);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.ForeColor = System.Drawing.Color.Coral;
            this.lblList.Location = new System.Drawing.Point(13, 16);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(175, 24);
            this.lblList.TabIndex = 7;
            this.lblList.Text = "Chọn mã sản phẩm";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.txtGiven);
            this.panelMain.Controls.Add(this.buttonFinish);
            this.panelMain.Controls.Add(this.dataGridViewCheckout);
            this.panelMain.Controls.Add(this.lblCheckout);
            this.panelMain.Controls.Add(this.dataGridViewSearch);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.labelChange);
            this.panelMain.Controls.Add(this.labelT3);
            this.panelMain.Controls.Add(this.labelGiven);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.labelTotal);
            this.panelMain.Controls.Add(this.labelT1);
            this.panelMain.Location = new System.Drawing.Point(202, 13);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(852, 655);
            this.panelMain.TabIndex = 8;
            // 
            // txtGiven
            // 
            this.txtGiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiven.Location = new System.Drawing.Point(567, 561);
            this.txtGiven.Name = "txtGiven";
            this.txtGiven.Size = new System.Drawing.Size(256, 34);
            this.txtGiven.TabIndex = 11;
            this.txtGiven.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGiven.TextChanged += new System.EventHandler(this.txtGiven_TextChanged);
            // 
            // buttonFinish
            // 
            this.buttonFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(107)))), ((int)(((byte)(86)))));
            this.buttonFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinish.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonFinish.Location = new System.Drawing.Point(0, 579);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(214, 76);
            this.buttonFinish.TabIndex = 10;
            this.buttonFinish.Text = "Xuất hóa đơn";
            this.buttonFinish.UseVisualStyleBackColor = false;
            // 
            // dataGridViewCheckout
            // 
            this.dataGridViewCheckout.AllowUserToAddRows = false;
            this.dataGridViewCheckout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.dataGridViewCheckout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheckout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCheckoutID,
            this.ColumnIndex,
            this.ColumnBookName,
            this.ColumnPrice,
            this.ColumnQuantity,
            this.ColumnTotal,
            this.ColumnDelete});
            this.dataGridViewCheckout.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewCheckout.EnableHeadersVisualStyles = false;
            this.dataGridViewCheckout.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewCheckout.Location = new System.Drawing.Point(0, 263);
            this.dataGridViewCheckout.Name = "dataGridViewCheckout";
            this.dataGridViewCheckout.RowHeadersVisible = false;
            this.dataGridViewCheckout.RowHeadersWidth = 50;
            this.dataGridViewCheckout.RowTemplate.Height = 24;
            this.dataGridViewCheckout.Size = new System.Drawing.Size(852, 212);
            this.dataGridViewCheckout.TabIndex = 6;
            this.dataGridViewCheckout.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCheckout_CellContentClick);
            this.dataGridViewCheckout.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCheckout_CellValueChanged);
            // 
            // ColumnCheckoutID
            // 
            this.ColumnCheckoutID.HeaderText = "ID";
            this.ColumnCheckoutID.MinimumWidth = 6;
            this.ColumnCheckoutID.Name = "ColumnCheckoutID";
            this.ColumnCheckoutID.Visible = false;
            this.ColumnCheckoutID.Width = 125;
            // 
            // ColumnIndex
            // 
            this.ColumnIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnIndex.HeaderText = "STT";
            this.ColumnIndex.MinimumWidth = 20;
            this.ColumnIndex.Name = "ColumnIndex";
            // 
            // ColumnBookName
            // 
            this.ColumnBookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnBookName.HeaderText = "Tên sản phẩm";
            this.ColumnBookName.MinimumWidth = 180;
            this.ColumnBookName.Name = "ColumnBookName";
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPrice.HeaderText = "Đơn giá";
            this.ColumnPrice.MinimumWidth = 100;
            this.ColumnPrice.Name = "ColumnPrice";
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnQuantity.HeaderText = "Số lượng";
            this.ColumnQuantity.MinimumWidth = 100;
            this.ColumnQuantity.Name = "ColumnQuantity";
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTotal.HeaderText = "Thành tiền";
            this.ColumnTotal.MinimumWidth = 150;
            this.ColumnTotal.Name = "ColumnTotal";
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDelete.HeaderText = "";
            this.ColumnDelete.MinimumWidth = 20;
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Text = "X";
            this.ColumnDelete.ToolTipText = "Bỏ sản phẩm";
            // 
            // lblCheckout
            // 
            this.lblCheckout.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckout.ForeColor = System.Drawing.Color.Coral;
            this.lblCheckout.Location = new System.Drawing.Point(0, 224);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(852, 39);
            this.lblCheckout.TabIndex = 7;
            this.lblCheckout.Text = "Danh sách sản phẩm thanh toán";
            this.lblCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.AllowUserToAddRows = false;
            this.dataGridViewSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(72)))));
            this.dataGridViewSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSearchID,
            this.ColumnSearchName,
            this.ColumnSearchPrice,
            this.ColumnAdd});
            this.dataGridViewSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewSearch.EnableHeadersVisualStyles = false;
            this.dataGridViewSearch.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewSearch.Location = new System.Drawing.Point(0, 35);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.RowHeadersWidth = 50;
            this.dataGridViewSearch.RowTemplate.Height = 24;
            this.dataGridViewSearch.Size = new System.Drawing.Size(852, 189);
            this.dataGridViewSearch.TabIndex = 6;
            // 
            // ColumnSearchID
            // 
            this.ColumnSearchID.HeaderText = "Mã sản phẩm";
            this.ColumnSearchID.MinimumWidth = 150;
            this.ColumnSearchID.Name = "ColumnSearchID";
            this.ColumnSearchID.Width = 150;
            // 
            // ColumnSearchName
            // 
            this.ColumnSearchName.HeaderText = "Tên sản phẩm";
            this.ColumnSearchName.MinimumWidth = 200;
            this.ColumnSearchName.Name = "ColumnSearchName";
            this.ColumnSearchName.Width = 300;
            // 
            // ColumnSearchPrice
            // 
            this.ColumnSearchPrice.HeaderText = "Đơn giá";
            this.ColumnSearchPrice.MinimumWidth = 150;
            this.ColumnSearchPrice.Name = "ColumnSearchPrice";
            this.ColumnSearchPrice.Width = 150;
            // 
            // ColumnAdd
            // 
            this.ColumnAdd.HeaderText = "Thêm";
            this.ColumnAdd.MinimumWidth = 80;
            this.ColumnAdd.Name = "ColumnAdd";
            this.ColumnAdd.Text = "Thêm";
            this.ColumnAdd.ToolTipText = "Thêm vào danh sách thanh toán";
            this.ColumnAdd.Width = 80;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelS);
            this.panelHeader.Controls.Add(this.textBox1);
            this.panelHeader.Controls.Add(this.labelSearch);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(852, 35);
            this.panelHeader.TabIndex = 9;
            // 
            // labelS
            // 
            this.labelS.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS.Location = new System.Drawing.Point(466, 0);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(181, 35);
            this.labelS.TabIndex = 9;
            this.labelS.Text = "Nhập mã sản phẩm";
            this.labelS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(647, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 27);
            this.textBox1.TabIndex = 8;
            // 
            // labelSearch
            // 
            this.labelSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.Color.Coral;
            this.labelSearch.Location = new System.Drawing.Point(0, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(291, 35);
            this.labelSearch.TabIndex = 7;
            this.labelSearch.Text = "Tìm kiếm sản phẩm";
            this.labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(162)))), ((int)(((byte)(220)))));
            this.label3.Location = new System.Drawing.Point(796, 605);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "₫";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelChange
            // 
            this.labelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.labelChange.Location = new System.Drawing.Point(529, 605);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(255, 29);
            this.labelChange.TabIndex = 7;
            this.labelChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelT3
            // 
            this.labelT3.AutoSize = true;
            this.labelT3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(162)))), ((int)(((byte)(220)))));
            this.labelT3.Location = new System.Drawing.Point(422, 605);
            this.labelT3.Name = "labelT3";
            this.labelT3.Size = new System.Drawing.Size(87, 29);
            this.labelT3.TabIndex = 7;
            this.labelT3.Text = "Trả lại:";
            // 
            // labelGiven
            // 
            this.labelGiven.AutoSize = true;
            this.labelGiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(162)))), ((int)(((byte)(220)))));
            this.labelGiven.Location = new System.Drawing.Point(376, 561);
            this.labelGiven.Name = "labelGiven";
            this.labelGiven.Size = new System.Drawing.Size(132, 29);
            this.labelGiven.TabIndex = 7;
            this.labelGiven.Text = "Khách đưa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(790, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "₫";
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.labelTotal.Location = new System.Drawing.Point(521, 498);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(263, 44);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelT1
            // 
            this.labelT1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(55)))));
            this.labelT1.Location = new System.Drawing.Point(391, 498);
            this.labelT1.Name = "labelT1";
            this.labelT1.Size = new System.Drawing.Size(136, 44);
            this.labelT1.TabIndex = 7;
            this.labelT1.Text = "Tổng:";
            // 
            // FormThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 690);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThanhToan";
            this.Text = "Hóa đơn thanh toán";
            this.Load += new System.EventHandler(this.FormThanhToan_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader column1;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelT3;
        private System.Windows.Forms.Label labelGiven;
        private System.Windows.Forms.Label labelT1;
        private System.Windows.Forms.DataGridView dataGridViewCheckout;
        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSearchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSearchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSearchPrice;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCheckoutID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox txtGiven;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelChange;
    }
}