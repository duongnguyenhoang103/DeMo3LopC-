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
    public partial class UC_Nghanh : UserControl
    {
        NghanhBE nghanh = new NghanhBE();
        KhoaBE khoa = new KhoaBE();
        public UC_Nghanh()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            dgvNganh.DataSource = nghanh.ShowNghanh();

        }
        public void loadCombox()
        {
            cbMaKhoa.DataSource = khoa.ShowKhoa();
            cbMaKhoa.DisplayMember = "MaKhoa";
            cbMaKhoa.ValueMember = "MaKhoa";
        }
        private void UC_Nghanh_Load(object sender, EventArgs e)
        {
            loadCombox();
            loadData();
        }

        private void dgvNganh_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            this.txtMaNghanh.Text = dgvNganh.Rows[vt].Cells["MaNghanh"].Value.ToString();
            this.txtTenNghanh.Text = dgvNganh.Rows[vt].Cells["TenNghanh"].Value.ToString();
            this.txtSoL.Text = dgvNganh.Rows[vt].Cells["SoLop"].Value.ToString();
            this.cbMaKhoa.SelectedValue = dgvNganh.Rows[vt].Cells["MaKhoa"].Value.ToString();
            this.txtSDT.Text = dgvNganh.Rows[vt].Cells["SDT"].Value.ToString();
            this.txtEmail.Text = dgvNganh.Rows[vt].Cells["Email"].Value.ToString();
            this.txtDiaChi.Text = dgvNganh.Rows[vt].Cells["DiaChi"].Value.ToString();
        }

  

        private void cbMaKhoa_MouseClick(object sender, MouseEventArgs e)
        {
            loadCombox();
        }

        private void UC_Nghanh_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           //loadData(); 
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNghanh.TextLength == 0 || dgvNganh.SelectedRows.Count < 0)
            {
                MessageBox.Show(" bạn phải chọn dữ liệu xóa ");
            }
            else
                if (DialogResult.Yes == MessageBox.Show(" bạn có chắc muốn xóa nghành '" + txtTenNghanh.Text + "' với mã '" + txtMaNghanh.Text + "'hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    string strMaNghanh = txtMaNghanh.Text;
                    nghanh.DeleteNganh(strMaNghanh);
                    MessageBox.Show("Xóa nghành có tên là :" + this.txtTenNghanh.Text + " !!! thành công");
                    loadData();


                }
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            txtMaNghanh.Text = "";
            txtTenNghanh.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtSoL.Text = "";
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtMaNghanh.TextLength == 0)
            {
                MessageBox.Show("bạn phải nhập mã nghành ");
                txtMaNghanh.Focus();
                return;
            }
            if (txtTenNghanh.TextLength == 0)
            {
                MessageBox.Show("bạn phải nhập tên nghành ");
                txtTenNghanh.Focus();
                return;
            }
            else if (txtMaNghanh.TextLength > 11)
            {
                MessageBox.Show(" Mã không vượt quá 10 kí tự");
                txtMaNghanh.ResetText();
                return;
            }
            else
            {
                try
                {
                    int vt = dgvNganh.CurrentCell.RowIndex;
                    string madk = dgvNganh.Rows[vt].Cells[0].Value.ToString();
                    //string madk = txtMaNghanh.Text;  
                    nghanh.UpdateNghanh(madk, txtMaNghanh.Text, txtTenNghanh.Text, Int32.Parse(txtSoL.Text), cbMaKhoa.SelectedValue.ToString(), Int32.Parse(txtSDT.Text), txtEmail.Text, txtDiaChi.Text);
                    MessageBox.Show("Sửa nghành " + this.txtMaNghanh.Text + " thành công");
                    loadData();
                }
                catch
                {
                    MessageBox.Show(" Sửa nghành với mã " + this.txtMaNghanh.Text + "không thành công vì mã đó đã có. Bạn hãy nhập mã khác");
                    txtMaNghanh.Focus();
                    txtMaNghanh.Text = "";

                }
            }                     
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaNghanh.TextLength.ToString().Trim()== "")
            {
                MessageBox.Show("bạn phải nhập mã nghành ");
                txtMaNghanh.Focus();
                return;
            }
            if (txtTenNghanh.TextLength == 0)
            {
                MessageBox.Show("bạn phải nhập tên nghành ");
                txtTenNghanh.Focus();
                return;
            }
            else if (txtMaNghanh.TextLength > 11)
            {
                MessageBox.Show(" Mã không vượt quá 10 kí tự");
                txtMaNghanh.ResetText();
                return;
            }
            else
            {
                try
                {
                    int Num;
                    bool ktra = int.TryParse(txtSDT.Text.Trim(), out Num);
                    if (!ktra)
                    {
                        MessageBox.Show("hãy nhập số");
                        txtSDT.ResetText();
                        txtSDT.Focus();
                        return;
                    }
                    int Num1;
                    bool ktra1 = int.TryParse(txtSoL.Text.Trim(), out Num1);
                    if (!ktra1)
                    {
                        MessageBox.Show("hãy nhập số");
                        txtSoL.ResetText();
                        txtSoL.Focus();
                        return;
                    }
                    else
                    {
                        nghanh.InsertNghanh(txtMaNghanh.Text, txtTenNghanh.Text, Int32.Parse(txtSoL.Text), cbMaKhoa.SelectedValue.ToString(), Int32.Parse(txtSDT.Text), txtEmail.Text, txtDiaChi.Text);
                        MessageBox.Show("Thêm nghành " + this.txtMaNghanh.Text + " thành công");
                        loadData();
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm nghành với mã " + this.txtMaNghanh.Text + "không thành công vì đã tồn tại");
                    txtMaNghanh.Focus();
                    txtMaNghanh.Text = "";

                }
            }                     
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            loadCombox();
            loadData();
        }

        

    }
}
