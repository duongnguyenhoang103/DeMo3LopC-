﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessEntity;
namespace WindowsForms
{
    public partial class frmDangN : Form
    {
        NguoiDungBE nguoidg = new NguoiDungBE();
        public Form1 main_from;
        public frmDangN(Form1 f00)
        {
            InitializeComponent();
            main_from = f00;
        }                   

        private void frmDangN_Load(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDN.TextLength == 0)
                {
                    MessageBox.Show(" ban phai nhap tai khoan");
                    txtDN.Focus();
                    return;
                }
                if (txtMK.TextLength == 0)
                {
                    MessageBox.Show(" mat khau khong dc de trong");
                    txtMK.Focus();
                    return;
                }
                else
                {
                    bool kq = nguoidg.CheckLogin(txtDN.Text.Trim(), txtMK.Text.Trim());
                    if (kq == true)
                    {
                        //if (txtDN.Text == "admin")
                        //{
                        //    main_from.ShowAllMenu();
                        //    this.Close();
                        //}
                        //else
                        //    main_from.ShowMenu();
                        //this.Close();

                        // this.Close();
                        //Form1 frm = new Form1();
                        //frm.Show();//
                        main_from.showMenu();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã nhập sai tai khoan hoặc mat khau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDN.Focus();
                        return;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(" Loi" + ex.Message); }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
