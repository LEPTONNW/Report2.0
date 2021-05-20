using System;
using System.Windows.Forms;

namespace Report2._0
{
    public partial class 바로가기창 : Form
    {
        public 바로가기창()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("chrome.exe", "www.naver.com");
            }

            catch
            {
                System.Diagnostics.Process.Start("www.naver.com");
            }
        }

        private void 바로가기창_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("chrome.exe", "http://www.skbroadband.com/content/realtime/Realtime_List.do");
            }

            catch
            {
                System.Diagnostics.Process.Start("http://www.skbroadband.com/content/realtime/Realtime_List.do");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("chrome.exe", "http://www.juso.go.kr/openIndexPage.do");
            }

            catch
            {
                System.Diagnostics.Process.Start("http://www.juso.go.kr/openIndexPage.do");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("chrome.exe", "http://hint.skbroadband.com/");
            }

            catch
            {
                System.Diagnostics.Process.Start("http://hint.skbroadband.com/");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("chrome.exe", "http://ukey.skbroadband.com/");
            }

            catch
            {
                System.Diagnostics.Process.Start("http://ukey.skbroadband.com/");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("chrome.exe", "http://stellent.sktelecom.com:8080/jsp/ZMKIJCMP20010.jsp");
            }

            catch
            {
                System.Diagnostics.Process.Start("http://stellent.sktelecom.com:8080/jsp/ZMKIJCMP20010.jsp");
            }
        }
    }
}
