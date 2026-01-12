using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ThongTinSoXo
{
    public partial class frmChinh : Form
    {
        private SoXoService soXoService;

        public frmChinh()
        {
            InitializeComponent();

            DateTime now = DateTime.Now;
            dtpNgay.MinDate = now.AddDays(-6);
            dtpNgay.MaxDate = now;

            soXoService = new SoXoService();
            rdMienBac.Checked = true;

            this.Load += Form1_Load;
            rdMienBac.CheckedChanged += Rd_CheckedChanged;
            rdMienTrung.CheckedChanged += Rd_CheckedChanged;
            rdMienNam.CheckedChanged += Rd_CheckedChanged;
            dtpNgay.ValueChanged += DtpNgay_ValueChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadKetQua();
        }

        private void Rd_CheckedChanged(object sender, EventArgs e)
        {
            LoadKetQua();
        }

        private void DtpNgay_ValueChanged(object sender, EventArgs e)
        {
            LoadKetQua();
        }

        private void LoadKetQua()
        {
            try
            {
                string mien = GetMien();
                List<KetQua> ketQuaList = soXoService.LayKetQua(mien, dtpNgay.Value);

                dataGridView1.DataSource = null;

                if (ketQuaList.Count > 0)
                    dataGridView1.DataSource = ketQuaList;
                else
                    MessageBox.Show("Không có dữ liệu ngày này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetMien()
        {
            if (rdMienTrung.Checked) return "mientrung";
            if (rdMienNam.Checked) return "miennam";
            return "mienbac";
        }

        private void txtTenDai_TextChanged(object sender, EventArgs e)
        {
            string mien = GetMien();
            string tenDai = txtTenDai.Text.Trim();

            var ketQuaTheoDai = soXoService.TimKiemTheoDai(mien, dtpNgay.Value, tenDai);

            dataGridView1.DataSource = null;
            if (ketQuaTheoDai.Count > 0)
                dataGridView1.DataSource = ketQuaTheoDai;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //dtpNgay.Value = DateTime.Now;
            txtSoCanDo.Text = string.Empty;
            txtTenDai.Text = string.Empty;
            LoadKetQua();
        }

        private void txtSoCanDo_TextChanged(object sender, EventArgs e)
        {
            string soCanDo = txtSoCanDo.Text.Trim();
            string mien = GetMien();
            List<KetQua> ketQuaList = soXoService.LayKetQua(mien, dtpNgay.Value);

            if (string.IsNullOrEmpty(soCanDo))
            {
                // Nếu ô trống thì hiển thị lại toàn bộ kết quả
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ketQuaList;
                return;
            }

            // Lọc theo số nhập vào (gõ đến đâu lọc đến đó)
            var ketQuaTim = ketQuaList
                .Where(kq => kq.SoTrung.Contains(soCanDo))
                .ToList();

            dataGridView1.DataSource = null;
            if (ketQuaTim.Count > 0)
                dataGridView1.DataSource = ketQuaTim;
        }
    }
}
