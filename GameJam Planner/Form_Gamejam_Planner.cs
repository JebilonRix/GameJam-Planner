using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace GameJam_Planner
{
    public partial class Form_Gamejam_Planner : Form
    {
        
        public int TextBoxCount = 6;
        public int RichTextBoxCount = 9;
        public int SumOfTextBox;

        public Form_Gamejam_Planner()
        {
            InitializeComponent();

            SumOfTextBox = RichTextBoxCount + TextBoxCount;

            tabPage1.Text = "Main";
            tabPage2.Text = "Code";
            tabPage3.Text = "Art";
            tabPage4.Text = "Sound";

            string[] Engines = new string[] { "Unity", "Unreal", "Godot", "CryEngine", "GameMaker" };

            for (int i = 0; i < Engines.Length; i++)
            {
                comboBoxEngines.Items.Add(Engines[i]);
            }

        }
        private void Form_Gamejam_Planner_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"saved.txt") == true)
            {
                string[] TxtLine = new string[TextBoxCount];
                string[] RichTxtLine = new string[RichTextBoxCount];

                using (StreamReader sr = new StreamReader(@"saved.txt"))
                {
                    {
                        int i = 0;

                        while (i < SumOfTextBox)
                        {
                            string x = sr.ReadLine().Trim();

                            if (x == "----")
                            {
                                i++;
                            }
                            else if (i < TextBoxCount && x != "----")
                            {
                                TxtLine[i] += x;
                            }
                            else if (TextBoxCount <= i && x != "----" && i < SumOfTextBox)
                            {
                                RichTxtLine[i - TextBoxCount] += x + '\n';
                            }
                        }
                    }

                    textBoxGroupName.Text = TxtLine[0];
                    textBoxTheme.Text = TxtLine[1];
                    textBoxName.Text = TxtLine[2];
                    textBoxGenre.Text = TxtLine[3];
                    textBoxArtStyle.Text = TxtLine[4];
                    comboBoxEngines.SelectedItem = TxtLine[5];

                    richTextBoxDy.Text = RichTxtLine[0];
                    richTextBoxMec.Text = RichTxtLine[1];
                    richTextBoxCl.Text = RichTxtLine[2];
                    richTextBoxMet.Text = RichTxtLine[3];
                    richTextBoxCh.Text = RichTxtLine[4];
                    richTextBoxOb.Text = RichTxtLine[5];
                    richTextBoxAn.Text = RichTxtLine[6];
                    richTextBoxMus.Text = RichTxtLine[7];
                    richTextBoxSo.Text = RichTxtLine[8];
                }
            }


            string j;
            
            using (StreamReader sr = new StreamReader(@"Deneme.json"))
            {
                 j = sr.ReadToEnd();
            }


            MyJson mj = new MyJson();
            mj = JsonConvert.DeserializeObject<MyJson>(File.ReadAllText(@"Deneme.json"));

            Debug.WriteLine(mj.Dynamics);

            

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
        private void buttonSave_Click(object sender, EventArgs e)
        {
            MyJson mj = new MyJson();

            

            mj.Animations = "";

            if (comboBoxEngines.SelectedItem != null)
            {
                textBoxGameEngine.Text = comboBoxEngines.SelectedItem.ToString();
                mj.GameEngine = comboBoxEngines.SelectedItem.ToString();
            }


            


            string[] TextBoxArray = new string[] { textBoxGroupName.Text,textBoxTheme.Text, textBoxName.Text, textBoxGenre.Text,
            textBoxArtStyle.Text,textBoxGameEngine.Text,richTextBoxDy.Text,richTextBoxMec.Text,richTextBoxCl.Text,richTextBoxMet.Text,
            richTextBoxCh.Text,richTextBoxOb.Text,richTextBoxAn.Text,richTextBoxMus.Text,richTextBoxSo.Text};

            string intermediacy = "----";

            mj.Group = TextBoxArray[0];
            mj.Theme = TextBoxArray[1];
            mj.Name = TextBoxArray[2];
            mj.Genre = TextBoxArray[3];
            mj.ArtStyle = TextBoxArray[4];
            mj.Dynamics = richTextBoxDy.Text;
            mj.UI = @"ui.jpg";

            string myjson = JsonConvert.SerializeObject(mj);

            File.WriteAllText(@"Deneme.json", myjson);


            using (StreamWriter sw = new StreamWriter(@"saved.txt"))
            {
                for (int i = 0; i < TextBoxArray.Length; i++)
                {
                    sw.WriteLine(TextBoxArray[i]);
                    sw.WriteLine(intermediacy);
                }
            }

            if (pictureBoxUi.Image != null)
            {
                ImageSaveController(pictureBoxUi, "ui.jpg");
            }
            if (pictureBoxMenu.Image != null)
            {
                ImageSaveController(pictureBoxMenu, "menu.jpg");
            }
            if (pictureBoxBackground.Image != null)
            {
                ImageSaveController(pictureBoxBackground, "background.jpg");
            }
        }
        private void button_Print_Click(object sender, EventArgs e)
        {
            Class_Print cp = new Class_Print();

            string[] MainLines = { textBoxGroupName.Text, textBoxTheme.Text, textBoxName.Text, textBoxGenre.Text, textBoxArtStyle.Text, textBoxGameEngine.Text };

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
        private void ImageSaveController(PictureBox pictureBox, string FileName)
        {
            if (File.Exists(@"FileName") == true)
            {
                File.Delete(@"FileName");

                string Fuat="Fuat";




                pictureBox.Image.Save(@Fuat);
                FileName = Fuat;

                pictureBox.Image.Save(@FileName);
            }
            else
            {
                pictureBox.Image.Save(@"FileName");
            }
        }

    }
}
