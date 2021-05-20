using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Report2._0
{
    public partial class IntStop : Form
    {
        public IntStop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:사용중잦은끊김 / 매번 CM,AP리셋 하고있으나 동일증상 일어난다심 / 점검요청 /지시서발행 " + Environment.NewLine + "3.진단툴확인:CM상태 online");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:사용중잦은끊김 / 매번 AP,모뎀리셋 하고있으나 동일증상 일어난다심 / 점검요청 /지시서발행 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:사용중잦은끊김 / 매번 AP리셋 하고있으나 동일증상 일어난다심 / 점검요청 /지시서발행 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:사용중잦은끊김 / 매번 ONT,AP리셋 하고있으나 동일증상 일어난다심 / 점검요청 /지시서발행 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:사용중잦은끊김 / 매번 CM리셋 하고있으나 동일증상 일어난다심 / 점검요청 /지시서발행 " + Environment.NewLine + "3.진단툴확인:CM상태 online");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:사용중잦은끊김 / 매번 모뎀리셋 하고있으나 동일증상 일어난다심 / 점검요청 /지시서발행 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:사용중잦은끊김 / 매번 랜선재연결 하고있으나 동일증상 일어난다심 / 점검요청 /지시서발행 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:사용중잦은끊김 / 매번 ONT리셋 하고있으나 동일증상 일어난다심 / 점검요청 /지시서발행 " + Environment.NewLine + "3.진단툴확인:");
        }
    }
}
