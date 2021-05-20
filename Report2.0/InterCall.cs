using System;
using System.Windows.Forms;

namespace Report2._0
{
    public partial class InterCall : Form
    {
        public InterCall()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:송수신불가 /TPAS리셋 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:송수신불가 /TPAS리셋실패,MTA수동리셋 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:송수신불가 /TPAS리셋실패, 모든선재연결 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인:CCS확인불가");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:송수신불가 / 포트리셋, 모든선재연결 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:착신전환 설정방법문의 / 안내 /종료 " + Environment.NewLine + "3.진단툴확인: ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:단말기 충전불량 /모든선 재연결 /동일증상 / 지시서발행 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:송수신불가 / 모든선재연결 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인:CCS확인불가");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:단말기 충전불량 / 제조사로 문의 안내 / 종료  " + Environment.NewLine + "3.진단툴확인:");
        }

        private void InterCall_Load(object sender, EventArgs e)
        {

        }
    }
}
