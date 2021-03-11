using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public partial class Form_Board : Form
    {
        public static Point DefaultSpawnPoint = new Point(390, 50);

        public Form_Board()
        {
            InitializeComponent();
            Class_Spawner.Spawner = new Class_Spawner();
        }

        private void Form_Gamejam_Planner_Load(object sender, EventArgs e)
        {

        }
        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved.");
        }
        private void ClearMenuItem_Click(object sender, EventArgs e)
        {

        }
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
        private void showOpeningSceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Enter enter = new Form_Enter();
            enter.GetMainValues();
            this.Close();
            enter.ShowDialog();
        }

        private void noteBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Box();
        }
        private void ImageBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pic();
        }
        private void toDoBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToDo();
        }
        private void RightClickToDo_Click(object sender, EventArgs e)
        {
            ToDo();
        }
        private void RightClickPicture_Click(object sender, EventArgs e)
        {
            Pic();
        }
        private void RightClickBox_Click(object sender, EventArgs e)
        {
            Box();
        }

        private void Box()
        {
            Class_Spawner.Spawner.SpawnLocation = DefaultSpawnPoint;
            var BoxSpawn = Class_Spawner.Spawner.Spawn_Group();
            this.Controls.Add(BoxSpawn);
        }
        private void Pic()
        {
            Class_Spawner.Spawner.SpawnLocation = DefaultSpawnPoint;
            var BoxSpawn = Class_Spawner.Spawner.Spawn_Picture();
            this.Controls.Add(BoxSpawn);
        }
        private void ToDo()
        {
            Class_Spawner.Spawner.SpawnLocation = DefaultSpawnPoint;
            var BoxSpawn = Class_Spawner.Spawner.Spawn_ToDo();
            this.Controls.Add(BoxSpawn);
        }

    }
}
