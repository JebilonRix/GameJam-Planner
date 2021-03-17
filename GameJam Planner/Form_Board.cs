using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace GameJam_Planner
{
    public partial class Form_Board : Form
    {
        public static Form_Board Board;
        public DataTable tb = new DataTable();
        private string SavePath;

        public Form_Board()
        {
            InitializeComponent();
            Spawn_Box.Spawner = new Spawn_Box();
            this.KeyDown += new KeyEventHandler(Form_Board_KeyDown);
            tb.Columns.Add("Situation", typeof(bool));
            tb.Columns.Add("Task", typeof(string));
            tb.Columns.Add("Managing", typeof(string));
            tb.AcceptChanges();

            dataGridViewSummary.DataSource = tb;
        }
        private void Form_Board_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.Color;
            this.Controls.Add(panelMain);
            this.Controls.Add(panelSummary);
            this.Controls.Add(panelMenu);
            this.KeyPreview = true;
        }
        private void OrtakSeyler(int type)
        {
            Point cp = PointToClient(Cursor.Position);
            Spawn_Box.Spawner.SpawnLocation = new Point(cp.X, cp.Y);
            var BoxSpawn = Spawn_Box.Spawner.Spawn_A_Box(type);
            this.Controls.Add(BoxSpawn);
            BoxSpawn.BringToFront();
        }
        public void GetMainValues(string location)
        {
            List<JsonBox> Panter = new List<JsonBox>();

            using (StreamReader sr = new StreamReader(location))
            {
                string noteJsonInput = sr.ReadToEnd();
                Panter = JsonConvert.DeserializeObject<List<JsonBox>>(noteJsonInput);
            }
            foreach (var item in Panter)
            {
                switch (item.BoxType)
                {
                    case "note":
                        CustomGroupBox cc = Spawn_Box.Spawner.Spawn_Json_A_Box(0, item);
                        this.Controls.Add(cc); break;
                    case "pic":
                        CustomGroupBox aa = Spawn_Box.Spawner.Spawn_Json_A_Box(1, item);
                        this.Controls.Add(aa); break;
                    case "do":
                        CustomGroupBox bb = Spawn_Box.Spawner.Spawn_Json_A_Box(2, item);
                        this.Controls.Add(bb); break;
                    default: break;
                }
            }

            textBox1.Text = Properties.Settings.Default.Group;
            textBox2.Text = Properties.Settings.Default.Name;
            textBox3.Text = Properties.Settings.Default.Theme;
            textBox4.Text = Properties.Settings.Default.Genre;
            textBox5.Text = Properties.Settings.Default.ArtStyle;
            comboBox1.SelectedItem = Properties.Settings.Default.GameEngine;
        }
        public void SetMainValues(string location)
        {
            List<JsonBox> Skull = new List<JsonBox>();
            foreach (var item in Spawn_Box.Spawner.MyBoxList) { Skull.Add(item.ConvertJsonBox()); }
            string MyBoxJson = JsonConvert.SerializeObject(Skull);
            using (StreamWriter sr = new StreamWriter(location)) { sr.Write(MyBoxJson); }

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

        private void RightClickNote_Click(object sender, EventArgs e)
        {
            OrtakSeyler(0);
        }
        private void RightClickPicture_Click(object sender, EventArgs e)
        {
            try { OrtakSeyler(1); }
            catch (Exception) { }
        }
        private void RightClickToDo_Click(object sender, EventArgs e)
        {
            OrtakSeyler(2);
        }
        private void Form_Board_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SetMainValues(SavePath);
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

        private void buttonMain_Click(object sender, EventArgs e)
        {
            panelMain.Visible = true;
            panelMain.Enabled = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelMain.Enabled = false;
        }
        private void buttonSummary_Click(object sender, EventArgs e)
        {
            panelSummary.Enabled = true;
            panelSummary.Visible = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            panelSummary.Visible = false;
            panelSummary.Enabled = false;
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            foreach (var item in Spawn_Box.Spawner.MyBoxList)
            {
                item.Dispose();
            }

            Spawn_Box.Spawner.MyBoxList = new List<CustomGroupBox>();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.SelectedItem = null;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    SavePath = ofd.FileName;
                    GetMainValues(ofd.FileName);
                    MessageBox.Show("Ta-daa");
                }
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    SetMainValues(sfd.FileName);
                    SavePath = sfd.FileName;
                    MessageBox.Show("Saved");
                }
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Clear", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                foreach (var item in Spawn_Box.Spawner.MyBoxList)
                {
                    item.Dispose();
                }

                Spawn_Box.Spawner.MyBoxList = new List<CustomGroupBox>();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                comboBox1.SelectedItem = null;

                this.BackColor = Color.FromArgb(64, 64, 64);
            }
        }
        private void buttonCredits_Click(object sender, EventArgs e)
        {
            string credits = ":Coder:" + "\n" + "\n" + "Fuat Can ERYİĞİT" + "\n" + "\n" + ":Special Thanks:" + "\n" + "\n"
                + "Muzaffer Erkan KÜPÇÜK" + "\n" + "Taha Buğra ŞENEL" + "\n" + "Tecelli AKINTUĞ" + "\n" + "Özge Selen BULGU";
            MessageBox.Show(credits);
        }
        private void buttonHints_Click(object sender, EventArgs e)
        {
            string message = "Please, press your right mouse button for adding boxes.";
            MessageBox.Show(message);
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to save?", "Exit", MessageBoxButtons.YesNoCancel);

            switch (dialog)
            {
                case DialogResult.Yes:
                    if (SavePath == null)
                    {
                        using (SaveFileDialog sfd = new SaveFileDialog())
                        {
                            if (sfd.ShowDialog() == DialogResult.OK)
                            {
                                SetMainValues(sfd.FileName);
                                SavePath = sfd.FileName;
                            }
                        }
                    }
                    SetMainValues(SavePath); 
                    Application.Exit(); break;
                case DialogResult.No: Application.Exit(); break;
                case DialogResult.Cancel: break;
            }


        }
    }
}
