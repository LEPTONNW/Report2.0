using System;
using System.Windows.Forms;
using System.Threading;

namespace Report2._0
{
    public partial class 타이머 : Form
    {
        public 타이머()
        {
            InitializeComponent();
        }

        private void 타이머_Load(object sender, EventArgs e)
        {

        }

        public static int hour, min, sec, ms = 0;
        public static int hour1, min1, sec1, ms1 = 0;
        public static int hour2, min2, sec2, ms2 = 0;

        public static int h, m, s, ss = 0;
        public static int h1, m1, s1, ss1 = 0;
        public static int h2, m2, s2, ss2 = 0;
        public static int In, Out = 0;

        private void button7_Click(object sender, EventArgs e)
        {
            Out++;
            아웃.Text = Out.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            In--;
            인.Text = In.ToString();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label2.Text = hour1 + ":" + min1 + ":" + sec1.ToString();
            label8.Text = h1 + ":" + m1 + ":" + s1.ToString();
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button3.BackColor = System.Drawing.Color.White;
            this.button4.BackColor = System.Drawing.Color.White;
            Thread.Sleep(1000);
            sec1++; s1++;
            if (ms1 > 10)
            {
                sec1++; s1++;
                ms1 = 0;
            }
            else
            {
                ms1 = 0;
            }
            if (sec1 > 60)
            {
                min1++; m1++;
                sec1 = 0; s1 = 0;
            }

            if (min1 > 60)
            {
                hour1++; h1++;
                min1 = 0; m1 = 0;
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            label1.Text = hour + ":" + min + ":" + sec.ToString();
            label7.Text = h + ":" + m + ":" + s.ToString();
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button3.BackColor = System.Drawing.Color.White;
            this.button4.BackColor = System.Drawing.Color.White;
            Thread.Sleep(1000);
            sec++; s++;
            if (ms > 10)
            {
                sec++; s++;
                ms = 0;
            }
            else
            {
                ms = 0;
            }
            if (sec > 60)
            {
                min++; m++;
                sec = 0; s = 0;
            }

            if (min > 60)
            {
                hour++; h++;
                min = 0; m = 0;
            }
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            label6.Text = hour2 + ":" + min2 + ":" + sec2.ToString();
            label9.Text = h2 + ":" + m2 + ":" + s2.ToString();
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button4.BackColor = System.Drawing.Color.White;
            Thread.Sleep(1000);
            sec2++; s2++;
            if (ms2 > 10)
            {
                sec2++; s2++;
                ms2 = 0;
            }
            else
            {
                ms2++;
            }
            if (sec2 > 60)
            {
                min2++; m2++;
                sec2 = 0; s2 = 0;
            }

            if (min2 > 60)
            {
                hour2++; h2++;
                min2 = 0; m2 = 0;
            }
        }



        private void button8_Click(object sender, EventArgs e)
        {
            Out--;
            아웃.Text = Out.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            In++;
            인.Text = In.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("단축키는 F1 ~ F8 입나다." + Environment.NewLine + "" + Environment.NewLine + "증가 : F5, F7" + Environment.NewLine + "감소 : F6, F8");
        }

        public static int counter = 0;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!base.ProcessCmdKey(ref msg, keyData))
            {
                if (keyData.Equals(Keys.F1))
                {

                    timer3.Stop();
                    timer1.Stop();
                    timer2.Start();
                    this.button2.BackColor = System.Drawing.Color.Orange;
                    this.button1.BackColor = System.Drawing.Color.White;
                    this.button3.BackColor = System.Drawing.Color.White;
                    this.button4.BackColor = System.Drawing.Color.White;
                    return true;
                }
                else if (keyData.Equals(Keys.F2))
                {
                    timer3.Stop();
                    timer2.Stop();
                    timer1.Start();
                    this.button1.BackColor = System.Drawing.Color.Orange;
                    this.button2.BackColor = System.Drawing.Color.White;
                    this.button3.BackColor = System.Drawing.Color.White;
                    this.button4.BackColor = System.Drawing.Color.White;
                    return true;
                }
                else if (keyData.Equals(Keys.F3))
                {
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Start();
                    this.button3.BackColor = System.Drawing.Color.Orange;
                    this.button1.BackColor = System.Drawing.Color.White;
                    this.button2.BackColor = System.Drawing.Color.White;
                    this.button4.BackColor = System.Drawing.Color.White;
                    return true;
                }
                else if (keyData.Equals(Keys.F4))
                {
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    this.button3.BackColor = System.Drawing.Color.White;
                    this.button1.BackColor = System.Drawing.Color.White;
                    this.button2.BackColor = System.Drawing.Color.White;
                    this.button4.BackColor = System.Drawing.Color.LightGreen;
                    hour = 0;
                    min = 0;
                    sec = 0;
                    ms = 0;

                    hour1 = 0; min1 = 0; sec1 = 0; ms1 = 0;

                    hour2 = 0; min2 = 0; sec2 = 0; ms2 = 0;
                    label1.Text = hour + ":" + min + ":" + sec + ":" + ms.ToString();
                    label2.Text = hour1 + ":" + min1 + ":" + sec1 + ":" + ms1.ToString();
                    label6.Text = hour2 + ":" + min2 + ":" + sec2 + ":" + ms2.ToString();

                    return true;
                }
                else if (keyData.Equals(Keys.F5))
                {
                    In++;
                    인.Text = In.ToString();
                    return true;
                }
                else if (keyData.Equals(Keys.F6))
                {
                    In--;
                    인.Text = In.ToString();
                    return true;
                }
                else if (keyData.Equals(Keys.F7))
                {
                    Out++;
                    아웃.Text = Out.ToString();
                    return true;
                }
                else if (keyData.Equals(Keys.F8))
                {
                    Out--;
                    아웃.Text = Out.ToString();
                    return true;
                }

                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            this.button3.BackColor = System.Drawing.Color.White;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button4.BackColor = System.Drawing.Color.LightGreen;

            hour = 0;
            min = 0;
            sec = 0;
            ms = 0;

            hour1 = 0; min1 = 0; sec1 = 0; ms1 = 0;

            hour2 = 0; min2 = 0; sec2 = 0; ms2 = 0;
            label1.Text = hour + ":" + min + ":" + sec + ":" + ms.ToString();
            label2.Text = hour1 + ":" + min1 + ":" + sec1 + ":" + ms1.ToString();
            label6.Text = hour2 + ":" + min2 + ":" + sec2 + ":" + ms2.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Start();
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button4.BackColor = System.Drawing.Color.White;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            timer2.Stop();
            timer1.Start();
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button3.BackColor = System.Drawing.Color.White;
            this.button4.BackColor = System.Drawing.Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            timer1.Stop();
            timer2.Start();
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button3.BackColor = System.Drawing.Color.White;
            this.button4.BackColor = System.Drawing.Color.White;

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
