using System;
using System.Windows.Forms;

namespace Bai4
{
    public partial class FormDanhBa : Form
    {
        private int _indexDangSua = -1;

        public FormDanhBa()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                return;
            }

            if (_indexDangSua != -1)
            {
                lstLienHe.Items[_indexDangSua] = $"{txtTen.Text.Trim()} - {txtSDT.Text.Trim()}";
                _indexDangSua = -1;
                txtTen.Clear();
                txtSDT.Clear();
                MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lstLienHe.Items.Add($"{txtTen.Text.Trim()} - {txtSDT.Text.Trim()}");
                txtTen.Clear();
                txtSDT.Clear();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _indexDangSua = lstLienHe.SelectedIndex;
            string selectedItem = lstLienHe.SelectedItem.ToString();
            string[] parts = selectedItem.Split(new string[] { " - " }, StringSplitOptions.None);
            if (parts.Length == 2)
            {
                txtTen.Text = parts[0];
                txtSDT.Text = parts[1];
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedItem = lstLienHe.SelectedItem.ToString();
            string ten = selectedItem.Split(new string[] { " - " }, StringSplitOptions.None)[0];

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa liên hệ {ten}? Thao tác này không thể hoàn tác!", 
                                                  "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lstLienHe.Items.RemoveAt(lstLienHe.SelectedIndex);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (_indexDangSua != -1)
                {
                    _indexDangSua = -1;
                    txtTen.Clear();
                    txtSDT.Clear();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDanhBa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTen.Text) || !string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                DialogResult result = MessageBox.Show("Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?", 
                                                      "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (result == DialogResult.No)
                {
                    txtTen.Clear();
                    txtSDT.Clear();
                    // Cho phép thoát bình thường
                }
                else if (result == DialogResult.Yes)
                {
                    // Cho phép thoát bình thường
                }
            }
        }
    }
}
