using System.Drawing;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public class Class_Spawner
    {
        public static Class_Spawner Spawner;

        public CustomGroupBox Spawn_Group(CustomGroupBox groupBox, RichTextBox richTextBox)
        {
            groupBox.Text = "GroupBox";
            groupBox.Size = new Size(230, 200);
            groupBox.ForeColor = Color.White;
            groupBox.Font = new Font("Arial", 15.25F, FontStyle.Bold, GraphicsUnit.Point);

            richTextBox.Location = new Point(6, 45);
            richTextBox.Size = new Size(220, 150);
            richTextBox.ForeColor = Color.Black;
            richTextBox.BackColor = Color.White;
            richTextBox.Font = new Font("Arial", 12.25F, FontStyle.Bold, GraphicsUnit.Point);

            Button buttonLock = new Button();
            buttonLock.Location = new Point(200, 14);
            buttonLock.Size = new Size(20, 20);
            buttonLock.Text = "";
            buttonLock.ForeColor = Color.Black;
            buttonLock.BackColor = Color.White;
            buttonLock.BackgroundImage = Image.FromFile(@"Assets\kilit.png");

            groupBox.Controls.Add(richTextBox);
            groupBox.Controls.Add(buttonLock);
            groupBox.CustomGroupBoxLock(buttonLock);
            groupBox.isLocked = false;
            groupBox.Location = new Point(390, 50);

            return groupBox;

        }

        public CustomGroupBox Spawn_Group(CustomGroupBox groupBox) // simple version
        {
            var richTextBox = new RichTextBox();

            groupBox.Text = "GroupBox";
            groupBox.Size = new Size(230, 200);
            groupBox.ForeColor = Color.White;
            groupBox.Font = new Font("Arial", 15.25F, FontStyle.Bold, GraphicsUnit.Point);

            richTextBox.Location = new Point(6, 45);
            richTextBox.Size = new Size(220, 150);
            richTextBox.ForeColor = Color.Black;
            richTextBox.BackColor = Color.White;
            richTextBox.Font = new Font("Arial", 12.25F, FontStyle.Bold, GraphicsUnit.Point);

            Button buttonLock = new Button();
            buttonLock.Location = new Point(200, 14);
            buttonLock.Size = new Size(20, 20);
            buttonLock.Text = "";
            buttonLock.ForeColor = Color.Black;
            buttonLock.BackColor = Color.White;
            buttonLock.BackgroundImage = Image.FromFile(@"Assets\kilit.png");

            groupBox.Controls.Add(richTextBox);
            groupBox.Controls.Add(buttonLock);
            groupBox.CustomGroupBoxLock(buttonLock);
            groupBox.isLocked = false;
            groupBox.Location = new Point(390, 50);

            return groupBox;

        }
        public CustomGroupBox Spawn_Picture(CustomGroupBox groupBox, PictureBox pictureBox)
        {
            groupBox.Controls.Add(pictureBox);

            groupBox.Text = "PictureBox";
            pictureBox.Location = new Point(6, 45);
            pictureBox.Size = new Size(220, 150);
            pictureBox.ForeColor = Color.Black;
            pictureBox.BackColor = Color.White;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = Image.FromFile(@"Assets\default.jpg");
            groupBox.Controls.Add(pictureBox);

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

            return groupBox;
        }

        public CustomGroupBox Spawn_Picture(CustomGroupBox groupBox) // simple version
        {
            PictureBox pictureBox = new PictureBox();

            pictureBox.Location = new Point(6, 45);
            pictureBox.Size = new Size(220, 150);
            pictureBox.ForeColor = Color.Black;
            pictureBox.BackColor = Color.White;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = Image.FromFile(@"Assets\default.jpg");

            groupBox.Text = "PictureBox";
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
            groupBox.Controls.Add(pictureBox);

            groupBox.CustomGroupBoxLock(buttonLock);
            groupBox.isLocked = false;

            return groupBox;
        }
    }
}
