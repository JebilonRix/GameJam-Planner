using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public partial class Form_Gamejam_Planner : Form
    {
        public Class_Print cp = new Class_Print();
        public Form_Gamejam_Planner()
        {
            InitializeComponent();
            tabPage1.Text = "Main";
            tabPage2.Text = "Code";
            tabPage3.Text = "Art";
            tabPage4.Text = "Sound";
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            string[] MainLines = { textBoxTheme.Text, textBoxName.Text, textBoxGenre.Text, textBoxArtStyle.Text, textBoxGameEngine.Text };

            string[] richDy = richTextBoxDy.Text.Split('\n');
            string[] richMec = richTextBoxMec.Text.Split('\n');
            string[] richCl = richTextBoxCl.Text.Split('\n');
            string[] richMet = richTextBoxMet.Text.Split('\n');
            string[] richCh = richTextBoxCh.Text.Split('\n');
            string[] richOb = richTextBoxOb.Text.Split('\n');
            string[] richAn = richTextBoxAn.Text.Split('\n');
            string[] richMus = richTextBoxMus.Text.Split('\n');
            string[] richSo = richTextBoxSo.Text.Split('\n');

            cp.Printer(MainLines, richDy, richMec, richCl, richMet, richCh, richOb, richAn, richMus, richSo);




        }
    }
}
