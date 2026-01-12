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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoThuNhat.Text);
            int b = int.Parse(txtSoThuHai.Text);
            float kq = 0;
            if (rdCong.Checked)
                kq = a + b;
            else if (rdTru.Checked)
                kq = a - b;
            else if (rdNhan.Checked)
                kq = a * b;
            else
                kq = a / b;

            //Hiển thị kết quả
            lblKetQua.Text = kq.ToString();
        }
    }
}
