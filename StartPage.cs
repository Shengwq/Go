using System.Windows.Forms;

namespace GO
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void GO_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PVP form2 = new PVP();
            form2.Show();

            //Close好像不行，form2也会很快关掉 为什么？
            //因为GO关掉之后 Main函数就结束了

            //没有释放资源，编译器第二次直接崩了？
            //一定要释放资源
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PVESelect form3 = new PVESelect();
            form3.Show();
        }
    }
}
