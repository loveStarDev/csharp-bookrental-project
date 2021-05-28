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
    public partial class reservation : Form
    {

        //전역변수
        private bool dragging = false;
        private Point offset;
        private DataTable reservation_table;
        private DataTable own_books_table;
        private Final_Project.main.logined_info cur_logined;








        //기본설정
        public reservation()
        {
            InitializeComponent();
            cur_logined.id = "master";
        }

        public reservation(Final_Project.main.logined_info cur_logined)
        {
            InitializeComponent();
            this.cur_logined = cur_logined;

        }

        private void reservation_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataset1.VIEW_WILL_RESERVATION' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.vIEW_WILL_RESERVATIONTableAdapter.Fill(this.dataset1.VIEW_WILL_RESERVATION);
            this.owN_BOOKSTableAdapter1.Fill(this.dataset1.OWN_BOOKS);
            reservatioN_BOOKSTableAdapter1.Fill(dataset1.RESERVATION_BOOKS);

            own_books_table = dataset1.Tables["OWN_BOOKS"];
            reservation_table = dataset1.Tables["RESERVATION_BOOKS"];
            //vIEWWILLRESERVATIONBindingSource.Filter = "O_STATE = '대출중' OR O_STATE = '도서관'"; // 예약중인 상품은 보이지 않음.
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
            if (MessageBox.Show("예약 창을 종료 하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void pictureBox_minimum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


















        // 사용자 정의함수
        /*--------------------------- DataGridView 포멧변경 -------------------------*/
        private void dbView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                if (e.ColumnIndex == 7)
                {
                    if (e.Value != null)
                    {

                        string text = e.Value.ToString();
                        switch (text)
                        {
                            case "예약중":
                                e.Value = "예약불가능";
                                break;
                            case "대여중":
                                foreach (DataRow row0 in reservation_table.Rows)
                                {
                                    //MessageBox.Show(row0["O_ID"].ToString() + row0["I_ID"].ToString());
                                    if (row0["I_ID"].ToString() == dataGridView_reservation.CurrentRow.Cells[0].Value.ToString() && row0["O_ID"].ToString() == dataGridView_reservation.CurrentRow.Cells[1].Value.ToString())
                                    {
                                        e.Value = "예약불가능";
                                        break;
                                    }
                                }
                                break;
                        }
                    }
                }
            }
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
        /*------------------------------- 검색 ------------------------------------*/
        private void button_reservation_searching_Click(object sender, EventArgs e)
        {
            if (vIEWWILLRESERVATIONBindingSource.Filter != null)
            {
                vIEWWILLRESERVATIONBindingSource.RemoveFilter();
                button_reservation_searching.ButtonText = "검색";
            }
            else
            {
                try
                {
                    switch (comboBox_reservation_searching.Text)
                    {
                        case "저자":
                            vIEWWILLRESERVATIONBindingSource.Filter = "I_AUTHOR LIKE '%" + textBox_reservation_searching.Text + "%'";
                            break;
                        case "출판사":
                            vIEWWILLRESERVATIONBindingSource.Filter = "I_PUBLISHER  LIKE '%" + textBox_reservation_searching.Text + "%'";
                            break;
                        case "장르":
                            vIEWWILLRESERVATIONBindingSource.Filter = "I_GENRE LIKE '%" + textBox_reservation_searching.Text + "%'";
                            break;
                        case "도서명":
                            vIEWWILLRESERVATIONBindingSource.Filter = "I_NAME LIKE '%" + textBox_reservation_searching.Text + "%'";
                            break;
                        case "도서관리등급":
                            vIEWWILLRESERVATIONBindingSource.Filter = "O_GRADE LIKE '%" + textBox_reservation_searching.Text + "%'";
                            break;
                        default:
                            MessageBox.Show("??");
                            break;
                    }
                    button_reservation_searching.ButtonText = "검색해제";
                }
                catch
                {
                    MessageBox.Show("바른값을 입력하시오.");
                    button_reservation_searching.ButtonText = "검색";
                }
            }
        }





















        // 이벤트
        /*------------------------------- Reservation_booking ------------------------------------*/
        private void dataGridView_reservation_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_reservation.CurrentRow == null)
                {
                    textbox_explain.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n 현재 모든 도서가 대출가능 또는 예약된 상태로 더 이상 예약이 불가능 하거나 검색 결과가 없습니다. \r\n죄송합니다. 다음에 이용해 주세요.";
                    textbox_explain.FillColor = Color.DarkRed;
                    textbox_explain.ForeColor = Color.White;
                }
                else
                {
                    textbox_explain.Text
                    = "\r\n\r\n\r\n[도서정보]\r\n"
                    + "\a    도서넘버 : BN" + dataGridView_reservation.CurrentRow.Cells[0].Value.ToString() + "-ON" + dataGridView_reservation.CurrentRow.Cells[1].Value.ToString() + "\r\n"
                    + "\a    도서명 : " + dataGridView_reservation.CurrentRow.Cells[2].Value.ToString() + "\r\n"
                    + "\a    저자 : " + dataGridView_reservation.CurrentRow.Cells[3].Value.ToString() + "\r\n"
                    + "\a    출판사 : " + dataGridView_reservation.CurrentRow.Cells[4].Value.ToString() + "\r\n"
                    + "\a    도서관리등급 : " + dataGridView_reservation.CurrentRow.Cells[5].Value.ToString() + "\r\n"
                    + "\a    장르 : " + dataGridView_reservation.CurrentRow.Cells[6].Value.ToString() + "\r\n"
                    + "\a    대여가격 : " + dataGridView_reservation.CurrentRow.Cells[10].Value.ToString() + "\r\n"
                    + "\a    대여기간 : " + dataGridView_reservation.CurrentRow.Cells[11].Value.ToString() + "일\r\n"
                    + "\a    반납위약금 : " + dataGridView_reservation.CurrentRow.Cells[12].Value.ToString() + "원\r\n"
                    + "------------------------------------\r\n  [위의 조건을 확인하고] 예약버튼을 눌러주세요.\r\n\r\n"
                    + "*주의) 대출가능 상태가 되면 예약중으로 변경되며 이메일이 전달됩니다. 이메일 확인 후 일주일 이내로 대출 또는 예약취소를 하지 않으면 자동으로 예약취소가 되며"
                    + "  회원등급에 불이익이 있을 수 있습니다.";
                    foreach(DataRow row0 in reservation_table.Rows)
                        if (row0["I_ID"].ToString() == dataGridView_reservation.CurrentRow.Cells[0].Value.ToString() && row0["O_ID"].ToString() == dataGridView_reservation.CurrentRow.Cells[1].Value.ToString())
                        {
                            textbox_explain.FillColor = Color.DarkRed;
                            textbox_explain.ForeColor = Color.White;
                            break;
                        }
                    else
                        {
                            textbox_explain.FillColor = Color.WhiteSmoke;
                            textbox_explain.ForeColor = Color.Black;
                        }
                }
            }
            catch (System.Exception)
            {

            }
        }

        private void button_reservation_acceess_Click(object sender, EventArgs e)
        {
            foreach (DataRow row0 in reservation_table.Rows)
            {
                //MessageBox.Show(row0["O_ID"].ToString() + row0["I_ID"].ToString());
                if (row0["I_ID"].ToString() == dataGridView_reservation.CurrentRow.Cells[0].Value.ToString() && row0["O_ID"].ToString() == dataGridView_reservation.CurrentRow.Cells[1].Value.ToString())
                {
                    MessageBox.Show("예약 불가능한 상품을 선택하셨습니다.");
                    return;
                }
            }

            try
            {
                if (MessageBox.Show("예약하시겠습니까?", "예약", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //MessageBox.Show(dataGridView_reservation.CurrentRow.Cells[7].Value.ToString());
                    switch (dataGridView_reservation.CurrentRow.Cells[7].Value.ToString())
                    {
                        //대출중인 상품 -> 예약테이블에 삽입 -> 반납시에 예약테이블 보고 예약중으로 변경
                        case "대여중":
                            DataRow new_row = reservation_table.NewRow(); // 예약테이블
                            new_row["I_ID"] = dataGridView_reservation.CurrentRow.Cells[0].Value;
                            new_row["O_ID"] = dataGridView_reservation.CurrentRow.Cells[1].Value;
                            new_row["M_ID"] = cur_logined.id;
                            new_row["R_DATE"] = DateTime.Now;
                            reservation_table.Rows.Add(new_row);

                            int res = reservatioN_BOOKSTableAdapter1.Update(dataset1.RESERVATION_BOOKS);
                            if (res > 0)
                            {
                                MessageBox.Show("예약신청이 완료 되었습니다.\r\n대여가능상태가 되면 이메일로 연락드리겠습니다. 감사합니다.");
                            }
                            else
                            {
                                MessageBox.Show("알수없는 이유로 예약에 실패 했습니다.");
                            }
                            break;

                        //예약은 한권에 하나만 할당받도록 설정
                        case "예약중":
                            MessageBox.Show("예약이 불가능한 상품입니다.\r\n예약중인 상품은 더 이상 예약할 수 없습니다.");
                            break;

                        //대여가능 상품은 보여주되 대여하도록 장려
                        case "도서관":
                            if (MessageBox.Show("현재 상품은 바로 대여가 가능합니다. \r\n예약하신다면 7일 이전에 대출을 받으러 오셔야합니다.\r\n그래도 예약 하시겠습니까?", "예약", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                            {
                                DataRow new_row2 = reservation_table.NewRow(); // 예약테이블
                                new_row2["I_ID"] = dataGridView_reservation.CurrentRow.Cells[0].Value;
                                new_row2["O_ID"] = dataGridView_reservation.CurrentRow.Cells[1].Value;
                                new_row2["M_ID"] = cur_logined.id;
                                new_row2["R_DATE"] = DateTime.Now;
                                reservation_table.Rows.Add(new_row2);

                                foreach (DataRow row in own_books_table.Rows)
                                {
                                    if (row["I_ID"].ToString() == dataGridView_reservation.CurrentRow.Cells[0].Value.ToString() && row["O_ID"].ToString() == dataGridView_reservation.CurrentRow.Cells[1].Value.ToString())
                                    {
                                        row["O_STATE"] = "예약중";
                                    }
                                }

                                int res2 = owN_BOOKSTableAdapter1.Update(dataset1.OWN_BOOKS) * reservatioN_BOOKSTableAdapter1.Update(dataset1.RESERVATION_BOOKS);
                                if (res2 > 0)
                                {
                                    MessageBox.Show("예약이 완료 되었습니다.\r\n" + DateTime.Today.AddDays(7) + "일 이전에 대출을 받아주세요.");
                                }
                                else
                                {
                                    MessageBox.Show("알수없는 이유로 예약에 실패 했습니다.");
                                }
                            }
                            break;
                    }
                    reservation_table = dataset1.Tables["RESERVATION_BOOKS"];

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("알수없는 이유로 예약에 실패 했습니다." + ex);
            }

        }
    }
}
