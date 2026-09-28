using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Bai2
{
    public partial class FormDatPhong : Form
    {
        private ErrorProvider successProvider = new ErrorProvider();

        public FormDatPhong()
        {
            InitializeComponent();
            SetupSuccessProvider();
            SetupValidation();
        }

        private void SetupSuccessProvider()
        {
            successProvider.ContainerControl = this;
            Bitmap bmp = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(Color.LimeGreen, 3))
                {
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    g.DrawLines(pen, new Point[] { new Point(3, 8), new Point(7, 12), new Point(14, 4) });
                }
            }
            successProvider.Icon = Icon.FromHandle(bmp.GetHicon());
            successProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void SetupValidation()
        {
            // Validating events
            txtHoTen.Validating += TxtHoTen_Validating;
            txtCCCD.Validating += TxtCCCD_Validating;
            txtNgayNhan.Validating += TxtNgayNhan_Validating;
            txtNgayTra.Validating += TxtNgayTra_Validating;
            txtSoNguoiLon.Validating += TxtSoNguoiLon_Validating;
            txtSoTreEm.Validating += TxtSoTreEm_Validating;

            // Validated events
            txtHoTen.Validated += Control_Validated;
            txtCCCD.Validated += Control_Validated;
            txtNgayNhan.Validated += Control_Validated;
            txtNgayTra.Validated += Control_Validated;
            txtSoNguoiLon.Validated += Control_Validated;
            txtSoTreEm.Validated += Control_Validated;
        }

        private void SetErrorState(Control control, System.ComponentModel.CancelEventArgs e, string errorMessage)
        {
            e.Cancel = true;
            errorProvider1.SetError(control, errorMessage);
            successProvider.SetError(control, "");
            control.BackColor = Color.MistyRose;
        }

        private void ClearErrorState(Control control)
        {
            errorProvider1.SetError(control, "");
            successProvider.SetError(control, "Hợp lệ");
            control.BackColor = Color.Honeydew;
        }

        private void TxtHoTen_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                SetErrorState(txtHoTen, e, "Họ tên không được để trống.");
            }
            else
            {
                ClearErrorState(txtHoTen);
            }
        }

        private void TxtCCCD_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtCCCD.Text.Length != 12 || !long.TryParse(txtCCCD.Text, out _))
            {
                SetErrorState(txtCCCD, e, "Số CCCD phải đúng 12 chữ số.");
            }
            else
            {
                ClearErrorState(txtCCCD);
            }
        }

        private void TxtNgayNhan_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!DateTime.TryParseExact(txtNgayNhan.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayNhan))
            {
                SetErrorState(txtNgayNhan, e, "Ngày nhận phòng không hợp lệ (dd/MM/yyyy).");
            }
            else if (ngayNhan.Date < DateTime.Today)
            {
                SetErrorState(txtNgayNhan, e, "Ngày nhận phòng phải >= hôm nay.");
            }
            else
            {
                ClearErrorState(txtNgayNhan);
            }
        }

        private void TxtNgayTra_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!DateTime.TryParseExact(txtNgayTra.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayTra))
            {
                SetErrorState(txtNgayTra, e, "Ngày trả phòng không hợp lệ (dd/MM/yyyy).");
            }
            else if (!DateTime.TryParseExact(txtNgayNhan.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayNhan) || ngayTra.Date <= ngayNhan.Date)
            {
                SetErrorState(txtNgayTra, e, "Ngày trả phải sau ngày nhận.");
            }
            else
            {
                ClearErrorState(txtNgayTra);
            }
        }

        private void TxtSoNguoiLon_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!int.TryParse(txtSoNguoiLon.Text, out int soNguoiLon) || soNguoiLon < 1 || soNguoiLon > 4)
            {
                SetErrorState(txtSoNguoiLon, e, "Số người lớn phải từ 1-4.");
            }
            else
            {
                ClearErrorState(txtSoNguoiLon);
            }
        }

        private void TxtSoTreEm_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!int.TryParse(txtSoTreEm.Text, out int soTreEm) || soTreEm < 0 || soTreEm > 3)
            {
                SetErrorState(txtSoTreEm, e, "Số trẻ em phải từ 0-3.");
            }
            else
            {
                ClearErrorState(txtSoTreEm);
            }
        }

        private void Control_Validated(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            control.BackColor = Color.Honeydew;
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DateTime ngayNhan = DateTime.ParseExact(txtNgayNhan.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime ngayTra = DateTime.ParseExact(txtNgayTra.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                int soDem = (ngayTra - ngayNhan).Days;
                
                string hoTen = txtHoTen.Text;
                int soNguoiLon = int.Parse(txtSoNguoiLon.Text);
                int soTreEm = int.Parse(txtSoTreEm.Text);

                string message = $"Đặt phòng thành công!\nKhách hàng: {hoTen}\nSố đêm: {soDem}\nNgười lớn: {soNguoiLon}\nTrẻ em: {soTreEm}";
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
