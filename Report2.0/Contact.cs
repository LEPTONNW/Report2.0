using System;
using System.Windows.Forms;

namespace Report2._0
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Clear();
            for(int i=listBox1.Items.Count-1; i >= 0; i-- )
            {
                if (listBox1.Items[i].ToString().ToLower().Contains(txt_search.Text.ToLower()))
                {
                    listBox1.SetSelected(i, true);
                }
            }
            label_status.Text = listBox1.SelectedItems.Count.ToString() + "검색완료";

        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!base.ProcessCmdKey(ref msg, keyData))
            {
                if (keyData.Equals(Keys.Enter))
                {
                    listBox1.SelectedItems.Clear();
                    for (int i = listBox1.Items.Count - 1; i >= 0; i--)
                    {
                        if (listBox1.Items[i].ToString().ToLower().Contains(txt_search.Text.ToLower()))
                        {
                            listBox1.SetSelected(i, true);
                        }
                    }
                    label_status.Text = listBox1.SelectedItems.Count.ToString() + "검색완료";

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
        private void Contact_Load(object sender, EventArgs e)
        {

        }
    }
}
