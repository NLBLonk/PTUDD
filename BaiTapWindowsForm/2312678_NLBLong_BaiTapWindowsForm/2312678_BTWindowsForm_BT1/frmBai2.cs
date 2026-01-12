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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void cboTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Lấy thứ tự mặt hàng được chọn
            var stt = cboTenHang.SelectedIndex;
            switch (stt)
            {
                // 0,1,2 là vị trí các mặt hàng trong list 
                // Theo thứ tự lần lượt là Chuột, Máy in, Bàn phím
                case 0:
                    txtDonGia.Text = "100000";
                    break;
                case 1:
                    txtDonGia.Text = "2000000";
                    break;
                case 2:
                    txtDonGia.Text = "150000";
                    break;
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int donGia = int.Parse(txtDonGia.Text);
            int soLuong = int.Parse(txtSL.Text);
            //double thanhTien = donGia * soLuong;

            //if (rdCK.Checked) 
            //    thanhTien = donGia * soLuong * 0.95;

            double thanhTien = 0;

            if (rdCK.Checked)
                thanhTien = (donGia * soLuong) - (0.05 * donGia * soLuong);
            else
                thanhTien = donGia * soLuong;

            //Hiển thị kết quả
            lblSoTien.Text = thanhTien.ToString();

        }
    }
}
