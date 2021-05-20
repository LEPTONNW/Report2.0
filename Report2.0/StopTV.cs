using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Report2._0
{
    public partial class StopTV : Form
    {
        public StopTV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:tv전체채널끊김,화면멈춤 / STB,AP,CM리셋 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인: itms인터넷정상");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:tv전체채널끊김,화면멈춤 / STB,AP,모뎀리셋 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인: itms인터넷정상");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:tv전체채널끊김,화면멈춤 / STB,AP,포트리셋 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인: itms인터넷정상");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:tv전체채널끊김,화면멈춤 / STB,AP,ONT리셋 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인: itms인터넷정상");
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void button8_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:tv전체채널끊김,화면멈춤 / STB,CM리셋 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인: itms인터넷정상");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:tv전체채널끊김,화면멈춤 / STB,모뎀리셋 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인: itms인터넷정상");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:tv전체채널끊김,화면멈춤 / STB,포트리셋 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인: itms인터넷정상");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:tv전체채널끊김,화면멈춤 / STB,ONT리셋 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인: itms인터넷정상");
        }
    }
}
