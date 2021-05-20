using System;
using System.Windows.Forms;

namespace Report2._0
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            this.Text = "Report 2.1"; //To set the title
            timer1.Start(); //starting the timer
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new InternerRe();
            myForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new NoLED();
            myForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myForm = new LED();
            myForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var myForm = new NOInternet();
            myForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:와이파이접속불가 / AP리셋 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 2.1.1 " + Environment.NewLine + "by MONG");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var myForm = new NoNetwork();
            myForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var myForm = new NoSignal();
            myForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:리모컨 교체" + Environment.NewLine + "2.증상 / 조치결과:리모컨 버튼동작불가 / 배터리교체,STB리셋 / 동일증상 /지시서발행 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var myForm = new InternetError();
            myForm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var myForm = new StopTV();
            myForm.Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1.불만내용: 잦은 인터넷끊김/ 잦은장애 불편호소 / 너무불편하다심 / 장애접수 여러번받았으나 개선안됨 / 조치거부 / 품해검증요청 / 지시서 " + Environment.NewLine + "2.장애횟수: 잦은장애" + Environment.NewLine + "3.고객요청사항:  ");
            MessageBox.Show("1.요금은 전날까지 계산되어서 익월에 청구됨" + Environment.NewLine + "" + Environment.NewLine + "2.해지는 영업일 기준으로 3일뒤에 해지됨" + Environment.NewLine + "" + Environment.NewLine + "3.장비회수하는 시간이 소요되고, 장비회수될 고객연락처와 주소 탐색되어야함, 또한 회수기간 1주일이상 지연된다면 106재연락 안내되어야함" + Environment.NewLine + "" + Environment.NewLine + "4.판매전화기 가입되어있어 해지했으나 약정잡혀있을경우 익월에 할인반환금 청구될수있음");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:재판매 / 해당부서 안내 / 종료 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:이전설치문의 / 일반상담 호전환 / 종료 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:가입자정보조회안됨 / 확인후 연락주신다심 / 종료 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:수신즉시끊김 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:인접불 / 회선장애로 복구중에있음 양해 /수긍 /종료  " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:인접불 / 회선작업으로 작업중에있음 양해 /수긍 /종료  " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:기업기술문의 / 해당부서 안내 /종료 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:해지시 위약금,약정기간 문의 / 해약상담 호전환 /종료 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:SKB가입문의 / 해당부서안내 /종료 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:리모컨 교체" + Environment.NewLine + "2.증상 / 조치결과:리모컨 파손 / 과금안내 /수긍 / 지시서발행 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var myForm = new TV();
            myForm.Show();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("센터OB(  ) : / 고객OB: / 내용전달 / ");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            var myForm = new Contact();
            myForm.Show();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            var myForm = new IntStop();
            myForm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            var MyForm = new InterCall();
            MyForm.Show();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            var MyForm = new 타이머();
            MyForm.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1. 고객요청:" + Environment.NewLine + "2.증상 / 조치결과:와이파이 비번 까먹음 / 비밀번호 재안내 / 종료 " + Environment.NewLine + "3.진단툴확인:");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //to display the time in the label
            time.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var MyForm = new 바로가기창();
            MyForm.Show();

            // 인터넷 띄우는 코드 System.Diagnostics.Process.Start( "www.naver.com");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var MyForm = new 난독기();
            MyForm.Show();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            var MyForm = new 미인증();
            MyForm.Show();
        }
    }
}
