using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Report2._0
{
    public partial class InternetError : Form
    {
        public InternetError()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: 인접불,tv인터넷연결오류 / CM,AP,STB리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: CM상태 offline");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: 인접불,tv인터넷연결오류 / 모뎀,AP,STB리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: 인접불,tv인터넷연결오류 / STB,AP,포트리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: 가입자 포트 상태 불량");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: 인접불,tv인터넷연결오류 / STB,AP,ONT리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: ONT상태 Inactive");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: 인접불,tv인터넷연결오류 / CM,STB리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: CM상태 offline");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: 인접불,tv인터넷연결오류 / 모뎀,STB리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: 인접불,tv인터넷연결오류 / STB,포트리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: 가입자 포트 상태 불량");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: 인접불,tv인터넷연결오류 / STB,ONT리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: ONT상태 Inactive");
        }
    }
}
