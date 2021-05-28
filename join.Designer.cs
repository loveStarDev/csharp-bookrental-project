namespace Final_Project
{
    partial class join
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(join));
            this.button_join = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_personal_detail = new System.Windows.Forms.Panel();
            this.checkBox_agree = new System.Windows.Forms.CheckBox();
            this.label_divider = new System.Windows.Forms.Label();
            this.textbox_address = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textbox_phone = new System.Windows.Forms.MaskedTextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.textbox_email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.panel_contact_detail = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_pw = new System.Windows.Forms.Label();
            this.textbox_certification = new System.Windows.Forms.MaskedTextBox();
            this.textbox_pw = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label_RRN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_pw2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textbox_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label_name = new System.Windows.Forms.Label();
            this.panel_explain = new System.Windows.Forms.Panel();
            this.label_explain = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label_logo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.oracleConnection1 = new Oracle.ManagedDataAccess.Client.OracleConnection();
            this.dataset11 = new Final_Project.dataset1();
            this.membeR_BOOKSTableAdapter1 = new Final_Project.dataset1TableAdapters.MEMBER_BOOKSTableAdapter();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox_exit = new System.Windows.Forms.PictureBox();
            this.pictureBox_minimum = new System.Windows.Forms.PictureBox();
            this.panel_body.SuspendLayout();
            this.panel_personal_detail.SuspendLayout();
            this.panel_contact_detail.SuspendLayout();
            this.panel_explain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimum)).BeginInit();
            this.SuspendLayout();
            // 
            // button_join
            // 
            this.button_join.Active = true;
            this.button_join.Activecolor = System.Drawing.Color.SeaGreen;
            this.button_join.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button_join.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_join.BorderRadius = 0;
            this.button_join.ButtonText = "SIGN_UP";
            this.button_join.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_join.DisabledColor = System.Drawing.Color.Gray;
            this.button_join.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_join.Iconcolor = System.Drawing.Color.White;
            this.button_join.Iconimage = null;
            this.button_join.Iconimage_right = null;
            this.button_join.Iconimage_right_Selected = null;
            this.button_join.Iconimage_Selected = null;
            this.button_join.IconMarginLeft = 0;
            this.button_join.IconMarginRight = 0;
            this.button_join.IconRightVisible = false;
            this.button_join.IconRightZoom = 0D;
            this.button_join.IconVisible = false;
            this.button_join.IconZoom = 0D;
            this.button_join.IsTab = false;
            this.button_join.Location = new System.Drawing.Point(0, 533);
            this.button_join.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.button_join.Name = "button_join";
            this.button_join.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button_join.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.button_join.OnHoverTextColor = System.Drawing.Color.White;
            this.button_join.selected = true;
            this.button_join.Size = new System.Drawing.Size(440, 58);
            this.button_join.TabIndex = 22;
            this.button_join.Text = "SIGN_UP";
            this.button_join.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_join.Textcolor = System.Drawing.Color.LightGray;
            this.button_join.TextFont = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_join.Click += new System.EventHandler(this.button_join_Click);
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 18;
            this.bunifuElipse.TargetControl = this;
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.panel_body.Controls.Add(this.button_join);
            this.panel_body.Controls.Add(this.panel_personal_detail);
            this.panel_body.Controls.Add(this.panel_contact_detail);
            this.panel_body.Controls.Add(this.panel_explain);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_body.Location = new System.Drawing.Point(0, 64);
            this.panel_body.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(440, 590);
            this.panel_body.TabIndex = 0;
            // 
            // panel_personal_detail
            // 
            this.panel_personal_detail.Controls.Add(this.checkBox_agree);
            this.panel_personal_detail.Controls.Add(this.label_divider);
            this.panel_personal_detail.Controls.Add(this.textbox_address);
            this.panel_personal_detail.Controls.Add(this.textbox_phone);
            this.panel_personal_detail.Controls.Add(this.label_address);
            this.panel_personal_detail.Controls.Add(this.textbox_email);
            this.panel_personal_detail.Controls.Add(this.label7);
            this.panel_personal_detail.Controls.Add(this.label_email);
            this.panel_personal_detail.Controls.Add(this.label_phone);
            this.panel_personal_detail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_personal_detail.Location = new System.Drawing.Point(0, 323);
            this.panel_personal_detail.Margin = new System.Windows.Forms.Padding(2);
            this.panel_personal_detail.Name = "panel_personal_detail";
            this.panel_personal_detail.Size = new System.Drawing.Size(440, 210);
            this.panel_personal_detail.TabIndex = 18;
            // 
            // checkBox_agree
            // 
            this.checkBox_agree.AutoSize = true;
            this.checkBox_agree.ForeColor = System.Drawing.Color.LightGray;
            this.checkBox_agree.Location = new System.Drawing.Point(224, 183);
            this.checkBox_agree.Name = "checkBox_agree";
            this.checkBox_agree.Size = new System.Drawing.Size(204, 16);
            this.checkBox_agree.TabIndex = 17;
            this.checkBox_agree.Text = "개인정보 취급방침에 동의합니다.";
            this.checkBox_agree.UseVisualStyleBackColor = true;
            // 
            // label_divider
            // 
            this.label_divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_divider.Location = new System.Drawing.Point(38, -1);
            this.label_divider.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_divider.Name = "label_divider";
            this.label_divider.Size = new System.Drawing.Size(360, 2);
            this.label_divider.TabIndex = 7;
            this.label_divider.Text = "              ";
            // 
            // textbox_address
            // 
            this.textbox_address.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textbox_address.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textbox_address.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textbox_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_address.Font = new System.Drawing.Font("Candara", 12F);
            this.textbox_address.ForeColor = System.Drawing.Color.LightGray;
            this.textbox_address.HintForeColor = System.Drawing.Color.Empty;
            this.textbox_address.HintText = "";
            this.textbox_address.isPassword = false;
            this.textbox_address.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.textbox_address.LineIdleColor = System.Drawing.Color.LightGray;
            this.textbox_address.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.textbox_address.LineThickness = 2;
            this.textbox_address.Location = new System.Drawing.Point(204, 126);
            this.textbox_address.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_address.MaxLength = 32767;
            this.textbox_address.Name = "textbox_address";
            this.textbox_address.Size = new System.Drawing.Size(194, 31);
            this.textbox_address.TabIndex = 8;
            this.textbox_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textbox_phone
            // 
            this.textbox_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.textbox_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_phone.Font = new System.Drawing.Font("굴림체", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textbox_phone.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textbox_phone.Location = new System.Drawing.Point(203, 50);
            this.textbox_phone.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_phone.Mask = "000-9000-0000";
            this.textbox_phone.Name = "textbox_phone";
            this.textbox_phone.Size = new System.Drawing.Size(205, 31);
            this.textbox_phone.TabIndex = 6;
            // 
            // label_address
            // 
            this.label_address.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Bold);
            this.label_address.ForeColor = System.Drawing.Color.LightGray;
            this.label_address.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_address.Location = new System.Drawing.Point(58, 135);
            this.label_address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(83, 24);
            this.label_address.TabIndex = 16;
            this.label_address.Text = "ADDRESS";
            this.label_address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textbox_email
            // 
            this.textbox_email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textbox_email.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textbox_email.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textbox_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_email.Font = new System.Drawing.Font("Candara", 12F);
            this.textbox_email.ForeColor = System.Drawing.Color.LightGray;
            this.textbox_email.HintForeColor = System.Drawing.Color.Empty;
            this.textbox_email.HintText = "";
            this.textbox_email.isPassword = false;
            this.textbox_email.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.textbox_email.LineIdleColor = System.Drawing.Color.LightGray;
            this.textbox_email.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.textbox_email.LineThickness = 2;
            this.textbox_email.Location = new System.Drawing.Point(203, 88);
            this.textbox_email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_email.MaxLength = 32767;
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(194, 31);
            this.textbox_email.TabIndex = 7;
            this.textbox_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(16, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "* Contact Detail";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_email
            // 
            this.label_email.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Bold);
            this.label_email.ForeColor = System.Drawing.Color.LightGray;
            this.label_email.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_email.Location = new System.Drawing.Point(58, 96);
            this.label_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(62, 24);
            this.label_email.TabIndex = 14;
            this.label_email.Text = "EMAIL";
            this.label_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_phone
            // 
            this.label_phone.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Bold);
            this.label_phone.ForeColor = System.Drawing.Color.LightGray;
            this.label_phone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_phone.Location = new System.Drawing.Point(58, 57);
            this.label_phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(83, 24);
            this.label_phone.TabIndex = 11;
            this.label_phone.Text = "PHONE";
            this.label_phone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_contact_detail
            // 
            this.panel_contact_detail.Controls.Add(this.label6);
            this.panel_contact_detail.Controls.Add(this.textbox_id);
            this.panel_contact_detail.Controls.Add(this.label_id);
            this.panel_contact_detail.Controls.Add(this.label_pw);
            this.panel_contact_detail.Controls.Add(this.textbox_certification);
            this.panel_contact_detail.Controls.Add(this.textbox_pw);
            this.panel_contact_detail.Controls.Add(this.label_RRN);
            this.panel_contact_detail.Controls.Add(this.label1);
            this.panel_contact_detail.Controls.Add(this.textbox_pw2);
            this.panel_contact_detail.Controls.Add(this.textbox_name);
            this.panel_contact_detail.Controls.Add(this.label_name);
            this.panel_contact_detail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_contact_detail.Location = new System.Drawing.Point(0, 73);
            this.panel_contact_detail.Margin = new System.Windows.Forms.Padding(2);
            this.panel_contact_detail.Name = "panel_contact_detail";
            this.panel_contact_detail.Size = new System.Drawing.Size(440, 250);
            this.panel_contact_detail.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(16, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "* Personal Detail";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textbox_id
            // 
            this.textbox_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textbox_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textbox_id.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textbox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_id.Font = new System.Drawing.Font("Candara", 12F);
            this.textbox_id.ForeColor = System.Drawing.Color.LightGray;
            this.textbox_id.HintForeColor = System.Drawing.Color.Empty;
            this.textbox_id.HintText = "";
            this.textbox_id.isPassword = false;
            this.textbox_id.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.textbox_id.LineIdleColor = System.Drawing.Color.LightGray;
            this.textbox_id.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.textbox_id.LineThickness = 2;
            this.textbox_id.Location = new System.Drawing.Point(203, 42);
            this.textbox_id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_id.MaxLength = 32767;
            this.textbox_id.Name = "textbox_id";
            this.textbox_id.Size = new System.Drawing.Size(194, 31);
            this.textbox_id.TabIndex = 1;
            this.textbox_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label_id
            // 
            this.label_id.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_id.ForeColor = System.Drawing.Color.LightGray;
            this.label_id.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_id.Location = new System.Drawing.Point(58, 49);
            this.label_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(29, 24);
            this.label_id.TabIndex = 1;
            this.label_id.Text = "ID";
            this.label_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_pw
            // 
            this.label_pw.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_pw.ForeColor = System.Drawing.Color.LightGray;
            this.label_pw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_pw.Location = new System.Drawing.Point(58, 88);
            this.label_pw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_pw.Name = "label_pw";
            this.label_pw.Size = new System.Drawing.Size(38, 24);
            this.label_pw.TabIndex = 3;
            this.label_pw.Text = "PW";
            this.label_pw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textbox_certification
            // 
            this.textbox_certification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.textbox_certification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_certification.Font = new System.Drawing.Font("굴림체", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textbox_certification.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textbox_certification.Location = new System.Drawing.Point(203, 202);
            this.textbox_certification.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_certification.Mask = "000000-0000000";
            this.textbox_certification.Name = "textbox_certification";
            this.textbox_certification.Size = new System.Drawing.Size(194, 31);
            this.textbox_certification.TabIndex = 5;
            this.textbox_certification.Click += new System.EventHandler(this.textbox_certification_Click);
            // 
            // textbox_pw
            // 
            this.textbox_pw.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textbox_pw.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textbox_pw.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textbox_pw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_pw.Font = new System.Drawing.Font("Candara", 12F);
            this.textbox_pw.ForeColor = System.Drawing.Color.LightGray;
            this.textbox_pw.HintForeColor = System.Drawing.Color.Empty;
            this.textbox_pw.HintText = "";
            this.textbox_pw.isPassword = true;
            this.textbox_pw.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.textbox_pw.LineIdleColor = System.Drawing.Color.LightGray;
            this.textbox_pw.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.textbox_pw.LineThickness = 2;
            this.textbox_pw.Location = new System.Drawing.Point(203, 82);
            this.textbox_pw.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_pw.MaxLength = 32767;
            this.textbox_pw.Name = "textbox_pw";
            this.textbox_pw.Size = new System.Drawing.Size(194, 31);
            this.textbox_pw.TabIndex = 2;
            this.textbox_pw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label_RRN
            // 
            this.label_RRN.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_RRN.ForeColor = System.Drawing.Color.LightGray;
            this.label_RRN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_RRN.Location = new System.Drawing.Point(62, 206);
            this.label_RRN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_RRN.Name = "label_RRN";
            this.label_RRN.Size = new System.Drawing.Size(43, 24);
            this.label_RRN.TabIndex = 6;
            this.label_RRN.Text = "SSN";
            this.label_RRN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(58, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "RE-PW";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textbox_pw2
            // 
            this.textbox_pw2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textbox_pw2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textbox_pw2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textbox_pw2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_pw2.Font = new System.Drawing.Font("Candara", 12F);
            this.textbox_pw2.ForeColor = System.Drawing.Color.LightGray;
            this.textbox_pw2.HintForeColor = System.Drawing.Color.Empty;
            this.textbox_pw2.HintText = "";
            this.textbox_pw2.isPassword = true;
            this.textbox_pw2.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.textbox_pw2.LineIdleColor = System.Drawing.Color.LightGray;
            this.textbox_pw2.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.textbox_pw2.LineThickness = 2;
            this.textbox_pw2.Location = new System.Drawing.Point(203, 122);
            this.textbox_pw2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_pw2.MaxLength = 32767;
            this.textbox_pw2.Name = "textbox_pw2";
            this.textbox_pw2.Size = new System.Drawing.Size(194, 31);
            this.textbox_pw2.TabIndex = 3;
            this.textbox_pw2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textbox_name
            // 
            this.textbox_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textbox_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textbox_name.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textbox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_name.Font = new System.Drawing.Font("Candara", 12F);
            this.textbox_name.ForeColor = System.Drawing.Color.LightGray;
            this.textbox_name.HintForeColor = System.Drawing.Color.Empty;
            this.textbox_name.HintText = "";
            this.textbox_name.isPassword = false;
            this.textbox_name.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.textbox_name.LineIdleColor = System.Drawing.Color.LightGray;
            this.textbox_name.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.textbox_name.LineThickness = 2;
            this.textbox_name.Location = new System.Drawing.Point(203, 162);
            this.textbox_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_name.MaxLength = 32767;
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(194, 31);
            this.textbox_name.TabIndex = 4;
            this.textbox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label_name
            // 
            this.label_name.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_name.ForeColor = System.Drawing.Color.LightGray;
            this.label_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_name.Location = new System.Drawing.Point(58, 166);
            this.label_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(61, 24);
            this.label_name.TabIndex = 9;
            this.label_name.Text = "NAME";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_explain
            // 
            this.panel_explain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(88)))));
            this.panel_explain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_explain.Controls.Add(this.label_explain);
            this.panel_explain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_explain.ForeColor = System.Drawing.SystemColors.Window;
            this.panel_explain.Location = new System.Drawing.Point(0, 0);
            this.panel_explain.Margin = new System.Windows.Forms.Padding(2);
            this.panel_explain.Name = "panel_explain";
            this.panel_explain.Size = new System.Drawing.Size(440, 73);
            this.panel_explain.TabIndex = 2;
            // 
            // label_explain
            // 
            this.label_explain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_explain.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_explain.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_explain.Image = global::Final_Project.Properties.Resources.profile_2x;
            this.label_explain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_explain.Location = new System.Drawing.Point(0, 0);
            this.label_explain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_explain.Name = "label_explain";
            this.label_explain.Padding = new System.Windows.Forms.Padding(130, 0, 0, 0);
            this.label_explain.Size = new System.Drawing.Size(440, 73);
            this.label_explain.TabIndex = 0;
            this.label_explain.Text = "      회원가입";
            this.label_explain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_logo
            // 
            this.label_logo.Enabled = false;
            this.label_logo.Font = new System.Drawing.Font("Lemon", 30F);
            this.label_logo.ForeColor = System.Drawing.Color.White;
            this.label_logo.Location = new System.Drawing.Point(48, 5);
            this.label_logo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(243, 45);
            this.label_logo.TabIndex = 6;
            this.label_logo.Text = "BookTree";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Connection = this.oracleConnection1;
            this.oracleCommand1.Transaction = null;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=ORARA;PASSWORD=5360413;PERSIST SECURITY INFO=True;USER ID=A5360413";
            this.oracleConnection1.Credential = null;
            // 
            // dataset11
            // 
            this.dataset11.DataSetName = "dataset1";
            this.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membeR_BOOKSTableAdapter1
            // 
            this.membeR_BOOKSTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Enabled = false;
            this.pictureBox_logo.Image = global::Final_Project.Properties.Resources.clipart1366865;
            this.pictureBox_logo.Location = new System.Drawing.Point(14, 10);
            this.pictureBox_logo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(30, 40);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 5;
            this.pictureBox_logo.TabStop = false;
            // 
            // pictureBox_exit
            // 
            this.pictureBox_exit.Image = global::Final_Project.Properties.Resources.X_simple_1;
            this.pictureBox_exit.Location = new System.Drawing.Point(412, 10);
            this.pictureBox_exit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox_exit.Name = "pictureBox_exit";
            this.pictureBox_exit.Size = new System.Drawing.Size(18, 10);
            this.pictureBox_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_exit.TabIndex = 2;
            this.pictureBox_exit.TabStop = false;
            this.pictureBox_exit.Click += new System.EventHandler(this.pictureBox_exit_Click);
            // 
            // pictureBox_minimum
            // 
            this.pictureBox_minimum.Image = global::Final_Project.Properties.Resources.mini_minus;
            this.pictureBox_minimum.Location = new System.Drawing.Point(398, 10);
            this.pictureBox_minimum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox_minimum.Name = "pictureBox_minimum";
            this.pictureBox_minimum.Size = new System.Drawing.Size(9, 10);
            this.pictureBox_minimum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_minimum.TabIndex = 1;
            this.pictureBox_minimum.TabStop = false;
            this.pictureBox_minimum.Click += new System.EventHandler(this.pictureBox_minimum_Click);
            // 
            // join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(86)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(440, 654);
            this.Controls.Add(this.label_logo);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.pictureBox_exit);
            this.Controls.Add(this.pictureBox_minimum);
            this.Controls.Add(this.panel_body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "join";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "join";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.join_FormClosed);
            this.Load += new System.EventHandler(this.join_Load);
            this.panel_body.ResumeLayout(false);
            this.panel_personal_detail.ResumeLayout(false);
            this.panel_personal_detail.PerformLayout();
            this.panel_contact_detail.ResumeLayout(false);
            this.panel_contact_detail.PerformLayout();
            this.panel_explain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_minimum;
        private System.Windows.Forms.PictureBox pictureBox_exit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Panel panel_personal_detail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textbox_address;
        private System.Windows.Forms.MaskedTextBox textbox_phone;
        private System.Windows.Forms.Label label_address;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textbox_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Panel panel_contact_detail;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textbox_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_pw;
        private System.Windows.Forms.MaskedTextBox textbox_certification;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textbox_pw;
        private System.Windows.Forms.Label label_RRN;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textbox_pw2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textbox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Panel panel_explain;
        private Bunifu.Framework.UI.BunifuCustomLabel label_logo;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label_divider;
        private Bunifu.Framework.UI.BunifuCustomLabel label_explain;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private Oracle.ManagedDataAccess.Client.OracleConnection oracleConnection1;
        private dataset1 dataset11;
        private dataset1TableAdapters.MEMBER_BOOKSTableAdapter membeR_BOOKSTableAdapter1;
        private Bunifu.Framework.UI.BunifuFlatButton button_join;
        private System.Windows.Forms.CheckBox checkBox_agree;
    }
}

