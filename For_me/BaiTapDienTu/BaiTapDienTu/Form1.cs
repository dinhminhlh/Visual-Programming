using System.Windows.Forms;

namespace BaiTapDienTu
{
    public partial class Form1 : Form
    {
        string ch;
        string chda;
        List<string> da;

        public Form1(string ddCH, string ddDA, string ddCHDA)
        {
            string s = QLFile.doccauhoi(ddCH);
            chda = QLFile.doccauhoi(ddCHDA);
            da = QLFile.docdapan(ddDA);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string s = QLFile.doccauhoi("");
            richTextBox1.Text = s;
        }
    }
}