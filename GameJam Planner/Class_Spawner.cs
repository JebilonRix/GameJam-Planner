using System.Drawing;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public class Class_Spawner
    {
        public static Class_Spawner Spawner;
        public int box_id, pic_id, do_id;
        public string TypeOfBox, CheckListItemText;
        public Point mouselocation;

        Class_Depo depo = new Class_Depo();

        private CustomGroupBox GroupBox(int type)
        {
            CustomGroupBox groupBox = new CustomGroupBox(type);

            groupBox.Location = new Point(390, 50);
            groupBox.ForeColor = Color.White;

            switch (TypeOfBox)
            {
                case "GroupText": groupBox.Text = "GroupBox" + box_id.ToString(); groupBox.Size = new Size(230, 200); break;
                case "GroupPicture": groupBox.Text = "PictureBox" + pic_id.ToString(); groupBox.Size = new Size(230, 200); break;
                case "GroupDo": groupBox.Text = "ToDoBox" + do_id.ToString(); groupBox.Size = new Size(210, 250); break;
                default: break;
            }

            return groupBox;
        }
        public RichTextBox RichTextBox(CustomGroupBox groupBox)
        {
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
            PictureBox pictureBox = new PictureBox();
          
            pictureBox.Size = new Size(220, 150);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = groupBox.ImageImporter();
            groupBox.Controls.Add(pictureBox);

            return pictureBox;
        }
        public CheckedListBox CheckedListBox(CustomGroupBox groupBox)
        {
            CheckedListBox checkedListBox = new CheckedListBox();
            checkedListBox.Location = new Point(6, 47);
            checkedListBox.Size = new Size(200, 210);
            groupBox.Controls.Add(checkedListBox);
            groupBox.MyTodoList = checkedListBox;

            return checkedListBox;
        }
        public Button LockButton(CustomGroupBox groupBox)
        {
            Button buttonLock = new Button();

            switch (TypeOfBox)
            {
                case "GroupText": buttonLock.Location = new Point(207, 22); break;
                case "GroupPicture": buttonLock.Location = new Point(207, 22); break;
                case "GroupDo": buttonLock.Location = new Point(190, 23); break;
                default: break;
            }

            buttonLock.Size = new Size(20, 20);
            buttonLock.Text = "";
            buttonLock.BackColor = Color.White;
            buttonLock.BackgroundImage = Image.FromFile(@"Assets\kilit.png");
            groupBox.Controls.Add(buttonLock);

            return buttonLock;
        }
        public Button AddButton(CustomGroupBox groupBox)
        {
            Button addButton = new Button();
            addButton.Location = new Point(135, 22);
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
            CustomGroupBox groupBox = GroupBox(0);
            RichTextBox(groupBox);
            LockButton(groupBox);
            groupBox.isLocked = false;

            return groupBox;
        }
        public CustomGroupBox Spawn_Picture()
        {
            pic_id++;
            TypeOfBox = "GroupPicture";
            CustomGroupBox groupBox = GroupBox(1);
            PictureBox(groupBox);
            LockButton(groupBox);
            groupBox.isLocked = false;

            return groupBox;
        }
        public CustomGroupBox Spawn_ToDo()
        {
            do_id++;
            TypeOfBox = "GroupDo";
            CustomGroupBox groupBox = GroupBox(2);
            CheckedListBox(groupBox);
            AddButton(groupBox);
            LockButton(groupBox);
            groupBox.isLocked = false;

            return groupBox;
        }
    }
}
