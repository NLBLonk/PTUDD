using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2312678_BTWindowsForm_BT2
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            ThietBi tb = new ThietBi("TB01", "Chuột", "Mỹ", 300000, 3);
            int donGia = tb.DonGia;
            int sl = tb.SoLuong;
            int kq = 0;
            kq=tb.ThanhTien(donGia, sl);

            //Hiển thị kết quả sử dụng lblThongBao
            lblThongBao.Text = tb.HienThi();
            //Hiển thị kết quả thành tiền sử dụng lblKQThanhTien
            lblKQThanhTien.Text = kq.ToString();
        }
    }
}
