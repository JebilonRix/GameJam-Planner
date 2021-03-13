using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        }

        private void Form_Board_Load(object sender, EventArgs e)
        {
            GetMainValues();

            if (!File.Exists(@"Note") || !File.Exists(@"Picture") || !File.Exists(@"ToDo")) { return; }
            List<JsonNoteBox> Panter = new List<JsonNoteBox>();
            List<JsonPictureBox> Noir = new List<JsonPictureBox>();
            List<JsonToDoBox> Queen = new List<JsonToDoBox>();

            using (StreamReader sr = new StreamReader(@"Note"))
            {
                string noteJsonInput = sr.ReadToEnd();
                Panter = JsonConvert.DeserializeObject<List<JsonNoteBox>>(noteJsonInput);
            }
            using (StreamReader sr = new StreamReader(@"Picture"))
            {
                string noteJsonInput = sr.ReadToEnd();
                Noir = JsonConvert.DeserializeObject<List<JsonPictureBox>>(noteJsonInput);
            }

            using (StreamReader sr = new StreamReader(@"ToDo"))
            {
                string noteJsonInput = sr.ReadToEnd();
                Queen = JsonConvert.DeserializeObject<List<JsonToDoBox>>(noteJsonInput);
            }

            foreach (var item in Panter)
            {
                CustomGroupBox cb = Class_Spawner.Spawner.Spawn_Note_With_Json(item);
                this.Controls.Add(cb);
            }
            foreach (var item in Noir)
            {
                CustomGroupBox cb = Class_Spawner.Spawner.Spawn_Picture_With_Json(item);
                this.Controls.Add(cb);
            }
            foreach (var item in Queen)
            {
                CustomGroupBox cb = Class_Spawner.Spawner.Spawn_ToDo_With_Json(item);
                this.Controls.Add(cb);
            }

        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMainValues();

            List<JsonNoteBox> Panter = new List<JsonNoteBox>();
            foreach (var item in Class_Spawner.Spawner.MyBoxesNote)
            {
                Panter.Add(item.ConvertJsonNoteBox());
            }
            string MyNoteJson = JsonConvert.SerializeObject(Panter);
            using (StreamWriter sr = new StreamWriter(@"Note")) { sr.Write(MyNoteJson); }

            List<JsonPictureBox> Noir = new List<JsonPictureBox>();
            foreach (var item in Class_Spawner.Spawner.MyBoxesPicture)
            {
                Noir.Add(item.ConvertJsonPictureBox());
            }
            string MyPictureJson = JsonConvert.SerializeObject(Noir);
            using (StreamWriter sr = new StreamWriter(@"Picture")) { sr.Write(MyPictureJson); }

            List<JsonToDoBox> Queen = new List<JsonToDoBox>();
            foreach (var item in Class_Spawner.Spawner.MyBoxesToDo)
            {
                Queen.Add(item.ConvertJsonToDoBox());
            }
            string MyToDoJson = JsonConvert.SerializeObject(Queen);
            using (StreamWriter sr = new StreamWriter(@"ToDo")) { sr.Write(MyToDoJson); }
            if (!exiting)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                Debug.WriteLine("Saved");
            }
            
        }
        private void ClearMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Clear", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                foreach (var item in Class_Spawner.Spawner.MyBoxesNote)
                {
                    item.Dispose();
                }
                foreach (var item in Class_Spawner.Spawner.MyBoxesPicture)
                {
                    item.Dispose();
                }
                foreach (var item in Class_Spawner.Spawner.MyBoxesToDo)
                {
                    item.Dispose();
                }

                Class_Spawner.Spawner.MyBoxesNote = new List<CustomGroupBox>();
                Class_Spawner.Spawner.MyBoxesPicture = new List<CustomGroupBox>();
                Class_Spawner.Spawner.MyBoxesToDo = new List<CustomGroupBox>();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                comboBox1.SelectedItem = null;
            }


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
            closeProgram(sender, e);
        }

        public bool exiting = false;
        private void Form_Board_FormClosing(object sender, FormClosingEventArgs e)
        {    
            closeProgram(sender, e);
        }

        void closeProgram(object sender, EventArgs e)
        {
            if (exiting)
            {
                Application.Exit();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    exiting = true;
                    saveToolStripMenuItem_Click(sender, e);
                    Application.Exit();
                }
            }
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
            var BoxSpawn = Class_Spawner.Spawner.Spawn_Note();
            this.Controls.Add(BoxSpawn);
        }
        private void SpawnPic()
        {
            Point cp = PointToClient(Cursor.Position);
            Class_Spawner.Spawner.SpawnLocation = new Point(cp.X, cp.Y);
            var BoxSpawn = Class_Spawner.Spawner.Spawn_Picture();
            try
            {
                this.Controls.Add(BoxSpawn);
            }
            catch (Exception)
            {
            }
            
        }
        private void SpawnToDo()
        {
            Point cp = PointToClient(Cursor.Position);
            Class_Spawner.Spawner.SpawnLocation = new Point(cp.X, cp.Y);
            var BoxSpawn = Class_Spawner.Spawner.Spawn_ToDo();
            this.Controls.Add(BoxSpawn);
        }


        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = true;
            panelMain.Enabled = true;
        }
        public void GetMainValues()
        {
            textBox1.Text = Properties.Settings.Default.Group;
            textBox2.Text = Properties.Settings.Default.Name;
            textBox3.Text = Properties.Settings.Default.Theme;
            textBox4.Text = Properties.Settings.Default.Genre;
            textBox5.Text = Properties.Settings.Default.ArtStyle;
            comboBox1.SelectedItem = Properties.Settings.Default.GameEngine;
        }
        public void SaveMainValues()
        {
            Properties.Settings.Default.Group = textBox1.Text;
            Properties.Settings.Default.Name = textBox2.Text;
            Properties.Settings.Default.Theme = textBox3.Text;
            Properties.Settings.Default.Genre = textBox4.Text;
            Properties.Settings.Default.ArtStyle = textBox5.Text;

            if (comboBox1.SelectedItem != null)
            {
                Properties.Settings.Default.GameEngine = comboBox1.SelectedItem.ToString();
            }
            else
            {
                Properties.Settings.Default.GameEngine = comboBox1.Text;
            }

            Properties.Settings.Default.Save();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelMain.Enabled = false;
        }

    }
}
