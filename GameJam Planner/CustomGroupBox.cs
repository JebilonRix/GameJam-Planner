using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public class CustomGroupBox : GroupBox
    {
        public static CustomGroupBox CGB;

        public Point point;
        public Point MousePush;
        public bool isLocked;
        public CheckedListBox MyTodoList;
        public int BoxID;
        public RichTextBox rtb;

        ContextMenu cm = new ContextMenu();
        Form_CustomMessageBox FNC = new Form_CustomMessageBox();
        Button MyLockButton;
        Button MyAddButton;
        public string LocationOfPicture;

        public CustomGroupBox(int type)
        {
            if (type == 0)
            {
                SetUpContextMenuNoteBox();
                MyLockButton = Class_Spawner.Spawner.LockButton(this, isLocked);
                MyLockButton.Click += ButtonLock_Click;
            }
            else if (type == 1)
            {
                SetUpContextMenuPic();
                MyLockButton = Class_Spawner.Spawner.LockButton(this, isLocked);
                MyLockButton.Click += ButtonLock_Click;
            }
            else if (type == 2)
            {
                SetUpContextMenuToDo();
                MyLockButton = Class_Spawner.Spawner.LockButton(this, isLocked);
                MyLockButton.Click += ButtonLock_Click;
                MyAddButton = Class_Spawner.Spawner.AddButton(this);
                MyAddButton.Click += AddButton_Click;
            }

        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            point = e.Location;
            string TypeOfBox = Class_Spawner.Spawner.TypeOfBox;

            switch (TypeOfBox)
            {
                case "GroupText": point = e.Location; break;
                case "GroupPicture": point = e.Location; break;
                case "GroupDo": point = e.Location; break;
                default: break;
            }

            switch (e.Button)
            {
                case MouseButtons.Right: cm.Show(this, point); break;
                case MouseButtons.Middle: Delete_Click(this, e); break;
                default: break;
            }

            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (this.isLocked == false && e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
            else if (this.isLocked == true)
            {
                //We'll bang,OK! 
            }

            base.OnMouseMove(e);
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            FNC.ShowDialog();
            int ToDoItemCount = MyTodoList.Items.Count;
            MyTodoList.Items.Insert(ToDoItemCount, FNC.Joker);
        }
        private void ButtonLock_Click(object sender, EventArgs e)
        {
            this.isLocked = !this.isLocked;

            switch (isLocked)
            {
                case true: MyLockButton.BackColor = Color.Red; break;
                case false: MyLockButton.BackColor = Color.White; break;
                default: break;
            }

        }
        private void ToDoBox_DeleteLine(object sender, EventArgs e)
        {
            this.MyTodoList.Items.Remove(MyTodoList.SelectedItem);
        }
        private void SetUpContextMenuNoteBox()
        {
            cm.MenuItems.Add("Change Color", new EventHandler(ChangeColor_Click));
            cm.MenuItems.Add("Change Name", new EventHandler(ChangeName_Click));
            cm.MenuItems.Add("Delet Dis", new EventHandler(Delete_Click));
        }
        private void SetUpContextMenuPic()
        {
            SetUpContextMenuNoteBox();
            cm.MenuItems.Add("Add Pic", new EventHandler(AddPicture_Click));
        }
        private void SetUpContextMenuToDo()
        {
            SetUpContextMenuNoteBox();
            cm.MenuItems.Add("Delete Line", new EventHandler(ToDoBox_DeleteLine));
        }


        private void ChangeColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = cd.Color;
                }
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            this.Dispose();
            string typeofbox = Class_Spawner.Spawner.TypeOfBox;
            switch (typeofbox)
            {
                case "note": Class_Spawner.Spawner.MyBoxesNote.Remove(this); break;
                case "pic": Class_Spawner.Spawner.MyBoxesPicture.Remove(this);  break;
                case "do": Class_Spawner.Spawner.MyBoxesToDo.Remove(this); break;
                default: break;
            }
        }
        private void ChangeName_Click(object sender, EventArgs e)
        {
            FNC.ShowDialog();
            this.Text = FNC.Joker;
        }
        private void AddPicture_Click(object sender, EventArgs e)
        {
            ImageImporter();
        }
        public Image ImageImporter()
        {
            Image img = null;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "(*.BMP; *.JPG; *.JPEG; *.GIF *.PNG;)| *.BMP; *.JPG; .JPEG; *.GIF;*.PNG; | All files(*.*) | *.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    img = new Bitmap(ofd.FileName);
                    File.Copy(ofd.FileName, ofd.SafeFileName, true);
                    LocationOfPicture = ofd.SafeFileName;
                }
                else
                {
                    this.Dispose();
                    Class_Spawner.Spawner.MyBoxesPicture.Remove(this);
                }
            }

            return img;
        }

        public JsonNoteBox ConvertJsonNoteBox()
        {
            JsonNoteBox output = new JsonNoteBox();
            output.BoxID = BoxID;
            output.BoxTitle = Text;
            output.BoxLocation = Location;
            output.BoxBackColor = BackColor;
            output.BoxIsLocked = isLocked;
            output.LocButtonBackground = MyLockButton.BackColor;

            if (rtb.Text == null)
            {
                rtb.Text = "";
            }

            output.RichText = rtb.Text;

            return output;
        }
        public JsonPictureBox ConvertJsonPictureBox()
        {
            JsonPictureBox output = new JsonPictureBox();
            output.BoxID = BoxID;
            output.BoxTitle = Text;
            output.BoxLocation = Location;
            output.BoxBackColor = BackColor;
            output.BoxIsLocked = isLocked;
            output.PictureLocation = LocationOfPicture;
            output.LocButtonBackground = MyLockButton.BackColor;

            return output;
        }
        public JsonToDoBox ConvertJsonToDoBox()
        {
            JsonToDoBox output = new JsonToDoBox();
            output.BoxID = BoxID;
            output.BoxTitle = Text;
            output.BoxLocation = Location;
            output.BoxBackColor = BackColor;
            output.BoxIsLocked = isLocked;
            output.LocButtonBackground = MyLockButton.BackColor;

            int len = MyTodoList.Items.Count;

            output.ItemID = new int[len];
            output.ItemName = new string[len];
            output.ItemChecked = new bool[len];

            for (int i = 0; i < len; i++)
            {
                output.ItemID[i] = i;
                output.ItemName[i] = MyTodoList.Items[i].ToString();
                output.ItemChecked[i] = MyTodoList.GetItemChecked(i);

            }
            return output;
        }
    }

    public class JsonNoteBox
    {
        public int BoxID { get; set; }
        public string BoxTitle { get; set; }
        public Point BoxLocation { get; set; }
        public Color BoxBackColor { get; set; }
        public bool BoxIsLocked { get; set; }
        public string RichText { get; set; }
        public Color LocButtonBackground { get; set; }
    }
    public class JsonPictureBox
    {
        public int BoxID { get; set; }
        public string BoxTitle { get; set; }
        public Point BoxLocation { get; set; }
        public Color BoxBackColor { get; set; }
        public bool BoxIsLocked { get; set; }
        public string PictureLocation { get; set; }
        public Color LocButtonBackground { get; set; }
    }
    public class JsonToDoBox
    {
        public int BoxID { get; set; }
        public string BoxTitle { get; set; }
        public Point BoxLocation { get; set; }
        public Color BoxBackColor { get; set; }
        public bool BoxIsLocked { get; set; }
        public int[] ItemID { get; set; }
        public string[] ItemName { get; set; }
        public bool[] ItemChecked { get; set; }
        public Color LocButtonBackground { get; set; }
    }
}
