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
    public partial class searching : Form
    {

        //전역변수
        private bool dragging = false;
        private Point offset;
        private DataTable searching_books;




        public searching()
        {
            InitializeComponent();
        }

        private void searching_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataset1.INFO_BOOKS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.iNFO_BOOKSTableAdapter.Fill(this.dataset1.INFO_BOOKS);
            searching_books = dataset1.Tables["VIEW_WILL_RESERVATION"];
            dataGridView_searching.CellFormatting += dbView_CellFormatting;
            iNFOBOOKSBindingSource.Sort = "I_ID ASC";
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            FormEffect(this);
        }

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("검색 창을 종료 하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void pictureBox_minimum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


















        // 정의함수

        /*--------------------------- 등급설정 -------------------------------*/
        private void dbView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                if (e.Value != null)
                {

                    string text = e.Value.ToString();
                    switch (text)
                    {
                        case "도서관":
                            e.Value = "";
                            break;
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

        /*------------------------------- Reservation_booking ------------------------------------*/
        private void button_searching_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox_searching.Text)
                {
                    case "도서등록번호":
                        vieW_WILL_RESERVATIONTableAdapter1.FillByiid(dataset1.VIEW_WILL_RESERVATION, Convert.ToInt32(textBox_searching.Text));
                        vIEWWILLRESERVATIONBindingSource1.Filter = "I_ID = '" + Convert.ToInt32(textBox_searching.Text) + "'";
                        break;
                    case "도서번호":
                        vieW_WILL_RESERVATIONTableAdapter1.FillByoid(dataset1.VIEW_WILL_RESERVATION, Convert.ToInt32(textBox_searching.Text));
                        vIEWWILLRESERVATIONBindingSource1.Filter = "O_ID = '" + textBox_searching.Text + "'";
                        break;
                    case "저자":
                        vieW_WILL_RESERVATIONTableAdapter1.FillByauthor(dataset1.VIEW_WILL_RESERVATION, '%' + textBox_searching.Text+ '%');
                        vIEWWILLRESERVATIONBindingSource1.Filter = "I_AUTHOR LIKE '%" + textBox_searching.Text + "%'";
                        break;
                    case "출판사":
                        vieW_WILL_RESERVATIONTableAdapter1.FillBypublisher(dataset1.VIEW_WILL_RESERVATION, '%' + textBox_searching.Text + '%');
                        vIEWWILLRESERVATIONBindingSource1.Filter = "I_PUBLISHER  LIKE '%" + textBox_searching.Text + "%'";
                        break;
                    case "장르":
                        vieW_WILL_RESERVATIONTableAdapter1.FillBygenre(dataset1.VIEW_WILL_RESERVATION, '%' + textBox_searching.Text+ '%');
                        vIEWWILLRESERVATIONBindingSource1.Filter = "I_GENRE LIKE '%" + textBox_searching.Text + "%'";
                        break;
                    case "도서명":
                        vieW_WILL_RESERVATIONTableAdapter1.FillByiname(dataset1.VIEW_WILL_RESERVATION, "%" + textBox_searching.Text+ "%");
                        vIEWWILLRESERVATIONBindingSource1.Filter = "I_NAME LIKE '%" + textBox_searching.Text + "%'";
                        break;
                    default:
                        MessageBox.Show("종류를 선택해주세요!");
                        break;
                }
            }
            catch
            {
                MessageBox.Show("정확한 값을 입력해주세요. (숫자/문자 구분)");
            }
        }

        private void button_can_rental_Click(object sender, EventArgs e)
        {
            if (iNFOBOOKSBindingSource.Filter != null)
            {
                iNFOBOOKSBindingSource.RemoveFilter();
                button_can_rental.ButtonText = "검색";
            }
            else
            {
                try
                {
                    switch (comboBox_can_rental.Text)
                    {
                        case "도서등록번호":
                            iNFOBOOKSBindingSource.Filter = "I_ID = '" + Convert.ToDecimal(textBox_can_rental.Text) + "'";
                            break;
                        case "저자":
                            iNFOBOOKSBindingSource.Filter = "I_AUTHOR LIKE '%" + textBox_can_rental.Text + "%'";
                            break;
                        case "출판사":
                            iNFOBOOKSBindingSource.Filter = "I_PUBLISHER  LIKE '%" + textBox_can_rental.Text + "%'";
                            break;
                        case "장르":
                            iNFOBOOKSBindingSource.Filter = "I_GENRE LIKE '%" + textBox_can_rental.Text + "%'";
                            break;
                        case "도서명":
                            iNFOBOOKSBindingSource.Filter = "I_NAME LIKE '%" + textBox_can_rental.Text + "%'";
                            break;
                        default:
                            MessageBox.Show("??");
                            break;
                    }
                    button_can_rental.ButtonText = "검색해제";
                }
                catch(System.Exception ex)
                {
                    MessageBox.Show("바른값을 입력하시오." + ex);
                    button_can_rental.ButtonText = "검색";
                }
            }
        }
    }
}
