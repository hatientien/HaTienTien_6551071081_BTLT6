using System;
using System.Windows.Forms;

namespace Bai6
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void menuMoGhiChuMoi_Click(object sender, EventArgs e)
        {
            FormGhiChu f = new FormGhiChu();
            f.MdiParent = this;
            f.FormClosed += F_FormClosed;
            f.Show();
            UpdateStatusCount();
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateStatusCount();
        }

        private void UpdateStatusCount()
        {
            lblStatusCount.Text = $"Số ghi chú đang mở: {this.MdiChildren.Length}";
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuXepTang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void menuXepNgang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuXepDoc_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
