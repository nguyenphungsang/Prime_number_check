
namespace Prime_number_check
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kiemtrasonguyento = new System.Windows.Forms.GroupBox();
            this.buttonKiemTra = new System.Windows.Forms.Button();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.nhapsotunhien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.danhsachdayso = new System.Windows.Forms.ListBox();
            this.kiemtrasonguyento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kiemtrasonguyento
            // 
            this.kiemtrasonguyento.Controls.Add(this.buttonKiemTra);
            this.kiemtrasonguyento.Controls.Add(this.lbKetQua);
            this.kiemtrasonguyento.Location = new System.Drawing.Point(12, 180);
            this.kiemtrasonguyento.Name = "kiemtrasonguyento";
            this.kiemtrasonguyento.Size = new System.Drawing.Size(303, 163);
            this.kiemtrasonguyento.TabIndex = 0;
            this.kiemtrasonguyento.TabStop = false;
            this.kiemtrasonguyento.Text = "Kiểm tra số nguyên tố";
            // 
            // buttonKiemTra
            // 
            this.buttonKiemTra.Location = new System.Drawing.Point(30, 48);
            this.buttonKiemTra.Name = "buttonKiemTra";
            this.buttonKiemTra.Size = new System.Drawing.Size(75, 23);
            this.buttonKiemTra.TabIndex = 3;
            this.buttonKiemTra.Text = "Kiểm tra";
            this.buttonKiemTra.UseVisualStyleBackColor = true;
            this.buttonKiemTra.Click += new System.EventHandler(this.buttonKiemTra_Click);
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(30, 103);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(0, 15);
            this.lbKetQua.TabIndex = 8;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(30, 95);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 23);
            this.buttonThem.TabIndex = 1;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(172, 95);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 2;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.Location = new System.Drawing.Point(393, 275);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(75, 23);
            this.buttonLamMoi.TabIndex = 4;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.UseVisualStyleBackColor = true;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(393, 320);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 5;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // nhapsotunhien
            // 
            this.nhapsotunhien.Location = new System.Drawing.Point(121, 22);
            this.nhapsotunhien.Name = "nhapsotunhien";
            this.nhapsotunhien.Size = new System.Drawing.Size(159, 23);
            this.nhapsotunhien.TabIndex = 6;
            this.nhapsotunhien.TextChanged += new System.EventHandler(this.nhapsotunhien_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập số tự nhiên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dãy số";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonXoa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonThem);
            this.groupBox1.Controls.Add(this.nhapsotunhien);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 135);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // danhsachdayso
            // 
            this.danhsachdayso.FormattingEnabled = true;
            this.danhsachdayso.ItemHeight = 15;
            this.danhsachdayso.Items.AddRange(new object[] {
            "34",
            "43",
            "33",
            "26",
            "78"});
            this.danhsachdayso.Location = new System.Drawing.Point(352, 78);
            this.danhsachdayso.Name = "danhsachdayso";
            this.danhsachdayso.Size = new System.Drawing.Size(120, 184);
            this.danhsachdayso.TabIndex = 12;
            this.danhsachdayso.SelectedIndexChanged += new System.EventHandler(this.danhsachdayso_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 363);
            this.Controls.Add(this.danhsachdayso);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonLamMoi);
            this.Controls.Add(this.kiemtrasonguyento);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.kiemtrasonguyento.ResumeLayout(false);
            this.kiemtrasonguyento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox kiemtrasonguyento;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonKiemTra;
        private System.Windows.Forms.Button buttonLamMoi;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.TextBox nhapsotunhien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox danhsachdayso;
    }
}

