using Oracle.ManagedDataAccess.Client;
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
    
    public partial class statistics : Form
    {
        // 기본
        public statistics()
        {
            InitializeComponent();
        }

        private void statistics_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataset11.INFO_BOOKS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.iNFO_BOOKSTableAdapter.Fill(this.dataset11.INFO_BOOKS);
            // TODO: 이 코드는 데이터를 'dataset11.VIEW_WILL_RESERVATION' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.vIEW_WILL_RESERVATIONTableAdapter.Fill(this.dataset11.VIEW_WILL_RESERVATION);
            if (oracleConnection1.State.ToString() == "Closed")
                oracleConnection1.Open();
            chart_maker();
            textbox_log();
            oracleConnection1.Close();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            FormEffect(this);
        }

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("관리자 창을 종료 하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void pictureBox_minimum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        /*--------------------------- 헤더 정렬 막기 -------------------------------*/
        private void SetDoNotSort(DataGridView dgv)
        {
            foreach (DataGridViewColumn i in dgv.Columns)
            {
                i.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }


        /* ------------------- 차트안에 들어갈 내용 삽입 -------------------*/
        private void chart_maker()
        {
            oracleCommand1.CommandText = "SELECT info_books.i_name, view_rental_count.vrc_count from info_books, view_rental_count where info_books.i_id = view_rental_count.i_id and rownum <= 5";
            OracleDataReader rdr = oracleCommand1.ExecuteReader();
            while (rdr.Read())
            {
                chart1.Series[0].Points.AddXY(rdr["I_NAME"].ToString() +"권", rdr["VRC_COUNT"].ToString());
            }

            rdr.Close();
        }

        /* ----------------- 아래쪽 텍스트 박스 삽입 ------------------*/
        private void textbox_log()
        {
            oracleCommand1.CommandText = "SELECT info_books.i_name, view_rental_count.vrc_count from info_books, view_rental_count where info_books.i_id = view_rental_count.i_id";
            OracleDataReader rdr = oracleCommand1.ExecuteReader();
            while (rdr.Read())
            {
                listBox1.Items.Add("[" + rdr["I_NAME"].ToString() + "] 를 총 " + rdr["VRC_COUNT"].ToString() + "회 대여한 기록이 있습니다.");
            }

            rdr.Close();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (oracleConnection1.State.ToString() == "Closed")
                oracleConnection1.Open();

            //MessageBox.Show(dateTimePicker1.Text);
            listBox1.Items.Clear();
            oracleCommand1.CommandText = "SELECT info_books.i_name, subquery1.VRC_COUNT " +
                "from info_books, (SELECT info_books.i_id as i_id, count(rental_books.i_id) as vrc_count "
                + "FROM info_books, rental_books "
                + "where rental_books.i_id = info_books.i_id "
                + "and to_date(rental_books.r_date, 'YY/MM/DD HH24:MI:SS') "
                + "between TO_DATE('" + dateTimePicker1.Text + "','YY/MM/DD HH24:MI:SS') "
                + "and TO_DATE('" + dateTimePicker2.Text + "', 'YY/MM/DD HH24:MI:SS') "
                + "group by info_books.i_id "
                + "order by vrc_count DESC) subquery1 "
                + "where info_books.i_id in subquery1.i_id ";

            OracleDataReader rdr = oracleCommand1.ExecuteReader();
            while (rdr.Read())
            {
                listBox1.Items.Add("[" + rdr["I_NAME"].ToString() + "] 를 총 " + rdr["VRC_COUNT"].ToString() + "회 대여한 기록이 있습니다.");
            }

            label_date.Text = dateTimePicker1.Text + " ~ " + dateTimePicker2.Text;
            rdr.Close();
            oracleConnection1.Close();
        }






        // 이벤트 발생
        private void bunifuDataGridView_history_SelectionChanged(object sender, EventArgs e)
        {
            if (bunifuDataGridView_history.CurrentRow == null)
                return;

            listBox_history.Items.Clear();
            if (oracleConnection1.State.ToString() == "Closed")
                oracleConnection1.Open();

            oracleCommand1.CommandText = "SELECT * FROM RENTAL_BOOKS WHERE RENTAL_BOOKS.I_ID = " + Convert.ToInt32(bunifuDataGridView_history.CurrentRow.Cells[0].Value);
            OracleDataReader rdr = oracleCommand1.ExecuteReader();

            while (rdr.Read())
            {
                listBox_history.Items.Add(rdr["R_DATE"].ToString() + "에 [" + rdr["M_ID"].ToString() + "] 님이 도서번호 [" + rdr["O_ID"].ToString() + "번]을 대출하였습니다.");
            }

            rdr.Close();
            oracleConnection1.Close();
        }

        private void bunifuButton_cost_search_Click(object sender, EventArgs e)
        {
            listBox_cost.Items.Clear();

            if (oracleConnection1.State.ToString() == "Closed")
                oracleConnection1.Open();

            //MessageBox.Show(dateTimePicker1.Text);
            oracleCommand1.CommandText = "SELECT info_books.i_name, subquery1.VRC_COUNT, info_books.i_rental_cost " 
                + "from info_books, (SELECT info_books.i_id as i_id, count(rental_books.i_id) as vrc_count "
                + "FROM info_books, rental_books "
                + "where rental_books.i_id = info_books.i_id "
                + "and TO_DATE(rental_books.r_date, 'YY/MM/DD HH24:MI:SS') "
                + "between TO_DATE('" + bunifuDatePicker_start.Value.ToShortDateString() + "','YY/MM/DD') "
                + "and TO_DATE('" + bunifuDatePicker_end.Value.ToShortDateString() + "', 'YY/MM/DD') "
                + "group by info_books.i_id "
                + "order by vrc_count DESC) subquery1 "
                + "where info_books.i_id in subquery1.i_id ";

            OracleDataReader rdr = oracleCommand1.ExecuteReader();
            int sum = 0;
            while (rdr.Read())
            {
                sum += Convert.ToInt32(rdr["VRC_COUNT"]) * Convert.ToInt32(rdr["i_rental_cost"]);
                listBox_cost.Items.Add("[" + rdr["I_NAME"].ToString() + "] - " + Convert.ToInt32(rdr["VRC_COUNT"]) * Convert.ToInt32(rdr["i_rental_cost"]) + "원");
            }
            bunifuTextBox_total.Text = sum.ToString()+"원";
            rdr.Close();
            oracleConnection1.Close();
        }

        private void bunifuButton_rental_Click(object sender, EventArgs e)
        {
            chart_day.Series[0].Points.Clear();
            chart_week.Series[0].Points.Clear();
            chart_month.Series[0].Points.Clear();

            if (oracleConnection1.State.ToString() == "Closed")
                oracleConnection1.Open();

            oracleCommand1.CommandText = "SELECT info_books.i_name, subquery1.VRC_COUNT , info_books.i_rental_cost "
                + "from info_books, (SELECT info_books.i_id as i_id, count(rental_books.i_id) as vrc_count "
                + "FROM info_books, rental_books "
                + "where rental_books.i_id = info_books.i_id "
                + "and TO_DATE(rental_books.r_date, 'YY/MM/DD') "
                + "in TO_DATE('" + bunifuDatePicker_rental.Value.ToShortDateString() + "','YY/MM/DD') "
                + "group by info_books.i_id "
                + "order by vrc_count DESC) subquery1 "
                + "where info_books.i_id in subquery1.i_id ";

            OracleDataReader rdr = oracleCommand1.ExecuteReader();
            if (rdr.HasRows)
            {
                chart_day.Visible = true;
                label_day.Visible = false;
            }
            else
            {
                chart_day.Visible = false;
                label_day.Visible = true;
            }

            while (rdr.Read())
            {
                chart_day.Series[0].Points.AddXY(rdr["I_NAME"].ToString(), Convert.ToInt32(rdr["VRC_COUNT"]));

            }


            oracleCommand1.CommandText
                = "select DATE_DAY, sum(i_RENTAL_COST) as sum "
                + "from (SELECT to_char(rental_books.r_date,'yyyy-mm-dd') as date_day, info_books.i_rental_cost "
                + "FROM RENTAL_BOOKS, INFO_BOOKS "
                + "where to_char(rental_books.r_date,'yyyy-iw') = to_char(to_date('" + bunifuDatePicker_rental.Value.ToShortDateString() + "','yyyy-mm-dd'),'yyyy-iw') "
                + "and rental_books.i_id = info_books.i_id "
                + "order by date_day) "
                + "group by date_day";
            OracleDataReader rdr2 = oracleCommand1.ExecuteReader();
            if (rdr2.HasRows)
            {
                chart_week.Visible = true;
                label_week.Visible = false;
            }
            else
            {
                chart_week.Visible = false;
                label_week.Visible = true;
            }

            while (rdr2.Read())
            {
                chart_week.Series[0].Points.AddXY(rdr2["date_day"].ToString(), Convert.ToInt32(rdr2["sum"]));

            }

            oracleCommand1.CommandText
                = "select DATE_DAY, sum(i_RENTAL_COST) as sum "
                + "from (SELECT to_char(rental_books.r_date,'yyyy-mm') as date_day, info_books.i_rental_cost "
                + "FROM RENTAL_BOOKS, INFO_BOOKS "
                + "where to_char(rental_books.r_date,'yyyy') = to_char(to_date('" + bunifuDatePicker_rental.Value.ToShortDateString() + "','yyyy-mm-dd'),'yyyy') "
                + "and rental_books.i_id = info_books.i_id "
                + "order by date_day) "
                + "group by date_day";
            OracleDataReader rdr3 = oracleCommand1.ExecuteReader();

            if (rdr3.HasRows)
            {
                chart_month.Visible = true;
                label_month.Visible = false;
            }
            else
            {
                chart_month.Visible = false;
                label_month.Visible = true;
            }

            while (rdr3.Read())
            {
                chart_month.Series[0].Points.AddXY(rdr3["date_day"].ToString(), Convert.ToInt32(rdr3["sum"]));

            }

            oracleConnection1.Close();

        }
    }
}
