using System;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public partial class Form_Gamejam_Planner : Form
    {

        public Form_Gamejam_Planner()
        {
            InitializeComponent();
            Class_Spawner.Spawner = new Class_Spawner();
            //this.MouseClick += groupBoxMouseClick;
            //this.MouseClick += pictureBoxClick;
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
            Class_Spawner.Spawner.Spawn_Group(e);
            this.Controls.Add(Class_Spawner.Spawner.Spawn_Group(e));
        }
        private void ImageBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_Spawner.Spawner.Spawn_Picture();
            this.Controls.Add(Class_Spawner.Spawner.Spawn_Picture());
        }
    }
}
