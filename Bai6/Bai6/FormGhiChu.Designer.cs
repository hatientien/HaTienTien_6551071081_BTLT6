namespace Bai6
{
    partial class FormGhiChu
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
            this.components = new System.ComponentModel.Container();
            this.lblTieuDeForm = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.lblMucDoUuTien = new System.Windows.Forms.Label();
            this.cboMucDoUuTien = new System.Windows.Forms.ComboBox();
            this.btnLuuGhiChu = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDeForm
            // 
            this.lblTieuDeForm.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblTieuDeForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDeForm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTieuDeForm.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDeForm.Name = "lblTieuDeForm";
            this.lblTieuDeForm.Size = new System.Drawing.Size(400, 30);
            this.lblTieuDeForm.TabIndex = 0;
            this.lblTieuDeForm.Text = "  [Double-click vào đây để phóng to / thu nhỏ]";
            this.lblTieuDeForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTieuDeForm.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblTieuDeForm_MouseDoubleClick);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Location = new System.Drawing.Point(12, 45);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(48, 15);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "Tiêu đề:";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Location = new System.Drawing.Point(80, 42);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(280, 23);
            this.txtTieuDe.TabIndex = 2;
            this.txtTieuDe.Validating += new System.ComponentModel.CancelEventHandler(this.txtTieuDe_Validating);
            this.txtTieuDe.Validated += new System.EventHandler(this.txtTieuDe_Validated);
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Location = new System.Drawing.Point(12, 80);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(60, 15);
            this.lblNoiDung.TabIndex = 3;
            this.lblNoiDung.Text = "Nội dung:";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(80, 80);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNoiDung.Size = new System.Drawing.Size(280, 120);
            this.txtNoiDung.TabIndex = 4;
            this.txtNoiDung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoiDung_KeyPress);
            this.txtNoiDung.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            // 
            // lblMucDoUuTien
            // 
            this.lblMucDoUuTien.AutoSize = true;
            this.lblMucDoUuTien.Location = new System.Drawing.Point(12, 215);
            this.lblMucDoUuTien.Name = "lblMucDoUuTien";
            this.lblMucDoUuTien.Size = new System.Drawing.Size(49, 15);
            this.lblMucDoUuTien.TabIndex = 5;
            this.lblMucDoUuTien.Text = "Priority:";
            // 
            // cboMucDoUuTien
            // 
            this.cboMucDoUuTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMucDoUuTien.FormattingEnabled = true;
            this.cboMucDoUuTien.Items.AddRange(new object[] {
            "Thấp",
            "Trung bình",
            "Cao"});
            this.cboMucDoUuTien.Location = new System.Drawing.Point(80, 212);
            this.cboMucDoUuTien.Name = "cboMucDoUuTien";
            this.cboMucDoUuTien.Size = new System.Drawing.Size(120, 23);
            this.cboMucDoUuTien.TabIndex = 6;
            // 
            // btnLuuGhiChu
            // 
            this.btnLuuGhiChu.Location = new System.Drawing.Point(280, 211);
            this.btnLuuGhiChu.Name = "btnLuuGhiChu";
            this.btnLuuGhiChu.Size = new System.Drawing.Size(80, 25);
            this.btnLuuGhiChu.TabIndex = 7;
            this.btnLuuGhiChu.Text = "Lưu";
            this.btnLuuGhiChu.UseVisualStyleBackColor = true;
            this.btnLuuGhiChu.Click += new System.EventHandler(this.btnLuuGhiChu_Click);
            this.btnLuuGhiChu.MouseEnter += new System.EventHandler(this.btnLuuGhiChu_MouseEnter);
            this.btnLuuGhiChu.MouseLeave += new System.EventHandler(this.btnLuuGhiChu_MouseLeave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormGhiChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 260);
            this.Controls.Add(this.btnLuuGhiChu);
            this.Controls.Add(this.cboMucDoUuTien);
            this.Controls.Add(this.lblMucDoUuTien);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.txtTieuDe);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblTieuDeForm);
            this.KeyPreview = true;
            this.Name = "FormGhiChu";
            this.Text = "Ghi chú mới";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGhiChu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTieuDeForm;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label lblMucDoUuTien;
        private System.Windows.Forms.ComboBox cboMucDoUuTien;
        private System.Windows.Forms.Button btnLuuGhiChu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
