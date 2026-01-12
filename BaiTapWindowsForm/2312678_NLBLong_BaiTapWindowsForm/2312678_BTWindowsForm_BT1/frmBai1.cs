using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2312678_BTWindowsForm_BT1
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            hh.MaHH = "HH01";
            hh.TenHH = "Chuột";
            hh.DVT = "Cái";
            hh.SoLuong = 3;
            hh.DonGia = 200000;

            //Hiển thị kết quả sử dụng lblThongBao
            lblThongBao.Text = hh.HienThi();
        }
    }
}
