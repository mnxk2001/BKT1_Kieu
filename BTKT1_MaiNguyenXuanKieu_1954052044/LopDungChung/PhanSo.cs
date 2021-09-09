using System;
using System.Collections.Generic;
using System.Text;

namespace BTKT1_MaiNguyenXuanKieu_1954052044.LopDungChung
{
    class PhanSo
    {
        private int tuSo, mauSo;

        public int TuSo
        {
            get { return tuSo; }
            set { tuSo = value; }
        }
        public int MauSo
        {
            get { return mauSo; }
            set { mauSo = value; }
        }

        public PhanSo()
        {
            tuSo = 0;
            mauSo = 1;
        }                   
        public PhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }
        
        public PhanSo Cong(PhanSo p)
        {
            int tongTu, tongMau;
            PhanSo ketQua;
            tongTu = tuSo * p.MauSo + p.TuSo * mauSo;
            tongMau = mauSo * p.MauSo;
            ketQua = new PhanSo(tongTu, tongMau);
            ketQua.ToiGian();
            return ketQua;
        }
        public PhanSo Nhan(PhanSo p)
        {
            int tongTu, tongMau;
            PhanSo ketQua;
            tongTu = tuSo * p.TuSo;
            tongMau = mauSo * p.MauSo;
            ketQua = new PhanSo(tongTu, tongMau);
            ketQua.ToiGian();
            return ketQua;
        }
                
        public PhanSo Tru(PhanSo p)
        {
            int tongTu, tongMau;
            PhanSo ketQua;
            tongTu = tuSo * p.MauSo - p.TuSo * mauSo;
            tongMau = mauSo * p.MauSo;
            ketQua = new PhanSo(tongTu, tongMau);
            ketQua.ToiGian();
            return ketQua;
        }

        public PhanSo Chia(PhanSo p)
        {
            int tongTu, tongMau;
            PhanSo ketQua;
            tongTu = tuSo * p.MauSo;
            tongMau = mauSo * p.TuSo;
            ketQua = new PhanSo(tongTu, tongMau);
            ketQua.ToiGian();
            return ketQua;
        }

        public void ToiGian()
        {
            int uocSo = 1;//lay USCLN 
            //CacCongThucToanHocDungChung c = new CacCongThucToanHocDungChung();

            //uocSo = c.LayUSCLN(tuSo, mauSo);

            uocSo = CacCongThucToanHocDungChung.LayUSCLN(tuSo, mauSo);
            tuSo = tuSo / uocSo;
            mauSo = mauSo / uocSo;
        }
    }
}
