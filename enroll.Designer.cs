namespace Final_Project
{
    partial class enroll
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enroll));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_main = new System.Windows.Forms.Panel();
            this.tabControl_enroll = new System.Windows.Forms.TabControl();
            this.tabPage_manage = new System.Windows.Forms.TabPage();
            this.groupBox_books = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.datepicker_book = new Bunifu.Framework.UI.BunifuDatepicker();
            this.button_book_filter = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox_book_filter = new System.Windows.Forms.ComboBox();
            this.iNFOBOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset11 = new Final_Project.dataset1();
            this.textBox_book_filter = new System.Windows.Forms.TextBox();
            this.button_book_save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button_book_delete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button_book_insert = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView_book = new System.Windows.Forms.DataGridView();
            this.oIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.oSTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.oPURCHASEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oLOCATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oWNBOOKSFK1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox_info_enroll = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datepicker_info = new Bunifu.Framework.UI.BunifuDatepicker();
            this.button_info_filter = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox_info_filtering = new System.Windows.Forms.ComboBox();
            this.textBox_info_filter = new System.Windows.Forms.TextBox();
            this.button_info_save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button_info_delete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button_info_insert = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView_info = new System.Windows.Forms.DataGridView();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label_logo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox_exit = new System.Windows.Forms.PictureBox();
            this.pictureBox_minimum = new System.Windows.Forms.PictureBox();
            this.infO_BOOKSTableAdapter1 = new Final_Project.dataset1TableAdapters.INFO_BOOKSTableAdapter();
            this.owN_BOOKSTableAdapter1 = new Final_Project.dataset1TableAdapters.OWN_BOOKSTableAdapter();
            this.iIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iAUTHORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPUBLISHERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPUBLISHEDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iRENTALCOSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iCOSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_PANELTY_COST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGENREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel_main.SuspendLayout();
            this.tabControl_enroll.SuspendLayout();
            this.tabPage_manage.SuspendLayout();
            this.groupBox_books.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNFOBOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oWNBOOKSFK1BindingSource)).BeginInit();
            this.groupBox_info_enroll.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimum)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_main.Controls.Add(this.tabControl_enroll);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_main.Location = new System.Drawing.Point(0, 79);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(968, 671);
            this.panel_main.TabIndex = 0;
            // 
            // tabControl_enroll
            // 
            this.tabControl_enroll.Controls.Add(this.tabPage_manage);
            this.tabControl_enroll.Location = new System.Drawing.Point(0, 22);
            this.tabControl_enroll.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl_enroll.Name = "tabControl_enroll";
            this.tabControl_enroll.SelectedIndex = 0;
            this.tabControl_enroll.Size = new System.Drawing.Size(969, 606);
            this.tabControl_enroll.TabIndex = 0;
            // 
            // tabPage_manage
            // 
            this.tabPage_manage.Controls.Add(this.groupBox_books);
            this.tabPage_manage.Controls.Add(this.groupBox_info_enroll);
            this.tabPage_manage.Location = new System.Drawing.Point(4, 22);
            this.tabPage_manage.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_manage.Name = "tabPage_manage";
            this.tabPage_manage.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_manage.Size = new System.Drawing.Size(961, 580);
            this.tabPage_manage.TabIndex = 0;
            this.tabPage_manage.Text = "도서관리";
            this.tabPage_manage.UseVisualStyleBackColor = true;
            // 
            // groupBox_books
            // 
            this.groupBox_books.Controls.Add(this.groupBox3);
            this.groupBox_books.Controls.Add(this.button_book_save);
            this.groupBox_books.Controls.Add(this.button_book_delete);
            this.groupBox_books.Controls.Add(this.button_book_insert);
            this.groupBox_books.Controls.Add(this.dataGridView_book);
            this.groupBox_books.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_books.ForeColor = System.Drawing.Color.Black;
            this.groupBox_books.Location = new System.Drawing.Point(12, 292);
            this.groupBox_books.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_books.Name = "groupBox_books";
            this.groupBox_books.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_books.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox_books.Size = new System.Drawing.Size(947, 283);
            this.groupBox_books.TabIndex = 9;
            this.groupBox_books.TabStop = false;
            this.groupBox_books.Text = "소지도서 등록/삭제";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.datepicker_book);
            this.groupBox3.Controls.Add(this.button_book_filter);
            this.groupBox3.Controls.Add(this.comboBox_book_filter);
            this.groupBox3.Controls.Add(this.textBox_book_filter);
            this.groupBox3.Location = new System.Drawing.Point(301, 20);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(643, 50);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "필터링";
            // 
            // datepicker_book
            // 
            this.datepicker_book.BackColor = System.Drawing.Color.DimGray;
            this.datepicker_book.BorderRadius = 0;
            this.datepicker_book.ForeColor = System.Drawing.Color.White;
            this.datepicker_book.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datepicker_book.FormatCustom = null;
            this.datepicker_book.Location = new System.Drawing.Point(145, 12);
            this.datepicker_book.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datepicker_book.Name = "datepicker_book";
            this.datepicker_book.Size = new System.Drawing.Size(371, 36);
            this.datepicker_book.TabIndex = 7;
            this.datepicker_book.Value = new System.DateTime(2019, 11, 17, 3, 13, 8, 959);
            this.datepicker_book.Visible = false;
            // 
            // button_book_filter
            // 
            this.button_book_filter.ActiveBorderThickness = 1;
            this.button_book_filter.ActiveCornerRadius = 20;
            this.button_book_filter.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_book_filter.ActiveForecolor = System.Drawing.Color.White;
            this.button_book_filter.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_book_filter.BackColor = System.Drawing.Color.Transparent;
            this.button_book_filter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_book_filter.BackgroundImage")));
            this.button_book_filter.ButtonText = "필터";
            this.button_book_filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_book_filter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_book_filter.ForeColor = System.Drawing.Color.ForestGreen;
            this.button_book_filter.IdleBorderThickness = 1;
            this.button_book_filter.IdleCornerRadius = 20;
            this.button_book_filter.IdleFillColor = System.Drawing.Color.DimGray;
            this.button_book_filter.IdleForecolor = System.Drawing.Color.White;
            this.button_book_filter.IdleLineColor = System.Drawing.Color.DimGray;
            this.button_book_filter.Location = new System.Drawing.Point(518, 11);
            this.button_book_filter.Margin = new System.Windows.Forms.Padding(4);
            this.button_book_filter.Name = "button_book_filter";
            this.button_book_filter.Size = new System.Drawing.Size(117, 34);
            this.button_book_filter.TabIndex = 6;
            this.button_book_filter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_book_filter.Click += new System.EventHandler(this.button_book_filter_Click);
            // 
            // comboBox_book_filter
            // 
            this.comboBox_book_filter.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iNFOBOOKSBindingSource, "I_ID", true));
            this.comboBox_book_filter.FormattingEnabled = true;
            this.comboBox_book_filter.Items.AddRange(new object[] {
            "도서번호",
            "도서등급",
            "현재도서상태",
            "구입시기",
            "현재도서위치"});
            this.comboBox_book_filter.Location = new System.Drawing.Point(9, 18);
            this.comboBox_book_filter.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_book_filter.Name = "comboBox_book_filter";
            this.comboBox_book_filter.Size = new System.Drawing.Size(131, 20);
            this.comboBox_book_filter.TabIndex = 4;
            this.comboBox_book_filter.Text = "도서번호";
            this.comboBox_book_filter.SelectedIndexChanged += new System.EventHandler(this.comboBox_book_filter_SelectedIndexChanged);
            // 
            // iNFOBOOKSBindingSource
            // 
            this.iNFOBOOKSBindingSource.DataMember = "INFO_BOOKS";
            this.iNFOBOOKSBindingSource.DataSource = this.dataset11;
            // 
            // dataset11
            // 
            this.dataset11.DataSetName = "dataset1";
            this.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_book_filter
            // 
            this.textBox_book_filter.Location = new System.Drawing.Point(145, 17);
            this.textBox_book_filter.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_book_filter.Name = "textBox_book_filter";
            this.textBox_book_filter.Size = new System.Drawing.Size(367, 21);
            this.textBox_book_filter.TabIndex = 5;
            // 
            // button_book_save
            // 
            this.button_book_save.ActiveBorderThickness = 1;
            this.button_book_save.ActiveCornerRadius = 20;
            this.button_book_save.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_book_save.ActiveForecolor = System.Drawing.Color.White;
            this.button_book_save.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_book_save.BackColor = System.Drawing.Color.Transparent;
            this.button_book_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_book_save.BackgroundImage")));
            this.button_book_save.ButtonText = "저장";
            this.button_book_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_book_save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_book_save.ForeColor = System.Drawing.Color.ForestGreen;
            this.button_book_save.IdleBorderThickness = 1;
            this.button_book_save.IdleCornerRadius = 20;
            this.button_book_save.IdleFillColor = System.Drawing.Color.DimGray;
            this.button_book_save.IdleForecolor = System.Drawing.Color.White;
            this.button_book_save.IdleLineColor = System.Drawing.Color.DimGray;
            this.button_book_save.Location = new System.Drawing.Point(204, 34);
            this.button_book_save.Margin = new System.Windows.Forms.Padding(4);
            this.button_book_save.Name = "button_book_save";
            this.button_book_save.Size = new System.Drawing.Size(91, 34);
            this.button_book_save.TabIndex = 3;
            this.button_book_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_book_save.Click += new System.EventHandler(this.button_book_save_Click);
            // 
            // button_book_delete
            // 
            this.button_book_delete.ActiveBorderThickness = 1;
            this.button_book_delete.ActiveCornerRadius = 20;
            this.button_book_delete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_book_delete.ActiveForecolor = System.Drawing.Color.White;
            this.button_book_delete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_book_delete.BackColor = System.Drawing.Color.Transparent;
            this.button_book_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_book_delete.BackgroundImage")));
            this.button_book_delete.ButtonText = "삭제";
            this.button_book_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_book_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_book_delete.ForeColor = System.Drawing.Color.ForestGreen;
            this.button_book_delete.IdleBorderThickness = 1;
            this.button_book_delete.IdleCornerRadius = 20;
            this.button_book_delete.IdleFillColor = System.Drawing.Color.DimGray;
            this.button_book_delete.IdleForecolor = System.Drawing.Color.White;
            this.button_book_delete.IdleLineColor = System.Drawing.Color.DimGray;
            this.button_book_delete.Location = new System.Drawing.Point(105, 34);
            this.button_book_delete.Margin = new System.Windows.Forms.Padding(4);
            this.button_book_delete.Name = "button_book_delete";
            this.button_book_delete.Size = new System.Drawing.Size(91, 34);
            this.button_book_delete.TabIndex = 2;
            this.button_book_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_book_delete.Click += new System.EventHandler(this.button_book_delete_Click);
            // 
            // button_book_insert
            // 
            this.button_book_insert.ActiveBorderThickness = 1;
            this.button_book_insert.ActiveCornerRadius = 20;
            this.button_book_insert.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_book_insert.ActiveForecolor = System.Drawing.Color.White;
            this.button_book_insert.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_book_insert.BackColor = System.Drawing.Color.Transparent;
            this.button_book_insert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_book_insert.BackgroundImage")));
            this.button_book_insert.ButtonText = "입력";
            this.button_book_insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_book_insert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_book_insert.ForeColor = System.Drawing.Color.ForestGreen;
            this.button_book_insert.IdleBorderThickness = 1;
            this.button_book_insert.IdleCornerRadius = 20;
            this.button_book_insert.IdleFillColor = System.Drawing.Color.DimGray;
            this.button_book_insert.IdleForecolor = System.Drawing.Color.White;
            this.button_book_insert.IdleLineColor = System.Drawing.Color.DimGray;
            this.button_book_insert.Location = new System.Drawing.Point(6, 34);
            this.button_book_insert.Margin = new System.Windows.Forms.Padding(4);
            this.button_book_insert.Name = "button_book_insert";
            this.button_book_insert.Size = new System.Drawing.Size(91, 34);
            this.button_book_insert.TabIndex = 1;
            this.button_book_insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_book_insert.Click += new System.EventHandler(this.button_book_insert_Click);
            // 
            // dataGridView_book
            // 
            this.dataGridView_book.AllowUserToAddRows = false;
            this.dataGridView_book.AutoGenerateColumns = false;
            this.dataGridView_book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_book.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_book.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_book.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oIDDataGridViewTextBoxColumn,
            this.iIDDataGridViewTextBoxColumn1,
            this.oGRADEDataGridViewTextBoxColumn,
            this.oSTATEDataGridViewTextBoxColumn,
            this.oPURCHASEDATEDataGridViewTextBoxColumn,
            this.oLOCATIONDataGridViewTextBoxColumn});
            this.dataGridView_book.DataSource = this.oWNBOOKSFK1BindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_book.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_book.Location = new System.Drawing.Point(5, 74);
            this.dataGridView_book.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_book.Name = "dataGridView_book";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_book.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_book.RowTemplate.Height = 27;
            this.dataGridView_book.Size = new System.Drawing.Size(938, 195);
            this.dataGridView_book.TabIndex = 7;
            this.dataGridView_book.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_book_DataError);
            // 
            // oIDDataGridViewTextBoxColumn
            // 
            this.oIDDataGridViewTextBoxColumn.DataPropertyName = "O_ID";
            this.oIDDataGridViewTextBoxColumn.HeaderText = "도서번호";
            this.oIDDataGridViewTextBoxColumn.Name = "oIDDataGridViewTextBoxColumn";
            this.oIDDataGridViewTextBoxColumn.Width = 61;
            // 
            // iIDDataGridViewTextBoxColumn1
            // 
            this.iIDDataGridViewTextBoxColumn1.DataPropertyName = "I_ID";
            this.iIDDataGridViewTextBoxColumn1.HeaderText = "도서등록번호";
            this.iIDDataGridViewTextBoxColumn1.Name = "iIDDataGridViewTextBoxColumn1";
            this.iIDDataGridViewTextBoxColumn1.Width = 72;
            // 
            // oGRADEDataGridViewTextBoxColumn
            // 
            this.oGRADEDataGridViewTextBoxColumn.DataPropertyName = "O_GRADE";
            this.oGRADEDataGridViewTextBoxColumn.HeaderText = "도서등급";
            this.oGRADEDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.oGRADEDataGridViewTextBoxColumn.Name = "oGRADEDataGridViewTextBoxColumn";
            this.oGRADEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oGRADEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.oGRADEDataGridViewTextBoxColumn.Width = 61;
            // 
            // oSTATEDataGridViewTextBoxColumn
            // 
            this.oSTATEDataGridViewTextBoxColumn.DataPropertyName = "O_STATE";
            this.oSTATEDataGridViewTextBoxColumn.HeaderText = "도서상태";
            this.oSTATEDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "도서관",
            "대여중",
            "예약중"});
            this.oSTATEDataGridViewTextBoxColumn.Name = "oSTATEDataGridViewTextBoxColumn";
            this.oSTATEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oSTATEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.oSTATEDataGridViewTextBoxColumn.Width = 61;
            // 
            // oPURCHASEDATEDataGridViewTextBoxColumn
            // 
            this.oPURCHASEDATEDataGridViewTextBoxColumn.DataPropertyName = "O_PURCHASE_DATE";
            dataGridViewCellStyle2.Format = "F";
            dataGridViewCellStyle2.NullValue = null;
            this.oPURCHASEDATEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.oPURCHASEDATEDataGridViewTextBoxColumn.HeaderText = "구입시기";
            this.oPURCHASEDATEDataGridViewTextBoxColumn.Name = "oPURCHASEDATEDataGridViewTextBoxColumn";
            this.oPURCHASEDATEDataGridViewTextBoxColumn.Width = 61;
            // 
            // oLOCATIONDataGridViewTextBoxColumn
            // 
            this.oLOCATIONDataGridViewTextBoxColumn.DataPropertyName = "O_LOCATION";
            this.oLOCATIONDataGridViewTextBoxColumn.HeaderText = "현재위치";
            this.oLOCATIONDataGridViewTextBoxColumn.Name = "oLOCATIONDataGridViewTextBoxColumn";
            this.oLOCATIONDataGridViewTextBoxColumn.Width = 61;
            // 
            // oWNBOOKSFK1BindingSource
            // 
            this.oWNBOOKSFK1BindingSource.DataMember = "OWN_BOOKS_FK1";
            this.oWNBOOKSFK1BindingSource.DataSource = this.iNFOBOOKSBindingSource;
            // 
            // groupBox_info_enroll
            // 
            this.groupBox_info_enroll.Controls.Add(this.groupBox2);
            this.groupBox_info_enroll.Controls.Add(this.button_info_save);
            this.groupBox_info_enroll.Controls.Add(this.button_info_delete);
            this.groupBox_info_enroll.Controls.Add(this.button_info_insert);
            this.groupBox_info_enroll.Controls.Add(this.dataGridView_info);
            this.groupBox_info_enroll.ForeColor = System.Drawing.Color.Black;
            this.groupBox_info_enroll.Location = new System.Drawing.Point(12, 5);
            this.groupBox_info_enroll.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_info_enroll.Name = "groupBox_info_enroll";
            this.groupBox_info_enroll.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_info_enroll.Size = new System.Drawing.Size(947, 283);
            this.groupBox_info_enroll.TabIndex = 0;
            this.groupBox_info_enroll.TabStop = false;
            this.groupBox_info_enroll.Text = "도서종류 등록/삭제";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datepicker_info);
            this.groupBox2.Controls.Add(this.button_info_filter);
            this.groupBox2.Controls.Add(this.comboBox_info_filtering);
            this.groupBox2.Controls.Add(this.textBox_info_filter);
            this.groupBox2.Location = new System.Drawing.Point(301, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(641, 50);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "필터링";
            // 
            // datepicker_info
            // 
            this.datepicker_info.BackColor = System.Drawing.Color.DimGray;
            this.datepicker_info.BorderRadius = 0;
            this.datepicker_info.ForeColor = System.Drawing.Color.White;
            this.datepicker_info.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datepicker_info.FormatCustom = null;
            this.datepicker_info.Location = new System.Drawing.Point(145, 10);
            this.datepicker_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datepicker_info.Name = "datepicker_info";
            this.datepicker_info.Size = new System.Drawing.Size(371, 36);
            this.datepicker_info.TabIndex = 7;
            this.datepicker_info.Value = new System.DateTime(2019, 11, 17, 3, 13, 8, 959);
            this.datepicker_info.Visible = false;
            // 
            // button_info_filter
            // 
            this.button_info_filter.ActiveBorderThickness = 1;
            this.button_info_filter.ActiveCornerRadius = 20;
            this.button_info_filter.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_info_filter.ActiveForecolor = System.Drawing.Color.White;
            this.button_info_filter.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_info_filter.BackColor = System.Drawing.Color.Transparent;
            this.button_info_filter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_info_filter.BackgroundImage")));
            this.button_info_filter.ButtonText = "필터";
            this.button_info_filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_info_filter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_info_filter.ForeColor = System.Drawing.Color.ForestGreen;
            this.button_info_filter.IdleBorderThickness = 1;
            this.button_info_filter.IdleCornerRadius = 20;
            this.button_info_filter.IdleFillColor = System.Drawing.Color.DimGray;
            this.button_info_filter.IdleForecolor = System.Drawing.Color.White;
            this.button_info_filter.IdleLineColor = System.Drawing.Color.DimGray;
            this.button_info_filter.Location = new System.Drawing.Point(518, 11);
            this.button_info_filter.Margin = new System.Windows.Forms.Padding(4);
            this.button_info_filter.Name = "button_info_filter";
            this.button_info_filter.Size = new System.Drawing.Size(117, 34);
            this.button_info_filter.TabIndex = 6;
            this.button_info_filter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_info_filter.Click += new System.EventHandler(this.button_info_filter_Click);
            // 
            // comboBox_info_filtering
            // 
            this.comboBox_info_filtering.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iNFOBOOKSBindingSource, "I_ID", true));
            this.comboBox_info_filtering.Items.AddRange(new object[] {
            "등록번호",
            "도서분야",
            "도서정가",
            "대여가격",
            "반납일",
            "도서명",
            "출판사",
            "출판일",
            "저자"});
            this.comboBox_info_filtering.Location = new System.Drawing.Point(9, 18);
            this.comboBox_info_filtering.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_info_filtering.Name = "comboBox_info_filtering";
            this.comboBox_info_filtering.Size = new System.Drawing.Size(131, 20);
            this.comboBox_info_filtering.TabIndex = 4;
            this.comboBox_info_filtering.Text = "도서명";
            this.comboBox_info_filtering.SelectedIndexChanged += new System.EventHandler(this.comboBox_info_filtering_SelectedIndexChanged);
            // 
            // textBox_info_filter
            // 
            this.textBox_info_filter.Location = new System.Drawing.Point(147, 16);
            this.textBox_info_filter.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_info_filter.Name = "textBox_info_filter";
            this.textBox_info_filter.Size = new System.Drawing.Size(365, 21);
            this.textBox_info_filter.TabIndex = 5;
            // 
            // button_info_save
            // 
            this.button_info_save.ActiveBorderThickness = 1;
            this.button_info_save.ActiveCornerRadius = 20;
            this.button_info_save.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_info_save.ActiveForecolor = System.Drawing.Color.White;
            this.button_info_save.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_info_save.BackColor = System.Drawing.Color.Transparent;
            this.button_info_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_info_save.BackgroundImage")));
            this.button_info_save.ButtonText = "저장";
            this.button_info_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_info_save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_info_save.ForeColor = System.Drawing.Color.ForestGreen;
            this.button_info_save.IdleBorderThickness = 1;
            this.button_info_save.IdleCornerRadius = 20;
            this.button_info_save.IdleFillColor = System.Drawing.Color.DimGray;
            this.button_info_save.IdleForecolor = System.Drawing.Color.White;
            this.button_info_save.IdleLineColor = System.Drawing.Color.DimGray;
            this.button_info_save.Location = new System.Drawing.Point(204, 34);
            this.button_info_save.Margin = new System.Windows.Forms.Padding(4);
            this.button_info_save.Name = "button_info_save";
            this.button_info_save.Size = new System.Drawing.Size(91, 34);
            this.button_info_save.TabIndex = 3;
            this.button_info_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_info_save.Click += new System.EventHandler(this.button_info_save_Click);
            // 
            // button_info_delete
            // 
            this.button_info_delete.ActiveBorderThickness = 1;
            this.button_info_delete.ActiveCornerRadius = 20;
            this.button_info_delete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_info_delete.ActiveForecolor = System.Drawing.Color.White;
            this.button_info_delete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_info_delete.BackColor = System.Drawing.Color.Transparent;
            this.button_info_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_info_delete.BackgroundImage")));
            this.button_info_delete.ButtonText = "삭제";
            this.button_info_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_info_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_info_delete.ForeColor = System.Drawing.Color.ForestGreen;
            this.button_info_delete.IdleBorderThickness = 1;
            this.button_info_delete.IdleCornerRadius = 20;
            this.button_info_delete.IdleFillColor = System.Drawing.Color.DimGray;
            this.button_info_delete.IdleForecolor = System.Drawing.Color.White;
            this.button_info_delete.IdleLineColor = System.Drawing.Color.DimGray;
            this.button_info_delete.Location = new System.Drawing.Point(105, 34);
            this.button_info_delete.Margin = new System.Windows.Forms.Padding(4);
            this.button_info_delete.Name = "button_info_delete";
            this.button_info_delete.Size = new System.Drawing.Size(91, 34);
            this.button_info_delete.TabIndex = 2;
            this.button_info_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_info_delete.Click += new System.EventHandler(this.button_info_delete_Click);
            // 
            // button_info_insert
            // 
            this.button_info_insert.ActiveBorderThickness = 1;
            this.button_info_insert.ActiveCornerRadius = 20;
            this.button_info_insert.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_info_insert.ActiveForecolor = System.Drawing.Color.White;
            this.button_info_insert.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_info_insert.BackColor = System.Drawing.Color.Transparent;
            this.button_info_insert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_info_insert.BackgroundImage")));
            this.button_info_insert.ButtonText = "입력";
            this.button_info_insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_info_insert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_info_insert.ForeColor = System.Drawing.Color.ForestGreen;
            this.button_info_insert.IdleBorderThickness = 1;
            this.button_info_insert.IdleCornerRadius = 20;
            this.button_info_insert.IdleFillColor = System.Drawing.Color.DimGray;
            this.button_info_insert.IdleForecolor = System.Drawing.Color.White;
            this.button_info_insert.IdleLineColor = System.Drawing.Color.DimGray;
            this.button_info_insert.Location = new System.Drawing.Point(6, 34);
            this.button_info_insert.Margin = new System.Windows.Forms.Padding(4);
            this.button_info_insert.Name = "button_info_insert";
            this.button_info_insert.Size = new System.Drawing.Size(91, 34);
            this.button_info_insert.TabIndex = 1;
            this.button_info_insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_info_insert.Click += new System.EventHandler(this.button_info_insert_Click);
            // 
            // dataGridView_info
            // 
            this.dataGridView_info.AllowUserToAddRows = false;
            this.dataGridView_info.AutoGenerateColumns = false;
            this.dataGridView_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_info.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iIDDataGridViewTextBoxColumn,
            this.iNAMEDataGridViewTextBoxColumn,
            this.iAUTHORDataGridViewTextBoxColumn,
            this.iPUBLISHERDataGridViewTextBoxColumn,
            this.iPUBLISHEDDATEDataGridViewTextBoxColumn,
            this.iRENTALCOSTDataGridViewTextBoxColumn,
            this.iCOSTDataGridViewTextBoxColumn,
            this.I_PANELTY_COST,
            this.iGENREDataGridViewTextBoxColumn});
            this.dataGridView_info.DataSource = this.iNFOBOOKSBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_info.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView_info.Location = new System.Drawing.Point(5, 74);
            this.dataGridView_info.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_info.Name = "dataGridView_info";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_info.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView_info.RowTemplate.Height = 27;
            this.dataGridView_info.Size = new System.Drawing.Size(938, 195);
            this.dataGridView_info.TabIndex = 7;
            this.dataGridView_info.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_info_DataError);
            this.dataGridView_info.SelectionChanged += new System.EventHandler(this.dataGridView_info_SelectionChanged);
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 18;
            this.bunifuElipse.TargetControl = this;
            // 
            // label_logo
            // 
            this.label_logo.Enabled = false;
            this.label_logo.Font = new System.Drawing.Font("Lemon", 45F);
            this.label_logo.Location = new System.Drawing.Point(80, -3);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(354, 78);
            this.label_logo.TabIndex = 4;
            this.label_logo.Text = "Master";
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logo.Enabled = false;
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(12, 3);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(72, 72);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_logo.TabIndex = 1;
            this.pictureBox_logo.TabStop = false;
            // 
            // pictureBox_exit
            // 
            this.pictureBox_exit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_exit.Image")));
            this.pictureBox_exit.Location = new System.Drawing.Point(940, 12);
            this.pictureBox_exit.Name = "pictureBox_exit";
            this.pictureBox_exit.Size = new System.Drawing.Size(19, 9);
            this.pictureBox_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_exit.TabIndex = 2;
            this.pictureBox_exit.TabStop = false;
            this.pictureBox_exit.Click += new System.EventHandler(this.pictureBox_exit_Click);
            // 
            // pictureBox_minimum
            // 
            this.pictureBox_minimum.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_minimum.Image")));
            this.pictureBox_minimum.Location = new System.Drawing.Point(926, 12);
            this.pictureBox_minimum.Name = "pictureBox_minimum";
            this.pictureBox_minimum.Size = new System.Drawing.Size(9, 9);
            this.pictureBox_minimum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_minimum.TabIndex = 1;
            this.pictureBox_minimum.TabStop = false;
            this.pictureBox_minimum.Click += new System.EventHandler(this.pictureBox_minimum_Click);
            // 
            // infO_BOOKSTableAdapter1
            // 
            this.infO_BOOKSTableAdapter1.ClearBeforeFill = true;
            // 
            // owN_BOOKSTableAdapter1
            // 
            this.owN_BOOKSTableAdapter1.ClearBeforeFill = true;
            // 
            // iIDDataGridViewTextBoxColumn
            // 
            this.iIDDataGridViewTextBoxColumn.DataPropertyName = "I_ID";
            this.iIDDataGridViewTextBoxColumn.HeaderText = "도서등록번호";
            this.iIDDataGridViewTextBoxColumn.Name = "iIDDataGridViewTextBoxColumn";
            this.iIDDataGridViewTextBoxColumn.Width = 72;
            // 
            // iNAMEDataGridViewTextBoxColumn
            // 
            this.iNAMEDataGridViewTextBoxColumn.DataPropertyName = "I_NAME";
            this.iNAMEDataGridViewTextBoxColumn.HeaderText = "도서명";
            this.iNAMEDataGridViewTextBoxColumn.Name = "iNAMEDataGridViewTextBoxColumn";
            this.iNAMEDataGridViewTextBoxColumn.Width = 61;
            // 
            // iAUTHORDataGridViewTextBoxColumn
            // 
            this.iAUTHORDataGridViewTextBoxColumn.DataPropertyName = "I_AUTHOR";
            this.iAUTHORDataGridViewTextBoxColumn.HeaderText = "저자";
            this.iAUTHORDataGridViewTextBoxColumn.Name = "iAUTHORDataGridViewTextBoxColumn";
            this.iAUTHORDataGridViewTextBoxColumn.Width = 51;
            // 
            // iPUBLISHERDataGridViewTextBoxColumn
            // 
            this.iPUBLISHERDataGridViewTextBoxColumn.DataPropertyName = "I_PUBLISHER";
            this.iPUBLISHERDataGridViewTextBoxColumn.HeaderText = "출판사";
            this.iPUBLISHERDataGridViewTextBoxColumn.Name = "iPUBLISHERDataGridViewTextBoxColumn";
            this.iPUBLISHERDataGridViewTextBoxColumn.Width = 61;
            // 
            // iPUBLISHEDDATEDataGridViewTextBoxColumn
            // 
            this.iPUBLISHEDDATEDataGridViewTextBoxColumn.DataPropertyName = "I_PUBLISHED_DATE";
            dataGridViewCellStyle6.Format = "F";
            this.iPUBLISHEDDATEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.iPUBLISHEDDATEDataGridViewTextBoxColumn.HeaderText = "출판일";
            this.iPUBLISHEDDATEDataGridViewTextBoxColumn.Name = "iPUBLISHEDDATEDataGridViewTextBoxColumn";
            this.iPUBLISHEDDATEDataGridViewTextBoxColumn.Width = 61;
            // 
            // iRENTALCOSTDataGridViewTextBoxColumn
            // 
            this.iRENTALCOSTDataGridViewTextBoxColumn.DataPropertyName = "I_RENTAL_COST";
            dataGridViewCellStyle7.Format = "#\"원\"";
            this.iRENTALCOSTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.iRENTALCOSTDataGridViewTextBoxColumn.HeaderText = "대출가격";
            this.iRENTALCOSTDataGridViewTextBoxColumn.Name = "iRENTALCOSTDataGridViewTextBoxColumn";
            this.iRENTALCOSTDataGridViewTextBoxColumn.Width = 61;
            // 
            // iCOSTDataGridViewTextBoxColumn
            // 
            this.iCOSTDataGridViewTextBoxColumn.DataPropertyName = "I_COST";
            dataGridViewCellStyle8.Format = "#\"원\"";
            this.iCOSTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.iCOSTDataGridViewTextBoxColumn.HeaderText = "도서정가";
            this.iCOSTDataGridViewTextBoxColumn.Name = "iCOSTDataGridViewTextBoxColumn";
            this.iCOSTDataGridViewTextBoxColumn.Width = 61;
            // 
            // I_PANELTY_COST
            // 
            this.I_PANELTY_COST.DataPropertyName = "I_PANELTY_COST";
            dataGridViewCellStyle9.Format = "#\"원\"";
            this.I_PANELTY_COST.DefaultCellStyle = dataGridViewCellStyle9;
            this.I_PANELTY_COST.HeaderText = "연체료";
            this.I_PANELTY_COST.Name = "I_PANELTY_COST";
            this.I_PANELTY_COST.Width = 61;
            // 
            // iGENREDataGridViewTextBoxColumn
            // 
            this.iGENREDataGridViewTextBoxColumn.DataPropertyName = "I_GENRE";
            this.iGENREDataGridViewTextBoxColumn.HeaderText = "장르";
            this.iGENREDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "소설",
            "시/에세이",
            "경제/경영",
            "자기계발",
            "인문",
            "역사/문화",
            "종교",
            "정치/사회",
            "예술/대중문화",
            "과학",
            "기술/공학",
            "컴퓨터/IT",
            "유아(0~7세)",
            "어린이(초등)",
            "어린이전집",
            "어린이영어",
            "청소년",
            "초등참고서",
            "중/고등참고서",
            "대학교재",
            "취업/수험서",
            "외국어",
            "가정/육아",
            "건강",
            "여행",
            "요리",
            "취미/실용/스포츠",
            "잡지",
            "만화",
            "교양만화",
            "역사만화",
            "직업만화",
            "일상생활/드라마/가족",
            "동물등장만화",
            "요리만화",
            "도박만화",
            "고전/문학작품만화",
            "로맨스만화",
            "스포츠만화",
            "SF/판타지",
            "액션/무협만화",
            "명랑/코믹만화",
            "탐정/추리",
            "공포/스릴러",
            "기타만화",
            "웹툰/카툰에세이",
            "그래픽노블",
            "캐릭터상품",
            "일러스트/작법",
            "만화잡지",
            "한국소개도서"});
            this.iGENREDataGridViewTextBoxColumn.Name = "iGENREDataGridViewTextBoxColumn";
            this.iGENREDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iGENREDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iGENREDataGridViewTextBoxColumn.Width = 51;
            // 
            // enroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(968, 750);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.pictureBox_exit);
            this.Controls.Add(this.pictureBox_minimum);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.label_logo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "enroll";
            this.Text = "enroll";
            this.Load += new System.EventHandler(this.enroll_Load);
            this.panel_main.ResumeLayout(false);
            this.tabControl_enroll.ResumeLayout(false);
            this.tabPage_manage.ResumeLayout(false);
            this.groupBox_books.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNFOBOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oWNBOOKSFK1BindingSource)).EndInit();
            this.groupBox_info_enroll.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.PictureBox pictureBox_minimum;
        private System.Windows.Forms.PictureBox pictureBox_exit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private Bunifu.Framework.UI.BunifuCustomLabel label_logo;
        private dataset1 dataset11;
        private System.Windows.Forms.TabControl tabControl_enroll;
        private System.Windows.Forms.TabPage tabPage_manage;
        private dataset1TableAdapters.INFO_BOOKSTableAdapter infO_BOOKSTableAdapter1;
        private System.Windows.Forms.BindingSource iNFOBOOKSBindingSource;
        private System.Windows.Forms.GroupBox groupBox_info_enroll;
        private Bunifu.Framework.UI.BunifuThinButton2 button_info_insert;
        private System.Windows.Forms.DataGridView dataGridView_info;
        private Bunifu.Framework.UI.BunifuThinButton2 button_info_delete;
        private Bunifu.Framework.UI.BunifuThinButton2 button_info_save;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_info_filtering;
        private System.Windows.Forms.TextBox textBox_info_filter;
        private Bunifu.Framework.UI.BunifuThinButton2 button_info_filter;
        private Bunifu.Framework.UI.BunifuDatepicker datepicker_info;
        private System.Windows.Forms.GroupBox groupBox_books;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuDatepicker datepicker_book;
        private Bunifu.Framework.UI.BunifuThinButton2 button_book_filter;
        private System.Windows.Forms.ComboBox comboBox_book_filter;
        private System.Windows.Forms.TextBox textBox_book_filter;
        private Bunifu.Framework.UI.BunifuThinButton2 button_book_save;
        private Bunifu.Framework.UI.BunifuThinButton2 button_book_delete;
        private Bunifu.Framework.UI.BunifuThinButton2 button_book_insert;
        private System.Windows.Forms.DataGridView dataGridView_book;
        private dataset1TableAdapters.OWN_BOOKSTableAdapter owN_BOOKSTableAdapter1;
        private System.Windows.Forms.BindingSource oWNBOOKSFK1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn oGRADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn oSTATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPURCHASEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oLOCATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iAUTHORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPUBLISHERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPUBLISHEDDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iRENTALCOSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iCOSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn I_PANELTY_COST;
        private System.Windows.Forms.DataGridViewComboBoxColumn iGENREDataGridViewTextBoxColumn;
    }
}

