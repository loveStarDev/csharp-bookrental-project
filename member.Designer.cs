namespace Final_Project
{
    partial class member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(member));
            this.panel_main = new System.Windows.Forms.Panel();
            this.tabControl_enroll = new System.Windows.Forms.TabControl();
            this.tabPage_enroll = new System.Windows.Forms.TabPage();
            this.groupBox_info_enroll = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mEMBERBOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset11 = new Final_Project.dataset1();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_filter = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox_filter = new System.Windows.Forms.ComboBox();
            this.textbox_member = new System.Windows.Forms.TextBox();
            this.button_save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button_delete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button_insert = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label_logo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox_exit = new System.Windows.Forms.PictureBox();
            this.pictureBox_minimum = new System.Windows.Forms.PictureBox();
            this.mEMBER_BOOKSTableAdapter = new Final_Project.dataset1TableAdapters.MEMBER_BOOKSTableAdapter();
            this.mIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mGRADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mJOINDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_CUR_RENT_COUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_main.SuspendLayout();
            this.tabControl_enroll.SuspendLayout();
            this.tabPage_enroll.SuspendLayout();
            this.groupBox_info_enroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERBOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.panel_main.Size = new System.Drawing.Size(971, 671);
            this.panel_main.TabIndex = 0;
            // 
            // tabControl_enroll
            // 
            this.tabControl_enroll.Controls.Add(this.tabPage_enroll);
            this.tabControl_enroll.Location = new System.Drawing.Point(0, 22);
            this.tabControl_enroll.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl_enroll.Name = "tabControl_enroll";
            this.tabControl_enroll.SelectedIndex = 0;
            this.tabControl_enroll.Size = new System.Drawing.Size(969, 606);
            this.tabControl_enroll.TabIndex = 0;
            // 
            // tabPage_enroll
            // 
            this.tabPage_enroll.Controls.Add(this.groupBox_info_enroll);
            this.tabPage_enroll.Location = new System.Drawing.Point(4, 22);
            this.tabPage_enroll.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_enroll.Name = "tabPage_enroll";
            this.tabPage_enroll.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_enroll.Size = new System.Drawing.Size(961, 580);
            this.tabPage_enroll.TabIndex = 0;
            this.tabPage_enroll.Text = "회원등록";
            this.tabPage_enroll.UseVisualStyleBackColor = true;
            // 
            // groupBox_info_enroll
            // 
            this.groupBox_info_enroll.Controls.Add(this.dataGridView1);
            this.groupBox_info_enroll.Controls.Add(this.groupBox2);
            this.groupBox_info_enroll.Controls.Add(this.button_save);
            this.groupBox_info_enroll.Controls.Add(this.button_delete);
            this.groupBox_info_enroll.Controls.Add(this.button_insert);
            this.groupBox_info_enroll.ForeColor = System.Drawing.Color.Black;
            this.groupBox_info_enroll.Location = new System.Drawing.Point(12, 5);
            this.groupBox_info_enroll.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_info_enroll.Name = "groupBox_info_enroll";
            this.groupBox_info_enroll.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_info_enroll.Size = new System.Drawing.Size(947, 571);
            this.groupBox_info_enroll.TabIndex = 0;
            this.groupBox_info_enroll.TabStop = false;
            this.groupBox_info_enroll.Text = "회원관리";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mIDDataGridViewTextBoxColumn,
            this.mNAMEDataGridViewTextBoxColumn,
            this.mPASSWORDDataGridViewTextBoxColumn,
            this.mSSNDataGridViewTextBoxColumn,
            this.mPHONEDataGridViewTextBoxColumn,
            this.mMAILDataGridViewTextBoxColumn,
            this.mADDRESSDataGridViewTextBoxColumn,
            this.mGRADEDataGridViewTextBoxColumn,
            this.mJOINDATEDataGridViewTextBoxColumn,
            this.M_CUR_RENT_COUNT});
            this.dataGridView1.DataSource = this.mEMBERBOOKSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(936, 504);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // mEMBERBOOKSBindingSource
            // 
            this.mEMBERBOOKSBindingSource.DataMember = "MEMBER_BOOKS";
            this.mEMBERBOOKSBindingSource.DataSource = this.dataset11;
            // 
            // dataset11
            // 
            this.dataset11.DataSetName = "dataset1";
            this.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_filter);
            this.groupBox2.Controls.Add(this.comboBox_filter);
            this.groupBox2.Controls.Add(this.textbox_member);
            this.groupBox2.Location = new System.Drawing.Point(523, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(419, 50);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "필터링";
            // 
            // button_filter
            // 
            this.button_filter.ActiveBorderThickness = 1;
            this.button_filter.ActiveCornerRadius = 20;
            this.button_filter.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_filter.ActiveForecolor = System.Drawing.Color.White;
            this.button_filter.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_filter.BackColor = System.Drawing.Color.Transparent;
            this.button_filter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_filter.BackgroundImage")));
            this.button_filter.ButtonText = "필터";
            this.button_filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_filter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_filter.ForeColor = System.Drawing.Color.ForestGreen;
            this.button_filter.IdleBorderThickness = 1;
            this.button_filter.IdleCornerRadius = 20;
            this.button_filter.IdleFillColor = System.Drawing.Color.DimGray;
            this.button_filter.IdleForecolor = System.Drawing.Color.White;
            this.button_filter.IdleLineColor = System.Drawing.Color.DimGray;
            this.button_filter.Location = new System.Drawing.Point(296, 9);
            this.button_filter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(117, 34);
            this.button_filter.TabIndex = 6;
            this.button_filter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_filter
            // 
            this.comboBox_filter.FormattingEnabled = true;
            this.comboBox_filter.Items.AddRange(new object[] {
            "아이디",
            "이름",
            "주민등록번호",
            "휴대폰",
            "이메일",
            "주소",
            "가입날짜"});
            this.comboBox_filter.Location = new System.Drawing.Point(9, 18);
            this.comboBox_filter.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_filter.Name = "comboBox_filter";
            this.comboBox_filter.Size = new System.Drawing.Size(98, 20);
            this.comboBox_filter.TabIndex = 4;
            // 
            // textbox_member
            // 
            this.textbox_member.Location = new System.Drawing.Point(110, 17);
            this.textbox_member.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_member.Name = "textbox_member";
            this.textbox_member.Size = new System.Drawing.Size(180, 21);
            this.textbox_member.TabIndex = 5;
            // 
            // button_save
            // 
            this.button_save.ActiveBorderThickness = 1;
            this.button_save.ActiveCornerRadius = 20;
            this.button_save.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_save.ActiveForecolor = System.Drawing.Color.White;
            this.button_save.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_save.BackColor = System.Drawing.Color.Transparent;
            this.button_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_save.BackgroundImage")));
            this.button_save.ButtonText = "저장";
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.ForestGreen;
            this.button_save.IdleBorderThickness = 1;
            this.button_save.IdleCornerRadius = 20;
            this.button_save.IdleFillColor = System.Drawing.Color.DimGray;
            this.button_save.IdleForecolor = System.Drawing.Color.White;
            this.button_save.IdleLineColor = System.Drawing.Color.DimGray;
            this.button_save.Location = new System.Drawing.Point(204, 34);
            this.button_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(91, 34);
            this.button_save.TabIndex = 3;
            this.button_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_delete
            // 
            this.button_delete.ActiveBorderThickness = 1;
            this.button_delete.ActiveCornerRadius = 20;
            this.button_delete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_delete.ActiveForecolor = System.Drawing.Color.White;
            this.button_delete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_delete.BackColor = System.Drawing.Color.Transparent;
            this.button_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_delete.BackgroundImage")));
            this.button_delete.ButtonText = "삭제";
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.ForestGreen;
            this.button_delete.IdleBorderThickness = 1;
            this.button_delete.IdleCornerRadius = 20;
            this.button_delete.IdleFillColor = System.Drawing.Color.DimGray;
            this.button_delete.IdleForecolor = System.Drawing.Color.White;
            this.button_delete.IdleLineColor = System.Drawing.Color.DimGray;
            this.button_delete.Location = new System.Drawing.Point(105, 34);
            this.button_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(91, 34);
            this.button_delete.TabIndex = 2;
            this.button_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_insert
            // 
            this.button_insert.ActiveBorderThickness = 1;
            this.button_insert.ActiveCornerRadius = 20;
            this.button_insert.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_insert.ActiveForecolor = System.Drawing.Color.White;
            this.button_insert.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_insert.BackColor = System.Drawing.Color.Transparent;
            this.button_insert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_insert.BackgroundImage")));
            this.button_insert.ButtonText = "입력";
            this.button_insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_insert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_insert.ForeColor = System.Drawing.Color.ForestGreen;
            this.button_insert.IdleBorderThickness = 1;
            this.button_insert.IdleCornerRadius = 20;
            this.button_insert.IdleFillColor = System.Drawing.Color.DimGray;
            this.button_insert.IdleForecolor = System.Drawing.Color.White;
            this.button_insert.IdleLineColor = System.Drawing.Color.DimGray;
            this.button_insert.Location = new System.Drawing.Point(6, 34);
            this.button_insert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(91, 34);
            this.button_insert.TabIndex = 1;
            this.button_insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
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
            // mEMBER_BOOKSTableAdapter
            // 
            this.mEMBER_BOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // mIDDataGridViewTextBoxColumn
            // 
            this.mIDDataGridViewTextBoxColumn.DataPropertyName = "M_ID";
            this.mIDDataGridViewTextBoxColumn.HeaderText = "회원아이디";
            this.mIDDataGridViewTextBoxColumn.Name = "mIDDataGridViewTextBoxColumn";
            this.mIDDataGridViewTextBoxColumn.ToolTipText = "중복되지 않는 값으로 설정";
            this.mIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // mNAMEDataGridViewTextBoxColumn
            // 
            this.mNAMEDataGridViewTextBoxColumn.DataPropertyName = "M_NAME";
            this.mNAMEDataGridViewTextBoxColumn.HeaderText = "이름";
            this.mNAMEDataGridViewTextBoxColumn.Name = "mNAMEDataGridViewTextBoxColumn";
            this.mNAMEDataGridViewTextBoxColumn.Width = 54;
            // 
            // mPASSWORDDataGridViewTextBoxColumn
            // 
            this.mPASSWORDDataGridViewTextBoxColumn.DataPropertyName = "M_PASSWORD";
            this.mPASSWORDDataGridViewTextBoxColumn.HeaderText = "비밀번호";
            this.mPASSWORDDataGridViewTextBoxColumn.Name = "mPASSWORDDataGridViewTextBoxColumn";
            this.mPASSWORDDataGridViewTextBoxColumn.Width = 78;
            // 
            // mSSNDataGridViewTextBoxColumn
            // 
            this.mSSNDataGridViewTextBoxColumn.DataPropertyName = "M_SSN";
            this.mSSNDataGridViewTextBoxColumn.HeaderText = "주민등록번호";
            this.mSSNDataGridViewTextBoxColumn.Name = "mSSNDataGridViewTextBoxColumn";
            this.mSSNDataGridViewTextBoxColumn.ToolTipText = "중복되지 않는 숫자들의 나열로 작성. {000000-0000000} 형식으로 지정";
            this.mSSNDataGridViewTextBoxColumn.Width = 72;
            // 
            // mPHONEDataGridViewTextBoxColumn
            // 
            this.mPHONEDataGridViewTextBoxColumn.DataPropertyName = "M_PHONE";
            this.mPHONEDataGridViewTextBoxColumn.HeaderText = "휴대폰";
            this.mPHONEDataGridViewTextBoxColumn.Name = "mPHONEDataGridViewTextBoxColumn";
            this.mPHONEDataGridViewTextBoxColumn.ToolTipText = "090-9999-9999 값으로 설정";
            this.mPHONEDataGridViewTextBoxColumn.Width = 61;
            // 
            // mMAILDataGridViewTextBoxColumn
            // 
            this.mMAILDataGridViewTextBoxColumn.DataPropertyName = "M_MAIL";
            this.mMAILDataGridViewTextBoxColumn.HeaderText = "이메일";
            this.mMAILDataGridViewTextBoxColumn.Name = "mMAILDataGridViewTextBoxColumn";
            this.mMAILDataGridViewTextBoxColumn.ToolTipText = "{ID}@{ADDR}.{sub} 형식";
            this.mMAILDataGridViewTextBoxColumn.Width = 61;
            // 
            // mADDRESSDataGridViewTextBoxColumn
            // 
            this.mADDRESSDataGridViewTextBoxColumn.DataPropertyName = "M_ADDRESS";
            this.mADDRESSDataGridViewTextBoxColumn.HeaderText = "주소";
            this.mADDRESSDataGridViewTextBoxColumn.Name = "mADDRESSDataGridViewTextBoxColumn";
            this.mADDRESSDataGridViewTextBoxColumn.Width = 51;
            // 
            // mGRADEDataGridViewTextBoxColumn
            // 
            this.mGRADEDataGridViewTextBoxColumn.DataPropertyName = "M_GRADE";
            this.mGRADEDataGridViewTextBoxColumn.HeaderText = "회원등급";
            this.mGRADEDataGridViewTextBoxColumn.Name = "mGRADEDataGridViewTextBoxColumn";
            this.mGRADEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mGRADEDataGridViewTextBoxColumn.ToolTipText = "일반회원(0)/매니저(1)/관리자(2)/블랙리스트(-1)";
            this.mGRADEDataGridViewTextBoxColumn.Width = 61;
            // 
            // mJOINDATEDataGridViewTextBoxColumn
            // 
            this.mJOINDATEDataGridViewTextBoxColumn.DataPropertyName = "M_JOINDATE";
            this.mJOINDATEDataGridViewTextBoxColumn.HeaderText = "가입날짜";
            this.mJOINDATEDataGridViewTextBoxColumn.Name = "mJOINDATEDataGridViewTextBoxColumn";
            this.mJOINDATEDataGridViewTextBoxColumn.ToolTipText = "YY-MM-DD";
            this.mJOINDATEDataGridViewTextBoxColumn.Width = 61;
            // 
            // M_CUR_RENT_COUNT
            // 
            this.M_CUR_RENT_COUNT.DataPropertyName = "M_CUR_RENT_COUNT";
            this.M_CUR_RENT_COUNT.HeaderText = "현재대출도서개수";
            this.M_CUR_RENT_COUNT.Name = "M_CUR_RENT_COUNT";
            this.M_CUR_RENT_COUNT.ReadOnly = true;
            this.M_CUR_RENT_COUNT.ToolTipText = "0";
            this.M_CUR_RENT_COUNT.Width = 83;
            // 
            // member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(971, 750);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.pictureBox_exit);
            this.Controls.Add(this.pictureBox_minimum);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.label_logo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "member";
            this.Text = "enroll";
            this.Load += new System.EventHandler(this.enroll_Load);
            this.panel_main.ResumeLayout(false);
            this.tabControl_enroll.ResumeLayout(false);
            this.tabPage_enroll.ResumeLayout(false);
            this.groupBox_info_enroll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEMBERBOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage_enroll;
        private System.Windows.Forms.GroupBox groupBox_info_enroll;
        private Bunifu.Framework.UI.BunifuThinButton2 button_insert;
        private Bunifu.Framework.UI.BunifuThinButton2 button_delete;
        private Bunifu.Framework.UI.BunifuThinButton2 button_save;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_filter;
        private System.Windows.Forms.TextBox textbox_member;
        private Bunifu.Framework.UI.BunifuThinButton2 button_filter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mEMBERBOOKSBindingSource;
        private dataset1TableAdapters.MEMBER_BOOKSTableAdapter mEMBER_BOOKSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mGRADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mJOINDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_CUR_RENT_COUNT;
    }
}

