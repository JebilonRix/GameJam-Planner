using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace GameJam_Planner
{
    public class Class_Spawner
    {
        public static Class_Spawner Spawner;

        public int box_id, pic_id, do_id;
        public string TypeOfBox, CheckListItemText;
        public Point SpawnLocation;


        private CustomGroupBox GroupBox(int type)
        {
            CustomGroupBox groupBox = new CustomGroupBox(type);

            groupBox.Location = SpawnLocation;
            groupBox.ForeColor = Color.White;

            switch (TypeOfBox)
            {
                case "GroupText": groupBox.Size = new Size(230, 200); break;
                case "GroupPicture": groupBox.Size = new Size(230, 200); break;
                case "GroupDo": groupBox.Size = new Size(210, 250); break;
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
            richTextBox.Text = "";

            groupBox.Controls.Add(richTextBox);
            return richTextBox;
        }
        public PictureBox PictureBox(CustomGroupBox groupBox)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(6, 45);
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
            TypeOfBox = "GroupText";

            CustomGroupBox groupBox = GroupBox(0);
            RichTextBox(groupBox);
            LockButton(groupBox);
            DefaultName(groupBox);
            groupBox.isLocked = false;

            box_id++;
            return groupBox;
        }
        public CustomGroupBox Spawn_Picture()
        {
            pic_id++;
            TypeOfBox = "GroupPicture";
            CustomGroupBox groupBox = GroupBox(1);
            PictureBox(groupBox);
            LockButton(groupBox);
            DefaultName(groupBox);
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
            DefaultName(groupBox);
            groupBox.isLocked = false;

            return groupBox;
        }

        public string DefaultName(CustomGroupBox groupBox)
        {
            switch (TypeOfBox)
            {
                case "GroupText": groupBox.Text = "GroupBox" + (box_id + 1).ToString(); break;
                case "GroupPicture": groupBox.Text = "PictureBox" + (pic_id + 1).ToString(); break;
                case "GroupDo": groupBox.Text = "ToDoBox" + (do_id + 1).ToString(); break;
                default: break;
            }

            return groupBox.Text;
        }


        public void DataSave(CustomGroupBox groupBox)
        {
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();

            dt1.Columns.Add("ID", typeof(int));
            dt1.Columns.Add("Title", typeof(string));
            dt1.Columns.Add("Location", typeof(string));
            dt1.Columns.Add("Size", typeof(string));
            dt1.Columns.Add("Lock", typeof(bool));
            dt1.Columns.Add("Text", typeof(string));

            dt2.Columns.Add("ID", typeof(int));
            dt2.Columns.Add("Title", typeof(string));
            dt2.Columns.Add("Location", typeof(string));
            dt2.Columns.Add("Size", typeof(string));
            dt2.Columns.Add("Lock", typeof(bool));
            dt2.Columns.Add("FileLocation", typeof(string));

            dt3.Columns.Add("ID", typeof(int));
            dt3.Columns.Add("Title", typeof(string));
            dt3.Columns.Add("Location", typeof(string));
            dt3.Columns.Add("Size", typeof(string));
            dt3.Columns.Add("Lock", typeof(bool));
            dt3.Columns.Add("ItemID", typeof(int));
            dt3.Columns.Add("ItemName", typeof(string));

            DataRow dr1 = dt1.NewRow();
            DataRow dr2 = dt2.NewRow();
            DataRow dr3 = dt3.NewRow();

            for (int i = 0; i < box_id; i++)
            {
                dr1["ID"] = box_id;
                dr1["Title"] = DefaultName(groupBox);
                // dr1["Location"] = groupBox.LocationChanged;
                dr1["Size"] = groupBox.Size;
                dr1["Lock"] = groupBox.isLocked;
                dr1["Text"] = RichTextBox(groupBox).Text;

                dt1.Rows.Add(dr1);
            }
            for (int i = 0; i < pic_id; i++)
            {
                dr2["ID"] = pic_id;
                dr2["Title"] = DefaultName(groupBox);
                // dr2["Location"] = groupBox.LocationChanged;
                dr2["Size"] = groupBox.Size;
                dr2["Lock"] = groupBox.isLocked;
                dr2["Text"] = CustomGroupBox.CGB.LocationOfPicture;

                dt2.Rows.Add(dr2);
            }
            for (int i = 0; i < do_id; i++)

                dt3.Rows.Add(dr3);
        }

    }
}
