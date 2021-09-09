using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BTKT1_MaiNguyenXuanKieu_1954052044
{
    public partial class Bai13 : Form
    {
        public Bai13()
        {
            InitializeComponent();
        }

        string path;
        int soNguoiChoiChon;
        int soLanChoi;
        int soLanThang, soLanThua;

        public void KhoiTao()
        {
            picChoose.Image = Image.FromFile(path + "1.bmp");
            soNguoiChoiChon = 0;
            soLanChoi = 0;
            soLanThang = soLanThua = 0;
            lbCount.Text = lbLose.Text = lbWin.Text = "";
            listResult.Items.Clear();
            picResult.Image = null;
        }

        private void Play()
        {
            Random rand = new Random();

            int soCuaMay = 0;
            string ketQua = "";

            soCuaMay = rand.Next(1, 7);
            soLanChoi++;
            picResult.Image = Image.FromFile(path + soCuaMay + ".bmp");
            if (soCuaMay == soNguoiChoiChon)
            {
                ketQua = "Thắng";
                soLanThang++;
            }
            else
            {
                ketQua = "Thua";
                soLanThua++;
            }
            listResult.Items.Add(string.Format("{0}. {1} (Đoán {2} ra {3})", soLanChoi, ketQua, soNguoiChoiChon, soCuaMay));
            listResult.SelectedIndex = listResult.Items.Count - 1;
            lbCount.Text = string.Format("Lần đoán: {0}", soLanChoi);
            lbWin.Text = string.Format("Lần thắng: {0} ({1:0.0}%)", soLanThang, (double)soLanThang * 100 / soLanChoi);
            lbLose.Text = string.Format("Lần thua: {0} ({1:0.0}%)", soLanThua, (double)soLanThua * 100 / soLanChoi);

        }

        private void NhanBT(Button bt)
        {
            picChoose.Image = Image.FromFile(path + bt.Text + ".bmp");
            soNguoiChoiChon = int.Parse(bt.Text);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            NhanBT(bt);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            KhoiTao();
        }
                
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    Play();
                    return true;
                case Keys.Escape:
                    KhoiTao();
                    return true;
                case Keys.D1:
                    NhanBT(btn1);
                    return true;
                case Keys.D2:
                    NhanBT(btn2);
                    return true;
                case Keys.D3:
                    NhanBT(btn3);
                    return true;
                case Keys.D4:
                    NhanBT(btn4);
                    return true;
                case Keys.D5:
                    NhanBT(btn5);
                    return true;
                case Keys.D6:
                    NhanBT(btn6);
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void Bai13_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath + @"\HinhXucXac\";
            KhoiTao();
        }


    }
    
}
