using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class review : Form
    {



        //전역변수
        private bool dragging = false;
        private Point offset;
        private DataTable review_table;
        private Final_Project.main.logined_info cur_logined;















        // 기본
        public review()
        {
            InitializeComponent();
            cur_logined.id = "guest";
        }

        public review(main.logined_info cur_logined)
        {
            InitializeComponent();
            this.cur_logined = cur_logined;
            label_user.Text = "작성자 : " + cur_logined.id;
        }

        private void review_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataset1.REVIEW_BOOKS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.rEVIEW_BOOKSTableAdapter.Fill(this.dataset1.REVIEW_BOOKS);
            // TODO: 이 코드는 데이터를 'dataset1.INFO_BOOKS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.iNFO_BOOKSTableAdapter.Fill(this.dataset1.INFO_BOOKS);
            review_table = dataset1.Tables["REVIEW_BOOKS"];

            rEVIEWBOOKSFK1BindingSource1.Sort = "R_ID ASC";

        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.UpdateStyles();
            FormEffect(this);
        }

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
             this.Dispose();
        }

        private void pictureBox_minimum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


















        // 사용자 정의함수
        private bool form_check(string name)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == name)
                {
                    form.Focus();
                    return true;
                }
            }
            return false;
        }

        public void FormEffect(Form fm)
        {
            double[] opacity = new double[] {
                0.01d, 0.02d, 0.03d, 0.04d, 0.05d, 0.06d, 0.07d, 0.08d, 0.09d,
                0.11d, 0.12d, 0.13d, 0.14d, 0.15d, 0.16d, 0.17d, 0.18d, 0.19d,
                0.21d, 0.22d, 0.23d, 0.24d, 0.25d, 0.26d, 0.27d, 0.28d, 0.29d,
                0.31d, 0.32d, 0.33d, 0.34d, 0.35d, 0.36d, 0.37d, 0.38d, 0.39d,
                0.41d, 0.42d, 0.43d, 0.44d, 0.45d, 0.46d, 0.47d, 0.48d, 0.49d,
                0.51d, 0.52d, 0.53d, 0.54d, 0.55d, 0.56d, 0.57d, 0.58d, 0.59d,
                0.61d, 0.62d, 0.63d, 0.64d, 0.65d, 0.66d, 0.67d, 0.68d, 0.69d,
                0.71d, 0.72d, 0.73d, 0.74d, 0.75d, 0.76d, 0.77d, 0.78d, 0.79d,
                0.81d, 0.82d, 0.83d, 0.84d, 0.85d, 0.86d, 0.87d, 0.88d, 0.89d,
                0.91d, 0.92d, 0.93d, 0.94d, 0.95d, 0.96d, 0.97d, 0.98d, 0.99d, 1.0d
            };
            int cnt = 0;
            System.Windows.Forms.Timer tm = new System.Windows.Forms.Timer();
            {
                fm.RightToLeftLayout = false;
                fm.Opacity = 0d;
                tm.Interval = 1;   // 나타나는 속도를 조절함.          
                tm.Tick += delegate (object obj, EventArgs e)
                {
                    if ((cnt + 1 > opacity.Length) || fm == null)
                    {
                        tm.Stop();
                        tm.Dispose();
                        tm = null;
                        return;
                    }
                    else fm.Opacity = opacity[cnt++];
                };
                tm.Start();
            }
        }

        public void DrawRoundRect(Graphics g, Pen p, float X, float Y, float width, float height, float radius)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(X + radius, Y, X + width - (radius * 2), Y);
            gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
            gp.AddLine(X + width, Y + radius, X + width, Y + height - (radius * 2));
            gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90);
            gp.AddLine(X + width - (radius * 2), Y + height, X + radius, Y + height);
            gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
            gp.AddLine(X, Y + height - (radius * 2), X, Y + radius);
            gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90);
            gp.CloseFigure();
            g.DrawPath(p, gp);
            gp.Dispose();
        }

        /*--------------------------- 마우스로 폼 이동 -------------------------------*/
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // 다른 컨트롤에 묶여있을 수 있을 수 있으므로 마우스캡쳐 해제
                ReleaseCapture();

                // 타이틀 바의 다운 이벤트처럼 보냄
                SendMessage(this.Handle, WM_NLBUTTONDOWN, HT_CAPTION, 0);
            }

            base.OnMouseDown(e);
        }

        /*--------------------------- 헤더 정렬 막기(미사용) -------------------------------*/
        private void SetDoNotSort(DataGridView dgv)
        {
            foreach (DataGridViewColumn i in dgv.Columns)
            {
                i.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        /*-------------------------- UPDATE 패널 마우스 이동 3개 ▼ ------------------------*/
        private void panel_update_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = new Point(e.X, e.Y);
        }

        private void panel_update_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Panel selPanel = (Panel)sender;
                selPanel.Left = e.X + selPanel.Left - offset.X;
                selPanel.Top = e.Y + selPanel.Top - offset.Y;
            }
        }

        private void panel_update_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }




















        // 이벤트
        private void button_search_Click(object sender, EventArgs e)
        {
            if (iNFOBOOKSBindingSource.Filter != null)
            {
                iNFOBOOKSBindingSource.RemoveFilter();
                button_search.ButtonText = "검색";
            }
            else
            {
                try
                {
                    switch (comboBox_search.Text)
                    {
                        case "저자":
                            iNFOBOOKSBindingSource.Filter = "I_AUTHOR LIKE '%" + textbox_search.Text + "%'";
                            break;
                        case "출판사":
                            iNFOBOOKSBindingSource.Filter = "I_PUBLISHER  LIKE '%" + textbox_search.Text + "%'";
                            break;
                        case "도서명":
                            iNFOBOOKSBindingSource.Filter = "I_NAME LIKE '%" + textbox_search.Text + "%'";
                            break;
                    }
                    button_search.ButtonText = "검색해제";
                }
                catch
                {
                    MessageBox.Show("바른값을 입력하시오.");
                    button_search.ButtonText = "검색";
                }
            }
        }


        string i_name = "";
        int i_id;
        private void datagridview_info_list_DoubleClick(object sender, EventArgs e)
        {
            i_name = datagridview_info_list.CurrentRow.Cells[1].Value.ToString();
            i_id = Convert.ToInt32(datagridview_info_list.CurrentRow.Cells[0].Value);
            label_selected_book.Text = "선택된 도서 : " + i_name;
            bunifuPages1.SelectedIndex = 1;
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 0;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 2;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 작성을 취소 하십니까?", "작성취소", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textbox_review_text.Clear();
                textbox_title_text.Clear();
                bunifuPages1.SelectedIndex = 1;
            }
        }

        private void datagridview_review_SelectionChanged(object sender, EventArgs e)
        {
            if (bunifuPages1.SelectedIndex == 1)
            {
                string m_id = datagridview_review.CurrentRow.Cells[1].Value.ToString();
                int i_id = Convert.ToInt32(datagridview_review.CurrentRow.Cells[0].Value);
                label_review_writer.Text = "작성자 : " + datagridview_review.CurrentRow.Cells[1].Value.ToString();
                textbox_title.Text = datagridview_review.CurrentRow.Cells[4].Value.ToString();
                textbox_review.Text = datagridview_review.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                textbox_review.Text = "";
                label_review_writer.Text = "작성자 : ";
                textbox_title.Text = "";
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (textbox_title_text.TextLength != 0 && textbox_title_text.TextLength != 0)
                    if (MessageBox.Show("게시글을 등록 하시겠습니까?", "후기작성", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataRow myNewrow = review_table.NewRow();
                        myNewrow["M_ID"] = cur_logined.id;
                        if (oracleConnection1.State.ToString() == "Closed")
                            oracleConnection1.Open();
                        oracleCommand1.CommandText = "SELECT seq_review.nextval FROM DUAL";
                        myNewrow["R_ID"] = Convert.ToInt32(oracleCommand1.ExecuteScalar());
                        myNewrow["R_TEXT"] = textbox_review_text.Text;
                        myNewrow["R_TITLE"] = textbox_title_text.Text;
                        myNewrow["R_STATE"] = 0;
                        myNewrow["I_ID"] = i_id;
                        review_table.Rows.Add(myNewrow);
                        int ret = this.rEVIEW_BOOKSTableAdapter.Update(this.dataset1.REVIEW_BOOKS);

                        if (ret > 0)
                        {
                            MessageBox.Show("게시글을 등록했습니다.", "등록", MessageBoxButtons.OK, MessageBoxIcon.None);
                            textbox_review_text.Clear();
                            textbox_title_text.Clear();
                            bunifuPages1.SelectedIndex = 1;
                        }

                        else
                            MessageBox.Show("저장 할 것이 없습니다.", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }
            catch (System.Exception  ex)
            {
                MessageBox.Show(" 알 수 없는 이유로 게시글 등록에 실패하였습니다. " + ex, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datagridview_review_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string m_id = datagridview_review.CurrentRow.Cells[1].Value.ToString();
            int i_id = Convert.ToInt32(datagridview_review.CurrentRow.Cells[0].Value);
            label_review_writer.Text = "작성자 : " + datagridview_review.CurrentRow.Cells[1].Value.ToString();
            textbox_title.Text = datagridview_review.CurrentRow.Cells[4].Value.ToString();
            textbox_review.Text = datagridview_review.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
