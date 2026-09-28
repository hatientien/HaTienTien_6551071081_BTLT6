namespace Bai5
{
    partial class FormBanVe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.lblPhim = new System.Windows.Forms.Label();
            this.cboPhim = new System.Windows.Forms.ComboBox();
            this.lblSuatChieu = new System.Windows.Forms.Label();
            this.cboSuatChieu = new System.Windows.Forms.ComboBox();
            this.lblGheDaChon = new System.Windows.Forms.Label();
            this.txtGheDaChon = new System.Windows.Forms.TextBox();
            this.btnChonGhe = new System.Windows.Forms.Button();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTenKhach
            // 
            this.lblTenKhach.AutoSize = true;
            this.lblTenKhach.Location = new System.Drawing.Point(20, 20);
            this.lblTenKhach.Name = "lblTenKhach";
            this.lblTenKhach.Size = new System.Drawing.Size(64, 15);
            this.lblTenKhach.TabIndex = 0;
            this.lblTenKhach.Text = "Tên khách:";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(20, 40);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(200, 23);
            this.txtTenKhach.TabIndex = 1;
            // 
            // lblPhim
            // 
            this.lblPhim.AutoSize = true;
            this.lblPhim.Location = new System.Drawing.Point(20, 70);
            this.lblPhim.Name = "lblPhim";
            this.lblPhim.Size = new System.Drawing.Size(38, 15);
            this.lblPhim.TabIndex = 2;
            this.lblPhim.Text = "Phim:";
            // 
            // cboPhim
            // 
            this.cboPhim.FormattingEnabled = true;
            this.cboPhim.Items.AddRange(new object[] {
            "Chiến binh cuối cùng",
            "Mắt biếc",
            "Bố già",
            "Nhà bà Nữ"});
            this.cboPhim.Location = new System.Drawing.Point(20, 90);
            this.cboPhim.Name = "cboPhim";
            this.cboPhim.Size = new System.Drawing.Size(200, 23);
            this.cboPhim.TabIndex = 3;
            // 
            // lblSuatChieu
            // 
            this.lblSuatChieu.AutoSize = true;
            this.lblSuatChieu.Location = new System.Drawing.Point(20, 120);
            this.lblSuatChieu.Name = "lblSuatChieu";
            this.lblSuatChieu.Size = new System.Drawing.Size(66, 15);
            this.lblSuatChieu.TabIndex = 4;
            this.lblSuatChieu.Text = "Suất chiếu:";
            // 
            // cboSuatChieu
            // 
            this.cboSuatChieu.FormattingEnabled = true;
            this.cboSuatChieu.Items.AddRange(new object[] {
            "09:00",
            "14:00",
            "19:00",
            "21:30"});
            this.cboSuatChieu.Location = new System.Drawing.Point(20, 140);
            this.cboSuatChieu.Name = "cboSuatChieu";
            this.cboSuatChieu.Size = new System.Drawing.Size(200, 23);
            this.cboSuatChieu.TabIndex = 5;
            // 
            // lblGheDaChon
            // 
            this.lblGheDaChon.AutoSize = true;
            this.lblGheDaChon.Location = new System.Drawing.Point(20, 170);
            this.lblGheDaChon.Name = "lblGheDaChon";
            this.lblGheDaChon.Size = new System.Drawing.Size(77, 15);
            this.lblGheDaChon.TabIndex = 6;
            this.lblGheDaChon.Text = "Ghế đã chọn:";
            // 
            // txtGheDaChon
            // 
            this.txtGheDaChon.Location = new System.Drawing.Point(20, 190);
            this.txtGheDaChon.Name = "txtGheDaChon";
            this.txtGheDaChon.ReadOnly = true;
            this.txtGheDaChon.Size = new System.Drawing.Size(200, 23);
            this.txtGheDaChon.TabIndex = 7;
            // 
            // btnChonGhe
            // 
            this.btnChonGhe.Location = new System.Drawing.Point(230, 189);
            this.btnChonGhe.Name = "btnChonGhe";
            this.btnChonGhe.Size = new System.Drawing.Size(80, 25);
            this.btnChonGhe.TabIndex = 8;
            this.btnChonGhe.Text = "Chọn ghế";
            this.btnChonGhe.UseVisualStyleBackColor = true;
            this.btnChonGhe.Click += new System.EventHandler(this.btnChonGhe_Click);
            // 
            // btnDatVe
            // 
            this.btnDatVe.Location = new System.Drawing.Point(20, 230);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(140, 35);
            this.btnDatVe.TabIndex = 9;
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.UseVisualStyleBackColor = true;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(170, 230);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(140, 35);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FormBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 290);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDatVe);
            this.Controls.Add(this.btnChonGhe);
            this.Controls.Add(this.txtGheDaChon);
            this.Controls.Add(this.lblGheDaChon);
            this.Controls.Add(this.cboSuatChieu);
            this.Controls.Add(this.lblSuatChieu);
            this.Controls.Add(this.cboPhim);
            this.Controls.Add(this.lblPhim);
            this.Controls.Add(this.txtTenKhach);
            this.Controls.Add(this.lblTenKhach);
            this.Name = "FormBanVe";
            this.Text = "Bán vé xem phim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label lblPhim;
        private System.Windows.Forms.ComboBox cboPhim;
        private System.Windows.Forms.Label lblSuatChieu;
        private System.Windows.Forms.ComboBox cboSuatChieu;
        private System.Windows.Forms.Label lblGheDaChon;
        private System.Windows.Forms.TextBox txtGheDaChon;
        private System.Windows.Forms.Button btnChonGhe;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Button btnHuy;
    }
}
