using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Report2._0
{
    public partial class TV : Form
    {
        public TV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:tv입력신호없음장애 / 외부입력재설정,STB리셋,모든선재연결 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:STB전원불량 / 셋탑박스전원안켜짐 / 모든선재연결 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과: STB영상출력이상 /  / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과: STB부팅불량 / 부팅도중화면에서멈춤 / STB리셋 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과: STB메뉴설정방법 문의 / 안내 / 종료" + Environment.NewLine + "3.진단툴확인:");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과: VOD재생불가 / 라이선스초기화,STB리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3.진단툴확인:");
        }

        private void TV_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과: tv전체채널 소리 안들림 / STB리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3.진단툴확인:");
        }
    }
}
