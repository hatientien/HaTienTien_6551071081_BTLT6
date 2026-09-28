namespace Bai1
{
    public partial class FrmDangKi : Form
    {
        public FrmDangKi()
        {
            InitializeComponent();
        }

        private bool KiemTraHopLe()
        {
            bool isValid = true;

            // (1) txtHoTen không để trống và tối thiểu 3 ký tự
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || txtHoTen.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không hợp lệ");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }

            // (2) txtSDT đúng 10 chữ số, bắt đầu bằng "0"
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSDT.Text, @"^0\d{9}$"))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại không đúng định dạng");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }

            // (3) txtEmail chứa "@" và "." phía sau "@"
            int atIndex = txtEmail.Text.IndexOf('@');
            if (atIndex == -1 || txtEmail.Text.IndexOf('.', atIndex) == -1)
            {
                errorProvider1.SetError(txtEmail, "Email không đúng định dạng");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            // (4) txtMatKhau tối thiểu 6 ký tự
            if (txtMatKhau.Text.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải có tối thiểu 6 ký tự");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }

            // (5) txtXacNhanMK phải khớp với txtMatKhau
            if (txtXacNhanMK.Text != txtMatKhau.Text || string.IsNullOrEmpty(txtXacNhanMK.Text))
            {
                errorProvider1.SetError(txtXacNhanMK, "Mật khẩu xác nhận không khớp");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }

            return isValid;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
            {
                return;
            }

            MessageBox.Show("Đăng ký thành công! Chào mừng " + txtHoTen.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.CausesValidation = false;
            errorProvider1.Clear();
            this.Close();
        }
    }
}
