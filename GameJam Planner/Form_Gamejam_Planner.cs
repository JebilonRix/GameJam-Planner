using System;
using System.Drawing;
using System.IO;
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
        private void Form_Gamejam_Planner_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"saved.txt") == true)
            {
                using (StreamReader sr = new StreamReader(@"saved.txt"))
                {
                    {
                        textBoxTheme.Text = sr.ReadLine();
                        textBoxName.Text = sr.ReadLine();
                        textBoxGenre.Text = sr.ReadLine();
                        textBoxArtStyle.Text = sr.ReadLine();
                        textBoxGameEngine.Text = sr.ReadLine();

                        richTextBoxDy.Text = sr.ReadLine();
                        richTextBoxMec.Text = sr.ReadLine();
                        richTextBoxCl.Text = sr.ReadLine();
                        richTextBoxMet.Text = sr.ReadLine();
                        richTextBoxCh.Text = sr.ReadLine();
                        richTextBoxOb.Text = sr.ReadLine();
                        richTextBoxAn.Text = sr.ReadLine();
                        richTextBoxMus.Text = sr.ReadLine();
                        richTextBoxSo.Text = sr.ReadLine();
                    }
                }
            }

            if (File.Exists(@"ui.jpg") == true)
            {
                pictureBoxUi.Image = Image.FromFile(@"ui.jpg");
            }
            if (File.Exists(@"menu.jpg") == true)
            {
                pictureBoxMenu.Image = Image.FromFile(@"menu.jpg");
            }
            if (File.Exists(@"background.jpg") == true)
            {
                pictureBoxBackground.Image = Image.FromFile(@"background.jpg");
            }
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
        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(@"saved.txt"))
            {
                sw.WriteLine(textBoxTheme.Text + "\n" + "----");
                sw.WriteLine(textBoxName.Text + "\n" + "----");
                sw.WriteLine(textBoxGenre.Text + "\n" + "----");
                sw.WriteLine(textBoxArtStyle.Text + "\n" + "----");
                sw.WriteLine(textBoxGameEngine.Text + "\n" + "----");

                sw.WriteLine(richTextBoxDy.Text + "\n" + "----");
                sw.WriteLine(richTextBoxMec.Text + "\n" + "----");
                sw.WriteLine(richTextBoxCl.Text + "\n" + "----");
                sw.WriteLine(richTextBoxMet.Text + "\n" + "----");
                sw.WriteLine(richTextBoxCh.Text + "\n" + "----");
                sw.WriteLine(richTextBoxOb.Text + "\n" + "----");
                sw.WriteLine(richTextBoxAn.Text + "\n" + "----");
                sw.WriteLine(richTextBoxMus.Text + "\n" + "----");
                sw.WriteLine(richTextBoxSo.Text + "\n" + "----");
            }

            if (pictureBoxUi.Image != null)
            {
                pictureBoxUi.Image.Save(@"ui.jpg");
            }
            if (pictureBoxMenu.Image != null)
            {
                pictureBoxMenu.Image.Save(@"menu.jpg");
            }
            if (pictureBoxBackground.Image != null)
            {
                pictureBoxBackground.Image.Save(@"background.jpg");
            }

        }
        private void pictureBoxUi_Click(object sender, EventArgs e)
        {
            pictureBoxUi.Image = ImageImporter(pictureBoxUi).Image;
        }
        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            pictureBoxMenu.Image = ImageImporter(pictureBoxMenu).Image;
        }
        private void pictureBoxBackground_Click(object sender, EventArgs e)
        {
            pictureBoxBackground.Image = ImageImporter(pictureBoxBackground).Image;
        }
        private PictureBox ImageImporter(PictureBox pictureBox)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = Image.FromFile(ofd.FileName);
                }
            }

            return pictureBox;
        }

    }
}
