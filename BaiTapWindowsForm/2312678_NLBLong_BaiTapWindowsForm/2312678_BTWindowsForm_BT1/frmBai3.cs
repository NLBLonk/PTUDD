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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoA.Text);
            int b = int.Parse(txtSoB.Text);
            int n = int.Parse(txtSoN.Text);
            int kq = 0;

            if (rdTongAB.Checked)
                TinhTong.CongHaiSo(a, b, ref kq);
            if (rdTongN.Checked)
                kq = TinhTong.TongDaySo(n);

            //Hiển thị kết quả
            lblKQ.Text = kq.ToString();

        }


    }
}
