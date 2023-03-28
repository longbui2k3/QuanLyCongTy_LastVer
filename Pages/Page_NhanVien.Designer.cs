namespace QuanLyDuAn.Pages
{
    partial class Page_NhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_NhanVien));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.dataGridViewMain = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_In = new FontAwesome.Sharp.IconButton();
            this.btn_Luu = new FontAwesome.Sharp.IconButton();
            this.btn_Xoa = new FontAwesome.Sharp.IconButton();
            this.btn_Them = new FontAwesome.Sharp.IconButton();
            this.cb_TinhTrang = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cb_ViTri = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cb_PhongBan = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btn_Search = new FontAwesome.Sharp.IconButton();
            this.txt_Search = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowCustomTheming = false;
            this.dataGridViewMain.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMain.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMain.ColumnHeadersHeight = 40;
            this.dataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column3,
            this.Column9,
            this.Column1,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column2,
            this.Column11});
            this.dataGridViewMain.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewMain.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewMain.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewMain.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewMain.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewMain.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewMain.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewMain.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewMain.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewMain.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewMain.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridViewMain.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewMain.CurrentTheme.Name = null;
            this.dataGridViewMain.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewMain.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewMain.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewMain.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewMain.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMain.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMain.EnableHeadersVisualStyles = false;
            this.dataGridViewMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewMain.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewMain.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewMain.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewMain.Location = new System.Drawing.Point(19, 18);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersVisible = false;
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.RowTemplate.Height = 40;
            this.dataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMain.Size = new System.Drawing.Size(1626, 618);
            this.dataGridViewMain.TabIndex = 0;
            this.dataGridViewMain.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridViewMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellContentClick);
            this.dataGridViewMain.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewMain_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_In);
            this.panel1.Controls.Add(this.btn_Luu);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.cb_TinhTrang);
            this.panel1.Controls.Add(this.cb_ViTri);
            this.panel1.Controls.Add(this.cb_PhongBan);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.txt_Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1662, 76);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_In
            // 
            this.btn_In.AutoSize = true;
            this.btn_In.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_In.FlatAppearance.BorderSize = 0;
            this.btn_In.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_In.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_In.ForeColor = System.Drawing.Color.Transparent;
            this.btn_In.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btn_In.IconColor = System.Drawing.Color.White;
            this.btn_In.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_In.IconSize = 30;
            this.btn_In.Location = new System.Drawing.Point(698, 23);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(94, 44);
            this.btn_In.TabIndex = 14;
            this.btn_In.Text = "In";
            this.btn_In.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_In.UseVisualStyleBackColor = false;
            // 
            // btn_Luu
            // 
            this.btn_Luu.AutoSize = true;
            this.btn_Luu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Luu.FlatAppearance.BorderSize = 0;
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Luu.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btn_Luu.IconColor = System.Drawing.Color.White;
            this.btn_Luu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Luu.IconSize = 30;
            this.btn_Luu.Location = new System.Drawing.Point(588, 24);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(94, 44);
            this.btn_Luu.TabIndex = 13;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Luu.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.AutoSize = true;
            this.btn_Xoa.BackColor = System.Drawing.Color.Red;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btn_Xoa.IconColor = System.Drawing.Color.White;
            this.btn_Xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Xoa.IconSize = 30;
            this.btn_Xoa.Location = new System.Drawing.Point(478, 24);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 44);
            this.btn_Xoa.TabIndex = 12;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.AutoSize = true;
            this.btn_Them.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Them.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btn_Them.IconColor = System.Drawing.Color.White;
            this.btn_Them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Them.IconSize = 30;
            this.btn_Them.Location = new System.Drawing.Point(368, 24);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 44);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // cb_TinhTrang
            // 
            this.cb_TinhTrang.BackColor = System.Drawing.Color.Transparent;
            this.cb_TinhTrang.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.cb_TinhTrang.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cb_TinhTrang.BorderRadius = 1;
            this.cb_TinhTrang.Color = System.Drawing.Color.RoyalBlue;
            this.cb_TinhTrang.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cb_TinhTrang.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb_TinhTrang.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cb_TinhTrang.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb_TinhTrang.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cb_TinhTrang.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cb_TinhTrang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_TinhTrang.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cb_TinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TinhTrang.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cb_TinhTrang.FillDropDown = true;
            this.cb_TinhTrang.FillIndicator = true;
            this.cb_TinhTrang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_TinhTrang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TinhTrang.ForeColor = System.Drawing.Color.White;
            this.cb_TinhTrang.FormattingEnabled = true;
            this.cb_TinhTrang.Icon = null;
            this.cb_TinhTrang.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cb_TinhTrang.IndicatorColor = System.Drawing.Color.White;
            this.cb_TinhTrang.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cb_TinhTrang.ItemBackColor = System.Drawing.Color.RoyalBlue;
            this.cb_TinhTrang.ItemBorderColor = System.Drawing.Color.White;
            this.cb_TinhTrang.ItemForeColor = System.Drawing.Color.Black;
            this.cb_TinhTrang.ItemHeight = 39;
            this.cb_TinhTrang.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cb_TinhTrang.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cb_TinhTrang.Items.AddRange(new object[] {
            "Tình Trạng (Tất Cả)",
            "Đang Làm",
            "Đã Nghỉ Việc"});
            this.cb_TinhTrang.ItemTopMargin = 3;
            this.cb_TinhTrang.Location = new System.Drawing.Point(1366, 23);
            this.cb_TinhTrang.MaxDropDownItems = 20;
            this.cb_TinhTrang.Name = "cb_TinhTrang";
            this.cb_TinhTrang.Size = new System.Drawing.Size(260, 45);
            this.cb_TinhTrang.TabIndex = 10;
            this.cb_TinhTrang.Text = "Tình Trạng (Tất Cả)";
            this.cb_TinhTrang.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cb_TinhTrang.TextLeftMargin = 5;
            this.cb_TinhTrang.SelectedIndexChanged += new System.EventHandler(this.cb_TinhTrang_SelectedIndexChanged);
            // 
            // cb_ViTri
            // 
            this.cb_ViTri.BackColor = System.Drawing.Color.Transparent;
            this.cb_ViTri.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.cb_ViTri.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cb_ViTri.BorderRadius = 1;
            this.cb_ViTri.Color = System.Drawing.Color.RoyalBlue;
            this.cb_ViTri.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cb_ViTri.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb_ViTri.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cb_ViTri.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb_ViTri.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cb_ViTri.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cb_ViTri.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_ViTri.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cb_ViTri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ViTri.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cb_ViTri.FillDropDown = true;
            this.cb_ViTri.FillIndicator = true;
            this.cb_ViTri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ViTri.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ViTri.ForeColor = System.Drawing.Color.White;
            this.cb_ViTri.FormattingEnabled = true;
            this.cb_ViTri.Icon = null;
            this.cb_ViTri.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cb_ViTri.IndicatorColor = System.Drawing.Color.White;
            this.cb_ViTri.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cb_ViTri.ItemBackColor = System.Drawing.Color.RoyalBlue;
            this.cb_ViTri.ItemBorderColor = System.Drawing.Color.White;
            this.cb_ViTri.ItemForeColor = System.Drawing.Color.Black;
            this.cb_ViTri.ItemHeight = 39;
            this.cb_ViTri.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cb_ViTri.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cb_ViTri.ItemTopMargin = 3;
            this.cb_ViTri.Location = new System.Drawing.Point(1088, 22);
            this.cb_ViTri.MaxDropDownItems = 20;
            this.cb_ViTri.Name = "cb_ViTri";
            this.cb_ViTri.Size = new System.Drawing.Size(260, 45);
            this.cb_ViTri.TabIndex = 9;
            this.cb_ViTri.Text = "Vị Trí (Tất Cả)";
            this.cb_ViTri.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cb_ViTri.TextLeftMargin = 5;
            this.cb_ViTri.SelectedIndexChanged += new System.EventHandler(this.cb_ViTri_SelectedIndexChanged);
            // 
            // cb_PhongBan
            // 
            this.cb_PhongBan.BackColor = System.Drawing.Color.Transparent;
            this.cb_PhongBan.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.cb_PhongBan.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cb_PhongBan.BorderRadius = 1;
            this.cb_PhongBan.Color = System.Drawing.Color.RoyalBlue;
            this.cb_PhongBan.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cb_PhongBan.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb_PhongBan.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cb_PhongBan.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb_PhongBan.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cb_PhongBan.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cb_PhongBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_PhongBan.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cb_PhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PhongBan.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cb_PhongBan.FillDropDown = true;
            this.cb_PhongBan.FillIndicator = true;
            this.cb_PhongBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_PhongBan.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_PhongBan.ForeColor = System.Drawing.Color.White;
            this.cb_PhongBan.FormattingEnabled = true;
            this.cb_PhongBan.Icon = null;
            this.cb_PhongBan.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cb_PhongBan.IndicatorColor = System.Drawing.Color.White;
            this.cb_PhongBan.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cb_PhongBan.ItemBackColor = System.Drawing.Color.RoyalBlue;
            this.cb_PhongBan.ItemBorderColor = System.Drawing.Color.White;
            this.cb_PhongBan.ItemForeColor = System.Drawing.Color.Black;
            this.cb_PhongBan.ItemHeight = 39;
            this.cb_PhongBan.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cb_PhongBan.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cb_PhongBan.ItemTopMargin = 6;
            this.cb_PhongBan.Location = new System.Drawing.Point(810, 22);
            this.cb_PhongBan.MaxDropDownItems = 20;
            this.cb_PhongBan.Name = "cb_PhongBan";
            this.cb_PhongBan.Size = new System.Drawing.Size(260, 45);
            this.cb_PhongBan.TabIndex = 8;
            this.cb_PhongBan.Text = "Phòng Ban (Tất Cả)";
            this.cb_PhongBan.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cb_PhongBan.TextLeftMargin = 5;
            this.cb_PhongBan.SelectedIndexChanged += new System.EventHandler(this.cb_PhongBan_SelectedIndexChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.AutoSize = true;
            this.btn_Search.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btn_Search.IconColor = System.Drawing.Color.White;
            this.btn_Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Search.IconSize = 30;
            this.btn_Search.Location = new System.Drawing.Point(305, 24);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(42, 44);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.AcceptsReturn = false;
            this.txt_Search.AcceptsTab = false;
            this.txt_Search.AnimationSpeed = 200;
            this.txt_Search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Search.AutoSize = true;
            this.txt_Search.BackColor = System.Drawing.Color.Transparent;
            this.txt_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_Search.BackgroundImage")));
            this.txt_Search.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_Search.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_Search.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_Search.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_Search.BorderRadius = 1;
            this.txt_Search.BorderThickness = 1;
            this.txt_Search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultFont = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Search.DefaultText = "";
            this.txt_Search.FillColor = System.Drawing.Color.White;
            this.txt_Search.HideSelection = true;
            this.txt_Search.IconLeft = null;
            this.txt_Search.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.IconPadding = 10;
            this.txt_Search.IconRight = null;
            this.txt_Search.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.Lines = new string[0];
            this.txt_Search.Location = new System.Drawing.Point(19, 23);
            this.txt_Search.MaxLength = 32767;
            this.txt_Search.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_Search.Modified = false;
            this.txt_Search.Multiline = false;
            this.txt_Search.Name = "txt_Search";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Search.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_Search.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Search.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Search.OnIdleState = stateProperties4;
            this.txt_Search.Padding = new System.Windows.Forms.Padding(3);
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_Search.PlaceholderText = "Tìm Kiếm Tên";
            this.txt_Search.ReadOnly = false;
            this.txt_Search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Search.SelectedText = "";
            this.txt_Search.SelectionLength = 0;
            this.txt_Search.SelectionStart = 0;
            this.txt_Search.ShortcutsEnabled = true;
            this.txt_Search.Size = new System.Drawing.Size(280, 45);
            this.txt_Search.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_Search.TabIndex = 6;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Search.TextMarginBottom = 0;
            this.txt_Search.TextMarginLeft = 3;
            this.txt_Search.TextMarginTop = 0;
            this.txt_Search.TextPlaceholder = "Tìm Kiếm Tên";
            this.txt_Search.UseSystemPasswordChar = false;
            this.txt_Search.WordWrap = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridViewMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1662, 653);
            this.panel2.TabIndex = 2;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Anh";
            this.Column3.HeaderText = "Ảnh";
            this.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MaNV";
            this.Column9.HeaderText = "Mã Nhân Viên";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "HoTen";
            this.Column1.HeaderText = "Họ Và Tên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.DataPropertyName = "GioiTinh";
            this.Column5.HeaderText = "Giới Tính";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 121;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NgaySinh";
            this.Column6.HeaderText = "Ngày Sinh";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TenPB";
            this.Column8.HeaderText = "Phòng Ban";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenChucVu";
            this.Column2.HeaderText = "Vị Trí";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "TinhTrang";
            this.Column11.HeaderText = "Tình Trạng";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            // 
            // Page_NhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Page_NhanVien";
            this.Size = new System.Drawing.Size(1662, 729);
            this.Load += new System.EventHandler(this.Page_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_Search;
        private Bunifu.UI.WinForms.BunifuTextBox txt_Search;
        private Bunifu.UI.WinForms.BunifuDropdown cb_PhongBan;
        private Bunifu.UI.WinForms.BunifuDropdown cb_TinhTrang;
        private Bunifu.UI.WinForms.BunifuDropdown cb_ViTri;
        private FontAwesome.Sharp.IconButton btn_Luu;
        private FontAwesome.Sharp.IconButton btn_Xoa;
        private FontAwesome.Sharp.IconButton btn_Them;
        private FontAwesome.Sharp.IconButton btn_In;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}
