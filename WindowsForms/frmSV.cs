using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessEntity;

namespace WindowsForms
{
    public partial class frmSV : Form
    {
        public frmSV()
        {
            InitializeComponent();
        }

        SinhVienBE sv = new SinhVienBE();
        LopBE lp = new LopBE();
   
        public void loadData()
        {
            //DataTable dt = new DataTable();
            //dt = sv.ShowSV();
            //dgvSV.DataSource = dt;
            dgvSV.DataSource = sv.GetAllSV();
            lbTg.Text = "co tong so:" + dgvSV.RowCount.ToString()+ " sinh vien";
            lbTg.ForeColor = Color.Black;
            lbTg.Font = new Font(lbTg.Font,FontStyle.Bold);
        }

        public void loadCombox()
        {
            // load combox MaLop 
            cbMaLop.DataSource = lp.ShowLop();
            cbMaLop.DisplayMember = "TenLop";
            cbMaLop.ValueMember = "MaLop";
           
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           // load colum Malop tren dgv
            //colMaLop.DataSource = lp.ShowLop();
            //colMaLop.DisplayMember = "TenLop";
            //colMaLop.ValueMember = "MaLop";

            loadCombox();
           
           loadData();
        }

        //dua dl len txtbox , cb ,,,
        private void dgvSV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
          
            int dong = e.RowIndex;
            
            {
                txtMSV.Text = dgvSV.Rows[dong].Cells[0].Value.ToString();
                txtTenSV.Text = dgvSV.Rows[dong].Cells[1].Value.ToString();
                cbGioiTinh.Text = dgvSV.Rows[dong].Cells[2].Value.ToString();
                txtSDT.Text = dgvSV.Rows[dong].Cells[3].Value.ToString();
                dateTimePickerNgaySinh.Text = dgvSV.Rows[dong].Cells[4].Value.ToString();
                cbMaLop.SelectedValue = dgvSV.Rows[dong].Cells[5].Value.ToString();
            }
        }

     
        private void cbMaLop_MouseClick(object sender, MouseEventArgs e)
        {
            loadCombox();
           // loadData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
             if (txtMSV.TextLength == 0 || dgvSV.SelectedRows.Count < 0)
            {
                MessageBox.Show(" ban phai chon du lieu xoa ");
            }
            else
                 if (DialogResult.Yes == MessageBox.Show(" ban co chac muon xoa sinh vien '" + txtTenSV.Text + "' voi ma '" + txtMSV.Text + "'hay k?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                 {
                     //try
                     //{
                     //int r = dgvSV.CurrentCell.RowIndex;
                     //string strMaSV = dgvSV.Rows[r].Cells[0].Value.ToString();
                     string strMaSV = dgvSV.SelectedRows[0].Cells[0].Value.ToString();
                     sv.DeleteSV(strMaSV);
                     Form1_Load(sender, e);
                     MessageBox.Show("Xoa sinh vien co ten la :  " + this.txtTenSV.Text + " thanh cong");
                     
                 }
        }

        

        private void frmSV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadData();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
        ////    sv.MaSV = txtMSV.Text;
        ////    sv.TenSV = txtTenSV.Text;
        ////    sv.GioiTinh = cbGioiTinh.SelectedValue.ToString();
        ////    sv.SDT = Int32.Parse(txtSDT.Text);
        ////    sv.NgaySinh = dateTimePickerNgaySinh.Value;
        ////    sv.MaLop = cbMaLop.SelectedValue.ToString();                             
                try
                {
                    if (txtSDT.TextLength == 0 || txtMSV.TextLength == 0 || txtTenSV.TextLength == 0)
                    {
                        MessageBox.Show(" ban phai nhap day du thong tin");
                        return;
                    }
                    int Num;
                    bool ktra = int.TryParse(txtSDT.Text.Trim(), out Num);
                    if (!ktra)
                    {
                        MessageBox.Show("hãy nhập số");
                        txtSDT.ResetText();
                        txtSDT.Focus();
                        return;
                    }
                    else
                    {
                        sv.InsertSV(txtMSV.Text, txtTenSV.Text, cbGioiTinh.SelectedItem.ToString(),
                                    Int32.Parse(txtSDT.Text), dateTimePickerNgaySinh.Value, cbMaLop.SelectedValue.ToString());
                        MessageBox.Show(" them sinh vien " + txtTenSV.Text + " co ma " + txtMSV.Text + " !!! thanh cong  ");
                        loadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("da ton tai ma sinh vien " + txtMSV.Text + " nay !!! Hay nhap ma moi ");
                    txtMSV.ResetText();
                    txtMSV.Focus();
                    return;
                }                       
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSDT.TextLength == 0 || txtMSV.TextLength == 0 || txtTenSV.TextLength == 0)
                {
                    MessageBox.Show(" ban phai nhap day du thong tin");
                    return;
                }
                int Num;
                bool ktra = int.TryParse(txtSDT.Text.Trim(), out Num);
                if (!ktra)
                {
                    MessageBox.Show("hãy nhập số");
                    txtSDT.ResetText();
                    txtSDT.Focus();
                    return;
                }
                else                 
                {
                    int r = dgvSV.CurrentCell.RowIndex;
                    string madk = dgvSV.Rows[r].Cells[0].Value.ToString();
                    sv.UpdateSV(madk, txtMSV.Text, txtTenSV.Text, cbGioiTinh.SelectedItem.ToString(),
                                Int32.Parse(txtSDT.Text), dateTimePickerNgaySinh.Value, cbMaLop.SelectedValue.ToString());
                     MessageBox.Show(" sua thong tin sinh vien " + txtTenSV.Text + " co ma " + txtMSV.Text + " !!! thanh cong  ");
                    loadData();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("da ton tai ma sinh vien " + txtMSV.Text + " nay !!! Hay nhap ma moi ");
                txtMSV.ResetText();
                txtMSV.Focus();
                return;
            }
            
        }

