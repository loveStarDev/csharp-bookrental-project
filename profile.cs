using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }

        public profile(main main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void prifile_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataset11.VIEW_RESERVATION_PROFILE' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.vIEW_RESERVATION_PROFILETableAdapter.Fill(this.dataset11.VIEW_RESERVATION_PROFILE);
            vIEWRESERVATIONPROFILEBindingSource.Filter = "M_ID = '" + main.cur_logined.id + "'";
            bunifuTextBox_id.Text = main.cur_logined.id;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
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






        //사용자 정의함수

        public bool isAvailablePW()
        {
            if(bunifuTextBox_curpw.Text != main.cur_logined.pw)
            {
                MessageBox.Show("현재 비밀번호가 맞지 않습니다. 다시한번 확인해주세요.");
                return false;
            }
            if (Regex.IsMatch(bunifuTextBox_pw1.Text, @"[a-zA-Z0-9~`!@#$%^&*()_\-+={}[\]|\\;:'""<>,.?/]") == false)
            {
                MessageBox.Show("PW는 숫자, 소문자, 대문자로만 구성해주세요,");
                bunifuTextBox_pw1.Text = "";
                bunifuTextBox_pw2.Text = "";
                bunifuTextBox_pw1.Focus();
                return false;
            }

            if (bunifuTextBox_pw1.Text != bunifuTextBox_pw2.Text)
            {
                MessageBox.Show("2차 비밀번호가 일치하지 않습니다.\n일치하는 비밀번호를 입력하세요.");
                bunifuTextBox_pw2.Text = "";
                bunifuTextBox_pw2.Focus();
                return false;
            }

            if (bunifuTextBox_pw1.Text.Length < 8 || bunifuTextBox_pw1.Text.Length > 20)
            {
                MessageBox.Show("비밀번호는 최소 8자리 이상 최대 20자리 이하로 생성해주세요.");
                bunifuTextBox_pw1.Text = "";
                bunifuTextBox_pw2.Text = "";
                bunifuTextBox_pw1.Focus();
                return false;
            }

            return true;
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

        /*--------------------------- 마우스로 폼 이동-------------------------------*/
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;
        private main main;

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

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            try
            {

                if (bunifuDataGridView1.CurrentRow == null)
                    return;

                if (MessageBox.Show("예약을 취소 하시겠습니까?", "예약취소", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string i_id = bunifuDataGridView1.CurrentRow.Cells[1].Value.ToString();
                    string o_id = bunifuDataGridView1.CurrentRow.Cells[2].Value.ToString();
                    string r_date = bunifuDataGridView1.CurrentRow.Cells[4].Value.ToString();

                    if (oracleConnection1.State.ToString() == "Closed")
                        oracleConnection1.Open();

                    oracleCommand1.CommandText = "DELETE FROM RESERVATION_BOOKS WHERE I_ID = " + Convert.ToInt32(i_id) + " AND O_ID = " + Convert.ToInt32(o_id) + " AND M_ID = '" + main.cur_logined.id + "'";
                    int res = oracleCommand1.ExecuteNonQuery();
                    if (res > 0)
                    {
                        vIEW_RESERVATION_PROFILETableAdapter.Fill(dataset11.VIEW_RESERVATION_PROFILE);
                        reservatioN_BOOKSTableAdapter1.Fill(dataset11.RESERVATION_BOOKS);
                        vieW_RENTALTableAdapter1.Fill(dataset11.VIEW_RENTAL);
                        vieW_WILL_RESERVATIONTableAdapter1.Fill(dataset11.VIEW_WILL_RESERVATION);
                        rentaL_BOOKSTableAdapter1.Fill(dataset11.RENTAL_BOOKS);
                        

                        MessageBox.Show("예약이 취소 되었습니다.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show(" 오류가 발생하였습니다. ");
                    }

                    oracleConnection1.Close();
                }
            }
            catch(System.Exception ex)
            {
                MessageBox.Show("오류가 발생하였습니다!!!" + ex);
            }

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (!isAvailablePW())
                return;

            if (oracleConnection1.State.ToString() == "Closed")
                oracleConnection1.Open();

            oracleCommand1.CommandText = "UPDATE member_books set m_password='" + bunifuTextBox_pw1.Text + "' WHERE m_id = '" + main.cur_logined.id + "'";
            int res = oracleCommand1.ExecuteNonQuery();
            if(res > 0)
            {
                MessageBox.Show("비밀번호가 변경 되었습니다. 다시 로그인 해주세요.");
                main.button_logout_Click(null, null);

            }
            else
            {
                MessageBox.Show("오류가 발생하였습니다.");
            }

            oracleConnection1.Close();
        }
    }
}
