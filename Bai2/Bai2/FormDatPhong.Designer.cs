namespace Bai2
{
    partial class FormDatPhong
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblNgayNhan = new System.Windows.Forms.Label();
            this.txtNgayNhan = new System.Windows.Forms.TextBox();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.txtNgayTra = new System.Windows.Forms.TextBox();
            this.lblSoNguoiLon = new System.Windows.Forms.Label();
            this.txtSoNguoiLon = new System.Windows.Forms.TextBox();
            this.lblSoTreEm = new System.Windows.Forms.Label();
            this.txtSoTreEm = new System.Windows.Forms.TextBox();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(50, 20);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(43, 15);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(50, 40);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(300, 23);
            this.txtHoTen.TabIndex = 1;
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(50, 70);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(55, 15);
            this.lblCCCD.TabIndex = 2;
            this.lblCCCD.Text = "Số CCCD";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(50, 90);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(300, 23);
            this.txtCCCD.TabIndex = 3;
            // 
            // lblNgayNhan
            // 
            this.lblNgayNhan.AutoSize = true;
            this.lblNgayNhan.Location = new System.Drawing.Point(50, 120);
            this.lblNgayNhan.Name = "lblNgayNhan";
            this.lblNgayNhan.Size = new System.Drawing.Size(98, 15);
            this.lblNgayNhan.TabIndex = 4;
            this.lblNgayNhan.Text = "Ngày nhận phòng";
            // 
            // txtNgayNhan
            // 
            this.txtNgayNhan.Location = new System.Drawing.Point(50, 140);
            this.txtNgayNhan.Name = "txtNgayNhan";
            this.txtNgayNhan.Size = new System.Drawing.Size(300, 23);
            this.txtNgayNhan.TabIndex = 5;
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Location = new System.Drawing.Point(50, 170);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(89, 15);
            this.lblNgayTra.TabIndex = 6;
            this.lblNgayTra.Text = "Ngày trả phòng";
            // 
            // txtNgayTra
            // 
            this.txtNgayTra.Location = new System.Drawing.Point(50, 190);
            this.txtNgayTra.Name = "txtNgayTra";
            this.txtNgayTra.Size = new System.Drawing.Size(300, 23);
            this.txtNgayTra.TabIndex = 7;
            // 
            // lblSoNguoiLon
            // 
            this.lblSoNguoiLon.AutoSize = true;
            this.lblSoNguoiLon.Location = new System.Drawing.Point(50, 220);
            this.lblSoNguoiLon.Name = "lblSoNguoiLon";
            this.lblSoNguoiLon.Size = new System.Drawing.Size(74, 15);
            this.lblSoNguoiLon.TabIndex = 8;
            this.lblSoNguoiLon.Text = "Số người lớn";
            // 
            // txtSoNguoiLon
            // 
            this.txtSoNguoiLon.Location = new System.Drawing.Point(50, 240);
            this.txtSoNguoiLon.Name = "txtSoNguoiLon";
            this.txtSoNguoiLon.Size = new System.Drawing.Size(300, 23);
            this.txtSoNguoiLon.TabIndex = 9;
            // 
            // lblSoTreEm
            // 
            this.lblSoTreEm.AutoSize = true;
            this.lblSoTreEm.Location = new System.Drawing.Point(50, 270);
            this.lblSoTreEm.Name = "lblSoTreEm";
            this.lblSoTreEm.Size = new System.Drawing.Size(58, 15);
            this.lblSoTreEm.TabIndex = 10;
            this.lblSoTreEm.Text = "Số trẻ em";
            // 
            // txtSoTreEm
            // 
            this.txtSoTreEm.Location = new System.Drawing.Point(50, 290);
            this.txtSoTreEm.Name = "txtSoTreEm";
            this.txtSoTreEm.Size = new System.Drawing.Size(300, 23);
            this.txtSoTreEm.TabIndex = 11;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDatPhong.ForeColor = System.Drawing.Color.White;
            this.btnDatPhong.Location = new System.Drawing.Point(50, 330);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(300, 35);
            this.btnDatPhong.TabIndex = 12;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 420);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.txtSoTreEm);
            this.Controls.Add(this.lblSoTreEm);
            this.Controls.Add(this.txtSoNguoiLon);
            this.Controls.Add(this.lblSoNguoiLon);
            this.Controls.Add(this.txtNgayTra);
            this.Controls.Add(this.lblNgayTra);
            this.Controls.Add(this.txtNgayNhan);
            this.Controls.Add(this.lblNgayNhan);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.lblCCCD);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Name = "FormDatPhong";
            this.Text = "Đặt phòng khách sạn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblNgayNhan;
        private System.Windows.Forms.TextBox txtNgayNhan;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.TextBox txtNgayTra;
        private System.Windows.Forms.Label lblSoNguoiLon;
        private System.Windows.Forms.TextBox txtSoNguoiLon;
        private System.Windows.Forms.Label lblSoTreEm;
        private System.Windows.Forms.TextBox txtSoTreEm;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
