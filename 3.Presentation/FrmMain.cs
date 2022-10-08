namespace _3.Presentation
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChucVu frmChucVu = new FrmChucVu();
            frmChucVu.ShowDialog();
        }

        private void cửaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCuaHang frmCuaHang = new FrmCuaHang();
            frmCuaHang.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien frmNhanVien = new FrmNhanVien();
            frmNhanVien.ShowDialog();
        }
    }
}