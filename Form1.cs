using System.Windows.Forms;

namespace GO
{
    public partial class GO : Form
    {
        public GO()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void GO_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
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
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
