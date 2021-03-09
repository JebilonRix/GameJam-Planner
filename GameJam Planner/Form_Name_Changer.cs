using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public partial class Form_Name_Changer : Form
    {
        public string Joker;

        public Form_Name_Changer()
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
