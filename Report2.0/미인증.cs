using System;
using System.Windows.Forms;

namespace Report2._0
{
    public partial class 미인증 : Form
    {
        public 미인증()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1.고객요청:" + Environment.NewLine + "2.증상 / 조치결과:이전설치문의 / 일반부서 안내 / 종료 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1.고객요청:" + Environment.NewLine + "2.증상 / 조칙결과:SKT문의 / 해당부서 안내 / 종료 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1.고객요청:" + Environment.NewLine + "2.증상 / 조치결과:KT문의 /해당부서 안내 / 종료" + Environment.NewLine + "3.진단툴확인:");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1.고객요청:" + Environment.NewLine + "2.증상 / 조치결과:LGU+문의 / 해당부서 안내 / 종료 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void 미인증_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1.고객요청:" + Environment.NewLine + "2.증상 / 조치결과:해약문의 / 해약부서 안내 / 종료 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1.고객요청:" + Environment.NewLine + "2.증상 / 조치결과:외부선 정리요청 / 센터OB:내용전달 / 종료 " + Environment.NewLine + "3.진단툴확인:");
        }
    }
}
