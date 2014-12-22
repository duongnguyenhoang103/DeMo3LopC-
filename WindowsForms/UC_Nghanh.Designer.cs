namespace WindowsForms
{
    partial class UC_Nghanh
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dockContainerItem1 = new DevComponents.DotNetBar.DockContainerItem();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNganh = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaNghanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNghanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMaKhoa = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtSoL = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenNghanh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSDT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaNghanh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bttNew = new DevComponents.DotNetBar.ButtonX();
            this.btXoa = new DevComponents.DotNetBar.ButtonX();
            this.btSua = new DevComponents.DotNetBar.ButtonX();
            this.btThem = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganh)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockContainerItem1
            // 
            this.dockContainerItem1.Name = "dockContainerItem1";
            this.dockContainerItem1.Text = "dockContainerItem1";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.panel3);
            this.panelEx1.Controls.Add(this.panel2);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(772, 495);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(772, 427);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNganh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nghành";
            // 
            // dgvNganh
            // 
            this.dgvNganh.AllowUserToAddRows = false;
            this.dgvNganh.AllowUserToDeleteRows = false;
            this.dgvNganh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNghanh,
            this.TenNghanh,
            this.SoLop,
            this.MaKhoa,
            this.SDT,
            this.Email,
            this.DiaChi});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNganh.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNganh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvNganh.Location = new System.Drawing.Point(3, 22);
            this.dgvNganh.Name = "dgvNganh";
            this.dgvNganh.ReadOnly = true;
            this.dgvNganh.Size = new System.Drawing.Size(766, 246);
            this.dgvNganh.TabIndex = 1;
            this.dgvNganh.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNganh_RowEnter);
            // 
            // MaNghanh
            // 
            this.MaNghanh.DataPropertyName = "MaNghanh";
            this.MaNghanh.HeaderText = "Mã nghành";
            this.MaNghanh.Name = "MaNghanh";
            this.MaNghanh.ReadOnly = true;
            this.MaNghanh.Width = 140;
            // 
            // TenNghanh
            // 
            this.TenNghanh.DataPropertyName = "TenNghanh";
            this.TenNghanh.HeaderText = "Tên nghành";
            this.TenNghanh.Name = "TenNghanh";
            this.TenNghanh.ReadOnly = true;
            this.TenNghanh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenNghanh.Width = 250;
            // 
            // SoLop
            // 
            this.SoLop.DataPropertyName = "SoLop";
            this.SoLop.HeaderText = "Số lớp";
            this.SoLop.Name = "SoLop";
            this.SoLop.ReadOnly = true;
            // 
            // MaKhoa
            // 
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = "Mã khoa";
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.ReadOnly = true;
            this.MaKhoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaKhoa.Width = 120;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SDT.Width = 150;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Email.Width = 200;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbMaKhoa);
            this.panel1.Controls.Add(this.txtSoL);
            this.panel1.Controls.Add(this.txtTenNghanh);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtMaNghanh);
            this.panel1.Controls.Add(this.labelX4);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.labelX7);
            this.panel1.Controls.Add(this.labelX6);
            this.panel1.Controls.Add(this.labelX5);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 156);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // cbMaKhoa
            // 
            this.cbMaKhoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMaKhoa.DisplayMember = "Text";
            this.cbMaKhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaKhoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaKhoa.FormattingEnabled = true;
            this.cbMaKhoa.ItemHeight = 19;
            this.cbMaKhoa.Location = new System.Drawing.Point(136, 106);
            this.cbMaKhoa.Name = "cbMaKhoa";
            this.cbMaKhoa.Size = new System.Drawing.Size(170, 25);
            this.cbMaKhoa.TabIndex = 2;
            this.cbMaKhoa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbMaKhoa_MouseClick);
            // 
            // txtSoL
            // 
            this.txtSoL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtSoL.Border.Class = "TextBoxBorder";
            this.txtSoL.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoL.Location = new System.Drawing.Point(136, 76);
            this.txtSoL.Name = "txtSoL";
            this.txtSoL.Size = new System.Drawing.Size(207, 25);
            this.txtSoL.TabIndex = 1;
            // 
            // txtTenNghanh
            // 
            this.txtTenNghanh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtTenNghanh.Border.Class = "TextBoxBorder";
            this.txtTenNghanh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNghanh.Location = new System.Drawing.Point(136, 47);
            this.txtTenNghanh.Name = "txtTenNghanh";
            this.txtTenNghanh.Size = new System.Drawing.Size(207, 25);
            this.txtTenNghanh.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtSDT.Border.Class = "TextBoxBorder";
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(537, 79);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(201, 25);
            this.txtSDT.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(537, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 25);
            this.txtEmail.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(537, 17);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(201, 25);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtMaNghanh
            // 
            this.txtMaNghanh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtMaNghanh.Border.Class = "TextBoxBorder";
            this.txtMaNghanh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNghanh.Location = new System.Drawing.Point(136, 18);
            this.txtMaNghanh.Name = "txtMaNghanh";
            this.txtMaNghanh.Size = new System.Drawing.Size(207, 25);
            this.txtMaNghanh.TabIndex = 1;
            // 
            // labelX4
            // 
            this.labelX4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(25, 105);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Mã khoa";
            // 
            // labelX3
            // 
            this.labelX3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(25, 76);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Số lớp";
            // 
            // labelX2
            // 
            this.labelX2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(25, 47);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(105, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Tên nghành";
            // 
            // labelX7
            // 
            this.labelX7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(429, 80);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(97, 23);
            this.labelX7.TabIndex = 0;
            this.labelX7.Text = "Số điện thoại";
            // 
            // labelX6
            // 
            this.labelX6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(429, 48);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Email";
            // 
            // labelX5
            // 
            this.labelX5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(429, 18);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Địa chỉ";
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(25, 18);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã nghành";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bttNew);
            this.panel2.Controls.Add(this.btXoa);
            this.panel2.Controls.Add(this.btSua);
            this.panel2.Controls.Add(this.btThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 427);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 68);
            this.panel2.TabIndex = 1;
            // 
            // bttNew
            // 
            this.bttNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bttNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bttNew.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.bttNew.Location = new System.Drawing.Point(192, 13);
            this.bttNew.Name = "bttNew";
            this.bttNew.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12, 0, 0, 12);
            this.bttNew.Size = new System.Drawing.Size(75, 43);
            this.bttNew.TabIndex = 10;
            this.bttNew.Text = "Nhập mới";
            this.bttNew.Click += new System.EventHandler(this.bttNew_Click);
            // 
            // btXoa
            // 
            this.btXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btXoa.Location = new System.Drawing.Point(506, 13);
            this.btXoa.Name = "btXoa";
            this.btXoa.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12, 0, 0, 12);
            this.btXoa.Size = new System.Drawing.Size(75, 43);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btSua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btSua.Location = new System.Drawing.Point(406, 13);
            this.btSua.Name = "btSua";
            this.btSua.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12, 0, 0, 12);
            this.btSua.Size = new System.Drawing.Size(75, 43);
            this.btSua.TabIndex = 8;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btThem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btThem.Location = new System.Drawing.Point(296, 13);
            this.btThem.Name = "btThem";
            this.btThem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12, 0, 0, 12);
            this.btThem.Size = new System.Drawing.Size(75, 43);
            this.btThem.TabIndex = 7;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // UC_Nghanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Name = "UC_Nghanh";
            this.Size = new System.Drawing.Size(772, 495);
            this.Load += new System.EventHandler(this.UC_Nghanh_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UC_Nghanh_MouseDoubleClick);
            this.panelEx1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.DockContainerItem dockContainerItem1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoL;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenNghanh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaNghanh;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMaKhoa;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSDT;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNghanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNghanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private DevComponents.DotNetBar.ButtonX bttNew;
        private DevComponents.DotNetBar.ButtonX btXoa;
        private DevComponents.DotNetBar.ButtonX btSua;
        private DevComponents.DotNetBar.ButtonX btThem;
    }
}
