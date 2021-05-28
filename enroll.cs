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
    public partial class enroll : Form
    {
        // 기본
        public enroll()
        {
            InitializeComponent();
        }

        private void enroll_Load(object sender, EventArgs e)
        {
            this.infO_BOOKSTableAdapter1.Fill(dataset11.INFO_BOOKS);
            this.owN_BOOKSTableAdapter1.Fill(dataset11.OWN_BOOKS);
            dataGridView_info.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView_book.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            //SetDoNotSort(dataGridView_info);
            //SetDoNotSort(dataGridView_book);

            iNFOBOOKSBindingSource.Sort = "I_ID ASC";
            oWNBOOKSFK1BindingSource.Sort = "I_ID,O_ID ASC";
            
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
















        /*--------------------- INFO_BOOKS 이벤트 ----------------------*/
        private void button_info_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("삭제하시겠습니까?", "행삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    iNFOBOOKSBindingSource.RemoveCurrent();
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("삭제할 데이터가 없습니다.");
            }
        }

        /* 행 추가 버튼을 눌렀을때 */
        private void button_info_insert_Click(object sender, EventArgs e)
        {
            try
            {
                iNFOBOOKSBindingSource.AddNew();
            }
            catch (System.Exception)
            {
                MessageBox.Show("이미 존재하는 행을 채워주세요!");
            }
        }

        private void button_info_save_Click(object sender, EventArgs e)
        {
            try
            {
                this.iNFOBOOKSBindingSource.EndEdit();
                dataGridView_info.EndEdit();
                int ret = this.infO_BOOKSTableAdapter1.Update(this.dataset11.INFO_BOOKS);
                if (ret > 0)
                    MessageBox.Show("업데이트 성공", "저장성공", MessageBoxButtons.OK, MessageBoxIcon.None);
                else
                    MessageBox.Show("업데이트 할 것이 없습니다.", "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ea)
            {
                MessageBox.Show("업데이트 실패" + ea, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_info_filter_Click(object sender, EventArgs e)
        {
            if (iNFOBOOKSBindingSource.Filter != null)
            {
                iNFOBOOKSBindingSource.RemoveFilter();
                button_info_filter.Text = "필터";
            }
            else
            {
                try
                {
                    switch (comboBox_info_filtering.Text)
                    {
                        case "등록번호":
                            iNFOBOOKSBindingSource.Filter = "I_ID = '" + textBox_info_filter.Text + "'";
                            break;
                        case "도서정가":
                            iNFOBOOKSBindingSource.Filter = "I_COST = '" + textBox_info_filter.Text + "'";
                            break;
                        case "대여가격":
                            iNFOBOOKSBindingSource.Filter = "I_RENTAL_COST = '" + textBox_info_filter.Text + "'";
                            break;
                        case "반납일":
                            iNFOBOOKSBindingSource.Filter = "I_RETURN_DATE = '" + textBox_info_filter.Text + "'";
                            break;
                        case "도서명":
                            iNFOBOOKSBindingSource.Filter = "I_NAME = '" + textBox_info_filter.Text + "'";
                            break;
                        case "저자":
                            iNFOBOOKSBindingSource.Filter = "I_AUTHOR = '" + textBox_info_filter.Text + "'";
                            break;
                        case "출판사":
                            iNFOBOOKSBindingSource.Filter = "I_PUBLISHER = '" + textBox_info_filter.Text + "'";
                            break;
                        case "출판일":
                            iNFOBOOKSBindingSource.Filter = "I_PUBLISHED_DATE = '" + Convert.ToDateTime(datepicker_info) + "'";
                            break;
                    }
                    button_info_filter.Text = "필터해제";
                }
                catch
                {
                    MessageBox.Show("바른값을 입력하시오.");
                }
            }
        }

        private void comboBox_info_filtering_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_info_filtering.Text)
            {
                case "출판일":
                    datepicker_info.Visible = true;
                    textBox_info_filter.Visible = false;
                    iNFOBOOKSBindingSource.Filter = "I_PUBLISHED_DATE = '" + textBox_info_filter.Text + "'";
                    break;
                default:
                    datepicker_info.Visible = false;
                    textBox_info_filter.Visible = true;
                    break;
            }
        }







        /*--------------------------- OWN_BOOKS 이벤트 -------------------------------*/

        private void button_book_insert_Click(object sender, EventArgs e)
        {
            try
            {
                oWNBOOKSFK1BindingSource.AddNew();
            }
            catch (System.Exception)
            {
                MessageBox.Show("이미 존재하는 열을 채워주세요!");
            }
        }

        private void button_book_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("삭제하시겠습니까?", "행삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oWNBOOKSFK1BindingSource.RemoveCurrent();
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("삭제할 데이터가 없습니다.");
            }
        }

        private void button_book_save_Click(object sender, EventArgs e)
        {
            try
            {
                this.oWNBOOKSFK1BindingSource.EndEdit();
                dataGridView_book.EndEdit();
                int ret = this.owN_BOOKSTableAdapter1.Update(this.dataset11);
                if (ret > 0)
                    MessageBox.Show("업데이트 성공", "저장성공", MessageBoxButtons.OK, MessageBoxIcon.None);
                else
                    MessageBox.Show("업데이트 할 것이 없습니다.", "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ea)
            {
                MessageBox.Show("업데이트 실패" + ea, "저장실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_book_filter_Click(object sender, EventArgs e)
        {
            if (oWNBOOKSFK1BindingSource.Filter != null)
            {
                oWNBOOKSFK1BindingSource.RemoveFilter();
                button_book_filter.Text = "필터";
            }
            else
            {
                try
                {
                    switch (comboBox_book_filter.Text)
                    {
                        case "소유책번호":
                            oWNBOOKSFK1BindingSource.Filter = "O_ID = '" + textBox_book_filter.Text + "'";
                            break;
                        case "도서등급":
                            oWNBOOKSFK1BindingSource.Filter = "O_GRADE = '" + textBox_book_filter.Text + "'";
                            break;
                        case "현재도서상태":
                            oWNBOOKSFK1BindingSource.Filter = "O_STATE = '" + textBox_book_filter.Text + "'";
                            break;
                        case "구입시기":
                            oWNBOOKSFK1BindingSource.Filter = "O_PURCHASE_DATE = '" + Convert.ToDateTime(datepicker_book) + "'";
                            break;
                        case "현재도서위치":
                            oWNBOOKSFK1BindingSource.Filter = "O_LOCATION = '" + textBox_book_filter.Text + "'";
                            break;
                    }
                    button_book_filter.Text = "필터해제";
                }
                catch
                { 
                    MessageBox.Show("바른값을 입력하시오.");
                }
            }
        }

        private void comboBox_book_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_book_filter.Text)
            {
                case "구입시기":
                    datepicker_book.Visible = true;
                    textBox_book_filter.Visible = false;
                    oWNBOOKSFK1BindingSource.Filter = "O_PURCHASE_DATE = '" + textBox_info_filter.Text + "'";
                    break;
                default:
                    datepicker_book.Visible = false;
                    textBox_book_filter.Visible = true;
                    break;
            }
        }

        private void dataGridView_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oWNBOOKSFK1BindingSource.Filter = "I_ID = '" + dataGridView_info.CurrentRow.Cells[0].Value.ToString() + "'";
            }
            catch
            {
                oWNBOOKSFK1BindingSource.RemoveFilter();
            }
        }

        private void dataGridView_info_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                oWNBOOKSFK1BindingSource.Filter = "I_ID = '" + dataGridView_info.CurrentRow.Cells[0].Value.ToString() + "'";
            }
            catch
            {
                oWNBOOKSFK1BindingSource.RemoveFilter();
            }
        }

        private void dataGridView_info_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.RowIndex)
            {
                case 0:
                    MessageBox.Show("[도서번호]를 확인해주세요.");
                    break;
                case 1:
                    MessageBox.Show("[도서명]을 확인해주세요.");
                    break;
                case 2:
                    MessageBox.Show("[저자]를 확인해주세요.");
                    break;
                case 3:
                    MessageBox.Show("[출판사]를 확인해주세요.");
                    break;
                case 4:
                    MessageBox.Show("[출판일]를 확인해주세요. \r\n기본적으로 'YY-MM-DD HH24:MI:SS' 형식입니다.");
                    break;
                case 5:
                    MessageBox.Show("[대출가격]를 확인해주세요.");
                    break;
                case 6:
                    MessageBox.Show("[도서정가]를 확인해주세요. \r\n일반적으로 숫자를 입력해주세요.");
                    break;
                case 7:
                    MessageBox.Show("[장르]를 확인해주세요. \r\n콤보박스 안의 목록중에 하나를 선택하세요.");
                    break;
            }
        }

        private void dataGridView_info_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    MessageBox.Show("[도서번호]를 확인해주세요. \r\n도서번호는 숫자로만 이루어져 있습니다.");
                    break;
                case 1:
                    MessageBox.Show("[도서명]을 확인해주세요.");
                    break;
                case 2:
                    MessageBox.Show("[저자]를 확인해주세요.");
                    break;
                case 3:
                    MessageBox.Show("[출판사]를 확인해주세요.");
                    break;
                case 4:
                    MessageBox.Show("[출판일]를 확인해주세요. \r\n기본적으로 'YY-MM-DD HH24:MI:SS' 형식입니다.");
                    break;
                case 5:
                    MessageBox.Show("[대출가격]를 확인해주세요.");
                    break;
                case 6:
                    MessageBox.Show("[도서정가]를 확인해주세요. \r\n일반적으로 숫자를 입력해주세요.");
                    break;
                case 7:
                    MessageBox.Show("[장르]를 확인해주세요. \r\n콤보박스 안의 목록중에 하나를 선택하세요.");
                    break;
            }
        }

        private void dataGridView_book_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    MessageBox.Show("[도서번호]를 확인해주세요. \r\n도서번호는 숫자로만 이루어져 있습니다.");
                    break;
                case 1:
                    MessageBox.Show("[도서등록번호]을 확인해주세요. \r\n 기본적으로 자동지정됩니다.");
                    break;
                case 2:
                    MessageBox.Show("[도서등급]를 확인해주세요. \r\nA, B, C 중 하나를 선택하여 기입하세요.");
                    break;
                case 3:
                    MessageBox.Show("[도서상태]를 확인해주세요.\r\n도서관(0), 대여중(1), 예약중(2) 세개 중 하나를 선택하여 기입하세요.");
                    break;
                case 4:
                    MessageBox.Show("[구입시기]를 확인해주세요. \r\n기본적으로 'YY-MM-DD HH24:MI:SS' 형식입니다.");
                    break;
                case 5:
                    MessageBox.Show("[현재위치]를 확인해주세요.");
                    break;
            }
        }
    }
}
