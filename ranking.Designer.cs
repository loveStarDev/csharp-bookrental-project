namespace Final_Project
{
    partial class ranking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ranking));
            this.label_logo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox_exit = new System.Windows.Forms.PictureBox();
            this.pictureBox_minimum = new System.Windows.Forms.PictureBox();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox_ranking = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.oracleConnection1 = new Oracle.ManagedDataAccess.Client.OracleConnection();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimum)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.label_logo.TabIndex = 8;
            this.label_logo.Text = "BookTree";
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
            this.pictureBox_logo.TabIndex = 7;
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
            this.pictureBox_exit.TabIndex = 10;
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
            this.pictureBox_minimum.TabIndex = 9;
            this.pictureBox_minimum.TabStop = false;
            this.pictureBox_minimum.Click += new System.EventHandler(this.pictureBox_minimum_Click);
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 18;
            this.bunifuElipse.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.listBox_ranking);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 561);
            this.panel1.TabIndex = 11;
            // 
            // listBox_ranking
            // 
            this.listBox_ranking.BackColor = System.Drawing.Color.White;
            this.listBox_ranking.FormattingEnabled = true;
            this.listBox_ranking.ItemHeight = 12;
            this.listBox_ranking.Location = new System.Drawing.Point(13, 68);
            this.listBox_ranking.Name = "listBox_ranking";
            this.listBox_ranking.Size = new System.Drawing.Size(414, 472);
            this.listBox_ranking.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(145, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "도서인기순위";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Connection = this.oracleConnection1;
            this.oracleCommand1.Transaction = null;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = global::Final_Project.Properties.Settings.Default.NewJueun;
            this.oracleConnection1.Credential = null;
            // 
            // ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(86)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(440, 654);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_exit);
            this.Controls.Add(this.pictureBox_minimum);
            this.Controls.Add(this.label_logo);
            this.Controls.Add(this.pictureBox_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ranking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ranking";
            this.Load += new System.EventHandler(this.ranking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimum)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel label_logo;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.PictureBox pictureBox_exit;
        private System.Windows.Forms.PictureBox pictureBox_minimum;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_ranking;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private Oracle.ManagedDataAccess.Client.OracleConnection oracleConnection1;
    }
}