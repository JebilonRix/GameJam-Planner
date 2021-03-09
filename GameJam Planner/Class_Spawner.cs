using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public class Class_Spawner
    {
        public static Class_Spawner Spawner;

        public CustomGroupBox Spawn_Group()
        {
            CustomGroupBox groupBox = new CustomGroupBox();

            groupBox.Text = "GroupBox";
            CommonsFeatures(groupBox);
            RichTextBox richTextBox = new RichTextBox();

            richTextBox.Location = new Point(6, 45);
            richTextBox.Size = new Size(220, 150);
            richTextBox.ForeColor = Color.Black;
            richTextBox.BackColor = Color.White;
            richTextBox.Font = new Font("Arial", 12.25F, FontStyle.Bold, GraphicsUnit.Point);

            groupBox.Controls.Add(richTextBox);

            return groupBox;
        }
        public CustomGroupBox Spawn_Picture()
        {
            CustomGroupBox groupBox = new CustomGroupBox();

            groupBox.Text = "PictureBox";
            CommonsFeatures(groupBox);
            PictureBox pictureBox = new PictureBox();

            pictureBox.Location = new Point(6, 45);
            pictureBox.Size = new Size(220, 150);
            pictureBox.ForeColor = Color.Black;
            pictureBox.BackColor = Color.White;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = Image.FromFile(@"Assets\default.jpg");

            groupBox.Controls.Add(pictureBox);

            return groupBox;
        }
        private void CommonsFeatures(CustomGroupBox groupBox)
        {
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

            groupBox.CustomGroupBoxLock(buttonLock);
            groupBox.isLocked = false;

            groupBox.Controls.Add(buttonLock);
        }

    }
}
