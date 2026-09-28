using System;
using System.Windows.Forms;

namespace Bai5
{
    public partial class FormBanVe : Form
    {
        public FormBanVe()
        {
            InitializeComponent();
        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            using (FormChonGhe dlg = new FormChonGhe(txtGheDaChon.Text))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtGheDaChon.Text = dlg.GheChon;
                }
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhach.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboPhim.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phim!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboSuatChieu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn suất chiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGheDaChon.Text))
            {
                MessageBox.Show("Vui lòng chọn ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenKhach = txtTenKhach.Text;
            string phim = cboPhim.SelectedItem.ToString();
            string suatChieu = cboSuatChieu.SelectedItem.ToString();
            string ghe = txtGheDaChon.Text;
            string giaVe = "75.000đ";

            string thongBao = $"Xác nhận đặt vé thành công!\n\n" +
                              $"Khách hàng: {tenKhach}\n" +
                              $"Phim: {phim}\n" +
                              $"Suất chiếu: {suatChieu}\n" +
                              $"Ghế: {ghe}\n" +
                              $"Giá vé: {giaVe}";

            MessageBox.Show(thongBao, "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Có thể xóa trắng sau khi đặt xong
            txtTenKhach.Clear();
            cboPhim.SelectedIndex = -1;
            cboSuatChieu.SelectedIndex = -1;
            txtGheDaChon.Clear();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
