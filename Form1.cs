namespace FirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = textBox1.Text;
            MessageBox.Show("You have entered : " + text);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Text = checkBox1.Text;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                label1.Text = checkBox2.Text;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = comboBox1.Text;
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ash = new Form1();
            ash.ShowDialog();
        }

        private void smurfCatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ash2 = new Form2();
            ash2.ShowDialog();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 adv = new Form3();
            adv.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void assignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 lmao = new Form4();
            lmao.ShowDialog();
        }

        private void assignementRevampToolStripMenuItem_Click(object sender, EventArgs e)
        {
            assignment1Revsamp ash = new assignment1Revsamp();
            ash.ShowDialog();
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
