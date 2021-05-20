using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Report2._0
{
    public partial class NoSignal : Form
    {
        public NoSignal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: tv전체채널방송신호없음 / AP,STB리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: AP핑안뜸");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: tv전체채널방송신호없음 / CM,STB리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: tv특정채널방송신호없음 / AP,STB리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: itms인터넷정상");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: tv전체채널방송신호없음 / STB,모뎀리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: tv전체채널방송신호없음 / STB,포트리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: tv전체채널방송신호없음 / STB,ONT리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: ");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: tv특정채널방송신호없음 / CM,STB리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: tv특정채널방송신호없음 / STB,모뎀리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: ");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: tv특정채널방송신호없음 / STB,포트리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: ");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2. 증상/조치결과: tv특정채널방송신호없음 / ONT,STB리셋 / 동일증상 / 지시서발행" + Environment.NewLine + "3. 진단툴확인: ");
        }
    }
}
