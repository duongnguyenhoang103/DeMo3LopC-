using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessEntity;

namespace WindowsForms
{
    public partial class UC_Diem : UserControl
    {
        public UC_Diem()
        {
            InitializeComponent();
        }

        SinhVienBE sv = new SinhVienBE();
        LopBE lp = new LopBE();
        MonHocBE mh = new MonHocBE();
        DiemBE d = new DiemBE();

        public void loadCombo()
        {
            cbSearch.SelectedIndex = 0;
            //load Cb MaSV
            cbMaSV.DataSource = sv.GetAllSV();
            cbMaSV.DisplayMember = "MaSV";
            cbMaSV.ValueMember = "MaSV";
            //load CbMaLop
            cbMaL.DataSource = lp.ShowLop();
            cbMaL.DisplayMember = "MaLop";
            cbMaL.ValueMember = "MaLop";
            //load Cb MaMonHoc
            cbMH.DataSource = mh.ShowMH();
            cbMH.DisplayMember = "MaMH";
            cbMH.ValueMember = "MaMH";
            //load ColMaSV
            colMaSV.DataSource = sv.GetAllSV();
            colMaSV.DisplayMember = "TenSV";
            colMaSV.ValueMember = "MaSV";
            // load colum Malop tren dgv  
            colMaLop.DataSource = lp.ShowLop();
            colMaLop.DisplayMember = "TenLop";
            colMaLop.ValueMember = "MaLop";
            //load Col MaMonHoc
            colMaMH .DataSource = mh.ShowMH();
            colMaMH .DisplayMember = "TenMH";
            colMaMH .ValueMember = "MaMH";
        }

        public void loadData()
        {
            dgvDiem.DataSource = d.showDiem();     
            
        }
        private void UC_Diem_Load(object sender, EventArgs e)
        {
            lbTg.Text = "";
            loadCombo();
            loadData();
        }

        private void dgvDiem_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDiem.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void dgvDiem_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //int vt = e.RowIndex;
            //cbMaSV.Text = dgvDiem.Rows[vt].Cells[1].Value.ToString();
            //cbMaL.Text = dgvDiem.Rows[vt].Cells[2].Value.ToString();
            //cbMH.Text = dgvDiem.Rows[vt].Cells[3].Value.ToString();

