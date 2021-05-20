using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Report2._0
{
    public partial class NoNetwork : Form
    {
        public NoNetwork()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: tv네트워크연결오류 / AP,STB리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: itms인터넷정상");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: tv네트워크연결오류 / CM,STB리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: itms인터넷정상");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: tv네트워크연결오류 / 모뎀,STB리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: itms인터넷정상");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: tv네트워크연결오류 / 포트,STB리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: itms인터넷정상");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: tv네트워크연결오류 / ONT,STB리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: itms인터넷정상");
        }
    }
}
