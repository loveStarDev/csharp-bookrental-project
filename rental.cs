using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading;

namespace Final_Project
{
    public partial class rental : Form
    {
        //전역변수
        private bool dragging = false;
        private Point offset;
        private DataTable rental_table;
        private DataTable member_table;
        private DataTable own_books;
        private DataTable info_books;
        private DataTable reservation_table;

        // 기본
        public rental()
        {
            InitializeComponent();
        }

        public rental(main.logined_info cur_logined)
        {
            InitializeComponent();
            this.cur_logined = cur_logined;
        }

        private void enroll_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataset1.MEMBER_BOOKS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.mEMBER_BOOKSTableAdapter.Fill(this.dataset1.MEMBER_BOOKS);
            // TODO: 이 코드는 데이터를 'dataset1.VIEW_CAN_RENTAL' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.vieW_CAN_RENTALTableAdapter1.Fill(this.dataset1.VIEW_CAN_RENTAL);
            // TODO: 이 코드는 데이터를 'dataset1.VIEW_PENALTY_COST' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.vIEW_PENALTY_COSTTableAdapter.Fill(this.dataset1.VIEW_PENALTY_COST);
            // TODO: 이 코드는 데이터를 'dataset1.VIEW_MANAGER_BOOKS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.vieW_MANAGER_BOOKSTableAdapter1.Fill(this.dataset1.VIEW_MANAGER_BOOKS);
            // TODO: 이 코드는 데이터를 'dataset1.VIEW_RENTAL' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.vIEW_RENTALTableAdapter.Fill(this.dataset1.VIEW_RENTAL);

            reservatioN_BOOKSTableAdapter1.Fill(dataset1.RESERVATION_BOOKS);
            rentaL_BOOKSTableAdapter1.Fill(dataset1.RENTAL_BOOKS);
            owN_BOOKSTableAdapter1.Fill(dataset1.OWN_BOOKS);
            infO_BOOKSTableAdapter1.Fill(dataset1.INFO_BOOKS);

            rental_table = dataset1.Tables["RENTAL_BOOKS"];
            member_table = dataset1.Tables["MEMBER_BOOKS"];
            info_books = dataset1.Tables["INFO_BOOKS"];
            own_books = dataset1.Tables["OWN_BOOKS"];
            reservation_table = dataset1.Tables["RESERVATION_BOOKS"];

            vIEWMANAGERBOOKSBindingSource1.Sort = "I_ID,O_ID ASC";
            oWNBOOKSBindingSource1.Sort = "I_ID, O_ID ASC";

