namespace QuanLyDuAn.Pages
{
    partial class Page_NhiemVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_NhiemVu));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Xoa = new FontAwesome.Sharp.IconButton();
            this.btn_Them = new FontAwesome.Sharp.IconButton();
            this.cb_ViTri = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cb_PhongBan = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btn_Search = new FontAwesome.Sharp.IconButton();
            this.txt_Search = new Bunifu.UI.WinForms.BunifuTextBox();
            this.dataGridViewMain = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.cb_ViTri);
            this.panel1.Controls.Add(this.cb_PhongBan);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.txt_Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1430, 76);
            this.panel1.TabIndex = 3;
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
            this.cb_ViTri.Location = new System.Drawing.Point(1160, 22);
            this.cb_ViTri.MaxDropDownItems = 20;
            this.cb_ViTri.Name = "cb_ViTri";
            this.cb_ViTri.Size = new System.Drawing.Size(260, 45);
            this.cb_ViTri.TabIndex = 9;
            this.cb_ViTri.Text = "Nhân Viên (Tất Cả)";
            this.cb_ViTri.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cb_ViTri.TextLeftMargin = 5;
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
            this.cb_PhongBan.Location = new System.Drawing.Point(877, 22);
            this.cb_PhongBan.MaxDropDownItems = 20;
            this.cb_PhongBan.Name = "cb_PhongBan";
            this.cb_PhongBan.Size = new System.Drawing.Size(260, 45);
            this.cb_PhongBan.TabIndex = 8;
            this.cb_PhongBan.Text = "Tình Trạng (Tất Cả)";
            this.cb_PhongBan.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cb_PhongBan.TextLeftMargin = 5;
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
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowCustomTheming = false;
            this.dataGridViewMain.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
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
            this.dataGridViewMain.Location = new System.Drawing.Point(19, 98);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersVisible = false;
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.RowTemplate.Height = 40;
            this.dataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMain.Size = new System.Drawing.Size(1401, 620);
            this.dataGridViewMain.TabIndex = 4;
            this.dataGridViewMain.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 100;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "User";
            this.Column2.MinimumWidth = 100;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "%(@Progress)";
            this.Column3.HeaderText = "Progress";
            this.Column3.MinimumWidth = 100;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số Lượng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 126;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Hạn chót";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 122;
            // 
            // Page_NhiemVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.panel1);
            this.Name = "Page_NhiemVu";
            this.Size = new System.Drawing.Size(1430, 744);
            this.Load += new System.EventHandler(this.Page_NhiemVu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Xoa;
        private FontAwesome.Sharp.IconButton btn_Them;
        private Bunifu.UI.WinForms.BunifuDropdown cb_ViTri;
        private Bunifu.UI.WinForms.BunifuDropdown cb_PhongBan;
        private FontAwesome.Sharp.IconButton btn_Search;
        private Bunifu.UI.WinForms.BunifuTextBox txt_Search;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewMain;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
