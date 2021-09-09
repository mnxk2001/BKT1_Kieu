using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BTKT1_MaiNguyenXuanKieu_1954052044.LopDungChung;

namespace BTKT1_MaiNguyenXuanKieu_1954052044
{
    public partial class Bai10 : Form
    {
        public Bai10()
        {
            InitializeComponent();
        }

        #region Biến toàn cục
        PhanSo p1, p2;
        #endregion

        private void Bai10_Load(object sender, EventArgs e)
        {
            p1 = new PhanSo();
            p2 = new PhanSo();
            txtTuSoKQ.Enabled = txtMauSoKQ.Enabled = false;
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BaiTapPhanSo_Load(object sender, EventArgs e)
        {
            p1 = new PhanSo();
            p2 = new PhanSo();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                //Cộng 2 phân số
                PhanSo ketQua = new PhanSo(1, 2);
                //1. Lấy giá trị từ textbox -> p1, p2
                p1.TuSo = Int32.Parse(txtTuSo1.Text);
                p1.MauSo = Int32.Parse(txtMauSo1.Text);
                p2.TuSo = Int32.Parse(txtTuSo2.Text);
                p2.MauSo = Int32.Parse(txtMauSo2.Text);
                //2. p1 + p2
                switch (b.Text)
                {
                    case "+":
                        ketQua = p1.Cong(p2);
                        lblPhepToan.Text = "+";
                        break;
                    case "-":
                        ketQua = p1.Tru(p2);
                        lblPhepToan.Text = "-";
                        break;
                    case "x":
                        ketQua = p1.Nhan(p2);
                        lblPhepToan.Text = "x";
                        break;
                    case "/":
                        ketQua = p1.Chia(p2);
                        lblPhepToan.Text = "/";
                        break;
                }

                txtTuSoKQ.Text = ketQua.TuSo.ToString();
                txtMauSoKQ.Text = ketQua.MauSo.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
