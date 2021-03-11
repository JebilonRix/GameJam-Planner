using System;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public partial class Form_Enter : Form
    {
        public static Form_Enter Enter_Form;
        Form_Board board = new Form_Board();

        public Form_Enter()
        {
            InitializeComponent();
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

        private void Form_Enter_Load(object sender, EventArgs e)
        {
            GetMainValues();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            board.ShowDialog();
            SaveMainValues();
            GetMainValues();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                textBoxGroupName.Text = "";
                textBoxTheme.Text = "";
                textBoxName.Text = "";
                textBoxGenre.Text = "";
                textBoxArtStyle.Text = "";
                comboBoxEngines.SelectedIndex = 0;


            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
