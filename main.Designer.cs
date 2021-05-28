namespace Final_Project
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_logined = new System.Windows.Forms.Panel();
            this.panel_manager = new System.Windows.Forms.Panel();
            this.button_statistics = new Bunifu.Framework.UI.BunifuTileButton();
            this.button_member = new Bunifu.Framework.UI.BunifuTileButton();
            this.button_enroll = new Bunifu.Framework.UI.BunifuTileButton();
            this.button_rent = new Bunifu.Framework.UI.BunifuTileButton();
            this.button_logout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label_hello = new System.Windows.Forms.Label();
            this.panel_side = new System.Windows.Forms.Panel();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_profile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_history = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_review = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_popular = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_booking = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_seraching = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_side_unlogin = new System.Windows.Forms.Panel();
            this.button_join = new Bunifu.Framework.UI.BunifuTileButton();
            this.button_login = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel_login = new Final_Project.main.DoubleBufferPanel();
            this.pictureBox_exit2 = new System.Windows.Forms.PictureBox();
            this.button_Access = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label_login_pw = new System.Windows.Forms.Label();
            this.label_login_id = new System.Windows.Forms.Label();
            this.textbox_login_pw = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textbox_login_id = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label_로그인 = new System.Windows.Forms.Label();
            this.vIEWWILLRESERVATIONBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataset11 = new Final_Project.dataset1();
            this.vIEWWILLRESERVATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label_logo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox_exit = new System.Windows.Forms.PictureBox();
            this.pictureBox_minimum = new System.Windows.Forms.PictureBox();
            this.membeR_BOOKSTableAdapter1 = new Final_Project.dataset1TableAdapters.MEMBER_BOOKSTableAdapter();
            this.rentaL_BOOKSTableAdapter1 = new Final_Project.dataset1TableAdapters.RENTAL_BOOKSTableAdapter();
            this.vieW_RENTALTableAdapter1 = new Final_Project.dataset1TableAdapters.VIEW_RENTALTableAdapter();
            this.vIEW_WILL_RESERVATIONTableAdapter = new Final_Project.dataset1TableAdapters.VIEW_WILL_RESERVATIONTableAdapter();
            this.reservatioN_BOOKSTableAdapter1 = new Final_Project.dataset1TableAdapters.RESERVATION_BOOKSTableAdapter();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.oracleConnection1 = new Oracle.ManagedDataAccess.Client.OracleConnection();
            this.panel_main.SuspendLayout();
            this.panel_logined.SuspendLayout();
            this.panel_manager.SuspendLayout();
            this.panel_side.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.panel_side_unlogin.SuspendLayout();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWWILLRESERVATIONBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWWILLRESERVATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimum)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel_main.Controls.Add(this.panel_logined);
            this.panel_main.Controls.Add(this.panel_side);
            this.panel_main.Controls.Add(this.panel_login);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_main.Location = new System.Drawing.Point(0, 87);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(971, 615);
            this.panel_main.TabIndex = 0;
            // 
            // panel_logined
            // 
            this.panel_logined.BackColor = System.Drawing.Color.White;
            this.panel_logined.Controls.Add(this.panel_manager);
            this.panel_logined.Controls.Add(this.button_logout);
            this.panel_logined.Controls.Add(this.label_hello);
            this.panel_logined.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logined.Location = new System.Drawing.Point(211, 0);
            this.panel_logined.Name = "panel_logined";
            this.panel_logined.Size = new System.Drawing.Size(760, 615);
            this.panel_logined.TabIndex = 6;
            this.panel_logined.Visible = false;
            // 
            // panel_manager
            // 
            this.panel_manager.BackColor = System.Drawing.Color.Transparent;
            this.panel_manager.Controls.Add(this.button_statistics);
            this.panel_manager.Controls.Add(this.button_member);
            this.panel_manager.Controls.Add(this.button_enroll);
            this.panel_manager.Controls.Add(this.button_rent);
            this.panel_manager.Location = new System.Drawing.Point(83, 61);
            this.panel_manager.Name = "panel_manager";
            this.panel_manager.Size = new System.Drawing.Size(573, 539);
            this.panel_manager.TabIndex = 7;
            this.panel_manager.Visible = false;
            // 
            // button_statistics
            // 
            this.button_statistics.BackColor = System.Drawing.Color.SeaGreen;
            this.button_statistics.color = System.Drawing.Color.SeaGreen;
            this.button_statistics.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.button_statistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_statistics.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.button_statistics.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_statistics.Image = global::Final_Project.Properties.Resources.icone_finance1;
            this.button_statistics.ImagePosition = 40;
            this.button_statistics.ImageZoom = 45;
            this.button_statistics.LabelPosition = 81;
            this.button_statistics.LabelText = "통계";
            this.button_statistics.Location = new System.Drawing.Point(293, 277);
            this.button_statistics.Margin = new System.Windows.Forms.Padding(6);
            this.button_statistics.Name = "button_statistics";
            this.button_statistics.Size = new System.Drawing.Size(280, 262);
            this.button_statistics.TabIndex = 3;
            this.button_statistics.Click += new System.EventHandler(this.button_statistics_Click);
            // 
            // button_member
            // 
            this.button_member.BackColor = System.Drawing.Color.Goldenrod;
            this.button_member.color = System.Drawing.Color.Goldenrod;
            this.button_member.colorActive = System.Drawing.Color.Gold;
            this.button_member.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_member.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.button_member.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_member.Image = ((System.Drawing.Image)(resources.GetObject("button_member.Image")));
            this.button_member.ImagePosition = 40;
            this.button_member.ImageZoom = 50;
            this.button_member.LabelPosition = 81;
            this.button_member.LabelText = "회원관리";
            this.button_member.Location = new System.Drawing.Point(1, 277);
            this.button_member.Margin = new System.Windows.Forms.Padding(6);
            this.button_member.Name = "button_member";
            this.button_member.Size = new System.Drawing.Size(280, 262);
            this.button_member.TabIndex = 2;
            this.button_member.Click += new System.EventHandler(this.button_member_Click);
            // 
            // button_enroll
            // 
            this.button_enroll.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_enroll.color = System.Drawing.Color.DeepSkyBlue;
            this.button_enroll.colorActive = System.Drawing.Color.LightSkyBlue;
            this.button_enroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_enroll.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.button_enroll.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_enroll.Image = ((System.Drawing.Image)(resources.GetObject("button_enroll.Image")));
            this.button_enroll.ImagePosition = 40;
            this.button_enroll.ImageZoom = 45;
            this.button_enroll.LabelPosition = 81;
            this.button_enroll.LabelText = "등록/폐기";
            this.button_enroll.Location = new System.Drawing.Point(293, 0);
            this.button_enroll.Margin = new System.Windows.Forms.Padding(6);
            this.button_enroll.Name = "button_enroll";
            this.button_enroll.Size = new System.Drawing.Size(280, 262);
            this.button_enroll.TabIndex = 1;
            this.button_enroll.Click += new System.EventHandler(this.button_enroll_Click);
            // 
            // button_rent
            // 
            this.button_rent.BackColor = System.Drawing.Color.Brown;
            this.button_rent.color = System.Drawing.Color.Brown;
            this.button_rent.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_rent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_rent.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.button_rent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_rent.Image = ((System.Drawing.Image)(resources.GetObject("button_rent.Image")));
            this.button_rent.ImagePosition = 40;
            this.button_rent.ImageZoom = 50;
            this.button_rent.LabelPosition = 81;
            this.button_rent.LabelText = "대여/반납";
            this.button_rent.Location = new System.Drawing.Point(1, 0);
            this.button_rent.Margin = new System.Windows.Forms.Padding(6);
            this.button_rent.Name = "button_rent";
            this.button_rent.Size = new System.Drawing.Size(280, 262);
            this.button_rent.TabIndex = 0;
            this.button_rent.Click += new System.EventHandler(this.button_rent_Click);
            // 
            // button_logout
            // 
            this.button_logout.ActiveBorderThickness = 1;
            this.button_logout.ActiveCornerRadius = 20;
            this.button_logout.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_logout.ActiveForecolor = System.Drawing.Color.White;
            this.button_logout.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_logout.BackColor = System.Drawing.Color.White;
            this.button_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_logout.BackgroundImage")));
            this.button_logout.ButtonText = "로그아웃";
            this.button_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_logout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.ForeColor = System.Drawing.Color.AliceBlue;
            this.button_logout.IdleBorderThickness = 1;
            this.button_logout.IdleCornerRadius = 20;
            this.button_logout.IdleFillColor = System.Drawing.Color.Green;
            this.button_logout.IdleForecolor = System.Drawing.Color.AliceBlue;
            this.button_logout.IdleLineColor = System.Drawing.Color.Green;
            this.button_logout.Location = new System.Drawing.Point(664, 5);
            this.button_logout.Margin = new System.Windows.Forms.Padding(5);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(82, 41);
            this.button_logout.TabIndex = 1;
            this.button_logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // label_hello
            // 
            this.label_hello.AutoSize = true;
            this.label_hello.ForeColor = System.Drawing.Color.Black;
            this.label_hello.Location = new System.Drawing.Point(493, 22);
            this.label_hello.Name = "label_hello";
            this.label_hello.Size = new System.Drawing.Size(163, 12);
            this.label_hello.TabIndex = 0;
            this.label_hello.Text = "[ manager ] 님, 환영합니다!";
            // 
            // panel_side
            // 
            this.panel_side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.panel_side.Controls.Add(this.panel_menu);
            this.panel_side.Controls.Add(this.panel_side_unlogin);
            this.panel_side.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_side.Location = new System.Drawing.Point(0, 0);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(211, 615);
            this.panel_side.TabIndex = 0;
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.button_profile);
            this.panel_menu.Controls.Add(this.button_history);
            this.panel_menu.Controls.Add(this.button_review);
            this.panel_menu.Controls.Add(this.button_popular);
            this.panel_menu.Controls.Add(this.button_booking);
            this.panel_menu.Controls.Add(this.button_seraching);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu.Location = new System.Drawing.Point(0, 131);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(211, 481);
            this.panel_menu.TabIndex = 0;
            // 
            // button_profile
            // 
            this.button_profile.Active = false;
            this.button_profile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.button_profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_profile.BorderRadius = 0;
            this.button_profile.ButtonText = "회원정보";
            this.button_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_profile.DisabledColor = System.Drawing.Color.Gray;
            this.button_profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_profile.Iconcolor = System.Drawing.Color.Transparent;
            this.button_profile.Iconimage = null;
            this.button_profile.Iconimage_right = null;
            this.button_profile.Iconimage_right_Selected = null;
            this.button_profile.Iconimage_Selected = null;
            this.button_profile.IconMarginLeft = 0;
            this.button_profile.IconMarginRight = 0;
            this.button_profile.IconRightVisible = true;
            this.button_profile.IconRightZoom = 0D;
            this.button_profile.IconVisible = true;
            this.button_profile.IconZoom = 90D;
            this.button_profile.IsTab = false;
            this.button_profile.Location = new System.Drawing.Point(0, 345);
            this.button_profile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_profile.Name = "button_profile";
            this.button_profile.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.button_profile.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.button_profile.OnHoverTextColor = System.Drawing.Color.White;
            this.button_profile.selected = false;
            this.button_profile.Size = new System.Drawing.Size(211, 69);
            this.button_profile.TabIndex = 5;
            this.button_profile.Text = "회원정보";
            this.button_profile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_profile.Textcolor = System.Drawing.Color.LightGray;
            this.button_profile.TextFont = new System.Drawing.Font("휴먼둥근헤드라인", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_profile.Click += new System.EventHandler(this.button_profile_Click);
            // 
            // button_history
            // 
            this.button_history.Active = false;
            this.button_history.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.button_history.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_history.BorderRadius = 0;
            this.button_history.ButtonText = "대출내역";
            this.button_history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_history.DisabledColor = System.Drawing.Color.Gray;
            this.button_history.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_history.Iconcolor = System.Drawing.Color.Transparent;
            this.button_history.Iconimage = null;
            this.button_history.Iconimage_right = null;
            this.button_history.Iconimage_right_Selected = null;
            this.button_history.Iconimage_Selected = null;
            this.button_history.IconMarginLeft = 0;
            this.button_history.IconMarginRight = 0;
            this.button_history.IconRightVisible = true;
            this.button_history.IconRightZoom = 0D;
            this.button_history.IconVisible = true;
            this.button_history.IconZoom = 90D;
            this.button_history.IsTab = false;
            this.button_history.Location = new System.Drawing.Point(0, 276);
            this.button_history.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_history.Name = "button_history";
            this.button_history.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.button_history.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.button_history.OnHoverTextColor = System.Drawing.Color.White;
            this.button_history.selected = false;
            this.button_history.Size = new System.Drawing.Size(211, 69);
            this.button_history.TabIndex = 4;
            this.button_history.Text = "대출내역";
            this.button_history.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_history.Textcolor = System.Drawing.Color.LightGray;
            this.button_history.TextFont = new System.Drawing.Font("휴먼둥근헤드라인", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_history.Click += new System.EventHandler(this.button_history_Click);
            // 
            // button_review
            // 
            this.button_review.Active = false;
            this.button_review.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button_review.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.button_review.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_review.BorderRadius = 0;
            this.button_review.ButtonText = "도서후기";
            this.button_review.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_review.DisabledColor = System.Drawing.Color.Gray;
            this.button_review.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_review.Iconcolor = System.Drawing.Color.Transparent;
            this.button_review.Iconimage = null;
            this.button_review.Iconimage_right = null;
            this.button_review.Iconimage_right_Selected = null;
            this.button_review.Iconimage_Selected = null;
            this.button_review.IconMarginLeft = 0;
            this.button_review.IconMarginRight = 0;
            this.button_review.IconRightVisible = true;
            this.button_review.IconRightZoom = 0D;
            this.button_review.IconVisible = true;
            this.button_review.IconZoom = 90D;
            this.button_review.IsTab = false;
            this.button_review.Location = new System.Drawing.Point(0, 207);
            this.button_review.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_review.Name = "button_review";
            this.button_review.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.button_review.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.button_review.OnHoverTextColor = System.Drawing.Color.White;
            this.button_review.selected = false;
            this.button_review.Size = new System.Drawing.Size(211, 69);
            this.button_review.TabIndex = 3;
            this.button_review.Text = "도서후기";
            this.button_review.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_review.Textcolor = System.Drawing.Color.LightGray;
            this.button_review.TextFont = new System.Drawing.Font("휴먼둥근헤드라인", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_review.Click += new System.EventHandler(this.button_review_Click);
            // 
            // button_popular
            // 
            this.button_popular.Active = false;
            this.button_popular.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button_popular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.button_popular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_popular.BorderRadius = 0;
            this.button_popular.ButtonText = "인기도서";
            this.button_popular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_popular.DisabledColor = System.Drawing.Color.Gray;
            this.button_popular.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_popular.Iconcolor = System.Drawing.Color.Transparent;
            this.button_popular.Iconimage = null;
            this.button_popular.Iconimage_right = null;
            this.button_popular.Iconimage_right_Selected = null;
            this.button_popular.Iconimage_Selected = null;
            this.button_popular.IconMarginLeft = 0;
            this.button_popular.IconMarginRight = 0;
            this.button_popular.IconRightVisible = true;
            this.button_popular.IconRightZoom = 0D;
            this.button_popular.IconVisible = true;
            this.button_popular.IconZoom = 90D;
            this.button_popular.IsTab = false;
            this.button_popular.Location = new System.Drawing.Point(0, 138);
            this.button_popular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_popular.Name = "button_popular";
            this.button_popular.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.button_popular.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.button_popular.OnHoverTextColor = System.Drawing.Color.White;
            this.button_popular.selected = false;
            this.button_popular.Size = new System.Drawing.Size(211, 69);
            this.button_popular.TabIndex = 2;
            this.button_popular.Text = "인기도서";
            this.button_popular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_popular.Textcolor = System.Drawing.Color.LightGray;
            this.button_popular.TextFont = new System.Drawing.Font("휴먼둥근헤드라인", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_popular.Click += new System.EventHandler(this.button_popular_Click);
            // 
            // button_booking
            // 
            this.button_booking.Active = false;
            this.button_booking.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button_booking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.button_booking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_booking.BorderRadius = 0;
            this.button_booking.ButtonText = "도서예약";
            this.button_booking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_booking.DisabledColor = System.Drawing.Color.Gray;
            this.button_booking.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_booking.Iconcolor = System.Drawing.Color.Transparent;
            this.button_booking.Iconimage = null;
            this.button_booking.Iconimage_right = null;
            this.button_booking.Iconimage_right_Selected = null;
            this.button_booking.Iconimage_Selected = null;
            this.button_booking.IconMarginLeft = 0;
            this.button_booking.IconMarginRight = 0;
            this.button_booking.IconRightVisible = true;
            this.button_booking.IconRightZoom = 0D;
            this.button_booking.IconVisible = true;
            this.button_booking.IconZoom = 90D;
            this.button_booking.IsTab = false;
            this.button_booking.Location = new System.Drawing.Point(0, 69);
            this.button_booking.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_booking.Name = "button_booking";
            this.button_booking.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.button_booking.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.button_booking.OnHoverTextColor = System.Drawing.Color.White;
            this.button_booking.selected = false;
            this.button_booking.Size = new System.Drawing.Size(211, 69);
            this.button_booking.TabIndex = 1;
            this.button_booking.Text = "도서예약";
            this.button_booking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_booking.Textcolor = System.Drawing.Color.LightGray;
            this.button_booking.TextFont = new System.Drawing.Font("휴먼둥근헤드라인", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_booking.Click += new System.EventHandler(this.button_reservation_Click);
            // 
            // button_seraching
            // 
            this.button_seraching.Active = true;
            this.button_seraching.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button_seraching.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.button_seraching.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_seraching.BorderRadius = 0;
            this.button_seraching.ButtonText = "도서검색";
            this.button_seraching.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_seraching.DisabledColor = System.Drawing.Color.Gray;
            this.button_seraching.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_seraching.Iconcolor = System.Drawing.Color.Transparent;
            this.button_seraching.Iconimage = null;
            this.button_seraching.Iconimage_right = null;
            this.button_seraching.Iconimage_right_Selected = null;
            this.button_seraching.Iconimage_Selected = null;
            this.button_seraching.IconMarginLeft = 0;
            this.button_seraching.IconMarginRight = 0;
            this.button_seraching.IconRightVisible = true;
            this.button_seraching.IconRightZoom = 0D;
            this.button_seraching.IconVisible = true;
            this.button_seraching.IconZoom = 90D;
            this.button_seraching.IsTab = false;
            this.button_seraching.Location = new System.Drawing.Point(0, 0);
            this.button_seraching.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_seraching.Name = "button_seraching";
            this.button_seraching.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.button_seraching.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.button_seraching.OnHoverTextColor = System.Drawing.Color.White;
            this.button_seraching.selected = true;
            this.button_seraching.Size = new System.Drawing.Size(211, 69);
            this.button_seraching.TabIndex = 0;
            this.button_seraching.Text = "도서검색";
            this.button_seraching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_seraching.Textcolor = System.Drawing.Color.LightGray;
            this.button_seraching.TextFont = new System.Drawing.Font("휴먼둥근헤드라인", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_seraching.Click += new System.EventHandler(this.button_seraching_Click);
            // 
            // panel_side_unlogin
            // 
            this.panel_side_unlogin.Controls.Add(this.button_join);
            this.panel_side_unlogin.Controls.Add(this.button_login);
            this.panel_side_unlogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_side_unlogin.Location = new System.Drawing.Point(0, 0);
            this.panel_side_unlogin.Name = "panel_side_unlogin";
            this.panel_side_unlogin.Size = new System.Drawing.Size(211, 131);
            this.panel_side_unlogin.TabIndex = 0;
            // 
            // button_join
            // 
            this.button_join.BackColor = System.Drawing.Color.SeaGreen;
            this.button_join.color = System.Drawing.Color.SeaGreen;
            this.button_join.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.button_join.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_join.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_join.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_join.ForeColor = System.Drawing.Color.LightGray;
            this.button_join.Image = ((System.Drawing.Image)(resources.GetObject("button_join.Image")));
            this.button_join.ImagePosition = 19;
            this.button_join.ImageZoom = 50;
            this.button_join.LabelPosition = 38;
            this.button_join.LabelText = "회원가입";
            this.button_join.Location = new System.Drawing.Point(105, 0);
            this.button_join.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.button_join.Name = "button_join";
            this.button_join.Size = new System.Drawing.Size(107, 131);
            this.button_join.TabIndex = 1;
            this.button_join.Click += new System.EventHandler(this.button_join_Click);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.SeaGreen;
            this.button_login.color = System.Drawing.Color.SeaGreen;
            this.button_login.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_login.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_login.ForeColor = System.Drawing.Color.LightGray;
            this.button_login.Image = ((System.Drawing.Image)(resources.GetObject("button_login.Image")));
            this.button_login.ImagePosition = 19;
            this.button_login.ImageZoom = 50;
            this.button_login.LabelPosition = 38;
            this.button_login.LabelText = "로그인";
            this.button_login.Location = new System.Drawing.Point(0, 0);
            this.button_login.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(105, 131);
            this.button_login.TabIndex = 0;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.Tomato;
            this.panel_login.Controls.Add(this.pictureBox_exit2);
            this.panel_login.Controls.Add(this.button_Access);
            this.panel_login.Controls.Add(this.label_login_pw);
            this.panel_login.Controls.Add(this.label_login_id);
            this.panel_login.Controls.Add(this.textbox_login_pw);
            this.panel_login.Controls.Add(this.textbox_login_id);
            this.panel_login.Controls.Add(this.label_로그인);
            this.panel_login.Location = new System.Drawing.Point(392, 61);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(346, 509);
            this.panel_login.TabIndex = 5;
            this.panel_login.Visible = false;
            this.panel_login.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_login_Paint);
            this.panel_login.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_login_MouseDown);
            this.panel_login.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_login_MouseMove);
            this.panel_login.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_login_MouseUp);
            // 
            // pictureBox_exit2
            // 
            this.pictureBox_exit2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_exit2.Image")));
            this.pictureBox_exit2.Location = new System.Drawing.Point(314, 12);
            this.pictureBox_exit2.Name = "pictureBox_exit2";
            this.pictureBox_exit2.Size = new System.Drawing.Size(19, 9);
            this.pictureBox_exit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_exit2.TabIndex = 5;
            this.pictureBox_exit2.TabStop = false;
            this.pictureBox_exit2.Click += new System.EventHandler(this.pictureBox_exit2_Click);
            // 
            // button_Access
            // 
            this.button_Access.ActiveBorderThickness = 1;
            this.button_Access.ActiveCornerRadius = 20;
            this.button_Access.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(129)))), ((int)(((byte)(117)))));
            this.button_Access.ActiveForecolor = System.Drawing.Color.White;
            this.button_Access.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(129)))), ((int)(((byte)(117)))));
            this.button_Access.BackColor = System.Drawing.Color.Tomato;
            this.button_Access.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Access.BackgroundImage")));
            this.button_Access.ButtonText = "ACESS";
            this.button_Access.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Access.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Access.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_Access.IdleBorderThickness = 1;
            this.button_Access.IdleCornerRadius = 20;
            this.button_Access.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(66)))), ((int)(((byte)(47)))));
            this.button_Access.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.button_Access.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(66)))), ((int)(((byte)(47)))));
            this.button_Access.Location = new System.Drawing.Point(94, 385);
            this.button_Access.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Access.Name = "button_Access";
            this.button_Access.Size = new System.Drawing.Size(163, 37);
            this.button_Access.TabIndex = 5;
            this.button_Access.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Access.Click += new System.EventHandler(this.button_Access_Click);
            // 
            // label_login_pw
            // 
            this.label_login_pw.AutoSize = true;
            this.label_login_pw.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_login_pw.Location = new System.Drawing.Point(38, 291);
            this.label_login_pw.Name = "label_login_pw";
            this.label_login_pw.Size = new System.Drawing.Size(32, 16);
            this.label_login_pw.TabIndex = 4;
            this.label_login_pw.Text = "PW";
            // 
            // label_login_id
            // 
            this.label_login_id.AutoSize = true;
            this.label_login_id.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_login_id.Location = new System.Drawing.Point(38, 237);
            this.label_login_id.Name = "label_login_id";
            this.label_login_id.Size = new System.Drawing.Size(21, 16);
            this.label_login_id.TabIndex = 3;
            this.label_login_id.Text = "ID";
            // 
            // textbox_login_pw
            // 
            this.textbox_login_pw.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(33)))), ((int)(((byte)(23)))));
            this.textbox_login_pw.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_login_pw.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(33)))), ((int)(((byte)(23)))));
            this.textbox_login_pw.BorderThickness = 3;
            this.textbox_login_pw.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textbox_login_pw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_login_pw.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textbox_login_pw.ForeColor = System.Drawing.Color.Black;
            this.textbox_login_pw.isPassword = true;
            this.textbox_login_pw.Location = new System.Drawing.Point(78, 278);
            this.textbox_login_pw.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_login_pw.MaxLength = 20;
            this.textbox_login_pw.Name = "textbox_login_pw";
            this.textbox_login_pw.Size = new System.Drawing.Size(218, 44);
            this.textbox_login_pw.TabIndex = 2;
            this.textbox_login_pw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textbox_login_id
            // 
            this.textbox_login_id.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(33)))), ((int)(((byte)(23)))));
            this.textbox_login_id.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_login_id.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(33)))), ((int)(((byte)(23)))));
            this.textbox_login_id.BorderThickness = 3;
            this.textbox_login_id.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textbox_login_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_login_id.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textbox_login_id.ForeColor = System.Drawing.Color.Black;
            this.textbox_login_id.isPassword = false;
            this.textbox_login_id.Location = new System.Drawing.Point(78, 223);
            this.textbox_login_id.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_login_id.MaxLength = 20;
            this.textbox_login_id.Name = "textbox_login_id";
            this.textbox_login_id.Size = new System.Drawing.Size(218, 44);
            this.textbox_login_id.TabIndex = 1;
            this.textbox_login_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label_로그인
            // 
            this.label_로그인.AutoSize = true;
            this.label_로그인.Font = new System.Drawing.Font("함초롬바탕 확장B", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_로그인.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_로그인.Location = new System.Drawing.Point(66, 100);
            this.label_로그인.Name = "label_로그인";
            this.label_로그인.Size = new System.Drawing.Size(215, 70);
            this.label_로그인.TabIndex = 0;
            this.label_로그인.Text = "LOGIN";
            // 
            // vIEWWILLRESERVATIONBindingSource1
            // 
            this.vIEWWILLRESERVATIONBindingSource1.DataMember = "VIEW_WILL_RESERVATION";
            this.vIEWWILLRESERVATIONBindingSource1.DataSource = this.dataset11;
            // 
            // dataset11
            // 
            this.dataset11.DataSetName = "dataset1";
            this.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vIEWWILLRESERVATIONBindingSource
            // 
            this.vIEWWILLRESERVATIONBindingSource.DataMember = "VIEW_WILL_RESERVATION";
            this.vIEWWILLRESERVATIONBindingSource.DataSource = this.dataset11;
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
            this.label_logo.Location = new System.Drawing.Point(70, 3);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(360, 72);
            this.label_logo.TabIndex = 4;
            this.label_logo.Text = "BookTree";
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Enabled = false;
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(19, 9);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(45, 63);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 1;
            this.pictureBox_logo.TabStop = false;
            // 
            // pictureBox_exit
            // 
            this.pictureBox_exit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_exit.Image")));
            this.pictureBox_exit.Location = new System.Drawing.Point(941, 12);
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
            this.pictureBox_minimum.Location = new System.Drawing.Point(927, 12);
            this.pictureBox_minimum.Name = "pictureBox_minimum";
            this.pictureBox_minimum.Size = new System.Drawing.Size(9, 9);
            this.pictureBox_minimum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_minimum.TabIndex = 1;
            this.pictureBox_minimum.TabStop = false;
            this.pictureBox_minimum.Click += new System.EventHandler(this.pictureBox_minimum_Click);
            // 
            // membeR_BOOKSTableAdapter1
            // 
            this.membeR_BOOKSTableAdapter1.ClearBeforeFill = true;
            // 
            // rentaL_BOOKSTableAdapter1
            // 
            this.rentaL_BOOKSTableAdapter1.ClearBeforeFill = true;
            // 
            // vieW_RENTALTableAdapter1
            // 
            this.vieW_RENTALTableAdapter1.ClearBeforeFill = true;
            // 
            // vIEW_WILL_RESERVATIONTableAdapter
            // 
            this.vIEW_WILL_RESERVATIONTableAdapter.ClearBeforeFill = true;
            // 
            // reservatioN_BOOKSTableAdapter1
            // 
            this.reservatioN_BOOKSTableAdapter1.ClearBeforeFill = true;
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.Credential = null;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(86)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(971, 702);
            this.Controls.Add(this.label_logo);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.pictureBox_exit);
            this.Controls.Add(this.pictureBox_minimum);
            this.Controls.Add(this.panel_main);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_logined.ResumeLayout(false);
            this.panel_logined.PerformLayout();
            this.panel_manager.ResumeLayout(false);
            this.panel_side.ResumeLayout(false);
            this.panel_menu.ResumeLayout(false);
            this.panel_side_unlogin.ResumeLayout(false);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWWILLRESERVATIONBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEWWILLRESERVATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.PictureBox pictureBox_minimum;
        private System.Windows.Forms.PictureBox pictureBox_exit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private System.Windows.Forms.Panel panel_side_unlogin;
        private System.Windows.Forms.Panel panel_menu;
        private Bunifu.Framework.UI.BunifuFlatButton button_seraching;
        private Bunifu.Framework.UI.BunifuTileButton button_login;
        private Bunifu.Framework.UI.BunifuTileButton button_join;
        private Bunifu.Framework.UI.BunifuFlatButton button_history;
        private Bunifu.Framework.UI.BunifuFlatButton button_review;
        private Bunifu.Framework.UI.BunifuFlatButton button_popular;
        private Bunifu.Framework.UI.BunifuFlatButton button_booking;
        private Bunifu.Framework.UI.BunifuFlatButton button_profile;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private Bunifu.Framework.UI.BunifuCustomLabel label_logo;
        private dataset1 dataset11;
        private dataset1TableAdapters.MEMBER_BOOKSTableAdapter membeR_BOOKSTableAdapter1;
        private DoubleBufferPanel panel_login;
        private System.Windows.Forms.Label label_로그인;
        private Bunifu.Framework.UI.BunifuMetroTextbox textbox_login_id;
        private System.Windows.Forms.Label label_login_pw;
        private System.Windows.Forms.Label label_login_id;
        private Bunifu.Framework.UI.BunifuMetroTextbox textbox_login_pw;
        private Bunifu.Framework.UI.BunifuThinButton2 button_Access;
        private System.Windows.Forms.Panel panel_logined;
        private System.Windows.Forms.PictureBox pictureBox_exit2;
        private System.Windows.Forms.Label label_hello;
        private System.Windows.Forms.Panel panel_manager;
        private Bunifu.Framework.UI.BunifuTileButton button_rent;
        private Bunifu.Framework.UI.BunifuTileButton button_statistics;
        private Bunifu.Framework.UI.BunifuTileButton button_member;
        private Bunifu.Framework.UI.BunifuTileButton button_enroll;
        private dataset1TableAdapters.RENTAL_BOOKSTableAdapter rentaL_BOOKSTableAdapter1;
        private dataset1TableAdapters.VIEW_RENTALTableAdapter vieW_RENTALTableAdapter1;
        private System.Windows.Forms.BindingSource vIEWWILLRESERVATIONBindingSource;
        private dataset1TableAdapters.VIEW_WILL_RESERVATIONTableAdapter vIEW_WILL_RESERVATIONTableAdapter;
        private dataset1TableAdapters.RESERVATION_BOOKSTableAdapter reservatioN_BOOKSTableAdapter1;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private Oracle.ManagedDataAccess.Client.OracleConnection oracleConnection1;
        private System.Windows.Forms.BindingSource vIEWWILLRESERVATIONBindingSource1;
        public Bunifu.Framework.UI.BunifuThinButton2 button_logout;
    }
}

