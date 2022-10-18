namespace _3.Presentation
{
    partial class ChiTietSP
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
            this.dtg_danhsachctsp = new System.Windows.Forms.DataGridView();
            this.tb_mota = new System.Windows.Forms.TextBox();
            this.tb_soluongton = new System.Windows.Forms.TextBox();
            this.cbb_sanpham = new System.Windows.Forms.ComboBox();
            this.tb_gianhap = new System.Windows.Forms.TextBox();
            this.tb_giaban = new System.Windows.Forms.TextBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.tb_gia1 = new System.Windows.Forms.TextBox();
            this.tb_gia2 = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_tensp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhsachctsp)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_danhsachctsp
            // 
            this.dtg_danhsachctsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_danhsachctsp.Location = new System.Drawing.Point(12, 276);
            this.dtg_danhsachctsp.Name = "dtg_danhsachctsp";
            this.dtg_danhsachctsp.RowHeadersWidth = 51;
            this.dtg_danhsachctsp.RowTemplate.Height = 29;
            this.dtg_danhsachctsp.Size = new System.Drawing.Size(1012, 236);
            this.dtg_danhsachctsp.TabIndex = 0;
            this.dtg_danhsachctsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_danhsachctsp_CellClick);
            // 
            // tb_mota
            // 
            this.tb_mota.Location = new System.Drawing.Point(200, 64);
            this.tb_mota.Name = "tb_mota";
            this.tb_mota.Size = new System.Drawing.Size(125, 27);
            this.tb_mota.TabIndex = 1;
            // 
            // tb_soluongton
            // 
            this.tb_soluongton.Location = new System.Drawing.Point(364, 64);
            this.tb_soluongton.Name = "tb_soluongton";
            this.tb_soluongton.Size = new System.Drawing.Size(125, 27);
            this.tb_soluongton.TabIndex = 2;
            this.tb_soluongton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_soluongton_KeyPress);
            // 
            // cbb_sanpham
            // 
            this.cbb_sanpham.FormattingEnabled = true;
            this.cbb_sanpham.Location = new System.Drawing.Point(12, 64);
            this.cbb_sanpham.Name = "cbb_sanpham";
            this.cbb_sanpham.Size = new System.Drawing.Size(151, 28);
            this.cbb_sanpham.TabIndex = 3;
            // 
            // tb_gianhap
            // 
            this.tb_gianhap.Location = new System.Drawing.Point(12, 136);
            this.tb_gianhap.Name = "tb_gianhap";
            this.tb_gianhap.Size = new System.Drawing.Size(151, 27);
            this.tb_gianhap.TabIndex = 4;
            // 
            // tb_giaban
            // 
            this.tb_giaban.Location = new System.Drawing.Point(200, 136);
            this.tb_giaban.Name = "tb_giaban";
            this.tb_giaban.Size = new System.Drawing.Size(125, 27);
            this.tb_giaban.TabIndex = 5;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(729, 62);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 29);
            this.btn_sua.TabIndex = 6;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(729, 112);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(94, 29);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(729, 12);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(94, 29);
            this.btn_them.TabIndex = 8;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // tb_gia1
            // 
            this.tb_gia1.Location = new System.Drawing.Point(607, 243);
            this.tb_gia1.Name = "tb_gia1";
            this.tb_gia1.Size = new System.Drawing.Size(125, 27);
            this.tb_gia1.TabIndex = 9;
            // 
            // tb_gia2
            // 
            this.tb_gia2.Location = new System.Drawing.Point(773, 243);
            this.tb_gia2.Name = "tb_gia2";
            this.tb_gia2.Size = new System.Drawing.Size(125, 27);
            this.tb_gia2.TabIndex = 10;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(930, 241);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(94, 29);
            this.btn_timkiem.TabIndex = 11;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mô tả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số lượng tồn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Giá nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Giá bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(607, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Giá min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(773, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Giá max";
            // 
            // tb_tensp
            // 
            this.tb_tensp.Location = new System.Drawing.Point(451, 243);
            this.tb_tensp.Name = "tb_tensp";
            this.tb_tensp.Size = new System.Drawing.Size(125, 27);
            this.tb_tensp.TabIndex = 19;
            this.tb_tensp.TextChanged += new System.EventHandler(this.tb_tensp_TextChanged);
            // 
            // ChiTietSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 524);
            this.Controls.Add(this.tb_tensp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.tb_gia2);
            this.Controls.Add(this.tb_gia1);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.tb_giaban);
            this.Controls.Add(this.tb_gianhap);
            this.Controls.Add(this.cbb_sanpham);
            this.Controls.Add(this.tb_soluongton);
            this.Controls.Add(this.tb_mota);
            this.Controls.Add(this.dtg_danhsachctsp);
            this.Name = "ChiTietSP";
            this.Text = "ChiTietSP";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhsachctsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtg_danhsachctsp;
        private TextBox tb_mota;
        private TextBox tb_soluongton;
        private ComboBox cbb_sanpham;
        private TextBox tb_gianhap;
        private TextBox tb_giaban;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_them;
        private TextBox tb_gia1;
        private TextBox tb_gia2;
        private Button btn_timkiem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tb_tensp;
    }
}