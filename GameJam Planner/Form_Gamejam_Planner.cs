using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public partial class Form_Gamejam_Planner : Form
    {
        CustomGroupBox ActiveGroupBox;
        RichTextBox ActiveRichTextBox;
        PictureBox ActivePicturetBox;
        private int switch_on;

        Class_Spawner Spawner = new Class_Spawner();
        public Form_Gamejam_Planner()
        {
            InitializeComponent();
            this.MouseClick += groupBoxMouseClick;
            this.MouseClick += pictureBoxClick;
        }
        private void Form_Gamejam_Planner_Load(object sender, EventArgs e)
        {
            string[] Engines = new string[] { "Unity", "Unreal", "Godot", "CryEngine", "GameMaker" };

            for (int i = 0; i < Engines.Length; i++)
            {
                comboBoxEngines.Items.Add(Engines[i]);
            }

            textBoxGroupName.Text = "";
            textBoxTheme.Text = "";
            textBoxName.Text = "";
            textBoxGenre.Text = "";
            textBoxArtStyle.Text = "";
            comboBoxEngines.SelectedItem = "";
        }
        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBoxEngines.SelectedItem != null)
            {

            }
            MessageBox.Show("Saved.");
        } //bitmedi
        private void ClearMenuItem_Click(object sender, EventArgs e)
        {
        }  //bitmedi
        private void HintsMenuItem_Click(object sender, EventArgs e)
        {
            string message = "You can add boxes like:" + "\n"
                + "\n" + "Coding: Dynamics, Methods"
                + "\n" + "Art Style: Characters, Objects, Animations"
                + "\n" + "Audio: Music, Foley";
            MessageBox.Show(message);
        }
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void noteBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomGroupBox groupBox = new CustomGroupBox();
            RichTextBox richTextBox = new RichTextBox();
            Spawner.Spawn_Group(groupBox, richTextBox);
            this.Controls.Add(groupBox);
            groupBox.MouseClick += groupBoxMouseClick;

            ActiveGroupBox = groupBox;
            ActiveRichTextBox = richTextBox;
            switch_on = 0;
        }
        private void ImageBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomGroupBox groupBox = new CustomGroupBox();
            PictureBox pictureBox = new PictureBox();
            Spawner.Spawn_Picture(groupBox, pictureBox);
            this.Controls.Add(groupBox);
            groupBox.MouseClick += groupBoxMouseClick;
            groupBox.MouseClick += pictureBoxClick;

            ActiveGroupBox = groupBox;
            ActivePicturetBox = pictureBox;
            switch_on = 1;
        }
        private void groupBoxMouseClick(object sender, MouseEventArgs e)
        {
            if (sender.GetType() == typeof(CustomGroupBox))
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.contextMenuStripOptions.Show();
                    contextMenuStripOptions.Left += CustomGroupBox.MousePosition.X;
                    contextMenuStripOptions.Top += CustomGroupBox.MousePosition.Y;
                }
            }
        }
        private void pictureBoxClick(object sender, MouseEventArgs e)
        {
            if (sender.GetType() == typeof(PictureBox))
            {
                if (e.Button == MouseButtons.Left)
                {
                    using (OpenFileDialog ofd = new OpenFileDialog())
                    {
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            ActivePicturetBox.Image = Image.FromFile(ofd.FileName);
                            Spawner.Spawn_Picture(ActiveGroupBox, ActivePicturetBox);
                            //File.Copy(ofd.FileName, "", true);
                        }
                    }
                }
            }
        }

        private void toolStripMenuItemName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }
        private void toolStripMenuItemColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    ActiveGroupBox.BackColor = cd.Color;

                    switch (switch_on)
                    {
                        case 0: Spawner.Spawn_Group(ActiveGroupBox, ActiveRichTextBox); break;
                        case 1: Spawner.Spawn_Picture(ActiveGroupBox, ActivePicturetBox); break;
                        default: break;
                    }


                }
            }
        }
        private void toolStripMenuItemDeleteTxt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3");
        }
        private void toolStripMenuItemDeletePic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4");
        }

    }
}