            dataGridView_location.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView_location.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            FormEffect(this);
        }

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("매니저 창을 종료 하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void pictureBox_minimum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_update_exit_Click(object sender, EventArgs e) // 도서정보 패널창 X 클릭
        {
            panel_update.SendToBack();
            panel_update.Visible = false;
        }







        // 정의함수
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
                tm.Interval = 10;   // 나타나는 속도를 조정함.          
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
        private main.logined_info cur_logined;

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

        private void up_date_all()
        {
            owN_BOOKSTableAdapter1.Fill(dataset1.OWN_BOOKS);
            rentaL_BOOKSTableAdapter1.Fill(dataset1.RENTAL_BOOKS);
            mEMBER_BOOKSTableAdapter.Fill(dataset1.MEMBER_BOOKS);
            infO_BOOKSTableAdapter1.Fill(dataset1.INFO_BOOKS);
            vIEW_RENTALTableAdapter.Fill(dataset1.VIEW_RENTAL);
            vieW_CAN_RENTALTableAdapter1.Fill(dataset1.VIEW_CAN_RENTAL);
            vIEW_PENALTY_COSTTableAdapter.Fill(dataset1.VIEW_PENALTY_COST);
            vieW_MANAGER_BOOKSTableAdapter1.Fill(dataset1.VIEW_MANAGER_BOOKS);

            rental_table = dataset1.Tables["RENTAL_BOOKS"];
            member_table = dataset1.Tables["MEMBER_BOOKS"];
            info_books = dataset1.Tables["INFO_BOOKS"];
            own_books = dataset1.Tables["OWN_BOOKS"];
        }












        /*--------------------------- 도서위치정보_main 이벤트 -------------------------------*/

        private void button_update_Click(object sender, EventArgs e) // 도서정보변경 버튼 클릭
        {
            this.owN_BOOKSTableAdapter1.Fill(this.dataset1.OWN_BOOKS);
            panel_update.Visible = true;
            panel_update.Location = new Point(136, 23);
            panel_update.BringToFront();
            panel_update.Focus();
        }

        private void button_location_filter_Click(object sender, EventArgs e) // 현재 도서위치 확인 필터링
        {
            if (vIEWMANAGERBOOKSBindingSource1.Filter != null)
            {
                vIEWMANAGERBOOKSBindingSource1.RemoveFilter();
                button_location_filter.ButtonText = "필터";
            }
            else
            {
                try
                {
                    switch (comboBox_rent_filter.Text)
                    {
                        case "도서등록번호":
                            vIEWMANAGERBOOKSBindingSource1.Filter = "I_ID = '" + textBox_rent_filter.Text + "'";
                            break;
                        case "도서번호":
                            vIEWMANAGERBOOKSBindingSource1.Filter = "O_ID = '" + textBox_rent_filter.Text + "'";
                            break;
                        case "저자":
                            vIEWMANAGERBOOKSBindingSource1.Filter = "I_AUTHOR LIKE '%" + textBox_rent_filter.Text + "%'";
                            break;
                        case "출판사":
                            vIEWMANAGERBOOKSBindingSource1.Filter = "I_PUBLISHER  LIKE '%" + textBox_rent_filter.Text + "%'";
                            break;
                        case "장르":
                            vIEWMANAGERBOOKSBindingSource1.Filter = "I_GENRE LIKE '%" + textBox_rent_filter.Text + "%'";
                            break;
                        case "도서명":
                            vIEWMANAGERBOOKSBindingSource1.Filter = "I_NAME LIKE '%" + textBox_rent_filter.Text + "%'";
                            break;
                    }
                    button_location_filter.ButtonText = "필터해제";
                }
                catch
                {
                    MessageBox.Show("바른값을 입력하시오.");
                    button_location_filter.ButtonText = "필터";
                }
            }
        }











        /*--------------------------- 도서위치정보_panel 이벤트 -------------------------------*/
        private void button_access_filter_Click(object sender, EventArgs e)
        {
            if (oWNBOOKSBindingSource1.Filter != null)
            {
                oWNBOOKSBindingSource1.RemoveFilter();
                button_access_filter.ButtonText = "검색";
                textBox_access.ReadOnly = false;
            }
            else
            {
                try
                {
                    if (textBox_access.Text.Replace(" ", "") == "")
                        return;

                    switch (comboBox_access.Text.ToString())
                    {
                        case "도서등급":
                            oWNBOOKSBindingSource1.Filter = "O_GRADE LIKE '%" + textBox_access.Text + "%'";
                            break;
                        case "도서상태":
                            oWNBOOKSBindingSource1.Filter = "O_STATE LIKE '%" + textBox_access.Text + "%'";
                            break;
                        case "도서번호":
                            oWNBOOKSBindingSource1.Filter = "O_ID = '" + textBox_access.Text + "'";
                            break;
                        case "도서등록번호":
                            oWNBOOKSBindingSource1.Filter = "I_ID = '" + textBox_access.Text + "'";
                            break;
                        case "현재위치":
                            oWNBOOKSBindingSource1.Filter = "O_LOCATION LIKE '%" + textBox_access.Text + "%'";
                            break;
                        default:
                            MessageBox.Show("콤보박스를 선택해주세요.");
                            return;
                    }
                    button_access_filter.ButtonText = "검색해제";
                    textBox_access.ReadOnly = true;
                }
                catch
                {
                    MessageBox.Show("정확한 값을 입력하시오.");
                    button_access_filter.ButtonText = "검색";
                }
            }
        }

        private void button_update_access_Click(object sender, EventArgs e) // 도서정보 수정 버튼 클릭
        {
            try
            {
                if (MessageBox.Show("업데이트 하시겠습니까?", "도서정보갱신", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dataGridView_update.EndEdit();
                    oWNBOOKSBindingSource1.EndEdit();
                    int ret = this.owN_BOOKSTableAdapter1.Update(this.dataset1.OWN_BOOKS);
                    vieW_MANAGER_BOOKSTableAdapter1.Fill(dataset1.VIEW_MANAGER_BOOKS);
                    owN_BOOKSTableAdapter1.Fill(dataset1.OWN_BOOKS);
                    own_books = dataset1.Tables["OWN_BOOKS"];

                    if (ret > 0)
                        MessageBox.Show("업데이트 성공", "저장성공", MessageBoxButtons.OK, MessageBoxIcon.None);
                    else
                        MessageBox.Show("업데이트 할 것이 없습니다.", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("업데이트 실패", "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }












        /*--------------------------- 도서반납 이벤트 -------------------------------*/
        private void button_search_Click(object sender, EventArgs e)
        {
            if (vIEWRENTALBindingSource.Filter != null)
            {
                vIEWRENTALBindingSource.RemoveFilter();
                button_search.Text = "검색";
            }
            else
            {
                try
                {
                    if (textBox_search.Text.Replace(" ", "") == "")
                        return;

                    switch (comboBox_list.Text.ToString())
                    {
                        case "도서명":
                            vIEWRENTALBindingSource.Filter = "I_NAME LIKE '%" + textBox_search.Text + "%'";
                            break;
                        case "도서등록번호":
                            vIEWRENTALBindingSource.Filter = "I_ID = '" + textBox_search.Text + "'";
                            break;
                        case "회원명":
                            vIEWRENTALBindingSource.Filter = "M_NAME LIKE '%" + textBox_search.Text + "%'";
                            break;
                        case "회원아이디":
                            vIEWRENTALBindingSource.Filter = "M_ID LIKE '%" + textBox_search.Text + "%'";
                            break;
                        default:
                            return;
                    }
                    button_search.Text = "검색해제";
                }
                catch
                {
                    MessageBox.Show("바른값을 입력하시오.");
                    button_search.Text = "검색";
                }
            }
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_return.CurrentRow == null)
                {
                    return;
                }
                string m_id = dataGridView_return.CurrentRow.Cells[5].Value.ToString();
                string i_id = dataGridView_return.CurrentRow.Cells[2].Value.ToString();
                string o_id = dataGridView_return.CurrentRow.Cells[3].Value.ToString();
                string r_date = dataGridView_return.CurrentRow.Cells[7].Value.ToString();
                int r_deadline = ((Convert.ToDateTime(dataGridView_return.CurrentRow.Cells[8].Value)).Subtract(DateTime.Today)).Days - 1;
                int penalty_cost = Convert.ToInt32(dataGridView_return.CurrentRow.Cells[11].Value.ToString()) * r_deadline * -1;
                if (((Convert.ToDateTime(dataGridView_return.CurrentRow.Cells[8].Value)).Subtract(DateTime.Now)).Days < 0) {
                    if (MessageBox.Show("위약금이 있는 손님입니다. 위약금은 [" + penalty_cost + "]원 입니다.\n위약금을 지불하였습니까?", "반납", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        MessageBox.Show("취소되었습니다.");
                        return;
                    }
                }

                if (MessageBox.Show("반납 하시겠습니까?", "반납", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dataGridView_return.CurrentRow.Cells[0].Value.ToString().Equals("0"))
                    {
                        foreach (DataRow dataRow in rental_table.Rows)
                        {
                            if (dataRow["M_ID"].ToString() == m_id && dataRow["I_ID"].ToString() == i_id && dataRow["O_ID"].ToString() == o_id && dataRow["R_DATE"].ToString() == r_date)
                            {
                                dataRow["R_IS_RETURN"] = 1;
                                dataRow["R_RETURN_DATE"] = DateTime.Now;
                                break;
                            }
                        }

                        foreach (DataRow row in member_table.Rows)
                        {
                            if (row["M_ID"].ToString().Equals(m_id))
                            {
                                row["M_CUR_RENT_COUNT"] = Convert.ToInt32(row["M_CUR_RENT_COUNT"].ToString()) - 1;
                                break;
                            }
                        }

                        foreach (DataRow row in own_books.Rows)
                        {
                            if (row["O_ID"].ToString().Equals(o_id) && row["I_ID"].ToString().Equals(i_id))
                            {
                                row["O_STATE"] = "도서관";
                                break;
                            }
                        }

                        reservation_update();

                        if (rentaL_BOOKSTableAdapter1.Update(dataset1.RENTAL_BOOKS) > 0 && mEMBER_BOOKSTableAdapter.Update(dataset1.MEMBER_BOOKS) > 0 && owN_BOOKSTableAdapter1.Update(dataset1.OWN_BOOKS) > 0)
                        {
                            up_date_all();
                            MessageBox.Show("반납되었습니다.", "반납", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                        else
                            MessageBox.Show("반납 할 수 없습니다.", "반납", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("이미 반납된 도서입니다.", "반납", MessageBoxButtons.OK, MessageBoxIcon.None);
                        return;
                    }
                }
            }
            catch (System.Exception er)
            {
                MessageBox.Show("업데이트 실패" + er, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void reservation_update()
        {
            try
            {
                foreach (DataRow row1 in reservation_table.Rows)
                {
                    if (row1["I_ID"].ToString() == dataGridView_return.CurrentRow.Cells[2].Value.ToString() && row1["O_ID"].ToString() == dataGridView_return.CurrentRow.Cells[3].Value.ToString())
                    {
                        foreach (DataRow row2 in own_books.Rows)
                        {
                            if (row2["I_ID"].ToString() == dataGridView_return.CurrentRow.Cells[2].Value.ToString() && row2["O_ID"].ToString() == dataGridView_return.CurrentRow.Cells[3].Value.ToString())
                            {
                                row2["O_STATE"] = "예약중";
                                //이메일 발송 --------- 구현해야함
                                if (oracleConnection1.State.ToString() == "Closed")
                                    oracleConnection1.Open();
                                oracleCommand1.CommandText = "SELECT m_mail FROM member_books WHERE m_id ='" + row1["M_ID"].ToString() + "'";
                                string email = (oracleCommand1.ExecuteScalar()).ToString();
                                MessageBox.Show("예약자가 있습니다. 아래의 이메일로 안내를 시작합니다. \r\n"+email);
                                oracleConnection1.Close();
                                MailSetting("a71136347@gmail.com", new MailAddress(email), "북트리 예약시스템", "예약하셨던 상품이 드디어 대출이 가능한 상태입니다.\r\n일주일 이내로 오셔서 승인 받아주시길 바랍니다.");
                            }
                        }
                    }
                    else
                    {
                        //MessageBox.Show(row1["I_ID"].ToString() + dataGridView_return.CurrentRow.Cells[2].Value.ToString());
                    }
                }
            }
            catch(System.Exception ex)
            {
                MessageBox.Show("예약도서 업데이트 실패!" + ex);
            }
        }




        /*--------------------- 이메일보내기 ---------------------*/
        private void MailSetting(String from, MailAddress to, string title, string txt, Attachment att = null)
        {
            try
            {
                MailMessage message = new MailMessage();
                message.To.Add(to);
                message.From = new MailAddress(from, "북트리", Encoding.UTF8);
                //MailAddress bcc = new MailAddress("bcc@gmail.com");//참조 메일계정
                //message.Bcc.Add(bcc);
                message.Subject = title;
                message.SubjectEncoding = UTF8Encoding.UTF8;
                message.Body = txt;
                message.BodyEncoding = UTF8Encoding.UTF8;
                message.IsBodyHtml = true; //메일내용이 HTML형식임
                message.Priority = MailPriority.High; //중요도 높음
                message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure; //메일 배달 실패시 알림
                if (att != null)
                {
                    Attachment attFile = new Attachment("d\\image1.jpg");//첨부파일
                    message.Attachments.Add(attFile);
                }

                SmtpClient client = new SmtpClient();
                client.Host = "smtp.gmail.com"; //SMTP(발송)서버 도메인
                client.Port = 587; //25, SMTP서버 포트
                client.EnableSsl = true; //SSL 사용
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("a71136347@gmail.com", "choijueun!");//보내는 사람 메일 서버접속계정, 암호, Anonymous이용시 생략
                client.Send(message);
                message.Dispose();
                MessageBox.Show("이메일을 발송 하였습니다.");
            }
            catch(System.Exception)
            {
                MessageBox.Show("멤버의 이메일 주소가 유효하지 않습니다.");
                return;
            }
        }







        /*--------------------------- 연체료 이벤트 -------------------------------*/
        private void button_member_search_Click(object sender, EventArgs e)
        {
            if (vIEWPENALTYCOSTBindingSource.Filter != null)
            {
                vIEWPENALTYCOSTBindingSource.RemoveFilter();
                button_member_search.ButtonText = "검색";
                textBox_member.ReadOnly = false;
            }
            else
            {
                try
                {
                    if (textBox_member.Text.Replace(" ", "") == "")
                        return;

                    switch (comboBox_member.Text.ToString())
                    {
                        case "회원이름":
                            vIEWPENALTYCOSTBindingSource.Filter = "M_NAME LIKE '%" + textBox_member.Text + "%'";
                            break;
                        case "회원아이디":
                            vIEWPENALTYCOSTBindingSource.Filter = "M_ID LIKE '%" + textBox_member.Text + "%'";
                            break;
                        case "대여도서명":
                            vIEWPENALTYCOSTBindingSource.Filter = "I_NAME LIKE '%" + textBox_member.Text + "%'";
                            break;
                        case "도서번호":
                            vIEWPENALTYCOSTBindingSource.Filter = "O_ID = '" + textBox_member.Text + "'";
                            break;
                        case "도서등록번호":
                            vIEWPENALTYCOSTBindingSource.Filter = "I_ID = '" + textBox_member.Text + "'";
                            break;
                        default:
                            return;
                    }
                    button_member_search.ButtonText = "검색해제";
                    textBox_member.ReadOnly = true;
                }
                catch
                {
                    MessageBox.Show("정확한 값을 입력하시오.");
                    button_member_search.ButtonText = "검색";
                }
            }
        }











        /*--------------------------- 도서대여 이벤트 -------------------------------*/
        private void button_rent_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_can_rental.CurrentRow == null || dataGridView_info_member.CurrentRow == null)
                    return;

                if ((5 - Convert.ToInt32(dataGridView_info_member.CurrentRow.Cells[6].Value)) <= 0)
                {
                    MessageBox.Show("인당 최대 5권만 대여할 수 있습니다.","대여불가",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                //예약한 책을 대여할 수 없도록 만든다.

                bool find = false;
                string m_id = dataGridView_info_member.CurrentRow.Cells[0].Value.ToString();
                string m_name = dataGridView_info_member.CurrentRow.Cells[1].Value.ToString();
                string i_id = dataGridView_can_rental.CurrentRow.Cells[0].Value.ToString();
                string o_id = dataGridView_can_rental.CurrentRow.Cells[1].Value.ToString();
                string i_name = dataGridView_can_rental.CurrentRow.Cells[2].Value.ToString();
                string o_location = dataGridView_can_rental.CurrentRow.Cells[5].Value.ToString();
                int m_grade = Convert.ToInt32(dataGridView_info_member.CurrentRow.Cells[7].Value);
                string i_return_date, i_rental_cost, i_panelty_cost; // 반납일수, 대여료, 연체료(하루금액)
                string explain = "------------------------확인 정보----------------------"
                               + "\r\n대여회원 : [" + m_id + "]     " + m_name + " 회원"
                               + "\r\n(EM" + i_id + ") - NUM_" + o_id + "\t대여도서 : [" + i_name + "]"
                               + "\r\n도서위치 : [" + o_location + "]";

                foreach (DataRow row in info_books.Rows)
                {
                    if (row["I_ID"].ToString().Equals(i_id))
                    {
                        find = true;
                        i_return_date = row["I_RETURN_DATE"].ToString();
                        i_rental_cost = row["i_rental_cost"].ToString();
                        i_panelty_cost = row["i_panelty_cost"].ToString();
                        if (m_grade == -1 && dataGridView_can_rental.CurrentRow.Cells[4].Value.ToString() == "A") {
                            MessageBox.Show("관리도서의 등급을 넘어섰습니다."); // 블랙리스트는 A급 도서를 빌리지 못한다.
                            return;
                        }

                            

                        explain += "\r\n대여일수 : [   " + i_return_date + "일   ]"
                                + "\r\n기본 1일 연체료 : [   " + i_panelty_cost + "원   ]"
                                + "\r\n-------------------------------------------------------"
                                + "\r\n대여료는 [   " + i_rental_cost + "원   ] 입니다.";
                        break;
                    }
                }

                if (!find)
                {
                    MessageBox.Show("고객을 찾을 수 없습니다.");
                    return; }
                find = false;

                if (MessageBox.Show(explain, "대여", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataRow row in member_table.Rows)
                    {
                        if (row["M_ID"].ToString().Equals(m_id))
                        {
                            find = true;
                            row["M_CUR_RENT_COUNT"] = Convert.ToInt32(row["M_CUR_RENT_COUNT"].ToString()) + 1;
                            break;
                        }
                    }
                    if (!find) return;
                    find = false;

                    DataRow rent_new = rental_table.NewRow();
                    rent_new["M_ID"] = m_id;
                    rent_new["I_ID"] = i_id;
                    rent_new["O_ID"] = o_id;
                    rent_new["R_DATE"] = DateTime.Now;
                    rent_new["R_RETURN_DATE"] = DBNull.Value;
                    rent_new["R_IS_RETURN"] = 0;
                    rent_new["R_IS_EXTENSION"] = 0;
                    rent_new["MANAGER_ID"] = cur_logined.id;

                    foreach (DataRow row in info_books.Rows)
                    {
                        if (row["I_ID"].ToString().Equals(i_id))
                        {
                            find = true;
                            i_return_date = row["I_RETURN_DATE"].ToString();
                            rent_new["R_DEADLINE"] = DateTime.Now.AddDays(Convert.ToDouble(i_return_date));
                            break;
                        }
                    }

                    if (!find) return;
                    find = false;

                    foreach (DataRow row in own_books.Rows)
                    {
                        if (row["O_ID"].ToString().Equals(o_id) && row["I_ID"].ToString().Equals(i_id))
                        {
                            find = true;
                            row["O_STATE"] = "대여중";
                            break;
                        }
                    }

                    if (!find) return;
                    find = false;

                    rental_table.Rows.Add(rent_new);
                    if (rentaL_BOOKSTableAdapter1.Update(dataset1.RENTAL_BOOKS) > 0 && mEMBER_BOOKSTableAdapter.Update(dataset1.MEMBER_BOOKS) > 0 && owN_BOOKSTableAdapter1.Update(dataset1.OWN_BOOKS)>0)
                    {
                        up_date_all();
                        MessageBox.Show("대여완료", "대여", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                        MessageBox.Show("대여할 수 없습니다.", "대여", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("취소되었습니다.", "취소", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }
            }
            catch (System.Exception er)
            {
                MessageBox.Show("업데이트 실패" + er, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_can_rental_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                textBox_info_rental.Text
                    = "\a    도서명 : " + dataGridView_can_rental.CurrentRow.Cells[2].Value.ToString() + "\r\n"
                    + "\a    도서등급 : " + dataGridView_can_rental.CurrentRow.Cells[4].Value.ToString() + "\r\n"
                    + "\a    위치 : " + dataGridView_can_rental.CurrentRow.Cells[10].Value.ToString() + "\r\n";
            }
            catch (System.Exception)
            {
                
            }
        }

        private void dataGridView_info_member_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                textBox_info_member.Text = "";
                if (5 - Convert.ToInt32(dataGridView_info_member.CurrentRow.Cells[6].Value) <= 0)
                {
                    textBox_info_member.BackColor = Color.Red;
                    textBox_info_member.Text += "[대여불가] \r\n";
                }
                else
                {
                    textBox_info_member.BackColor = Color.Green;
                    textBox_info_member.Text += "[대여가능] \r\n";
                }

                if (Convert.ToInt32(dataGridView_info_member.CurrentRow.Cells[7].Value) < 0)
                {
                    textBox_info_member.BackColor = Color.Yellow;
                    textBox_info_member.Text += "[블랙리스트] \r\n";
                }

                textBox_info_member.Text
                += "\a    회원아이디 : " + dataGridView_info_member.CurrentRow.Cells[0].Value.ToString() + "\r\n"
                + "\a    회원이름 : " + dataGridView_info_member.CurrentRow.Cells[1].Value.ToString() + "\r\n"
                + "\a    전화번호 : " + dataGridView_info_member.CurrentRow.Cells[2].Value.ToString() + "\r\n"
                + "\a    이메일 : " + dataGridView_info_member.CurrentRow.Cells[3].Value.ToString() + "\r\n"
                + "\a    주소 : " + dataGridView_info_member.CurrentRow.Cells[4].Value.ToString() + "\r\n"
                + "\a    현재대출권수 : " + dataGridView_info_member.CurrentRow.Cells[6].Value.ToString() + "\r\n"
                + "\a    대출가능권수 : " + Convert.ToString(5 - Convert.ToInt32(dataGridView_info_member.CurrentRow.Cells[6].Value)) + "\r\n";
            }
            catch (System.Exception)
            {
               
            }
        }

        private void button_rent_search_Click(object sender, EventArgs e) // 도서검색, 회원검색
        {
            if (vIEWCANRENTALBindingSource.Filter != null)
            {
                vIEWCANRENTALBindingSource.RemoveFilter();
                button_rent_search.Text = "검색";
            }
            else if (mEMBERBOOKSBindingSource.Filter != null)
            {
                mEMBERBOOKSBindingSource.RemoveFilter();
                button_rent_search.Text = "검색";
            }
            else
            {
                try
                {
                    if (textBox_rent.Text.Replace(" ", "") == "")
                        return;

                    switch (comboBox_rent.Text.ToString())
                    {
                        case "도서명":
                            vIEWCANRENTALBindingSource.Filter = "I_NAME LIKE '%" + textBox_rent.Text + "%'";
                            break;
                        case "도서등록번호":
                            vIEWCANRENTALBindingSource.Filter = "I_ID = '" + textBox_rent.Text + "'";
                            break;
                        case "회원명":
                            mEMBERBOOKSBindingSource.Filter = "M_NAME LIKE '%" + textBox_rent.Text + "%'";
                            break;
                        case "회원아이디":
                            mEMBERBOOKSBindingSource.Filter = "M_ID LIKE '%" + textBox_rent.Text + "%'";
                            break;
                        default:
                            return;
                    }
                    button_rent_search.Text = "검색해제";
                }
                catch
                {
                    MessageBox.Show("바른값을 입력하시오.");
                    button_rent_search.Text = "검색";
                }
            }
        }




        private void dataGridView_return_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dataGridView_return.Rows)
            {
                if (((Convert.ToDateTime(Myrow.Cells[8].Value)).Subtract(DateTime.Now)).Days < 0)
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }



        private void button_assign_Click(object sender, EventArgs e)
        {
            try
            {
                string m_id = datagridview_assign.CurrentRow.Cells[0].Value.ToString();
                string i_id = datagridview_assign.CurrentRow.Cells[1].Value.ToString();
                string o_id = datagridview_assign.CurrentRow.Cells[2].Value.ToString();

                string m_name = "";

                foreach (DataRow row1 in own_books.Rows)
                {
                    if(row1["O_ID"].ToString() == o_id && row1["I_ID"].ToString() == i_id && row1["O_STATE"].ToString() == "대여중")
                    {
                        MessageBox.Show("아직 해당 상품을 예약할 수 없습니다.");
                        return;
                    }
                }

                foreach (DataRow row in member_table.Rows)
                {
                    if (row["M_ID"].ToString() == m_id)
                        m_name = row["M_NAME"].ToString();

                    if(5 - Convert.ToInt32(row["M_CUR_RENT_COUNT"].ToString()) <= 0)
                    {
                        MessageBox.Show("인당 최대 5권만 대여할 수 있습니다.", "승인불가", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string i_return_date = "", i_rental_cost = "", i_panelty_cost = "", i_name = ""; // 반납일수, 대여료, 연체료(하루금액)
                bool find = false;
                /*string explain = "------------------------확인 정보----------------------"
                               + "\r\n대여회원 : [" + m_id + "]     " + m_name + " 회원";*/
                foreach (DataRow row in info_books.Rows)
                {
                    if (row["I_ID"].ToString().Equals(i_id))
                    {
                        find = true;
                        i_name = row["I_NAME"].ToString();
                        i_return_date = row["I_RETURN_DATE"].ToString();
                        i_rental_cost = row["i_rental_cost"].ToString();
                        i_panelty_cost = row["i_panelty_cost"].ToString();

                        /*explain += "\r\n(BN" + i_id + ") - ON_" + o_id + "\t대여도서 : [" + i_name + "]"
                                + "\r\n대여일수 : [   " + i_return_date + "일   ]"
                                + "\r\n기본 1일 연체료 : [   " + i_panelty_cost + "원   ]"
                                + "\r\n-------------------------------------------------------"
                                + "\r\n대여료는 [   " + i_rental_cost + "원   ] 입니다.";*/
                        break;
                    }
                }

                /*if (!find) return;
                find = false;*/

                if (MessageBox.Show("위의 내용에 동의하십니까?" , "승인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataRow row in member_table.Rows)
                    {
                        if (row["M_ID"].ToString().Equals(m_id))
                        {
                            find = true;
                            row["M_CUR_RENT_COUNT"] = Convert.ToInt32(row["M_CUR_RENT_COUNT"].ToString()) + 1;
                            break;
                        }
                    }
                    if (!find) return;
                    find = false;

                    DataRow rent_new = rental_table.NewRow();
                    rent_new["M_ID"] = m_id;
                    rent_new["I_ID"] = i_id;
                    rent_new["O_ID"] = o_id;
                    rent_new["R_DATE"] = DateTime.Now;
                    rent_new["R_RETURN_DATE"] = DBNull.Value;
                    rent_new["R_IS_RETURN"] = 0;
                    rent_new["R_IS_EXTENSION"] = 0;
                    rent_new["MANAGER_ID"] = cur_logined.id;

                    foreach (DataRow row in info_books.Rows)
                    {
                        if (row["I_ID"].ToString().Equals(i_id))
                        {
                            find = true;
                            i_return_date = row["I_RETURN_DATE"].ToString();
                            rent_new["R_DEADLINE"] = DateTime.Now.AddDays(Convert.ToDouble(i_return_date));
                            break;
                        }
                    }

                    if (!find) return;
                    find = false;

                    foreach (DataRow row in own_books.Rows)
                    {
                        if (row["O_ID"].ToString().Equals(o_id) && row["I_ID"].ToString().Equals(i_id))
                        {
                            find = true;
                            row["O_STATE"] = "대여중";
                            break;
                        }
                    }

                    if (!find) return;
                    find = false;

                    rental_table.Rows.Add(rent_new);
                    datagridview_assign.Rows.Remove(datagridview_assign.CurrentRow);
                    if (reservatioN_BOOKSTableAdapter1.Update(dataset1.RESERVATION_BOOKS) >0 && rentaL_BOOKSTableAdapter1.Update(dataset1.RENTAL_BOOKS) > 0 && mEMBER_BOOKSTableAdapter.Update(dataset1.MEMBER_BOOKS) > 0 && owN_BOOKSTableAdapter1.Update(dataset1.OWN_BOOKS) > 0)
                    {
                        up_date_all();
                        MessageBox.Show("대여완료", "대여", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                        MessageBox.Show("대여할 수 없습니다.", "대여", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("취소되었습니다.", "취소", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }
            }
            catch (System.Exception er)
            {
                MessageBox.Show("업데이트 실패" + er, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datagridview_assign_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string m_id = datagridview_assign.CurrentRow.Cells[0].Value.ToString();
            string i_id = datagridview_assign.CurrentRow.Cells[1].Value.ToString();
            string o_id = datagridview_assign.CurrentRow.Cells[2].Value.ToString();

            string m_name = "";
            bool find = false;
            foreach (DataRow row in member_table.Rows)
            {
                if (row["M_ID"].ToString().Equals(m_id))
                    m_name = row["M_NAME"].ToString();
            }

            string i_return_date = "", i_rental_cost = "", i_panelty_cost = "", i_name = ""; // 반납일수, 대여료, 연체료(하루금액)
            find = false;

            string o_location = dataGridView_can_rental.CurrentRow.Cells[5].Value.ToString();

            string explain = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n------------------------확인 정보----------------------"
                           + "\r\n대여회원 : [" + m_id + "]\r\n회원명 : " + m_name + " 회원";
            foreach (DataRow row in info_books.Rows)
            {
                if (row["I_ID"].ToString().Equals(i_id))
                {
                    find = true;
                    i_name = row["I_NAME"].ToString();
                    i_return_date = row["I_RETURN_DATE"].ToString();
                    i_rental_cost = row["i_rental_cost"].ToString();
                    i_panelty_cost = row["i_panelty_cost"].ToString();

                    explain += "\r\nBN" + i_id + "-ON" + o_id + "\r\n대여도서 : [" + i_name + "]"
                            + "\r\n대여일수 : [   " + i_return_date + "일   ]"
                            + "\r\n기본 1일 연체료 : [   " + i_panelty_cost + "원   ]"
                            + "\r\n-------------------------------------------------------"
                            + "\r\n대여료는 [   " + i_rental_cost + "원   ] 입니다.";
                    break;
                }
            }

            if (!find) return;
            find = false;

            textbox_assign.Text = explain;
        }

        private void button_send_mail(object sender, EventArgs e)
        {
            MailSetting("BookTree@booktree.com", new MailAddress(dataGridView_penalty.CurrentRow.Cells[9].Value.ToString()), "[안내] 북트리 시스템 - 반납기간을 지나 연체료가 발생하였습니다.", "<br> <center> <font size=15> <b> BookTree System Message </b> </font> </center><hr> 대출하신 도서를 반납하지 않아 연체료가 발생하였습니다. <br> 연체료 미납상황이므로 북트리를 방문하셔서 반납해주시길 바랍니다. <br>");
        }
    }
}
