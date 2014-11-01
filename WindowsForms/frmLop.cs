﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using BusinessEntity;

namespace WindowsForms
{
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }
        LopBE lp = new LopBE();
        
        public void loadData()
        {
            //DataTable dt = new DataTable();
            //dt = lp.ShowLop();
            //dgvLop.DataSource = dt;
            dgvLop.DataSource = lp.ShowLop();
            // sap xep 1 DataView tren DataTable

           
            this.lbTong.Text = " Co tong so : " + dgvLop.Rows.Count.ToString() + " lop ";
        }
        private void frmLop_Load(object sender, EventArgs e)
        {
           
            loadData();
            
        }

        // ham nay de them cot STT k co trong dataSQLsever ma o trong thiet ke dataGridView khi them colSTT
        private void dgvLop_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //for (int i = 0; i < dgvLop.Rows.Count; i++)
            //{
            //    dgvLop.Rows[i].Cells[0].Value = i + 1;
            //}
            dgvLop.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        
       

        // hien thi dl len texbox,cb,,,,
        private void dgvLop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            this.txtMaLop.Text = dgvLop.Rows[dong].Cells["MaLop"].Value.ToString();
            this.txTenLp.Text = dgvLop.Rows[dong].Cells["TenLop"].Value.ToString();
        }

       

        private void btThem_Click(object sender, EventArgs e)
        {

            if (txtMaLop.TextLength == 0 || txTenLp.TextLength == 0)
            {
                MessageBox.Show(" ban phai nhap day tu thong tin");
                return;
            }
            else if (txtMaLop.TextLength > 11)
            {
                MessageBox.Show(" Ma khong vuot qua 10 ki tu");
                txtMaLop.ResetText();
                return;
            }
            else
            {
                try
                {
                    lp.InsertLop(this.txtMaLop.Text.Trim(), this.txTenLp.Text.Trim());
                    MessageBox.Show("Them ma lop " + this.txtMaLop.Text + " thanh cong");
                    frmLop_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Them ma lop " + this.txtMaLop.Text + " khong thanh cong vi da ton tai");
                    txtMaLop.Text = "";
                    txTenLp.Text = "";
                }
            }                     
        }


        private void btSua_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtMaLop.TextLength == 0 || txTenLp.TextLength == 0)
                {
                    MessageBox.Show(" ban phai chon 1 thong tin du lieu nao do de sua");
                    return;
                }

                if (txtMaLop.TextLength > 11)
                {
                    MessageBox.Show(" Ma khong vuot qua 11 ki tu");
                    txtMaLop.ResetText();
                    return;
                }
                else
                    if (DialogResult.Yes == MessageBox.Show("ban co muon sua ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        int r = dgvLop.CurrentCell.RowIndex;
                        string strmadk = dgvLop.Rows[r].Cells["MaLop"].Value.ToString();
                        lp.UpdateLop(strmadk, txtMaLop.Text, this.txTenLp.Text);
                        MessageBox.Show(" ban da sua Thanh cong");
                        frmLop_Load(sender, e);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi" + ex.Message);
            }

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLop.TextLength == 0)
            {
                MessageBox.Show(" ban phai chon du lieu xoa ");
            }
            else
                if (DialogResult.Yes == MessageBox.Show(" ban co chac muon xoa lop '" + txTenLp.Text + "' voi ma '" + txtMaLop.Text + "'hay k?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //try
                    //{
                    int r = dgvLop.CurrentCell.RowIndex;
                    string strMaLop = dgvLop.Rows[r].Cells["MaLop"].Value.ToString();
                    lp.DeleteLop(strMaLop);
                    MessageBox.Show("Xoa ma lop " + this.txtMaLop.Text + " thanh cong");
                    frmLop_Load(sender, e);
                    //}


                    //catch 
                    //{
                    //    MessageBox.Show("Xoa ma lop " + this.txtMaLop.Text + " khong thanh cong ");
                    //}
                }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //if (txtSearch.Text.Trim() == "")
            //{
            //    MessageBox.Show("Bạn phải điền thông tin tìm kiếm");
            //    this.txtSearch.Focus();
            //    return;
            //}
            //else
            //{

            //}
            
            string key =txtSearch.Text.Trim();
            dgvLop.DataSource = lp.SearchLopBy(key);
            if (dgvLop.Rows.Count == 0)
            {
                this.lbTong.ForeColor = Color.Red;
                this.lbTong.Text = " khong tim thay";
            }
            else
            {
                this.lbTong.ForeColor = Color.BlueViolet;
                this.lbTong.Text = " Co tong so : " + dgvLop.Rows.Count.ToString()+ " lop ";
            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
           // txtSearch.ResetText();
        }

        private void txtSearch_MouseHover(object sender, EventArgs e)
        {
            txtSearch.ResetText();
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            txtMaLop.ResetText();
            txTenLp.ResetText();
        }

        
        

        


    
      
        
    }
}
