namespace Bai6
{
    partial class FormChinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuTep = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMoGhiChuMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCuaSo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuXepTang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuXepNgang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuXepDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTep,
            this.menuCuaSo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuTep
            // 
            this.menuTep.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMoGhiChuMoi,
            this.menuThoat});
            this.menuTep.Name = "menuTep";
            this.menuTep.Size = new System.Drawing.Size(39, 20);
            this.menuTep.Text = "Tệp";
            // 
            // menuMoGhiChuMoi
            // 
            this.menuMoGhiChuMoi.Name = "menuMoGhiChuMoi";
            this.menuMoGhiChuMoi.Size = new System.Drawing.Size(180, 22);
            this.menuMoGhiChuMoi.Text = "Mở ghi chú mới";
            this.menuMoGhiChuMoi.Click += new System.EventHandler(this.menuMoGhiChuMoi_Click);
            // 
            // menuThoat
            // 
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(180, 22);
            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);
            // 
            // menuCuaSo
            // 
            this.menuCuaSo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuXepTang,
            this.menuXepNgang,
            this.menuXepDoc});
            this.menuCuaSo.Name = "menuCuaSo";
            this.menuCuaSo.Size = new System.Drawing.Size(55, 20);
            this.menuCuaSo.Text = "Cửa sổ";
            // 
            // menuXepTang
            // 
            this.menuXepTang.Name = "menuXepTang";
            this.menuXepTang.Size = new System.Drawing.Size(180, 22);
            this.menuXepTang.Text = "Xếp tầng";
            this.menuXepTang.Click += new System.EventHandler(this.menuXepTang_Click);
            // 
            // menuXepNgang
            // 
            this.menuXepNgang.Name = "menuXepNgang";
            this.menuXepNgang.Size = new System.Drawing.Size(180, 22);
            this.menuXepNgang.Text = "Xếp ngang";
            this.menuXepNgang.Click += new System.EventHandler(this.menuXepNgang_Click);
            // 
            // menuXepDoc
            // 
            this.menuXepDoc.Name = "menuXepDoc";
            this.menuXepDoc.Size = new System.Drawing.Size(180, 22);
            this.menuXepDoc.Text = "Xếp dọc";
            this.menuXepDoc.Click += new System.EventHandler(this.menuXepDoc_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusCount
            // 
            this.lblStatusCount.Name = "lblStatusCount";
            this.lblStatusCount.Size = new System.Drawing.Size(126, 17);
            this.lblStatusCount.Text = "Số ghi chú đang mở: 0";
            // 
            // FormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormChinh";
            this.Text = "Note Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuTep;
        private System.Windows.Forms.ToolStripMenuItem menuMoGhiChuMoi;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuCuaSo;
        private System.Windows.Forms.ToolStripMenuItem menuXepTang;
        private System.Windows.Forms.ToolStripMenuItem menuXepNgang;
        private System.Windows.Forms.ToolStripMenuItem menuXepDoc;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusCount;
    }
}
