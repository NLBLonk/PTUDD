using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2312678_BTWindowsForm_BT3
{
    internal class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public double HeSoLuong { get; set; }
        public double HeSoPhuCap { get; set; }

        public NhanVien(string ma, string ht, string ns, double hsl, double hspc)
        {
            this.MaNhanVien = ma;
            this.HoTen = ht;
            this.NgaySinh = ns;
            this.HeSoLuong = hsl;
            this.HeSoPhuCap = hspc;
        }
        public double TinhLuong()
        {
            return (HeSoLuong + HeSoPhuCap) * 1150000;
        }
        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", MaNhanVien, HoTen, NgaySinh, HeSoLuong, HeSoPhuCap);
        }
    }
}