            //txtDTP.Text = dgvDiem.Rows[vt].Cells[4].Value.ToString();
            //txtDiemThi.Text = dgvDiem.Rows[vt].Cells[5].Value.ToString();
            //txtLanThi.Text = dgvDiem.Rows[vt].Cells[6].Value.ToString();
            //txtHocKi.Text = dgvDiem.Rows[vt].Cells[7].Value.ToString();
            //txtSoTietNgi.Text = dgvDiem.Rows[vt].Cells[8].Value.ToString();  
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            txtDTP.Text = ""; 
            txtDiemThi.Text = "";            
            txtLanThi.Text = ""; 
            txtHocKi .Text = "";
            txtSoTietNgi.Text = "";
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbMaSV.SelectedValue.ToString() == "" || dgvDiem.SelectedRows.Count < 0)
                {
                    MessageBox.Show(" bạn phải chọn điểm của 1 sinh viên để xóa ");
                }
                else
                {

                    //  if (DialogResult.Yes == MessageBox.Show(" bạn có chắc muốn xóa điểm sinh viên " +colMaSV.DisplayMember.   + " với mã " + cbMaSV.SelectedValue  + "'hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    if (DialogResult.Yes == MessageBox.Show(" bạn có chắc muốn xóa điểm sinh viên có mã " + cbMaSV.SelectedValue + "'hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        int dong = dgvDiem.CurrentCell.RowIndex;
                      // string madk = dgvDiem.Rows[dong].Cells[0].Value.ToString().Trim();
                        string maSV = dgvDiem.Rows[dong].Cells["colMaSV"].Value.ToString().Trim();
                        string maMaL = dgvDiem.Rows[dong].Cells["colMaLop"].Value.ToString().Trim();
                        string maMH = dgvDiem.Rows[dong].Cells["colMaMH"].Value.ToString().Trim();
                        string maLanThi = dgvDiem.Rows[dong].Cells["LanThi"].Value.ToString().Trim();
                        d.deleteDiemByMaM( maSV, maMaL, maMH,maLanThi );
                        MessageBox.Show("Xóa điểm môn " + cbMH.SelectedValue + " của sinh viên có mã " + cbMaSV.SelectedValue + " thành công");
                        loadData();
                 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" lỗi" + ex); 
            }
            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDTP.TextLength == 0 || txtDiemThi.TextLength == 0 || txtHocKi.TextLength == 0 || txtLanThi.TextLength == 0)
                {
                    MessageBox.Show(" bạn phải nhập đầy đủ thông tin");
                    return;
                }
                int Num;
                bool ktra = int.TryParse(txtDTP.Text.Trim(), out Num);
                if (!ktra)
                {
                    MessageBox.Show("hãy nhập số");
                    txtDTP.ResetText();
                    txtDTP.Focus();
                    return;
                }

                int Num1;
                bool ktra1 = int.TryParse(txtDiemThi.Text.Trim(), out Num1);
                if (!ktra1)
                {
                    MessageBox.Show("hãy nhập số");
                    txtDiemThi.ResetText();
                    txtDiemThi.Focus();
                    return;
                }
                int Num2;
                bool ktra2 = int.TryParse(txtLanThi.Text.Trim(), out Num2);
                if (!ktra2)
                {
                    MessageBox.Show("hãy nhập số");
                    txtLanThi.ResetText();
                    txtLanThi.Focus();
                    return;
                }
                int Num3;
                bool ktra3 = int.TryParse(txtHocKi.Text.Trim(), out Num3);
                if (!ktra3)
                {
                    MessageBox.Show("hãy nhập số");
                    txtHocKi.ResetText();
                    txtHocKi.Focus();
                    return;
                }
                int Num4;
                bool ktra4 = int.TryParse(txtSoTietNgi.Text.Trim(), out Num4);
                if (!ktra4)
                {
                    MessageBox.Show("hãy nhập số");
                    txtSoTietNgi.ResetText();
                    txtSoTietNgi.Focus();
                    return;
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show(" bạn có chắc muốn thêm điểm sinh viên có mã " + cbMaSV.SelectedValue + "'hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        d.insertDiem(cbMaSV.SelectedValue.ToString(), cbMaL.SelectedValue.ToString(), cbMH.SelectedValue.ToString(), float.Parse(txtDTP.Text),
                                  float.Parse(txtDiemThi.Text), int.Parse(txtLanThi.Text), int.Parse(txtHocKi.Text), int.Parse(txtSoTietNgi.Text));

                        MessageBox.Show(" thêm thành công  ");
                        loadData();
                        txtSearch.Text = ""; 
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("đã tồn tại điểm môn" + cbMH.SelectedValue+" của sinh viên"+cbMaSV.SelectedValue+ "này !!! ");
                MessageBox.Show("lỗi" +ex);
                txtLanThi.Focus();                   
                return;
            }                       
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDTP.TextLength == 0 || txtDiemThi.TextLength == 0 || txtHocKi.TextLength == 0 || txtLanThi.TextLength == 0)
                {
                    MessageBox.Show(" bạn phải nhập đầy đủ thông tin");
                    return;
                }
                int Num;
                bool ktra = int.TryParse(txtDTP.Text.Trim(), out Num);
                if (!ktra)
                {
                    MessageBox.Show("hãy nhập số");
                    txtDTP.ResetText();
                    txtDTP.Focus();
                    return;
                }

                int Num1;
                bool ktra1 = int.TryParse(txtDiemThi.Text.Trim(), out Num1);
                if (!ktra1)
                {
                    MessageBox.Show("hãy nhập số");
                    txtDiemThi.ResetText();
                    txtDiemThi.Focus();
                    return;
                }
                int Num2;
                bool ktra2 = int.TryParse(txtLanThi.Text.Trim(), out Num2);
                if (!ktra2)
                {
                    MessageBox.Show("hãy nhập số");
                    txtLanThi.ResetText();
                    txtLanThi.Focus();
                    return;
                }
                int Num3;
                bool ktra3 = int.TryParse(txtHocKi.Text.Trim(), out Num3);
                if (!ktra3)
                {
                    MessageBox.Show("hãy nhập số");
                    txtHocKi.ResetText();
                    txtHocKi.Focus();
                    return;
                }
                int Num4;
                bool ktra4 = int.TryParse(txtSoTietNgi.Text.Trim(), out Num4);
                if (!ktra4)
                {
                    MessageBox.Show("hãy nhập số");
                    txtSoTietNgi.ResetText();
                    txtSoTietNgi.Focus();
                    return;
                }
                else
                {
                    int dg = dgvDiem.CurrentCell.RowIndex;
                    string madkSV = dgvDiem.Rows[dg].Cells["colMaSV"].Value.ToString();
                     string madkL = dgvDiem.Rows[dg].Cells["colMaLop"].Value.ToString(); 
                    string madkMH = dgvDiem.Rows[dg].Cells["colMaMH"].Value.ToString();
                    string madkLT = dgvDiem.Rows[dg].Cells["LanThi"].Value.ToString(); 
                   
                    d.updateDiem(madkSV,madkL ,madkMH,madkLT , cbMaSV.SelectedValue.ToString(), cbMaL.SelectedValue.ToString(), cbMH.SelectedValue.ToString(), float.Parse(txtDTP.Text),
                              float.Parse(txtDiemThi.Text), int.Parse(txtLanThi.Text), int.Parse(txtHocKi.Text), int.Parse(txtSoTietNgi.Text));

                    MessageBox.Show(" sửa thành công  ");
                    loadData();
                    txtSearch.Text = ""; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Lỗi truy vấn " + ex.Message);
            }                       
        }


        private void dgvDiem_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int vt = e.RowIndex;
            cbMaSV.Text = dgvDiem.Rows[vt].Cells[1].Value.ToString();
            cbMaL.Text = dgvDiem.Rows[vt].Cells[2].Value.ToString();
            cbMH.Text = dgvDiem.Rows[vt].Cells[3].Value.ToString();

            txtDTP.Text = dgvDiem.Rows[vt].Cells[4].Value.ToString();
            txtDiemThi.Text = dgvDiem.Rows[vt].Cells[5].Value.ToString();
            txtLanThi.Text = dgvDiem.Rows[vt].Cells[6].Value.ToString();
            txtHocKi.Text = dgvDiem.Rows[vt].Cells[7].Value.ToString();
            txtSoTietNgi.Text = dgvDiem.Rows[vt].Cells[8].Value.ToString();  
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string key = txtSearch.Text.ToString().Trim();
            try
            {
                if (txtSearch.TextLength == 0)
                {
                    MessageBox.Show(" bạn phải nhập kí tự tìm kiếm");
                    txtSearch.Focus();
                    return;
                }
                if (cbSearch.SelectedItem.ToString() == "Mã lớp")
                {
                    dgvDiem.DataSource = d.getDiemByIdLop(key);
                    if (dgvDiem.Rows.Count == 0)
                    {
                        this.lbTg.ForeColor = Color.Red;
                        this.lbTg.Text = " không tìm thấy";
                        txtDTP.Text = "";
                        txtDiemThi.Text = "";
                        txtLanThi.Text = "";
                        txtHocKi.Text = "";
                        txtSoTietNgi.Text = "";
                    }
                    else
                    {
                        lbTg.ForeColor = Color.BlueViolet;
                        lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                        this.lbTg.Text = "Tìm thấy: " + dgvDiem.Rows.Count.ToString() + " sinh Viên ";
                    }
                }
                if (cbSearch.SelectedItem.ToString() == "Mã sinh viên")
                {
                    dgvDiem.DataSource = d.getDiemByIdSV(key);
                    if (dgvDiem.Rows.Count == 0)
                    {
                        this.lbTg.ForeColor = Color.Red;
                        this.lbTg.Text = " không tìm thấy";
                        txtDTP.Text = "";
                        txtDiemThi.Text = "";
                        txtLanThi.Text = "";
                        txtHocKi.Text = "";
                        txtSoTietNgi.Text = "";
                    }
                    else
                    {
                        lbTg.ForeColor = Color.BlueViolet;
                        lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                        this.lbTg.Text = "Tìm thấy: " + dgvDiem.Rows.Count.ToString() + " sinh Viên ";
                    }
                }
                if (cbSearch.SelectedItem.ToString() == "Tất cả")
                {
                    dgvDiem.DataSource = d.getDiemByAll(key);
                    if (dgvDiem.Rows.Count == 0)
                    {
                        this.lbTg.ForeColor = Color.Red;
                        this.lbTg.Text = " không tìm thấy";
                        txtDTP.Text = "";
                        txtDiemThi.Text = "";
                        txtLanThi.Text = "";
                        txtHocKi.Text = "";
                        txtSoTietNgi.Text = "";
                    }
                    else
                    {
                        lbTg.ForeColor = Color.BlueViolet;
                        lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                        this.lbTg.Text = "Tìm thấy: " + dgvDiem.Rows.Count.ToString() + " sinh Viên ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" lỗi" +ex);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string key = txtSearch.Text.ToString().Trim();
            try
            {
                if (txtSearch.TextLength == 0)
                {
                    loadData();
                }
                if (cbSearch.SelectedItem.ToString() == "Mã lớp")
                {
                    dgvDiem.DataSource = d.getDiemByMaLop(key);
                    if (dgvDiem.Rows.Count == 0)
                    {
                        this.lbTg.ForeColor = Color.Red;
                        this.lbTg.Text = " không tìm thấy";
                        txtDTP.Text = "";
                        txtDiemThi.Text = "";
                        txtLanThi.Text = "";
                        txtHocKi.Text = "";
                        txtSoTietNgi.Text = "";
                    }
                    else
                    {
                        lbTg.ForeColor = Color.BlueViolet;
                        lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                        this.lbTg.Text = "Tìm thấy: " + dgvDiem.Rows.Count.ToString() + " sinh Viên ";
                    }
                }
                if (cbSearch.SelectedItem.ToString() == "Mã sinh viên")
                {
                    dgvDiem.DataSource = d.getDiemByMaSV(key);
                    if (dgvDiem.Rows.Count == 0)
                    {
                        this.lbTg.ForeColor = Color.Red;
                        this.lbTg.Text = " không tìm thấy";
                        txtDTP.Text = "";
                        txtDiemThi.Text = "";
                        txtLanThi.Text = "";
                        txtHocKi.Text = "";
                        txtSoTietNgi.Text = "";
                    }
                    else
                    {
                        lbTg.ForeColor = Color.BlueViolet;
                        lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                        this.lbTg.Text = "Tìm thấy: " + dgvDiem.Rows.Count.ToString() + " sinh Viên ";
                    }
                }
                if (cbSearch.SelectedItem.ToString() == "Tất cả")
                {
                    dgvDiem.DataSource = d.getDiemByTatCa(key);
                    if (dgvDiem.Rows.Count == 0)
                    {
                        this.lbTg.ForeColor = Color.Red;
                        this.lbTg.Text = " không tìm thấy";
                        txtDTP.Text = "";
                        txtDiemThi.Text = "";
                        txtLanThi.Text = "";
                        txtHocKi.Text = "";
                        txtSoTietNgi.Text = "";
                    }
                    else
                    {
                        lbTg.ForeColor = Color.BlueViolet;
                        lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                        this.lbTg.Text = "Tìm thấy: " + dgvDiem.Rows.Count.ToString() + " sinh Viên ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" lỗi" + ex);
            }
        }

      
        
    }
}
