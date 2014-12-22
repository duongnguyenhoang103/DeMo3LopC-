using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using BusinessEntity; 

namespace WindowsForms
{
    public partial class UC_BCThongKeSV : UserControl
    {
        public UC_BCThongKeSV()
        {
            InitializeComponent();
        }
        BCThongKeSvBE  sv = new BCThongKeSvBE ();
        LopBE lp = new LopBE();
        public void loadComb()
        {
            cbSearch.DataSource = lp.ShowLop();
            cbSearch.DisplayMember = "MaLop";
            cbSearch.ValueMember = "MaLop";
        }
        private void UC_BCThongKeSV_Load(object sender, EventArgs e)
        {
            lbTg.Text = "";
            loadComb();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string key = cbSearch.SelectedValue.ToString().Trim();      
            dgvSV.DataSource = sv.getSvByIdLop(key);
            if (dgvSV.Rows.Count > 0)
            {
                lbTg.Text = "có tống số: " + dgvSV.Rows.Count.ToString() + "sinh viên";
                lbTg.ForeColor = Color.BlueViolet;
                lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
            }
            else
            {
                lbTg.Text = "không có";
                lbTg.ForeColor = Color.Red;
                lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
            }
        }

        private void btIn_Click(object sender, EventArgs e)
        {

        }

        private void dgvSV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvSV.Rows[e.RowIndex].Cells[0].Value= e.RowIndex + 1; 
        }
    }
}
