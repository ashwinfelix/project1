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
    public partial class Form2 : Form
    {
        public List<Person> People { get; set; }
        public Form2()
        {
            People = GetPeople();
            InitializeComponent();
        }

        private List<Person> GetPeople()
        {
            var list = new List<Person>();
            list.Add(new Person()
            {
                Id = 1,
                Name = "Ashwin",
                Surname = "Felix",
                Profession = "Cricketer"
            });

            list.Add(new Person()
            {
                Id = 1,
                Name = "Arjun",
                Surname = "JayaKumar",
                Profession = "Plumber"
            });

            list.Add(new Person()
            {
                Id = 1,
                Name = "Adin",
                Surname = "Dipu",
                Profession = "Sweeper"
            });

            return list;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var people = this.People;
            dataGridView1.DataSource = people;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (file1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(file1.FileName);
            }
        }
    }
}
