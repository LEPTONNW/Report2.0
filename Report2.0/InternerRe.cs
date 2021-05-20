using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Report2._0
{
    public partial class InternerRe : Form
    {
        public InternerRe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:"+Environment.NewLine+"2.증상 / 조치결과:댁내재배선 / 과금안내/수긍 /지시서발행"+ Environment.NewLine+"3.진단툴확인:");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:댁내재배선 / 과금안내 / 불수긍 / 상급자협의후 1회성 면제, 추후불가 안내 / 수긍 / 지시서발행" + Environment.NewLine + "3.진단툴확인:");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:댁내재배선(면제) / 지시서발행" + Environment.NewLine + "3.진단툴확인:");
        }
    }
}
