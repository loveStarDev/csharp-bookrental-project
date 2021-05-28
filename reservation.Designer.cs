namespace Final_Project
{
    partial class reservation
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reservation));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_logo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dataset1 = new Final_Project.dataset1();
            this.oracleConnection1 = new Oracle.ManagedDataAccess.Client.OracleConnection();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_reservation = new System.Windows.Forms.Panel();
            this.textbox_explain = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.Label_reservation = new Bunifu.UI.WinForms.BunifuLabel();
            this.button_reservation_acceess = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox_reservation_search = new System.Windows.Forms.GroupBox();
            this.button_reservation_searching = new Bunifu.Framework.UI.BunifuThinButton2();
            this.textBox_reservation_searching = new System.Windows.Forms.TextBox();
            this.comboBox_reservation_searching = new System.Windows.Forms.ComboBox();
            this.dataGridView_reservation = new System.Windows.Forms.DataGridView();
            this.iIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iAUTHORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPUBLISHERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGENREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPURCHASEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oLOCATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iRENTALCOSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iRETURNDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPANELTYCOSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIEWWILLRESERVATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIEW_WILL_RESERVATIONTableAdapter = new Final_Project.dataset1TableAdapters.VIEW_WILL_RESERVATIONTableAdapter();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox_exit = new System.Windows.Forms.PictureBox();
            this.pictureBox_minimum = new System.Windows.Forms.PictureBox();
            this.reservatioN_BOOKSTableAdapter1 = new Final_Project.dataset1TableAdapters.RESERVATION_BOOKSTableAdapter();
            this.owN_BOOKSTableAdapter1 = new Final_Project.dataset1TableAdapters.OWN_BOOKSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataset1)).BeginInit();
            this.panel_main.SuspendLayout();
            this.panel_reservation.SuspendLayout();
            this.groupBox_reservation_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_reservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWWILLRESERVATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimum)).BeginInit();
            this.SuspendLayout();
            // 
            // label_logo
            // 
            this.label_logo.Enabled = false;
            this.label_logo.Font = new System.Drawing.Font("Lemon", 45F);
            this.label_logo.Location = new System.Drawing.Point(89, 2);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(370, 78);
            this.label_logo.TabIndex = 8;
            this.label_logo.Text = "Customer";
            this.bunifuToolTip1.SetToolTip(this.label_logo, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label_logo, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label_logo, "");
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 18;
            this.bunifuElipse.TargetControl = this;
            // 
            // dataset1
            // 
            this.dataset1.DataSetName = "dataset1";
            this.dataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.Credential = null;
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Black;
            this.panel_main.Controls.Add(this.panel_reservation);
            this.panel_main.Location = new System.Drawing.Point(0, 85);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(971, 637);
            this.panel_main.TabIndex = 10;
            this.bunifuToolTip1.SetToolTip(this.panel_main, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel_main, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel_main, "");
            // 
            // panel_reservation
            // 
            this.panel_reservation.BackColor = System.Drawing.SystemColors.Menu;
            this.panel_reservation.Controls.Add(this.textbox_explain);
            this.panel_reservation.Controls.Add(this.Label_reservation);
            this.panel_reservation.Controls.Add(this.button_reservation_acceess);
            this.panel_reservation.Controls.Add(this.groupBox_reservation_search);
            this.panel_reservation.Controls.Add(this.dataGridView_reservation);
            this.panel_reservation.ForeColor = System.Drawing.Color.Black;
            this.panel_reservation.Location = new System.Drawing.Point(0, 9);
            this.panel_reservation.Name = "panel_reservation";
            this.panel_reservation.Size = new System.Drawing.Size(971, 617);
            this.panel_reservation.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.panel_reservation, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel_reservation, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel_reservation, "");
            // 
            // textbox_explain
            // 
            this.textbox_explain.AcceptsReturn = false;
            this.textbox_explain.AcceptsTab = false;
            this.textbox_explain.AnimationSpeed = 200;
            this.textbox_explain.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textbox_explain.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textbox_explain.BackColor = System.Drawing.Color.Transparent;
            this.textbox_explain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textbox_explain.BackgroundImage")));
            this.textbox_explain.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.textbox_explain.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textbox_explain.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.textbox_explain.BorderColorIdle = System.Drawing.Color.Silver;
            this.textbox_explain.BorderRadius = 3;
            this.textbox_explain.BorderThickness = 1;
            this.textbox_explain.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textbox_explain.Cursor = System.Windows.Forms.Cursors.Default;
            this.textbox_explain.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.textbox_explain.DefaultText = "ppppui";
            this.textbox_explain.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textbox_explain.ForeColor = System.Drawing.Color.Black;
            this.textbox_explain.HideSelection = true;
            this.textbox_explain.IconLeft = null;
            this.textbox_explain.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.textbox_explain.IconPadding = 10;
            this.textbox_explain.IconRight = null;
            this.textbox_explain.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.textbox_explain.Lines = new string[] {
        "ppppui"};
            this.textbox_explain.Location = new System.Drawing.Point(558, 99);
            this.textbox_explain.MaxLength = 32767;
            this.textbox_explain.MinimumSize = new System.Drawing.Size(100, 35);
            this.textbox_explain.Modified = false;
            this.textbox_explain.Multiline = true;
            this.textbox_explain.Name = "textbox_explain";
            stateProperties5.BorderColor = System.Drawing.Color.Transparent;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textbox_explain.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.textbox_explain.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.Red;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textbox_explain.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties8.ForeColor = System.Drawing.Color.Black;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textbox_explain.OnIdleState = stateProperties8;
            this.textbox_explain.PasswordChar = '\0';
            this.textbox_explain.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.textbox_explain.PlaceholderText = "";
            this.textbox_explain.ReadOnly = true;
            this.textbox_explain.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_explain.SelectedText = "";
            this.textbox_explain.SelectionLength = 0;
            this.textbox_explain.SelectionStart = 6;
            this.textbox_explain.ShortcutsEnabled = true;
            this.textbox_explain.Size = new System.Drawing.Size(406, 448);
            this.textbox_explain.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.textbox_explain.TabIndex = 18;
            this.textbox_explain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_explain.TextMarginBottom = 0;
            this.textbox_explain.TextMarginLeft = 5;
            this.textbox_explain.TextMarginTop = 0;
            this.textbox_explain.TextPlaceholder = "";
            this.bunifuToolTip1.SetToolTip(this.textbox_explain, "예약 도서의 정보입니다. 동의하신다면 예약신청 버튼을 눌러주세요!");
            this.bunifuToolTip1.SetToolTipIcon(this.textbox_explain, null);
            this.bunifuToolTip1.SetToolTipTitle(this.textbox_explain, "확인");
            this.textbox_explain.UseSystemPasswordChar = false;
            this.textbox_explain.WordWrap = true;
            // 
            // Label_reservation
            // 
            this.Label_reservation.AutoEllipsis = true;
            this.Label_reservation.CursorType = null;
            this.Label_reservation.Font = new System.Drawing.Font("휴먼옛체", 48F, System.Drawing.FontStyle.Bold);
            this.Label_reservation.ForeColor = System.Drawing.Color.Crimson;
            this.Label_reservation.Location = new System.Drawing.Point(362, 17);
            this.Label_reservation.Name = "Label_reservation";
            this.Label_reservation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_reservation.Size = new System.Drawing.Size(259, 70);
            this.Label_reservation.TabIndex = 17;
            this.Label_reservation.Text = "도서예약";
            this.Label_reservation.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Label_reservation.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.Label_reservation, "도서예약을 하시려면 왼쪽에서 도서를 선택하고 오른쪽\r\n내용을 확인 후 예약신청 을 눌러주시길 바랍니다.");
            this.bunifuToolTip1.SetToolTipIcon(this.Label_reservation, global::Final_Project.Properties.Resources.document_add_icon);
            this.bunifuToolTip1.SetToolTipTitle(this.Label_reservation, "안내");
            // 
            // button_reservation_acceess
            // 
            this.button_reservation_acceess.ActiveBorderThickness = 1;
            this.button_reservation_acceess.ActiveCornerRadius = 20;
            this.button_reservation_acceess.ActiveFillColor = System.Drawing.Color.IndianRed;
            this.button_reservation_acceess.ActiveForecolor = System.Drawing.Color.White;
            this.button_reservation_acceess.ActiveLineColor = System.Drawing.Color.IndianRed;
            this.button_reservation_acceess.BackColor = System.Drawing.SystemColors.Menu;
            this.button_reservation_acceess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_reservation_acceess.BackgroundImage")));
            this.button_reservation_acceess.ButtonText = "예약신청";
            this.button_reservation_acceess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reservation_acceess.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.button_reservation_acceess.ForeColor = System.Drawing.Color.White;
            this.button_reservation_acceess.IdleBorderThickness = 1;
            this.button_reservation_acceess.IdleCornerRadius = 20;
            this.button_reservation_acceess.IdleFillColor = System.Drawing.Color.DarkRed;
            this.button_reservation_acceess.IdleForecolor = System.Drawing.Color.SeaShell;
            this.button_reservation_acceess.IdleLineColor = System.Drawing.Color.Black;
            this.button_reservation_acceess.Location = new System.Drawing.Point(562, 550);
            this.button_reservation_acceess.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.button_reservation_acceess.Name = "button_reservation_acceess";
            this.button_reservation_acceess.Size = new System.Drawing.Size(402, 59);
            this.button_reservation_acceess.TabIndex = 16;
            this.button_reservation_acceess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.button_reservation_acceess, "");
            this.bunifuToolTip1.SetToolTipIcon(this.button_reservation_acceess, null);
            this.bunifuToolTip1.SetToolTipTitle(this.button_reservation_acceess, "");
            this.button_reservation_acceess.Click += new System.EventHandler(this.button_reservation_acceess_Click);
            // 
            // groupBox_reservation_search
            // 
            this.groupBox_reservation_search.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_reservation_search.Controls.Add(this.button_reservation_searching);
            this.groupBox_reservation_search.Controls.Add(this.textBox_reservation_searching);
            this.groupBox_reservation_search.Controls.Add(this.comboBox_reservation_searching);
            this.groupBox_reservation_search.ForeColor = System.Drawing.Color.Black;
            this.groupBox_reservation_search.Location = new System.Drawing.Point(6, 94);
            this.groupBox_reservation_search.Name = "groupBox_reservation_search";
            this.groupBox_reservation_search.Size = new System.Drawing.Size(546, 75);
            this.groupBox_reservation_search.TabIndex = 15;
            this.groupBox_reservation_search.TabStop = false;
            this.groupBox_reservation_search.Text = "도서검색";
            this.bunifuToolTip1.SetToolTip(this.groupBox_reservation_search, "");
            this.bunifuToolTip1.SetToolTipIcon(this.groupBox_reservation_search, null);
            this.bunifuToolTip1.SetToolTipTitle(this.groupBox_reservation_search, "");
            // 
            // button_reservation_searching
            // 
            this.button_reservation_searching.ActiveBorderThickness = 1;
            this.button_reservation_searching.ActiveCornerRadius = 20;
            this.button_reservation_searching.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.button_reservation_searching.ActiveForecolor = System.Drawing.Color.White;
            this.button_reservation_searching.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.button_reservation_searching.BackColor = System.Drawing.Color.Transparent;
            this.button_reservation_searching.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_reservation_searching.BackgroundImage")));
            this.button_reservation_searching.ButtonText = "검색";
            this.button_reservation_searching.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reservation_searching.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reservation_searching.ForeColor = System.Drawing.Color.SeaShell;
            this.button_reservation_searching.IdleBorderThickness = 1;
            this.button_reservation_searching.IdleCornerRadius = 20;
            this.button_reservation_searching.IdleFillColor = System.Drawing.Color.MidnightBlue;
            this.button_reservation_searching.IdleForecolor = System.Drawing.Color.SeaShell;
            this.button_reservation_searching.IdleLineColor = System.Drawing.Color.Indigo;
            this.button_reservation_searching.Location = new System.Drawing.Point(447, 18);
            this.button_reservation_searching.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_reservation_searching.Name = "button_reservation_searching";
            this.button_reservation_searching.Size = new System.Drawing.Size(89, 40);
            this.button_reservation_searching.TabIndex = 8;
            this.button_reservation_searching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.button_reservation_searching, "");
            this.bunifuToolTip1.SetToolTipIcon(this.button_reservation_searching, null);
            this.bunifuToolTip1.SetToolTipTitle(this.button_reservation_searching, "");
            this.button_reservation_searching.Click += new System.EventHandler(this.button_reservation_searching_Click);
            // 
            // textBox_reservation_searching
            // 
            this.textBox_reservation_searching.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_reservation_searching.Location = new System.Drawing.Point(128, 26);
            this.textBox_reservation_searching.Name = "textBox_reservation_searching";
            this.textBox_reservation_searching.Size = new System.Drawing.Size(307, 26);
            this.textBox_reservation_searching.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.textBox_reservation_searching, "");
            this.bunifuToolTip1.SetToolTipIcon(this.textBox_reservation_searching, null);
            this.bunifuToolTip1.SetToolTipTitle(this.textBox_reservation_searching, "");
            // 
            // comboBox_reservation_searching
            // 
            this.comboBox_reservation_searching.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox_reservation_searching.FormattingEnabled = true;
            this.comboBox_reservation_searching.Items.AddRange(new object[] {
            "도서명",
            "저자",
            "출판사",
            "도서관리등급",
            "장르"});
            this.comboBox_reservation_searching.Location = new System.Drawing.Point(18, 28);
            this.comboBox_reservation_searching.Name = "comboBox_reservation_searching";
            this.comboBox_reservation_searching.Size = new System.Drawing.Size(104, 24);
            this.comboBox_reservation_searching.TabIndex = 0;
            this.comboBox_reservation_searching.Text = "도서명";
            this.bunifuToolTip1.SetToolTip(this.comboBox_reservation_searching, "");
            this.bunifuToolTip1.SetToolTipIcon(this.comboBox_reservation_searching, null);
            this.bunifuToolTip1.SetToolTipTitle(this.comboBox_reservation_searching, "");
            // 
            // dataGridView_reservation
            // 
            this.dataGridView_reservation.AllowUserToAddRows = false;
            this.dataGridView_reservation.AllowUserToDeleteRows = false;
            this.dataGridView_reservation.AutoGenerateColumns = false;
            this.dataGridView_reservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_reservation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_reservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_reservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_reservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iIDDataGridViewTextBoxColumn,
            this.oIDDataGridViewTextBoxColumn,
            this.iNAMEDataGridViewTextBoxColumn,
            this.iAUTHORDataGridViewTextBoxColumn,
            this.iPUBLISHERDataGridViewTextBoxColumn,
            this.oGRADEDataGridViewTextBoxColumn,
            this.iGENREDataGridViewTextBoxColumn,
            this.oSTATEDataGridViewTextBoxColumn,
            this.oPURCHASEDATEDataGridViewTextBoxColumn,
            this.oLOCATIONDataGridViewTextBoxColumn,
            this.iRENTALCOSTDataGridViewTextBoxColumn,
            this.iRETURNDATEDataGridViewTextBoxColumn,
            this.iPANELTYCOSTDataGridViewTextBoxColumn});
            this.dataGridView_reservation.DataSource = this.vIEWWILLRESERVATIONBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_reservation.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_reservation.Location = new System.Drawing.Point(6, 175);
            this.dataGridView_reservation.Name = "dataGridView_reservation";
            this.dataGridView_reservation.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_reservation.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_reservation.RowTemplate.Height = 23;
            this.dataGridView_reservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_reservation.Size = new System.Drawing.Size(546, 433);
            this.dataGridView_reservation.TabIndex = 14;
            this.bunifuToolTip1.SetToolTip(this.dataGridView_reservation, "");
            this.bunifuToolTip1.SetToolTipIcon(this.dataGridView_reservation, null);
            this.bunifuToolTip1.SetToolTipTitle(this.dataGridView_reservation, "");
            this.dataGridView_reservation.SelectionChanged += new System.EventHandler(this.dataGridView_reservation_SelectionChanged);
            // 
            // iIDDataGridViewTextBoxColumn
            // 
            this.iIDDataGridViewTextBoxColumn.DataPropertyName = "I_ID";
            this.iIDDataGridViewTextBoxColumn.HeaderText = "I_ID";
            this.iIDDataGridViewTextBoxColumn.Name = "iIDDataGridViewTextBoxColumn";
            this.iIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iIDDataGridViewTextBoxColumn.Visible = false;
            this.iIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // oIDDataGridViewTextBoxColumn
            // 
            this.oIDDataGridViewTextBoxColumn.DataPropertyName = "O_ID";
            this.oIDDataGridViewTextBoxColumn.HeaderText = "O_ID";
            this.oIDDataGridViewTextBoxColumn.Name = "oIDDataGridViewTextBoxColumn";
            this.oIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oIDDataGridViewTextBoxColumn.Visible = false;
            this.oIDDataGridViewTextBoxColumn.Width = 56;
            // 
            // iNAMEDataGridViewTextBoxColumn
            // 
            this.iNAMEDataGridViewTextBoxColumn.DataPropertyName = "I_NAME";
            this.iNAMEDataGridViewTextBoxColumn.HeaderText = "도서명";
            this.iNAMEDataGridViewTextBoxColumn.Name = "iNAMEDataGridViewTextBoxColumn";
            this.iNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNAMEDataGridViewTextBoxColumn.Width = 61;
            // 
            // iAUTHORDataGridViewTextBoxColumn
            // 
            this.iAUTHORDataGridViewTextBoxColumn.DataPropertyName = "I_AUTHOR";
            this.iAUTHORDataGridViewTextBoxColumn.HeaderText = "저자";
            this.iAUTHORDataGridViewTextBoxColumn.Name = "iAUTHORDataGridViewTextBoxColumn";
            this.iAUTHORDataGridViewTextBoxColumn.ReadOnly = true;
            this.iAUTHORDataGridViewTextBoxColumn.Width = 51;
            // 
            // iPUBLISHERDataGridViewTextBoxColumn
            // 
            this.iPUBLISHERDataGridViewTextBoxColumn.DataPropertyName = "I_PUBLISHER";
            this.iPUBLISHERDataGridViewTextBoxColumn.HeaderText = "출판사";
            this.iPUBLISHERDataGridViewTextBoxColumn.Name = "iPUBLISHERDataGridViewTextBoxColumn";
            this.iPUBLISHERDataGridViewTextBoxColumn.ReadOnly = true;
            this.iPUBLISHERDataGridViewTextBoxColumn.Width = 61;
            // 
            // oGRADEDataGridViewTextBoxColumn
            // 
            this.oGRADEDataGridViewTextBoxColumn.DataPropertyName = "O_GRADE";
            this.oGRADEDataGridViewTextBoxColumn.HeaderText = "도서관리등급";
            this.oGRADEDataGridViewTextBoxColumn.Name = "oGRADEDataGridViewTextBoxColumn";
            this.oGRADEDataGridViewTextBoxColumn.ReadOnly = true;
            this.oGRADEDataGridViewTextBoxColumn.Width = 72;
            // 
            // iGENREDataGridViewTextBoxColumn
            // 
            this.iGENREDataGridViewTextBoxColumn.DataPropertyName = "I_GENRE";
            this.iGENREDataGridViewTextBoxColumn.HeaderText = "장르";
            this.iGENREDataGridViewTextBoxColumn.Name = "iGENREDataGridViewTextBoxColumn";
            this.iGENREDataGridViewTextBoxColumn.ReadOnly = true;
            this.iGENREDataGridViewTextBoxColumn.Width = 51;
            // 
            // oSTATEDataGridViewTextBoxColumn
            // 
            this.oSTATEDataGridViewTextBoxColumn.DataPropertyName = "O_STATE";
            this.oSTATEDataGridViewTextBoxColumn.HeaderText = "예약가능여부";
            this.oSTATEDataGridViewTextBoxColumn.Name = "oSTATEDataGridViewTextBoxColumn";
            this.oSTATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.oSTATEDataGridViewTextBoxColumn.Width = 72;
            // 
            // oPURCHASEDATEDataGridViewTextBoxColumn
            // 
            this.oPURCHASEDATEDataGridViewTextBoxColumn.DataPropertyName = "O_PURCHASE_DATE";
            this.oPURCHASEDATEDataGridViewTextBoxColumn.HeaderText = "O_PURCHASE_DATE";
            this.oPURCHASEDATEDataGridViewTextBoxColumn.Name = "oPURCHASEDATEDataGridViewTextBoxColumn";
            this.oPURCHASEDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.oPURCHASEDATEDataGridViewTextBoxColumn.Visible = false;
            this.oPURCHASEDATEDataGridViewTextBoxColumn.Width = 148;
            // 
            // oLOCATIONDataGridViewTextBoxColumn
            // 
            this.oLOCATIONDataGridViewTextBoxColumn.DataPropertyName = "O_LOCATION";
            this.oLOCATIONDataGridViewTextBoxColumn.HeaderText = "O_LOCATION";
            this.oLOCATIONDataGridViewTextBoxColumn.Name = "oLOCATIONDataGridViewTextBoxColumn";
            this.oLOCATIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.oLOCATIONDataGridViewTextBoxColumn.Visible = false;
            this.oLOCATIONDataGridViewTextBoxColumn.Width = 107;
            // 
            // iRENTALCOSTDataGridViewTextBoxColumn
            // 
            this.iRENTALCOSTDataGridViewTextBoxColumn.DataPropertyName = "I_RENTAL_COST";
            this.iRENTALCOSTDataGridViewTextBoxColumn.HeaderText = "I_RENTAL_COST";
            this.iRENTALCOSTDataGridViewTextBoxColumn.Name = "iRENTALCOSTDataGridViewTextBoxColumn";
            this.iRENTALCOSTDataGridViewTextBoxColumn.ReadOnly = true;
            this.iRENTALCOSTDataGridViewTextBoxColumn.Visible = false;
            this.iRENTALCOSTDataGridViewTextBoxColumn.Width = 127;
            // 
            // iRETURNDATEDataGridViewTextBoxColumn
            // 
            this.iRETURNDATEDataGridViewTextBoxColumn.DataPropertyName = "I_RETURN_DATE";
            this.iRETURNDATEDataGridViewTextBoxColumn.HeaderText = "I_RETURN_DATE";
            this.iRETURNDATEDataGridViewTextBoxColumn.Name = "iRETURNDATEDataGridViewTextBoxColumn";
            this.iRETURNDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iRETURNDATEDataGridViewTextBoxColumn.Visible = false;
            this.iRETURNDATEDataGridViewTextBoxColumn.Width = 126;
            // 
            // iPANELTYCOSTDataGridViewTextBoxColumn
            // 
            this.iPANELTYCOSTDataGridViewTextBoxColumn.DataPropertyName = "I_PANELTY_COST";
            this.iPANELTYCOSTDataGridViewTextBoxColumn.HeaderText = "I_PANELTY_COST";
            this.iPANELTYCOSTDataGridViewTextBoxColumn.Name = "iPANELTYCOSTDataGridViewTextBoxColumn";
            this.iPANELTYCOSTDataGridViewTextBoxColumn.ReadOnly = true;
            this.iPANELTYCOSTDataGridViewTextBoxColumn.Visible = false;
            this.iPANELTYCOSTDataGridViewTextBoxColumn.Width = 135;
            // 
            // vIEWWILLRESERVATIONBindingSource
            // 
            this.vIEWWILLRESERVATIONBindingSource.DataMember = "VIEW_WILL_RESERVATION";
            this.vIEWWILLRESERVATIONBindingSource.DataSource = this.dataset1;
            // 
            // vIEW_WILL_RESERVATIONTableAdapter
            // 
            this.vIEW_WILL_RESERVATIONTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = "Information";
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logo.Enabled = false;
            this.pictureBox_logo.Image = global::Final_Project.Properties.Resources._9405e34df4de152cba0e31c040f5675e_open_book_round_icon1;
            this.pictureBox_logo.Location = new System.Drawing.Point(12, 4);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(85, 78);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 5;
            this.pictureBox_logo.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox_logo, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox_logo, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox_logo, "");
            // 
            // pictureBox_exit
            // 
            this.pictureBox_exit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_exit.Image")));
            this.pictureBox_exit.Location = new System.Drawing.Point(937, 17);
            this.pictureBox_exit.Name = "pictureBox_exit";
            this.pictureBox_exit.Size = new System.Drawing.Size(19, 9);
            this.pictureBox_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_exit.TabIndex = 7;
            this.pictureBox_exit.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox_exit, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox_exit, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox_exit, "");
            this.pictureBox_exit.Click += new System.EventHandler(this.pictureBox_exit_Click);
            // 
            // pictureBox_minimum
            // 
            this.pictureBox_minimum.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_minimum.Image")));
            this.pictureBox_minimum.Location = new System.Drawing.Point(923, 17);
            this.pictureBox_minimum.Name = "pictureBox_minimum";
            this.pictureBox_minimum.Size = new System.Drawing.Size(9, 9);
            this.pictureBox_minimum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_minimum.TabIndex = 6;
            this.pictureBox_minimum.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox_minimum, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox_minimum, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox_minimum, "");
            this.pictureBox_minimum.Click += new System.EventHandler(this.pictureBox_minimum_Click);
            // 
            // reservatioN_BOOKSTableAdapter1
            // 
            this.reservatioN_BOOKSTableAdapter1.ClearBeforeFill = true;
            // 
            // owN_BOOKSTableAdapter1
            // 
            this.owN_BOOKSTableAdapter1.ClearBeforeFill = true;
            // 
            // reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(971, 750);
            this.Controls.Add(this.label_logo);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.pictureBox_exit);
            this.Controls.Add(this.pictureBox_minimum);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reservation";
            this.Text = "reservation";
            this.Load += new System.EventHandler(this.reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataset1)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_reservation.ResumeLayout(false);
            this.panel_reservation.PerformLayout();
            this.groupBox_reservation_search.ResumeLayout(false);
            this.groupBox_reservation_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_reservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWWILLRESERVATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.PictureBox pictureBox_exit;
        private System.Windows.Forms.PictureBox pictureBox_minimum;
        private Bunifu.Framework.UI.BunifuCustomLabel label_logo;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private dataset1 dataset1;
        private Oracle.ManagedDataAccess.Client.OracleConnection oracleConnection1;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_reservation;
        private Bunifu.Framework.UI.BunifuThinButton2 button_reservation_acceess;
        private System.Windows.Forms.GroupBox groupBox_reservation_search;
        private System.Windows.Forms.DataGridView dataGridView_reservation;
        private Bunifu.Framework.UI.BunifuThinButton2 button_reservation_searching;
        private System.Windows.Forms.TextBox textBox_reservation_searching;
        private System.Windows.Forms.ComboBox comboBox_reservation_searching;
        private Bunifu.UI.WinForms.BunifuLabel Label_reservation;
        private System.Windows.Forms.BindingSource vIEWWILLRESERVATIONBindingSource;
        private dataset1TableAdapters.VIEW_WILL_RESERVATIONTableAdapter vIEW_WILL_RESERVATIONTableAdapter;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox textbox_explain;
        private dataset1TableAdapters.RESERVATION_BOOKSTableAdapter reservatioN_BOOKSTableAdapter1;
        private dataset1TableAdapters.OWN_BOOKSTableAdapter owN_BOOKSTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iAUTHORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPUBLISHERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGENREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSTATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPURCHASEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oLOCATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iRENTALCOSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iRETURNDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPANELTYCOSTDataGridViewTextBoxColumn;
    }
}