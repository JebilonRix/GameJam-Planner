using System.Drawing;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public class Class_Spawner
    {
        public static Class_Spawner Spawner;
        public int box_id;
        public int pic_id;
        public int do_id;
        public string TypeOfBox;
        public string CheckListItemText;

        private CustomGroupBox GroupBox()
        {
            CustomGroupBox groupBox = new CustomGroupBox();
            groupBox.Size = new Size(230, 200);
            groupBox.Location = new Point(390, 50);
            groupBox.ForeColor = Color.White;
            groupBox.Font = new Font("Arial", 15.25F, FontStyle.Bold, GraphicsUnit.Point);


            return groupBox;
        }
        public RichTextBox RichTextBox(CustomGroupBox groupBox)
        {
            groupBox.Text = "GroupBox" + box_id.ToString();
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Location = new Point(6, 45);
            richTextBox.Size = new Size(220, 150);
            richTextBox.ForeColor = Color.Black;
            richTextBox.BackColor = Color.White;
            richTextBox.Font = new Font("Arial", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox.Controls.Add(richTextBox);
            return richTextBox;
        }
        public PictureBox PictureBox(CustomGroupBox groupBox)
        {
            groupBox.Text = "PictureBox" + pic_id.ToString();
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(6, 45);
            pictureBox.Size = new Size(220, 150);
            pictureBox.ForeColor = Color.Black;
            pictureBox.BackColor = Color.White;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = groupBox.ImageImporter();
            groupBox.Controls.Add(pictureBox);

            return pictureBox;
        }
        public CheckedListBox CheckedListBox(CustomGroupBox groupBox)
        {
            groupBox.Text = "ToDoBox" + do_id.ToString();
            CheckedListBox checkedListBox = new CheckedListBox();
            checkedListBox.Location = new Point(6, 47);
            checkedListBox.Size = new Size(200, 252);
            groupBox.Controls.Add(checkedListBox);

            return checkedListBox;
        }
        public Button LockButton(CustomGroupBox groupBox)
        {
            Button buttonLock = new Button();
            buttonLock.Location = new Point(200, 14);
            buttonLock.Size = new Size(20, 20);
            buttonLock.Text = "";
            buttonLock.ForeColor = Color.Black;
            buttonLock.BackColor = Color.White;
            buttonLock.BackgroundImage = Image.FromFile(@"Assets\kilit.png");
            groupBox.Controls.Add(buttonLock);

            return buttonLock;
        }
        public Button AddButton(CustomGroupBox groupBox)
        {
            Button addButton = new Button();
            addButton.Location = new Point(146, 22);
            addButton.Size = new Size(54, 22);
            addButton.Text = "Add";
            addButton.ForeColor = Color.Black;
            addButton.BackColor = Color.White;
            addButton.Font = new Font("Arial", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox.Controls.Add(addButton);

            return addButton;
        }

        public CustomGroupBox Spawn_Group()
        {
            box_id++;
            TypeOfBox = "GroupText";
            CustomGroupBox groupBox = GroupBox();
            RichTextBox(groupBox);
            LockButton(groupBox);

            groupBox.isLocked = false;

            return groupBox;
        }
        public CustomGroupBox Spawn_Picture()
        {
            pic_id++;
            TypeOfBox = "GroupPict";
            CustomGroupBox groupBox = GroupBox();
            PictureBox(groupBox);
            LockButton(groupBox);
            groupBox.isLocked = false;

            return groupBox;
        }
        public CustomGroupBox Spawn_ToDo()
        {
            do_id++;
            TypeOfBox = "GroupDo";
            CustomGroupBox groupBox = GroupBox();
            CheckedListBox(groupBox);
            AddButton(groupBox);
            LockButton(groupBox);
            groupBox.isLocked = false;
            groupBox.BasCek = false;

            if (CheckListItemText != null)
            {
                CheckedListBox(groupBox).Items.Add(CheckListItemText, false);
            }

            return groupBox;
        }
    }
}