        // ham k chan nhap tu ban phim cac chu cai 
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            //{ e.Handled = true; }
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.TextLength == 0)
                    {
                        MessageBox.Show(" ban phai nhap ky tu tim kiem");
                        return;
                    }
            string key = txtSearch.Text.ToString().Trim();
            try 
            {

                if (cbSearch.SelectedItem.ToString() == "Ma Lop")
                {
                    
                        dgvSV.DataSource = sv.GetSVByIdMaLop(key);
                        if (dgvSV.Rows.Count == 0)
                        {
                            this.lbTg.ForeColor = Color.Red;
                            this.lbTg.Text = " khong tim thay";
                            txtMSV.Text = "";
                            txtTenSV.Text = "";
                            txtSDT.Text = "";
                        }
                        else
                        {
                            this.lbTg.ForeColor = Color.Black;
                            this.lbTg.Text = " Co tong so : " + dgvSV.Rows.Count.ToString() + " Sinh Vien ";
                        }
                    }
                
                else
                    if (cbSearch.SelectedItem.ToString() == "Ten Lop")
                    {
                        dgvSV.DataSource = sv.GetSVByIdTenLop(key);

                        if (dgvSV.Rows.Count == 0)
                        {
                            this.lbTg.ForeColor = Color.Red;
                            this.lbTg.Text = " khong tim thay";
                            txtMSV.Text = "";
                            txtTenSV.Text = "";
                            txtSDT.Text = "";
                        }
                        else
                        {
                            this.lbTg.ForeColor = Color.Black;
                            this.lbTg.Text = " Co tong so : " + dgvSV.Rows.Count.ToString() + " Sinh Vien ";
                        }
                    }
            }
            catch (Exception ex)
            { MessageBox.Show(" ban phai chon kieu tim kiem"); }
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            string key = txtSearch.Text.ToString().Trim();
            try 
            { if (cbSearch.SelectedItem.ToString() == "Ma Lop")
                {
                dgvSV.DataSource = sv.GetSVByIdMaLop(key);
                if (dgvSV.Rows.Count == 0)
                {
                    this.lbTg.ForeColor = Color.Red;
                    this.lbTg.Text = " khong tim thay";
                    txtMSV.Text = "";
                    txtTenSV.Text = "";
                    txtSDT.Text = "";
                }
                else
                {
                    this.lbTg.ForeColor = Color.Black;
                    this.lbTg.Text = " Co tong so : " + dgvSV.Rows.Count.ToString() + " Sinh Vien ";
                }
            }
            else
                if (cbSearch.SelectedItem.ToString() == "Ten Lop")
                {
                    dgvSV.DataSource = sv.GetSVByIdTenLop(key);

                    if (dgvSV.Rows.Count == 0)
                    {
                        this.lbTg.ForeColor = Color.Red;
                        this.lbTg.Text = " khong tim thay";
                        txtMSV.Text = "";
                        txtTenSV.Text = "";
                        txtSDT.Text = "";
                    }
                    else
                    {
                        this.lbTg.ForeColor = Color.Black;
                        this.lbTg.Text = " Co tong so : " + dgvSV.Rows.Count.ToString() + " Sinh Vien ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" ban phai chon kieu tim kiem");
            }

        } 
    }
}
