using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Web;
using System.Net;
using System.Xml;
using System.Net.Http;
using System.Runtime.InteropServices;

namespace Final_Project
{
    public partial class join : Form
    {
        //전역변수
        DataTable member_table;





        //기본
        public join()
        {
            InitializeComponent();
        }

        private void join_Load(object sender, EventArgs e)
        {
            //FormEffect(this);
            this.membeR_BOOKSTableAdapter1.Fill(this.dataset11.MEMBER_BOOKS);
            this.member_table = dataset11.Tables["MEMBER_BOOKS"];
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            FormEffect(this);
        }

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("회원가입을 종료 하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void pictureBox_minimum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }






        //사용자 정의함수
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

        private bool IsAvailableRRN(string RRN)
        {
            foreach (DataRow row in member_table.Rows)
            {
                if (textbox_certification.Text == row["m_ssn"].ToString())
                {
                    alert_message("이미 회원가입된 주민등록번호 입니다.");
                    button_join.Enabled = false;
                    this.Dispose();
                    return false;
                }
            }

            RRN = RRN.Replace(" ", "");/*공백 제거*/
            //문자 '-' 제거
            RRN = RRN.Replace("-", ""); //주민등록번호가 13자리인가?
            if (RRN.Length != 13)
            {
                alert_message("유효한 주민등록 번호가 아닙니다. 다시 입력해주세요.");
                return false;
            }

            int sum = 0;
            for (int i = 0; i < RRN.Length - 1; i++)
            {
                char c = RRN[i];                //숫자로 이루어져 있는가?
                if (!char.IsNumber(c))
                {
                    alert_message("유효한 주민등록 번호가 아닙니다. 다시 입력해주세요.");
                    return false;
                }
                else
                {
                    if (i < RRN.Length)
                    {
                        sum += int.Parse(c.ToString()) * ((i % 8) + 2);//지정된 숫자로 각 자리를 나눈 후 더한다.
                    }
                }
            }
           
            if (!((((11 - (sum % 11)) % 10).ToString()) == ((RRN[RRN.Length - 1]).ToString()))) // 검증코드와 결과 값이 같은가?
            {
                alert_message("유효한 주민등록 번호가 아닙니다. 다시 입력해주세요.");
                return false;
            }
            return true;
        }

        private void alert_message(string str)
        {
            MessageBox.Show(str, "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool isAvailableID()
        {
            string str = @"[~!@\#$%^&*\()\=+|\\/:;?""<>']";
            System.Text.RegularExpressions.Regex rex = new System.Text.RegularExpressions.Regex(str);
            if (rex.IsMatch(textbox_id.Text))
            {
                textbox_id.Text.Remove(0, textbox_id.Text.Length);
                textbox_id.Text = "";
                textbox_id.Focus();
                alert_message("아이디는 특수문자, 공백이 허용되지 않습니다.");
                return false;
            }

            foreach (DataRow row in member_table.Rows)
            {
                if (textbox_id.Text == row["m_id"].ToString())
                {
                    alert_message("중복된 아이디 입니다.");
                    textbox_id.Text = "";
                    textbox_id.Focus();
                    return false;
                }
            }

            if(textbox_id.Text.Length < 5 || textbox_id.Text.Length > 18)
            {
                alert_message("아이디는 최소5자 이상 최대 18자 이하로 생성해주세요.");
                textbox_id.Text = "";
                textbox_id.Focus();
                return false;
            }
            return true;
        }

        public bool isAvailablePW()
        {
            if (Regex.IsMatch(textbox_pw.Text, @"[a-zA-Z0-9~`!@#$%^&*()_\-+={}[\]|\\;:'""<>,.?/]") == false)
            {
                alert_message("PW는 숫자, 소문자, 대문자로만 구성해주세요,");
                textbox_pw.Text = "";
                textbox_pw2.Text = "";
                textbox_pw.Focus();
                return false;
            }

            if (textbox_pw.Text != textbox_pw2.Text)
            {
                alert_message("2차 비밀번호가 일치하지 않습니다.\n일치하는 비밀번호를 입력하세요.");
                textbox_pw2.Text = "";
                textbox_pw2.Focus();
                return false;
            }

            if (textbox_pw.Text.Length < 8 || textbox_pw.Text.Length > 20)
            {
                alert_message("비밀번호는 최소 8자리 이상 최대 20자리 이하로 생성해주세요.");
                textbox_pw.Text = "";
                textbox_pw2.Text = "";
                textbox_pw.Focus();
                return false;
            }

            return true;
        }

        public bool isAvailableEMAIL()
        {
            if (!Regex.IsMatch(textbox_email.Text, @"[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?"))
            {
                textbox_email.Text = "";
                textbox_email.Focus();
                alert_message("이메일 형식이 유효하지 않습니다. 다시 확인해주세요.");
                return false;
            }
            return true;
        }
    
        private void textbox_certification_Click(object sender, EventArgs e)
        {
            if (textbox_certification.Text.Length == 7) // 기본 7자 부터 시작한다. 
            {
                String txt = textbox_certification.Text.Substring(0, 6).Trim(); //'-' 제외하고 공백 제거 
                if (textbox_certification.SelectionStart > txt.Length)// 입력된 곳을 벗어나 click 하면 
                {
                    textbox_certification.SelectionStart = txt.Length; // 입력한 곳의 맨끝으로 가고 
                }
            }
            else
            {
                String txt = textbox_certification.Text.Trim(); // 공백제거 
                if (textbox_certification.SelectionStart > txt.Length) // 입력된 곳을 벗어나 click 하면 
                {
                    textbox_certification.SelectionStart = txt.Length; // 입력한 곳의 맨끝으로 가고 
                }
            }
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







        //버튼클릭
        private void button_join_Click(object sender, EventArgs e)
        {
            if (!isAvailableID()) return;
            if (!isAvailablePW()) return;
            if (!IsAvailableRRN(textbox_certification.Text)) return;
            if (!isAvailableEMAIL()) return;
            if(checkBox_agree.Checked != true)
            {
                alert_message("약관 동의를 해주세요,");
                return;
            }

            DataRow member_NewDataRow = member_table.NewRow();
            member_NewDataRow["M_ID"] = textbox_id.Text;
            member_NewDataRow["M_NAME"] = textbox_name.Text;
            member_NewDataRow["M_PASSWORD"] = textbox_pw.Text;
            member_NewDataRow["M_SSN"] = textbox_certification.Text;
            member_NewDataRow["M_PHONE"] = textbox_phone.Text;
            member_NewDataRow["M_MAIL"] = textbox_email.Text;
            member_NewDataRow["M_ADDRESS"] = textbox_address.Text;
            member_NewDataRow["M_GRADE"] = 0;
            member_NewDataRow["M_CUR_RENT_COUNT"] = 0;

            if (oracleConnection1.State.ToString() == "Closed")
                oracleConnection1.Open();
            oracleCommand1.CommandText = "SELECT SYSDATE FROM DUAL";
            member_NewDataRow["M_JOINDATE"] = Convert.ToDateTime(oracleCommand1.ExecuteScalar());
            oracleConnection1.Close();

            member_table.Rows.Add(member_NewDataRow);

            try
            {
                int ret = this.membeR_BOOKSTableAdapter1.Update(this.dataset11.MEMBER_BOOKS);
                
                if (ret > 0)
                    MessageBox.Show("회원가입이 완료되었습니다.");
                else
                    MessageBox.Show("업데이트 할 것이 없습니다.", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception)
            {
                MessageBox.Show("업데이트 실패, 빈칸을 모두 채워주세요.", "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                member_table.Rows.Remove(member_NewDataRow);
                return;
            }
            button_join.Enabled = false;
            this.Dispose();
        }

        private void join_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
