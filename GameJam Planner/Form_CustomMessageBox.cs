using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public partial class Form_CustomMessageBox : Form
    {
        public string Joker;

        public Form_CustomMessageBox()
        {
            InitializeComponent();
        }
        private void buttonApply_Click(object sender, EventArgs e)
        {
            Joker = textBox1.Text;
            this.Close();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
