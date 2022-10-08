namespace _3.Presentation
{
    partial class FrmNhanVien
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
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_cuahang = new System.Windows.Forms.ComboBox();
            this.cbb_guibc = new System.Windows.Forms.ComboBox();
            this.cbb_chucvu = new System.Windows.Forms.ComboBox();
            this.cbb_gioitinh = new System.Windows.Forms.ComboBox();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_ho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_tendem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dtgv_show = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_hd = new System.Windows.Forms.CheckBox();
            this.cb_khd = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_show)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Location = new System.Drawing.Point(324, 53);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(125, 27);
            this.tb_matkhau.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới tính";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_khd);
            this.groupBox1.Controls.Add(this.cb_hd);
            this.groupBox1.Controls.Add(this.cbb_cuahang);
            this.groupBox1.Controls.Add(this.cbb_guibc);
            this.groupBox1.Controls.Add(this.cbb_chucvu);
            this.groupBox1.Controls.Add(this.cbb_gioitinh);
            this.groupBox1.Controls.Add(this.dtp_ngaysinh);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tb_sdt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_diachi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_ho);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_tendem);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_matkhau);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_ten);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_ma);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 312);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chức vụ";
            // 
            // cbb_cuahang
            // 
            this.cbb_cuahang.FormattingEnabled = true;
            this.cbb_cuahang.Location = new System.Drawing.Point(602, 48);
            this.cbb_cuahang.Name = "cbb_cuahang";
            this.cbb_cuahang.Size = new System.Drawing.Size(155, 28);
            this.cbb_cuahang.TabIndex = 32;
            // 
            // cbb_guibc
            // 
            this.cbb_guibc.FormattingEnabled = true;
            this.cbb_guibc.Location = new System.Drawing.Point(602, 135);
            this.cbb_guibc.Name = "cbb_guibc";
            this.cbb_guibc.Size = new System.Drawing.Size(155, 28);
            this.cbb_guibc.TabIndex = 31;
            // 
            // cbb_chucvu
            // 
            this.cbb_chucvu.FormattingEnabled = true;
            this.cbb_chucvu.Location = new System.Drawing.Point(602, 93);
            this.cbb_chucvu.Name = "cbb_chucvu";
            this.cbb_chucvu.Size = new System.Drawing.Size(155, 28);
            this.cbb_chucvu.TabIndex = 30;
            // 
            // cbb_gioitinh
            // 
            this.cbb_gioitinh.FormattingEnabled = true;
            this.cbb_gioitinh.Location = new System.Drawing.Point(324, 93);
            this.cbb_gioitinh.Name = "cbb_gioitinh";
            this.cbb_gioitinh.Size = new System.Drawing.Size(125, 28);
            this.cbb_gioitinh.TabIndex = 29;
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Location = new System.Drawing.Point(88, 219);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(250, 27);
            this.dtp_ngaysinh.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(383, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Trạng thái";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(483, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "NV gửi báo cáo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(535, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Chức vụ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(524, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Cửa hàng";
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(324, 175);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(125, 27);
            this.tb_sdt.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(282, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "SĐT";
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(324, 135);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(125, 27);
            this.tb_diachi.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Địa chỉ";
            // 
            // tb_ho
            // 
            this.tb_ho.Location = new System.Drawing.Point(91, 175);
            this.tb_ho.Name = "tb_ho";
            this.tb_ho.Size = new System.Drawing.Size(125, 27);
            this.tb_ho.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Họ";
            // 
            // tb_tendem
            // 
            this.tb_tendem.Location = new System.Drawing.Point(91, 135);
            this.tb_tendem.Name = "tb_tendem";
            this.tb_tendem.Size = new System.Drawing.Size(125, 27);
            this.tb_tendem.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tên đệm";
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(91, 93);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(125, 27);
            this.tb_ten.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên";
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(91, 53);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(125, 27);
            this.tb_ma.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(6, 177);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(227, 29);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(6, 137);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(227, 29);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(6, 95);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(227, 29);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(6, 53);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(227, 29);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dtgv_show
            // 
            this.dtgv_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_show.Location = new System.Drawing.Point(17, 61);
            this.dtgv_show.Name = "dtgv_show";
            this.dtgv_show.RowHeadersWidth = 51;
            this.dtgv_show.RowTemplate.Height = 29;
            this.dtgv_show.Size = new System.Drawing.Size(991, 261);
            this.dtgv_show.TabIndex = 0;
            this.dtgv_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_show_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgv_show);
            this.groupBox3.Location = new System.Drawing.Point(12, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1025, 342);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách chức vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_reset);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Location = new System.Drawing.Point(796, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 312);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // cb_hd
            // 
            this.cb_hd.AutoSize = true;
            this.cb_hd.Location = new System.Drawing.Point(464, 224);
            this.cb_hd.Name = "cb_hd";
            this.cb_hd.Size = new System.Drawing.Size(103, 24);
            this.cb_hd.TabIndex = 33;
            this.cb_hd.Text = "Hoạt động";
            this.cb_hd.UseVisualStyleBackColor = true;
            this.cb_hd.Click += new System.EventHandler(this.cb_hd_Click);
            // 
            // cb_khd
            // 
            this.cb_khd.AutoSize = true;
            this.cb_khd.Location = new System.Drawing.Point(573, 224);
            this.cb_khd.Name = "cb_khd";
            this.cb_khd.Size = new System.Drawing.Size(147, 24);
            this.cb_khd.TabIndex = 34;
            this.cb_khd.Text = "Không hoạt động";
            this.cb_khd.UseVisualStyleBackColor = true;
            this.cb_khd.Click += new System.EventHandler(this.cb_khd_Click);
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 680);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_show)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox tb_matkhau;
        private Label label6;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox tb_sdt;
        private Label label9;
        private TextBox tb_diachi;
        private Label label8;
        private TextBox tb_ho;
        private Label label5;
        private TextBox tb_tendem;
        private Label label7;
        private TextBox tb_ten;
        private Label label2;
        private TextBox tb_ma;
        private Label label1;
        private Button btn_reset;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
        private DataGridView dtgv_show;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private DateTimePicker dtp_ngaysinh;
        private ComboBox cbb_gioitinh;
        private ComboBox cbb_cuahang;
        private ComboBox cbb_guibc;
        private ComboBox cbb_chucvu;
        private CheckBox cb_khd;
        private CheckBox cb_hd;
    }
}