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

            //Close�����У�form2Ҳ��ܿ�ص� Ϊʲô��
            //��ΪGO�ص�֮�� Main�����ͽ�����

            //û���ͷ���Դ���������ڶ���ֱ�ӱ��ˣ�
            //һ��Ҫ�ͷ���Դ
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
