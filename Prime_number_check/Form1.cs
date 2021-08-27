using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_number_check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Alt | Keys.H))
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                    if (System.Windows.Forms.Application.MessageLoop)
                        System.Windows.Forms.Application.Exit();
            }
            else if (e.KeyData == (Keys.Alt | Keys.T))
            {
                themSo();
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
                if (System.Windows.Forms.Application.MessageLoop)
                    System.Windows.Forms.Application.Exit();
        }

        private void themSo()
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(nhapsotunhien.Text, "[ ^ 0-9]") && nhapsotunhien.Text.Trim().Length > 0)
            {
                danhsachdayso.Items.Add(nhapsotunhien.Text);
            }
            else
            {
                MessageBox.Show("Bạn phải nhập số vào", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            themSo();
        }

        private void danhsachdayso_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (danhsachdayso.Items.Count > 0 && danhsachdayso.GetItemText(danhsachdayso.SelectedItem) != "")
            {
                danhsachdayso.Items.Remove(danhsachdayso.SelectedItem);
            }
            else
            {
                MessageBox.Show("Danh sách trống hoặc chưa chọn số", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonKiemTra_Click(object sender, EventArgs e)
        {
            int so = Int32.Parse(danhsachdayso.GetItemText(danhsachdayso.SelectedItem));
            if (so % 2 == 0)
            {
                lbKetQua.Text = danhsachdayso.GetItemText(danhsachdayso.SelectedItem) + " là số nguyên tố";
            }
            else
            {
                lbKetQua.Text = danhsachdayso.GetItemText(danhsachdayso.SelectedItem) + " không là số nguyên tố";
            }
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void nhapsotunhien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
