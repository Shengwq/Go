using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GO
{
    public partial class PVESelect : Form
    {
        public PVESelect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="初级")
            {
                PVE pveWindow = new PVE();
                pveWindow.Show();
                this.Close();
            }
        }
    }
}
