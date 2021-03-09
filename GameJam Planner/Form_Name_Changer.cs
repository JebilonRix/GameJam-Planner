using System;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public partial class Form_Name_Changer : Form
    {
        public static Form_Name_Changer Name_Changer;
        public Form_Name_Changer()
        {
            InitializeComponent();
        }

        public string TXT;

        public bool Result;
        private void buttonApply_Click(object sender, EventArgs e)
        {
            TXT = textBox1.Text;
            Result = true;
            this.Close();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Result = false;
            this.Close();
        }
    }
}
