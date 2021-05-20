using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Report2._0
{
    public partial class NOInternet : Form
    {
        public NOInternet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:인접불,언플러그 / AP리셋,랜선재연결 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인:CM상태 online");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:인접불,언플러그 / AP리셋,랜선재연결 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:인접불,언플러그 / AP리셋,랜선재연결 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인:포트 업");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:인접불,언플러그 / AP리셋,랜선재연결 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인:ONT상태 active");
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:인접불,언플러그 / CM리셋,랜선재연결 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인:CM상태 online");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:인접불,언플러그 / 모뎀리셋,랜선재연결 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:인접불,언플러그 / 포트리셋,랜선재연결 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인:포트 업");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:인접불,언플러그 / ONT리셋,랜선재연결 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인:ONT상태 active");
        }
    }
}
