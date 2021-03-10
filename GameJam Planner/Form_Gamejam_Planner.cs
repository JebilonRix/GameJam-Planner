﻿using System;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public partial class Form_Gamejam_Planner : Form
    {
        public Form_Gamejam_Planner()
        {
            InitializeComponent();
            Class_Spawner.Spawner = new Class_Spawner();
        }
        public void GetMainValues()
        {
            textBoxGroupName.Text = Properties.Settings.Default.Group;
            textBoxTheme.Text = Properties.Settings.Default.Theme;
            textBoxName.Text = Properties.Settings.Default.Name;
            textBoxGenre.Text = Properties.Settings.Default.Genre;
            textBoxArtStyle.Text = Properties.Settings.Default.ArtStyle;
            comboBoxEngines.SelectedItem = Properties.Settings.Default.GameEngine;
        }
        public void SaveMainValues()
        {
            Properties.Settings.Default.Group = textBoxGroupName.Text;
            Properties.Settings.Default.Theme = textBoxTheme.Text;
            Properties.Settings.Default.Name = textBoxName.Text;
            Properties.Settings.Default.Genre = textBoxGenre.Text;
            Properties.Settings.Default.ArtStyle = textBoxArtStyle.Text;

            if (comboBoxEngines.SelectedItem != null)
            {
                Properties.Settings.Default.GameEngine = comboBoxEngines.SelectedItem.ToString();
            }

            Properties.Settings.Default.Save();
        }
        private void Form_Gamejam_Planner_Load(object sender, EventArgs e)
        {
            GetMainValues();

            string[] Engines = new string[] { "Unity", "Unreal", "Godot", "CryEngine", "GameMaker" };

            for (int i = 0; i < Engines.Length; i++)
            {
                comboBoxEngines.Items.Add(Engines[i]);
            }

            comboBoxEngines.SelectedIndex = 0;
        }
        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            SaveMainValues();
            MessageBox.Show("Saved.");
            GetMainValues();
        }
        private void ClearMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                foreach (Control item in groupBoxMain.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                    else if (item is ComboBox)
                    {
                        item.Text = "-Select -";
                    }
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
            Application.Exit();
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
            var BoxSpawn = Class_Spawner.Spawner.Spawn_Group();
            this.Controls.Add(BoxSpawn);
        }
        private void Pic()
        {
            var BoxSpawn = Class_Spawner.Spawner.Spawn_Picture();
            this.Controls.Add(BoxSpawn);
        }
        private void ToDo()
        {
            var BoxSpawn = Class_Spawner.Spawner.Spawn_ToDo();
            this.Controls.Add(BoxSpawn);
        }


    }
}
