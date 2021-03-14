using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace GameJam_Planner
{
    public partial class Form_Board : Form
    {
        public static Form_Board Board;
        bool exiting = false;

        public Form_Board()
        {
            InitializeComponent();
            Class_Spawner.Spawner = new Class_Spawner();
            this.KeyDown += new KeyEventHandler(Form_Board_KeyDown);
        }

        private void Form_Board_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            GetMainValues();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMainValues();
            if (!exiting)
            {
                MessageBox.Show("Saved");
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
            string message = "Please, press your right mouse button for adding boxes.";
            MessageBox.Show(message);
        }
        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string credits = ":Coders:" + "\n" + "\n" + "Fuat Can ERYİĞİT" + "\n" + "Muzaffer Erkan Küpçük" + "\n" + "Taha Buğra ŞENEL" + "\n" + "\n" + ":Special Thanks:" + "\n" + "\n" + "Tecelli Akıntuğ" + "\n" + "Özge Selen Bulgu";
            MessageBox.Show(credits);
        }
        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = true;
            panelMain.Enabled = true;
        }
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            closeProgram(sender, e, "Menu");
        }
        private void Form_Board_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeProgram(sender, e, "x");
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
        private void button3_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelMain.Enabled = false;
        }
        private void Form_Board_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveMainValues();
                e.SuppressKeyPress = true;
                PopupNotifier pop = new PopupNotifier();
                pop.TitleText = "Planner";
                pop.TitleColor = Color.Red;
                pop.ContentText = "Saved";
                pop.ContentColor = Color.Red;
                pop.BodyColor = Color.Black;
                pop.Popup();
            }
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
                //We'll bang, OK!
            }

        }
        private void SpawnToDo()
        {
            Point cp = PointToClient(Cursor.Position);
            Class_Spawner.Spawner.SpawnLocation = new Point(cp.X, cp.Y);
            var BoxSpawn = Class_Spawner.Spawner.Spawn_ToDo();
            this.Controls.Add(BoxSpawn);
        }


        public void GetMainValues()
        {
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
            textBox1.Text = Properties.Settings.Default.Group;
            textBox2.Text = Properties.Settings.Default.Name;
            textBox3.Text = Properties.Settings.Default.Theme;
            textBox4.Text = Properties.Settings.Default.Genre;
            textBox5.Text = Properties.Settings.Default.ArtStyle;
            comboBox1.SelectedItem = Properties.Settings.Default.GameEngine;
            this.BackColor = Properties.Settings.Default.Color;
        }
        public void SaveMainValues()
        {
            List<JsonNoteBox> Panter = new List<JsonNoteBox>();
            foreach (var item in Class_Spawner.Spawner.MyBoxesNote) { Panter.Add(item.ConvertJsonNoteBox()); }
            string MyNoteJson = JsonConvert.SerializeObject(Panter);
            using (StreamWriter sr = new StreamWriter(@"Note")) { sr.Write(MyNoteJson); }

            List<JsonPictureBox> Noir = new List<JsonPictureBox>();
            foreach (var item in Class_Spawner.Spawner.MyBoxesPicture) { Noir.Add(item.ConvertJsonPictureBox()); }
            string MyPictureJson = JsonConvert.SerializeObject(Noir);
            using (StreamWriter sr = new StreamWriter(@"Picture")) { sr.Write(MyPictureJson); }

            List<JsonToDoBox> Queen = new List<JsonToDoBox>();
            foreach (var item in Class_Spawner.Spawner.MyBoxesToDo) { Queen.Add(item.ConvertJsonToDoBox()); }
            string MyToDoJson = JsonConvert.SerializeObject(Queen);
            using (StreamWriter sr = new StreamWriter(@"ToDo")) { sr.Write(MyToDoJson); }

            Properties.Settings.Default.Group = textBox1.Text;
            Properties.Settings.Default.Name = textBox2.Text;
            Properties.Settings.Default.Theme = textBox3.Text;
            Properties.Settings.Default.Genre = textBox4.Text;
            Properties.Settings.Default.ArtStyle = textBox5.Text;
            Properties.Settings.Default.Color = this.BackColor;

            if (comboBox1.SelectedItem != null) { Properties.Settings.Default.GameEngine = comboBox1.SelectedItem.ToString(); }
            else { Properties.Settings.Default.GameEngine = comboBox1.Text; }

            Properties.Settings.Default.Save();
        }
        private void closeProgram(object sender, EventArgs e, string exitingtype)
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
                else if (dialog == DialogResult.No && exitingtype == "x")
                {
                    var f = e as FormClosingEventArgs;
                    f.Cancel = true;
                }
            }
        }

    }
}
