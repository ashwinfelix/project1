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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public States SelectedState
        {
            get
            {
                return (States)comboBox1.SelectedItem;
            }
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            List<States> list = new List<States>();
            list.Add(new States() { ID = 1, Name = "Tamil Nadu" });
            list.Add(new States() { ID = 2, Name = "Kerala" });
            list.Add(new States() { ID = 3, Name = "Karnataka" });
            list.Add(new States() { ID = 4, Name = "Goa" });
            comboBox1.DataSource = list;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Name";

        }
    }
}
