using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312678_BTWindowsForm_BT1
{
    internal class TinhTong
    {
        public static void CongHaiSo(int a, int b, ref int s)
        {
            s = a + b;
        }

        public static int TongDaySo(int n)
        {
            int tong = 0;
            for (int i = 1; i < n; i++)
            {
                tong += i;
            }
            return tong;
        }


    }
}
