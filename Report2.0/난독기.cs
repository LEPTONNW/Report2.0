using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Report2._0
{
    public partial class 난독기 : Form
    {
        public 난독기()
        {
            InitializeComponent();
        }

        public static string temp = "";
        public static int i;

        private void 난독기_Load(object sender, EventArgs e)
        {

        }

        private void 암호1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 출력1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 암호화_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(암호1.Text))
            {
                출력1.Text = "";
            }

            else
            {

                int w;
                string str = 암호1.Text;
                char[] strArray = str.ToCharArray();

                for (w = 0; w < strArray.Length; w++)
                {
                    출력1.Text += (int)strArray[w] + "!";
                }

                Clipboard.SetText(출력1.Text + (char)((int)10));

                암호1.Text = "";

            }


        }

        private void 복호화_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(복호1.Text))
            {
                출력2.Text = "";
                i = 0;
                temp = "";
            }

            else
            {
                test1 ms = new test1();

                ms.a = new List<Int64>();

                string str = 복호1.Text;
                char[] strArray = str.ToCharArray();

                for (i = 0; i < strArray.Length; i++)
                {
                    if (strArray[i] == '!')
                    {
                        ms.a.Add(Int64.Parse(temp));
                        temp = "";
                    }
                    else
                    {
                        temp += strArray[i];
                    }
                }



                foreach (Int64 b in ms.a)
                {

                    출력2.Text += Convert.ToChar(b);
                }

                Clipboard.SetText(출력2.Text);

                복호1.Text = "";
            }

        }

        private void 복호1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 출력2_TextChanged(object sender, EventArgs e)
        {


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void 진법1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox2.Text = "";
            }

            else
            {

                int w;
                string str = textBox1.Text;
                char[] strArray = str.ToCharArray();

                for (w = 0; w < strArray.Length; w++)
                {
                    if (strArray[w] == '!')
                    {
                        textBox2.Text += "!";
                    }
                    else
                    {
                        if (strArray[w] == '0')
                        {
                            textBox2.Text += "Z";

                        }
                        else if (strArray[w] == '1')
                        {
                            textBox2.Text += "O";

                        }
                        else if (strArray[w] == '2')
                        {
                            textBox2.Text += "T";

                        }
                        else if (strArray[w] == '3')
                        {
                            textBox2.Text += "H";

                        }
                        else if (strArray[w] == '4')
                        {
                            textBox2.Text += "F";

                        }
                        else if (strArray[w] == '5')
                        {
                            textBox2.Text += "I";

                        }
                        else if (strArray[w] == '6')
                        {
                            textBox2.Text += "S";

                        }
                        else if (strArray[w] == '7')
                        {
                            textBox2.Text += "V";

                        }
                        else if (strArray[w] == '8')
                        {
                            textBox2.Text += "E";

                        }
                        else if (strArray[w] == '9')
                        {
                            textBox2.Text += "N";

                        }

                    }
                }

                Clipboard.SetText(textBox2.Text);

                textBox1.Text = "";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void 해독버튼1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(난독문1.Text))
            {
                해독문1.Text = "";
            }

            else
            {

                int w;
                string str = 난독문1.Text;
                char[] strArray = str.ToCharArray();

                for (w = 0; w < strArray.Length; w++)
                {
                    if (strArray[w] == '!')
                    {
                        해독문1.Text += "!";
                    }
                    else
                    {
                        if (strArray[w] == 'Z')
                        {
                            해독문1.Text += "0";

                        }
                        else if (strArray[w] == 'O')
                        {
                            해독문1.Text += "1";

                        }
                        else if (strArray[w] == 'T')
                        {
                            해독문1.Text += "2";

                        }
                        else if (strArray[w] == 'H')
                        {
                            해독문1.Text += "3";

                        }
                        else if (strArray[w] == 'F')
                        {
                            해독문1.Text += "4";

                        }
                        else if (strArray[w] == 'I')
                        {
                            해독문1.Text += "5";

                        }
                        else if (strArray[w] == 'S')
                        {
                            해독문1.Text += "6";

                        }
                        else if (strArray[w] == 'V')
                        {
                            해독문1.Text += "7";

                        }
                        else if (strArray[w] == 'E')
                        {
                            해독문1.Text += "8";

                        }
                        else if (strArray[w] == 'N')
                        {
                            해독문1.Text += "9";

                        }

                    }
                }

                Clipboard.SetText(해독문1.Text);

                난독문1.Text = "";

            }
        }

        private void 난독문1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 해독문1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    class test1
    {
        public List<Int64> a
        {
            get;
            set;
        }
    }



}
