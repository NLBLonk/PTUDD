using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._4_CTQuanLyThongTinSVDonGian
{
    public delegate int SoSanh(object sv1, object sv2);
    class QuanLySinhVien
    {
        public List<SinhVien> ds;
        public QuanLySinhVien()
        {
            ds = new List<SinhVien>();
        }

        public SinhVien this[int index]
        {
            get { return ds[index] as SinhVien; }
            set { ds[index] = value; }
        }

        public void Them(SinhVien hp)
        {
            ds.Add(hp);
        }

        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien kq = null;
            foreach(SinhVien sv in ds)
            {
                kq = sv;
                break;
            }
            return kq;
        }

        public bool Sua(SinhVien svsua, object obj, SoSanh ss)
        {
            int i, count; bool kq = false;
            count = this.ds.Count - 1;
            for (i=0; i<count; i++)
            {
                this[i] = svsua;
                kq = true;
                break;
            }
            return kq;
        }

        public void Xoa(object obj, SoSanh ss)
        {
            int i=ds.Count-1;
            for(;i>=0;i--)
            {
                if (ss(obj, this[i]) == 0)
                    this.ds.RemoveAt(i);
            }
        }


    }
}
