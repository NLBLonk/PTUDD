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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnNoiChuoi_Click(object sender, EventArgs e)
        {
            string a = txtChuoi1.Text;
            string b = txtChuoi2.Text;
            string kq = "";
            Cau3.NoiChuoi(a, b, ref kq);
            lblGhepChuoi.Text = kq;
        }

        private void btnGiaiThua_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSo.Text);
            long kq = 0;

            kq = Cau3.GiaiThua(n);
            lblGiaiThua.Text = kq.ToString();
        }

        
    }
}
