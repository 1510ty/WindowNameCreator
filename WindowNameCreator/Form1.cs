namespace WindowNameCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
            MessageBox.Show("�ύX����܂����I","WindowNameCreator",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
