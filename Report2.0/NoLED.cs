﻿using System;

using System.Windows.Forms;

namespace Report2._0
{
    public partial class NoLED : Form
    {
        public NoLED()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1.고객요청:" + Environment.NewLine + "2.증상 / 조치결과:인접불 / CM,AP리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3.진단툴확인:CM상태 offline ");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1.고객요청:" + Environment.NewLine + "2.증상 / 조치결과:인접불 / 모뎀,AP리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3.진단툴확인:");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1.고객요청:" + Environment.NewLine + "2.증상 / 조치결과:인접불 / AP,포트리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3.진단툴확인:포트다운");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1.고객요청:" + Environment.NewLine + "2.증상 / 조치결과:인접불 / ONT,AP리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3.진단툴확인:ONT상태 inactive");
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1.고객요청:" + Environment.NewLine + "2.증상 / 조치결과:인접불 / CM리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3.진단툴확인:CM상태 offline ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1.고객요청:" + Environment.NewLine + "2.증상 / 조치결과:인접불 / 모뎀리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3.진단툴확인:");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1.고객요청:" + Environment.NewLine + "2.증상 / 조치결과:인접불 / 포트리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3.진단툴확인:가입자 포트 상태 불량");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1.고객요청:" + Environment.NewLine + "2.증상 / 조치결과:인접불 / ONT리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3.진단툴확인:ONT상태 inactive");
        }
    }
}
