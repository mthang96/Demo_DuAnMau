namespace _3.Presentation
{
    partial class FrmBanHang
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
            this.dtg_listsp = new System.Windows.Forms.DataGridView();
            this.dtg_giohang = new System.Windows.Forms.DataGridView();
            this.btn_xoáp = new System.Windows.Forms.Button();
            this.btn_xoagiohang = new System.Windows.Forms.Button();
            this.btn_hoadon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_tienkhachdua = new System.Windows.Forms.TextBox();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.lb_tienthua = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_mahd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtg_hoadoncho = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_giohang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hoadoncho)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_listsp
            // 
            this.dtg_listsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listsp.Location = new System.Drawing.Point(6, 21);
            this.dtg_listsp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_listsp.Name = "dtg_listsp";
            this.dtg_listsp.RowHeadersWidth = 51;
            this.dtg_listsp.RowTemplate.Height = 29;
            this.dtg_listsp.Size = new System.Drawing.Size(617, 223);
            this.dtg_listsp.TabIndex = 0;
            this.dtg_listsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_listsp_CellClick);
            // 
            // dtg_giohang
            // 
            this.dtg_giohang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_giohang.Location = new System.Drawing.Point(12, 21);
            this.dtg_giohang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_giohang.Name = "dtg_giohang";
            this.dtg_giohang.RowHeadersWidth = 51;
            this.dtg_giohang.RowTemplate.Height = 29;
            this.dtg_giohang.Size = new System.Drawing.Size(617, 148);
            this.dtg_giohang.TabIndex = 1;
            this.dtg_giohang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_giohang_CellClick);
            // 
            // btn_xoáp
            // 
            this.btn_xoáp.Location = new System.Drawing.Point(13, 193);
            this.btn_xoáp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoáp.Name = "btn_xoáp";
            this.btn_xoáp.Size = new System.Drawing.Size(111, 22);
            this.btn_xoáp.TabIndex = 2;
            this.btn_xoáp.Text = "Xóa Sản Phẩm";
            this.btn_xoáp.UseVisualStyleBackColor = true;
            this.btn_xoáp.Click += new System.EventHandler(this.btn_xoáp_Click);
            // 
            // btn_xoagiohang
            // 
            this.btn_xoagiohang.Location = new System.Drawing.Point(158, 193);
            this.btn_xoagiohang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoagiohang.Name = "btn_xoagiohang";
            this.btn_xoagiohang.Size = new System.Drawing.Size(82, 22);
            this.btn_xoagiohang.TabIndex = 3;
            this.btn_xoagiohang.Text = "Xóa Hết";
            this.btn_xoagiohang.UseVisualStyleBackColor = true;
            this.btn_xoagiohang.Click += new System.EventHandler(this.btn_xoagiohang_Click);
            // 
            // btn_hoadon
            // 
            this.btn_hoadon.Location = new System.Drawing.Point(271, 193);
            this.btn_hoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hoadon.Name = "btn_hoadon";
            this.btn_hoadon.Size = new System.Drawing.Size(110, 22);
            this.btn_hoadon.TabIndex = 4;
            this.btn_hoadon.Text = "Tạo Hóa Đơn";
            this.btn_hoadon.UseVisualStyleBackColor = true;
            this.btn_hoadon.Click += new System.EventHandler(this.btn_hoadon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_tienkhachdua);
            this.groupBox1.Controls.Add(this.btn_thanhtoan);
            this.groupBox1.Controls.Add(this.lb_tienthua);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lb_tongtien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lb_mahd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(671, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 255);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh toán";
            // 
            // tb_tienkhachdua
            // 
            this.tb_tienkhachdua.Location = new System.Drawing.Point(138, 129);
            this.tb_tienkhachdua.Name = "tb_tienkhachdua";
            this.tb_tienkhachdua.Size = new System.Drawing.Size(100, 23);
            this.tb_tienkhachdua.TabIndex = 9;
            this.tb_tienkhachdua.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Location = new System.Drawing.Point(94, 211);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(75, 23);
            this.btn_thanhtoan.TabIndex = 8;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // lb_tienthua
            // 
            this.lb_tienthua.AutoSize = true;
            this.lb_tienthua.Location = new System.Drawing.Point(138, 169);
            this.lb_tienthua.Name = "lb_tienthua";
            this.lb_tienthua.Size = new System.Drawing.Size(16, 15);
            this.lb_tienthua.TabIndex = 7;
            this.lb_tienthua.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tiền thừa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tiền khách đưa";
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.Location = new System.Drawing.Point(138, 93);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(16, 15);
            this.lb_tongtien.TabIndex = 3;
            this.lb_tongtien.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng tiền:";
            // 
            // lb_mahd
            // 
            this.lb_mahd.AutoSize = true;
            this.lb_mahd.Location = new System.Drawing.Point(138, 52);
            this.lb_mahd.Name = "lb_mahd";
            this.lb_mahd.Size = new System.Drawing.Size(16, 15);
            this.lb_mahd.TabIndex = 1;
            this.lb_mahd.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtg_giohang);
            this.groupBox2.Controls.Add(this.btn_hoadon);
            this.groupBox2.Controls.Add(this.btn_xoáp);
            this.groupBox2.Controls.Add(this.btn_xoagiohang);
            this.groupBox2.Location = new System.Drawing.Point(10, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 248);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ hàng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtg_listsp);
            this.groupBox3.Location = new System.Drawing.Point(10, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(629, 255);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sản phẩm";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtg_hoadoncho);
            this.groupBox4.Location = new System.Drawing.Point(671, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 248);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hóa đơn chờ";
            // 
            // dtg_hoadoncho
            // 
            this.dtg_hoadoncho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_hoadoncho.Location = new System.Drawing.Point(6, 21);
            this.dtg_hoadoncho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_hoadoncho.Name = "dtg_hoadoncho";
            this.dtg_hoadoncho.RowHeadersWidth = 51;
            this.dtg_hoadoncho.RowTemplate.Height = 29;
            this.dtg_hoadoncho.Size = new System.Drawing.Size(250, 211);
            this.dtg_hoadoncho.TabIndex = 6;
            this.dtg_hoadoncho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_hoadoncho_CellClick);
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 551);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmBanHang";
            this.Text = "FrmBanHang";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_giohang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hoadoncho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtg_listsp;
        private DataGridView dtg_giohang;
        private Button btn_xoáp;
        private Button btn_xoagiohang;
        private Button btn_hoadon;
        private GroupBox groupBox1;
        private Button btn_thanhtoan;
        private Label lb_tienthua;
        private Label label6;
        private Label label4;
        private Label lb_tongtien;
        private Label label3;
        private Label lb_mahd;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dtg_hoadoncho;
        private TextBox tb_tienkhachdua;
    }
}