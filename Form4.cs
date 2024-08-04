using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox5.Text))
            {
                return;
            }
            else
            {
                listBox1.Items.Add(txtbox5.Text);
                txtbox5.Clear();
                txtbox5.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblvalue.Text = listBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Subscribers> list = new List<Subscribers>();
            list.Add(new Subscribers() { ID = "KL", Name = "Kerala"});
            list.Add(new Subscribers() { ID = "TN", Name = "Tamil Nadu" });
            list.Add(new Subscribers() { ID = "AP", Name = "Andhra Pradesh" });
            listBox1.DataSource = list;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "Name";
        }
    }
}
