using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public partial class Form_Gamejam_Planner : Form
    {
        public Form_Gamejam_Planner()
        {
            InitializeComponent();
            this.MouseClick += AAA;
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
        } //bitmedi
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
            string message = "You can add boxes like:" + "\n" + "\n" + "Coding: Dynamics, Methods" + "\n" + "Art Style: Characters, Objects, Animations" + "\n" + "Audio: Music, Foley";
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
            groupBox.Text = "GroupBox";
            Spawn_Group(groupBox, richTextBox);

        }
        private void imageBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomGroupBox groupBox = new CustomGroupBox();
            PictureBox pictureBox = new PictureBox();
            groupBox.Text = "PictureBox";
            Spawn_Picture(groupBox, pictureBox);
        }
        private void soundBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomGroupBox groupBox = new CustomGroupBox();
            RichTextBox richTextBox = new RichTextBox();
            groupBox.Text = "SoundBox";
            Spawn_Group(groupBox, richTextBox);

        }
        private void Spawn_Group(CustomGroupBox groupBox, RichTextBox richTextBox)
        {
            this.Controls.Add(richTextBox);
            richTextBox.Location = new Point(6, 45);
            richTextBox.Size = new Size(220, 150);
            richTextBox.ForeColor = Color.Black;
            richTextBox.BackColor = Color.White;
            richTextBox.Font = new Font("Arial", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox.Controls.Add(richTextBox);
            Shaper(groupBox);
        }
        private void Spawn_Picture(CustomGroupBox groupBox, PictureBox pictureBox)
        {
            this.Controls.Add(pictureBox);
            pictureBox.Location = new Point(6, 45);
            pictureBox.Size = new Size(220, 150);
            pictureBox.ForeColor = Color.Black;
            pictureBox.BackColor = Color.White;
            pictureBox.Font = new Font("Arial", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox.Controls.Add(pictureBox);
            Shaper(groupBox);
        }
        private void Shaper(CustomGroupBox groupBox)
        {
            this.Controls.Add(groupBox);
            groupBox.Location = new Point(390, 50);
            groupBox.Size = new Size(230, 200);
            groupBox.ForeColor = Color.White;
            groupBox.Font = new Font("Arial", 15.25F, FontStyle.Bold, GraphicsUnit.Point);

            Button buttonLock = new Button();
            buttonLock.Location = new Point(200, 14);
            buttonLock.Size = new Size(20, 20);
            buttonLock.Text = "";
            buttonLock.ForeColor = Color.Black;
            buttonLock.BackColor = Color.White;
            buttonLock.BackgroundImage = Image.FromFile(@"Assets\kilit.png");
            groupBox.Controls.Add(buttonLock);

            groupBox.CustomGroupBoxLock(buttonLock);
            groupBox.isLocked = false;

            groupBox.MouseClick += AAA;

        }
        private void AAA(object sender, MouseEventArgs e)
        {
            if (sender.GetType() == typeof(CustomGroupBox))
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.contextMenuStripOptions.Show();
                    contextMenuStripOptions.Left += CustomGroupBox.MousePosition.X;
                    contextMenuStripOptions.Top += CustomGroupBox.MousePosition.Y;

                    int index = contextMenuStripOptions.Items.Count;

                    if (e.Button == MouseButtons.Left)
                    {
                        switch (index)
                        {
                            case 0: toolStripMenuItemName_Click(sender, e); break;
                           // case 1: toolStripMenuItemColor_Click(sender, e); break;
                            case 2: toolStripMenuItemDeleteTxt_Click(sender, e); break;
                            case 3: toolStripMenuItemDeletePic_Click(sender, e); break;

                            default: break;
                        }

                    }
                }
            }
        }

        private void toolStripMenuItemName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }
        private void toolStripMenuItemColor_Click(object sender, EventArgs e,CustomGroupBox groupBox)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    groupBox.BackColor = cd.Color;
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