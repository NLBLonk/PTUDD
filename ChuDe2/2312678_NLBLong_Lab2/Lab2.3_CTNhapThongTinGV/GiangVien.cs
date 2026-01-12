using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._3_CTNhapThongTinGV
{
    public class GiangVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set;}

        public DateTime NgaySinh { get; set; }
        public DanhSachHocPhan dsHocPhan;
        public string GioiTinh;
        public string[] NgoaiNgu;
        public string SoDT;
        public string Mail;

        public GiangVien()
        {
            dsHocPhan = new DanhSachHocPhan();
            NgoaiNgu = new string[20]; 
        }

        public GiangVien(string maso, string sdt, string mail, string hoten,
            DateTime ngaysinh, DanhSachHocPhan ds, string gt, string[] nn)
        {
            this.MaSo = maso;
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.dsHocPhan = ds;
            this.GioiTinh = gt;
            this.NgoaiNgu = nn;
            this.SoDT = sdt;
            this.Mail = mail;
        }


        public override string ToString()
        {
            string s = "Mã số:" + MaSo + "\n" + "Họ tên:" + HoTen + "\n" + "Ngày sinh:" + NgaySinh.ToString() + "\n"
                + "Giới tính:" + GioiTinh + "\n" + "Số điên thoại:" + SoDT + "\n" + "Mail:" + Mail + "\n";
            string sngoaingu = "Ngoại ngữ:";
            foreach (string t in NgoaiNgu)
            {
                sngoaingu += t + ";";
            }
            string MonDay = "Danh sách môn dạy:";
            foreach (HocPhan mh in dsHocPhan.ds)
            {
                MonDay += mh + ";";
            }
            s += "\n" + sngoaingu + "\n" + MonDay;
            return s;
        }
    }
}
