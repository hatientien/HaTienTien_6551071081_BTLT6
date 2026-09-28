namespace Bai3
{
    partial class FormNhapDiem
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
            this.lblMaHS = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblToan = new System.Windows.Forms.Label();
            this.lblVan = new System.Windows.Forms.Label();
            this.lblAnh = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtToan = new System.Windows.Forms.TextBox();
            this.txtVan = new System.Windows.Forms.TextBox();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoaTrang = new System.Windows.Forms.Button();
            this.listBoxDiem = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Location = new System.Drawing.Point(20, 20);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(43, 15);
            this.lblMaHS.TabIndex = 0;
            this.lblMaHS.TabStop = false;
            this.lblMaHS.Text = "Mã HS";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(20, 40);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(100, 23);
            this.txtMaHS.TabIndex = 0;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(140, 20);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(43, 15);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.TabStop = false;
            this.lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(140, 40);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(150, 23);
            this.txtHoTen.TabIndex = 1;
            // 
            // lblToan
            // 
            this.lblToan.AutoSize = true;
            this.lblToan.Location = new System.Drawing.Point(310, 20);
            this.lblToan.Name = "lblToan";
            this.lblToan.Size = new System.Drawing.Size(65, 15);
            this.lblToan.TabIndex = 0;
            this.lblToan.TabStop = false;
            this.lblToan.Text = "Điểm Toán";
            // 
            // txtToan
            // 
            this.txtToan.Location = new System.Drawing.Point(310, 40);
            this.txtToan.Name = "txtToan";
            this.txtToan.Size = new System.Drawing.Size(80, 23);
            this.txtToan.TabIndex = 2;
            // 
            // lblVan
            // 
            this.lblVan.AutoSize = true;
            this.lblVan.Location = new System.Drawing.Point(410, 20);
            this.lblVan.Name = "lblVan";
            this.lblVan.Size = new System.Drawing.Size(59, 15);
            this.lblVan.TabIndex = 0;
            this.lblVan.TabStop = false;
            this.lblVan.Text = "Điểm Văn";
            // 
            // txtVan
            // 
            this.txtVan.Location = new System.Drawing.Point(410, 40);
            this.txtVan.Name = "txtVan";
            this.txtVan.Size = new System.Drawing.Size(80, 23);
            this.txtVan.TabIndex = 3;
            // 
            // lblAnh
            // 
            this.lblAnh.AutoSize = true;
            this.lblAnh.Location = new System.Drawing.Point(510, 20);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(60, 15);
            this.lblAnh.TabIndex = 0;
            this.lblAnh.TabStop = false;
            this.lblAnh.Text = "Điểm Anh";
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(510, 40);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(80, 23);
            this.txtAnh.TabIndex = 4;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(20, 80);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 30);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.BackColor = System.Drawing.Color.LightGray;
            this.btnXoaTrang.Location = new System.Drawing.Point(140, 80);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(100, 30);
            this.btnXoaTrang.TabIndex = 6;
            this.btnXoaTrang.Text = "Xóa Trắng";
            this.btnXoaTrang.UseVisualStyleBackColor = false;
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // listBoxDiem
            // 
            this.listBoxDiem.FormattingEnabled = true;
            this.listBoxDiem.ItemHeight = 15;
            this.listBoxDiem.Location = new System.Drawing.Point(20, 130);
            this.listBoxDiem.Name = "listBoxDiem";
            this.listBoxDiem.Size = new System.Drawing.Size(570, 200);
            this.listBoxDiem.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 350);
            this.Controls.Add(this.listBoxDiem);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.lblAnh);
            this.Controls.Add(this.txtVan);
            this.Controls.Add(this.lblVan);
            this.Controls.Add(this.txtToan);
            this.Controls.Add(this.lblToan);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.lblMaHS);
            this.Name = "FormNhapDiem";
            this.Text = "Nhập điểm học sinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblToan;
        private System.Windows.Forms.TextBox txtToan;
        private System.Windows.Forms.Label lblVan;
        private System.Windows.Forms.TextBox txtVan;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoaTrang;
        private System.Windows.Forms.ListBox listBoxDiem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
