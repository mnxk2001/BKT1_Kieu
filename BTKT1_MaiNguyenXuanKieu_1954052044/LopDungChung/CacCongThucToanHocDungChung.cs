using System;
using System.Collections.Generic;
using System.Text;

namespace BTKT1_MaiNguyenXuanKieu_1954052044.LopDungChung
{
    class CacCongThucToanHocDungChung
    {
        public static int LayUSCLN(int so1, int so2)
        {
            int a, b;
            a = Math.Abs(so1);
            b = Math.Abs(so2);
            if (b == 0)
            {
                return a;
            }
            return LayUSCLN(b, a % b);
        }
    }
}
