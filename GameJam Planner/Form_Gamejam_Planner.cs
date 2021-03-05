using Newtonsoft.Json; //uzantılıradan json yüklenmesi gerekmetedir.(NuPaket)
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace GameJam_Planner
{
    public partial class Form_Gamejam_Planner : Form
    {
        public Form_Gamejam_Planner()
        {
            InitializeComponent();
        }
        private void Form_Gamejam_Planner_Load(object sender, EventArgs e)
        {
            string[] Engines = new string[] { "Unity", "Unreal", "Godot", "CryEngine", "GameMaker" };

            for (int i = 0; i < Engines.Length; i++)
            {
                comboBoxEngines.Items.Add(Engines[i]);
            }

            MyJson mj = new MyJson();
            mj = JsonConvert.DeserializeObject<MyJson>(File.ReadAllText(@"Deneme.json"));

            LoadPage(mj, "");

        }
        public void LoadPage(MyJson mj, string komut)
        {
            textBoxGroupName.Text = mj.Group;
            textBoxTheme.Text = mj.Theme;
            textBoxName.Text = mj.Name;
            textBoxGenre.Text = mj.Genre;
            textBoxArtStyle.Text = mj.ArtStyle;
            comboBoxEngines.SelectedItem = mj.GameEngine;
            richTextBoxDy.Text = mj.Dynamics;
            richTextBoxMec.Text = mj.Mechanics;
            richTextBoxCl.Text = mj.Classes;
            richTextBoxMet.Text = mj.Methods;
            richTextBoxCh.Text = mj.Characters;
            richTextBoxOb.Text = mj.Objects;
            richTextBoxAn.Text = mj.Animations;
            richTextBoxMus.Text = mj.Musics;
            richTextBoxSo.Text = mj.Sounds;

            if (File.Exists(@"ui.jpg"))
            {
                if (mj.UI != null)
                {
                    pictureBoxUi.Image = Image.FromFile(mj.UI);
                    buttonUiDeleter.Enabled = true;
                }
            }
            if (File.Exists(@"menu.jpg"))
            {
                if (mj.Menu != null)
                {
                    pictureBoxMenu.Image = Image.FromFile(mj.Menu);
                    buttonMenuDeleter.Enabled = true;
                }
            }
            if (File.Exists(@"background.jpg"))
            {
                if (mj.Background != null)
                {
                    pictureBoxBackground.Image = Image.FromFile(mj.Background);
                    buttonBackgroundDeleter.Enabled = true;
                }
            }

            if (komut == "clear")
            {
                ImageRemover(pictureBoxUi, "ui.jpg", buttonUiDeleter);
                ImageRemover(pictureBoxMenu, "menu.jpg", buttonMenuDeleter);
                ImageRemover(pictureBoxBackground, "background.jpg", buttonBackgroundDeleter);
            }



        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            MyJson mj = new MyJson();

            if (comboBoxEngines.SelectedItem != null)
            {
                mj.GameEngine = comboBoxEngines.SelectedItem.ToString();
            }

            mj.Group = textBoxGroupName.Text;
            mj.Theme = textBoxTheme.Text;
            mj.Name = textBoxName.Text;
            mj.Genre = textBoxGenre.Text;
            mj.ArtStyle = textBoxArtStyle.Text;
            mj.Animations = richTextBoxAn.Text;
            mj.Characters = richTextBoxCh.Text;
            mj.Dynamics = richTextBoxDy.Text;
            mj.Mechanics = richTextBoxMec.Text;
            mj.Classes = richTextBoxCl.Text;
            mj.Methods = richTextBoxMet.Text;
            mj.Objects = richTextBoxOb.Text;
            mj.Musics = richTextBoxMus.Text;
            mj.Sounds = richTextBoxSo.Text;

            if (pictureBoxUi.Image != null)
            {
                mj.UI = "ui.jpg";
            }
            if (pictureBoxMenu.Image != null)
            {
                mj.Menu = "menu.jpg";
            }
            if (pictureBoxBackground.Image != null)
            {
                mj.Background = "background.jpg";
            }

            string myjson = JsonConvert.SerializeObject(mj);
            File.WriteAllText(@"Deneme.json", myjson);

            MessageBox.Show("Saved.");
        }
        private void button_Print_Click(object sender, EventArgs e)
        {
            Class_Print cp = new Class_Print();

            string[] MainLines = { textBoxGroupName.Text, textBoxTheme.Text, textBoxName.Text, textBoxGenre.Text, textBoxArtStyle.Text };

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

        #region ImageImport
        private void pictureBoxUi_Click(object sender, EventArgs e)
        {
            pictureBoxUi.Image = ImageImporter(pictureBoxUi, "ui.jpg", buttonUiDeleter).Image;
        }
        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {

            pictureBoxMenu.Image = ImageImporter(pictureBoxMenu, "menu.jpg", buttonMenuDeleter).Image;

        }
        private void pictureBoxBackground_Click(object sender, EventArgs e)
        {
            pictureBoxBackground.Image = ImageImporter(pictureBoxBackground, "background.jpg", buttonBackgroundDeleter).Image;
        }
        private PictureBox ImageImporter(PictureBox pictureBox, string name, Button button)
        {
            if (File.Exists(name))
            {
                pictureBox.Image.Dispose();
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox.Image = Image.FromFile(ofd.FileName);
                        File.Copy(ofd.FileName, name, true);
                        button.Enabled = true;
                    }
                }
            }
            else
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox.Image = Image.FromFile(ofd.FileName);
                        File.Copy(ofd.FileName, name, true);
                        button.Enabled = true;
                    }
                }
            }

            return pictureBox;
        }

        #endregion

        #region ImageRemove

        private void ImageRemover(PictureBox pictureBox, string filename, Button button)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
                File.Delete(filename);
                pictureBox.Image = Image.FromFile(@"default\default.jpg");
                button.Enabled = false;
            }
        }
        private void buttonUiDeleter_Click(object sender, EventArgs e)
        {
            ImageRemover(pictureBoxUi, "ui.jpg", buttonUiDeleter);
        }

        private void buttonMenuDeleter_Click(object sender, EventArgs e)
        {
            ImageRemover(pictureBoxMenu, "menu.jpg", buttonMenuDeleter);
        }

        private void buttonBackgroundDeleter_Click(object sender, EventArgs e)
        {
            ImageRemover(pictureBoxBackground, "background.jpg", buttonBackgroundDeleter);
        }

        #endregion

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            LoadPage(new MyJson(), "clear");
        }
    }
}
