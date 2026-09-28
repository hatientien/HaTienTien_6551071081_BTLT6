using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai3
{
    public partial class FormNhapDiem : Form
    {
        public FormNhapDiem()
        {
            InitializeComponent();
            DangKyEnterChuyenField();
            DangKyChonToanBoText();
        }

        private void DangKyEnterChuyenField()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.KeyPress += (sender, e) =>
                    {
                        if (e.KeyChar == (char)Keys.Enter)
                        {
                            e.Handled = true;
                            if (sender == txtAnh)
                            {
                                btnLuu.PerformClick();
                            }
                            else
                            {
                                this.SelectNextControl((Control)sender, true, true, true, true);
                            }
                        }
                    };
                }
            }
        }

        private void DangKyChonToanBoText()
        {
            txtToan.Enter += TextBoxDiem_Enter;
            txtVan.Enter += TextBoxDiem_Enter;
            txtAnh.Enter += TextBoxDiem_Enter;
        }

        private void TextBoxDiem_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.SelectAll();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hasError = false;

            if (string.IsNullOrWhiteSpace(txtMaHS.Text))
            {
                errorProvider1.SetError(txtMaHS, "Mã học sinh không được trống");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được trống");
                hasError = true;
            }

            decimal diemToan, diemVan, diemAnh;

            if (!decimal.TryParse(txtToan.Text, out diemToan) || diemToan < 0 || diemToan > 10)
            {
                errorProvider1.SetError(txtToan, "Điểm Toán không hợp lệ (0.0 - 10.0)");
                hasError = true;
            }

            if (!decimal.TryParse(txtVan.Text, out diemVan) || diemVan < 0 || diemVan > 10)
            {
                errorProvider1.SetError(txtVan, "Điểm Văn không hợp lệ (0.0 - 10.0)");
                hasError = true;
            }

            if (!decimal.TryParse(txtAnh.Text, out diemAnh) || diemAnh < 0 || diemAnh > 10)
            {
                errorProvider1.SetError(txtAnh, "Điểm Anh không hợp lệ (0.0 - 10.0)");
                hasError = true;
            }

            if (!hasError)
            {
                string line = $"{txtMaHS.Text} | {txtHoTen.Text} | T:{diemToan:0.0} V:{diemVan:0.0} A:{diemAnh:0.0}";
                listBoxDiem.Items.Add(line);
                XoaTrangForm();
            }
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            XoaTrangForm();
        }

        private void XoaTrangForm()
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();
            errorProvider1.Clear();
            txtMaHS.Focus();
        }
    }
}
