using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Report2._0
{
    public partial class WIFI : Form
    {
        public WIFI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:와이파이접속불가 / AP리셋 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인:CM상태 online");
        }
    }
}
