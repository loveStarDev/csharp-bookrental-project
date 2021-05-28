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
    public partial class main : Form
    {

        // 더블 버퍼링 패널
        public class DoubleBufferPanel : Panel
        {
            public DoubleBufferPanel()
            {
                this.SetStyle(ControlStyles.DoubleBuffer, true);
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                this.SetStyle(ControlStyles.UserPaint, true);
                this.UpdateStyles();
            }
        }

        // 더블 버퍼링 Gridview
        public class DoubleBufferDGV : DataGridView
        {
            public DoubleBufferDGV()
            {
                this.SetStyle(ControlStyles.DoubleBuffer, true);
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                this.SetStyle(ControlStyles.UserPaint, true);
                this.UpdateStyles();
            }
        }

        // 구조체
        public struct logined_info
        {
            public string id;
            public string pw;
            public bool logined;
            public int grade;
        }







        // 전역변수
        DataTable member_table;
        DataTable rental_books;
        DataTable reservation_books;
        DataTable view_rental_books;
        public logined_info cur_logined = new logined_info();
        private bool dragging = false;
        private Point offset;
        Stack<Form> every_form = new Stack<Form>();






        // 기본
        public main()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            cur_logined.grade = -2;
            cur_logined.id = "GUEST";
            cur_logined.pw = "";
            cur_logined.logined = false;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            FormEffect(this);
        }

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료 하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void pictureBox_minimum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void main_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataset11.VIEW_WILL_RESERVATION' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.vIEW_WILL_RESERVATIONTableAdapter.Fill(this.dataset11.VIEW_WILL_RESERVATION);
            membeR_BOOKSTableAdapter1.Fill(dataset11.MEMBER_BOOKS);
            rentaL_BOOKSTableAdapter1.Fill(dataset11.RENTAL_BOOKS);
            vieW_RENTALTableAdapter1.FillByis_return(dataset11.VIEW_RENTAL);

            member_table = dataset11.Tables["MEMBER_BOOKS"];
            rental_books = dataset11.Tables["RENTAL_BOOKS"];
            reservation_books = dataset11.Tables["RESERVATION_BOOKS"];
            view_rental_books = dataset11.Tables["VIEW_RENTAL"];
            //update_all();
        }







        // 정의함수
       
        private bool update_all() // 실행시키면 필요한 정보를 갱신시킴
        {
            foreach (DataRow row in view_rental_books.Rows)
            {
                string m_id = row["M_ID"].ToString(); // 회원아이디
                string r_date = row["R_DATE"].ToString(); // 대여일
                string r_deadline = row["R_DEADLINE"].ToString(); //반납기일
                string i_panelty_cost = row["I_PANELTY_COST"].ToString(); // 하루당 연체료
                string i_id = row["I_ID"].ToString(); // 책등록번호
                string o_id = row["O_ID"].ToString(); // 도서번호

                try
                {
                    if (DateTime.Now > Convert.ToDateTime(r_deadline))
                    {
                        foreach (DataRow row2 in rental_books.Rows)
                        {
                            if (row2["I_ID"].ToString() == i_id && row2["o_id"].ToString() == o_id && row2["M_ID"].ToString() == m_id && row2["R_DATE"].ToString() == r_date)
                            {

                            }
                        }
                        int ret = rentaL_BOOKSTableAdapter1.Update(dataset11.RENTAL_BOOKS);
                        if (ret > 0)
                            MessageBox.Show("INITIALIZING.. SUCESS!");
                        else
                            MessageBox.Show("INITIALIZING.. FAILED!");
                    }
                }
                catch (System.Exception ea)
                {
                    MessageBox.Show(r_deadline);
                    MessageBox.Show("갱신실패" + ea, "UPDATE_ALL");
                }

            }

            return true;
        }

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
                0.91d, 0.92d, 0.93d, 0.94d, 0.95d, 0.96d, 0.97d, 0.98d, 0.99d,1d
            };
            int cnt = 0;
            System.Windows.Forms.Timer tm = new System.Windows.Forms.Timer();
            {
                fm.RightToLeftLayout = false;
                fm.Opacity = 0d;
                tm.Interval = 1;   // 나타나는 속도를 조정함.          
                tm.Tick += delegate (object obj, EventArgs e)
                {
                    if ((cnt + 1 > opacity.Length) || fm == null)
                    {
                        tm.Stop();
                        tm.Dispose();
                        tm = null;
                        return;
                    }
                    else
                    {
                        fm.Opacity = opacity[cnt++];
                    }
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


        /*--------------------------- 마우스로 폼 이동-------------------------------*/
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

        /*------------------------------- 모든폼종료 ------------------------------------*/
        private void all_form_closing()
        {
            int i = every_form.Count;
            for(int j = 0; j < i; j++)
            {
                (every_form.Pop()).Dispose();
            }
        }

        /*------------------------------- 모든패널끄기 ------------------------------------*/
        private void shut_down_panels()
        {
            panel_login.Visible = false;
        }












        //이벤트 처리하는 부분
        /*------------------------------- 회원가입 Event ------------------------------------*/
        private void button_join_Click(object sender, EventArgs e)
        {
            if (!form_check("join"))
            {
                join form_join = new join();
                every_form.Push(form_join);
                form_join.Show();
            }

            shut_down_panels();
        }



        /*------------------------------- 로그인 Event ------------------------------------*/
        private void button_login_Click(object sender, EventArgs e)
        {
            shut_down_panels();
            textbox_login_id.Text = "";
            textbox_login_pw.Text = "";
            panel_login.Location = new Point(392, 61);
            panel_login.Visible = true;
        }

        private void panel_login_Paint(object sender, PaintEventArgs e)
        {
            Graphics v = e.Graphics;
            Pen pen = new Pen(Color.Snow);
            pen.Width = 10;
            DrawRoundRect(v, pen, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 10);
            base.OnPaint(e);
        }

        private void button_Access_Click(object sender, EventArgs e)
        {
            bool id = false;
            bool pw = false;
            membeR_BOOKSTableAdapter1.Fill(dataset11.MEMBER_BOOKS);

            foreach (DataRow row in member_table.Rows)
            {
                if (textbox_login_id.Text == row["M_ID"].ToString())
                {
                    /*if (Convert.ToInt32(row["M_GRADE"]) < 0) // 블랙리스트 로그인 가능
                    {
                        MessageBox.Show("회원님의 접속이 승락되지 않았습니다. 자세한 사항은 관리자에게 문의 부탁드립니다.");
                        return;
                    }*/
                    id = true;

                    if (textbox_login_pw.Text == row["M_PASSWORD"].ToString())
                    {
                        pw = true;
                        cur_logined.id = textbox_login_id.Text;
                        cur_logined.pw = textbox_login_pw.Text;
                        cur_logined.grade = Convert.ToInt32(row["M_GRADE"]);
                        cur_logined.logined = true;
                    }
                }
                else continue;
            }

            if (!id)
            {
                MessageBox.Show("일치하는 아이디가 없습니다.");
                return;
            }

            if (!pw)
            {
                MessageBox.Show("비밀번호가 틀렸습니다.");
                return;
            }

            panel_login.Visible = false;
            panel_logined.Visible = true;
            panel_side_unlogin.Visible = false;
            label_hello.Text = "[ " + cur_logined.id + " ]님, 환영합니다!";
            if (cur_logined.grade > 0) panel_manager.Visible = true;
            all_form_closing();
            shut_down_panels();
        }

        private void pictureBox_exit2_Click(object sender, EventArgs e)
        {
            textbox_login_id.Text = "";
            textbox_login_pw.Text = "";
            panel_login.Visible = false;
        }

        private void panel_login_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = new Point(e.X, e.Y);
            panel_login.Refresh();
        }

        private void panel_login_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Panel selPanel = (Panel)sender;
                selPanel.Left = e.X + selPanel.Left - offset.X;
                selPanel.Top = e.Y + selPanel.Top - offset.Y;
            }
            //Rectangle toInvalidate = new Rectangle(e.X - 50, e.Y - 50, 50, 50);
            //panel_login.Invalidate(toInvalidate);
            panel_login.Refresh();
        }

        private void panel_login_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            panel_login.Refresh();
        }



        /*------------------------------- 로그아웃 Panel ------------------------------------*/
        public void button_logout_Click(object sender, EventArgs e)
        {
            cur_logined.logined = false;
            panel_logined.Visible = false;
            panel_side_unlogin.Visible = true;
            panel_manager.Visible = false;
            cur_logined.id = "";
            cur_logined.pw = "";
            cur_logined.grade = -2;
            all_form_closing();
            shut_down_panels();
        }





        /*------------------------------- 관리자 Panel Buttons! ------------------------------------*/
        private bool check_grade(int grade)
        {
            if (grade >= -2 && grade <= 2)
            {
                if (grade <= cur_logined.grade)
                    return true;

                string msg = "";
                switch (grade)
                {
                    case 0:
                        msg += "[회원]";
                        break;
                    case 1:
                        msg += "[매니저]";
                        break;
                    case 2:
                        msg += "[관리자]";
                        break;
                    case -1:
                        msg += "[GUEST]";
                        break;
                }

                msg += " 이상의 권한이 필요합니다.\n현재 " + cur_logined.id + "님의 등급은 ";
                switch (cur_logined.grade)
                {
                    case -2:
                        msg += "[비회원] 입니다.";
                        break;
                    case -1:
                        MessageBox.Show("죄송합니다. 관리자에게 문의해주세요.");
                        return false;
                    case 0:
                        msg += "[회원] 입니다.";
                        break;
                    case 1:
                        msg += "[매니저] 입니다.";
                        break;
                    case 2:
                        msg += "[관리자] 입니다.";
                        break;
                    default:
                        return false;
                }

                MessageBox.Show(msg);
                return false;
            }
            else
            {
                MessageBox.Show("프로그래밍에 잘못된 값을 입력하였습니다.");
                return false;
            }
        }

        private void button_enroll_Click(object sender, EventArgs e)
        {
            shut_down_panels();
            if (!check_grade(2))
                return;

            if (!form_check("enroll"))
            {
                enroll form_enroll = new enroll();
                every_form.Push(form_enroll);
                form_enroll.Show();
            }
        }

        private void button_member_Click(object sender, EventArgs e)
        {
            shut_down_panels();
            if (!check_grade(2))
                return;

            if (!form_check("member"))
            {
                member form_member = new member();
                every_form.Push(form_member);
                form_member.Show();
            }
        }

        private void button_statistics_Click(object sender, EventArgs e)
        {
            shut_down_panels();
            if (!check_grade(2))
                return;

            if (!form_check("statistics"))
            {
                statistics form_statistics = new statistics();
                every_form.Push(form_statistics);
                form_statistics.Show();
            }
        }

        private void button_rent_Click(object sender, EventArgs e)
        {
            shut_down_panels();
            if (!check_grade(1))
                return;

            if (!form_check("rental"))
            {
                rental form_rental = new rental(cur_logined);
                every_form.Push(form_rental);
                form_rental.Show();
            }
        }









        /*------------------------------- SIDE_BUTTON_CLICK ------------------------------------*/
        private void button_seraching_Click(object sender, EventArgs e)
        {
            shut_down_panels();
            if (!check_grade(-2))
                return;

            if (!form_check("searching"))
            {
                searching form_searching = new searching();
                every_form.Push(form_searching);
                form_searching.Show();
            }
        }

        private void button_reservation_Click(object sender, EventArgs e)
        {
            shut_down_panels();
            if (!check_grade(0))
                return;

            if (!form_check("reservation"))
            {
                reservation form_reservation = new reservation(cur_logined);
                every_form.Push(form_reservation);
                form_reservation.Show();
            }
        }

        private void button_history_Click(object sender, EventArgs e)
        {
            shut_down_panels();
            if (!check_grade(0))
                return;

            if (!form_check("history"))
            {
                history form_history = new history(cur_logined);
                every_form.Push(form_history);
                form_history.Show();
            }
        }

        private void button_review_Click(object sender, EventArgs e)
        {
            shut_down_panels();
            if (!check_grade(1))
                return;

            if (!form_check("review"))
            {
                review form_review = new review(cur_logined);
                every_form.Push(form_review);
                form_review.Show();
            }
        }

        private void button_popular_Click(object sender, EventArgs e)
        {
            shut_down_panels();
            if (!check_grade(-2))
                return;

            if (!form_check("ranking"))
            {
                ranking form_ranking = new ranking();
                every_form.Push(form_ranking);
                form_ranking.Show();
            }
        }

        private void button_profile_Click(object sender, EventArgs e)
        {
            shut_down_panels();
            if (!check_grade(-1))
                return;

            if (!form_check("profile"))
            {
                profile form_profile = new profile(this);
                every_form.Push(form_profile);
                form_profile.Show();
            }
        }
    }
}
