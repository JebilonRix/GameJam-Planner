using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public partial class Form_Board : Form
    {
        public static Form_Board Board;
        public Form_Board()
        {
            InitializeComponent();
            Class_Spawner.Spawner = new Class_Spawner();
            Class_Depo.Depo = new Class_Depo();
        }
        private void Form_Board_Load(object sender, EventArgs e)
        {
            Class_Depo.Depo.DataTableDepo.Columns.Add("Type", typeof(string));
            Class_Depo.Depo.DataTableDepo.Columns.Add("ID", typeof(int));
            Class_Depo.Depo.DataTableDepo.Columns.Add("Title", typeof(string));
            Class_Depo.Depo.DataTableDepo.Columns.Add("Location", typeof(string));
            Class_Depo.Depo.DataTableDepo.Columns.Add("Lock", typeof(bool));
            Class_Depo.Depo.DataTableDepo.Columns.Add("Content1", typeof(string));
            Class_Depo.Depo.DataTableDepo.Columns.Add("Content2", typeof(string));

            dataGridView1.DataSource = Class_Depo.Depo.DataTableDepo;
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            //Class_Depo.Depo.Updates();
            Class_Depo.Depo.Writer(Class_Spawner.Spawner.box_id + Class_Spawner.Spawner.pic_id + Class_Spawner.Spawner.do_id);
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
            SpawnBox();
        }
        private void ImageBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpawnPic();
        }
        private void toDoBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpawnToDo();
        }
        private void RightClickToDo_Click(object sender, EventArgs e)
        {
            SpawnToDo();
        }
        private void RightClickPicture_Click(object sender, EventArgs e)
        {
            SpawnPic();
        }
        private void RightClickBox_Click(object sender, EventArgs e)
        {
            SpawnBox();
        }

        private void SpawnBox()
        {
            Point cp = PointToClient(Cursor.Position);
            Class_Spawner.Spawner.SpawnLocation = new Point(cp.X, cp.Y);
            var BoxSpawn = Class_Spawner.Spawner.Spawn_Group();
            this.Controls.Add(BoxSpawn);

        }
        private void SpawnPic()
        {
            Point cp = PointToClient(Cursor.Position);
            Class_Spawner.Spawner.SpawnLocation = new Point(cp.X, cp.Y);
            var BoxSpawn = Class_Spawner.Spawner.Spawn_Picture();
            this.Controls.Add(BoxSpawn);
        }
        private void SpawnToDo()
        {
            Point cp = PointToClient(Cursor.Position);
            Class_Spawner.Spawner.SpawnLocation = new Point(cp.X, cp.Y);
            var BoxSpawn = Class_Spawner.Spawner.Spawn_ToDo();
            this.Controls.Add(BoxSpawn);
        }
        private void changeBackcolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = cd.Color;
                }
            }
        }
    }
}
