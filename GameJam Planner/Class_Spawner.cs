﻿using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;



namespace GameJam_Planner
{
    public class Class_Spawner
    {
        public static Class_Spawner Spawner;
        public string TypeOfBox, CheckListItemText, DefaultTitle;
        public Point SpawnLocation;
        public List<CustomGroupBox> MyBoxesNote = new List<CustomGroupBox>();
        public List<CustomGroupBox> MyBoxesPicture = new List<CustomGroupBox>();
        public List<CustomGroupBox> MyBoxesToDo = new List<CustomGroupBox>();

        public Class_Spawner()
        {
        }
        public CustomGroupBox GroupBox(int type)
        {
            CustomGroupBox groupBox = new CustomGroupBox(type);

            switch (TypeOfBox)
            {
                case "GroupNote": groupBox.Text = "NoteBox"; break;
                case "GroupPicture": groupBox.Text = "PictureBox"; break;
                case "GroupDo": groupBox.Text = "ToDoBox"; break;
                default: break;
            }

            groupBox.Location = SpawnLocation;
            groupBox.ForeColor = Color.White;

            switch (TypeOfBox)
            {
                case "GroupNote": groupBox.Size = new Size(230, 200); break;
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
            groupBox.rtb = richTextBox;

            groupBox.Controls.Add(richTextBox);
            return richTextBox;
        }
        public PictureBox PictureBox(CustomGroupBox groupBox)
        {
            PictureBox picBox = new PictureBox();
            picBox.Location = new Point(6, 45);
            picBox.Size = new Size(220, 150);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox.Image = groupBox.ImageImporter();
            groupBox.Controls.Add(picBox);

            return picBox;
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
                case "GroupNote": buttonLock.Location = new Point(207, 22); break;
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


        public CustomGroupBox Spawn_Note()
        {
            TypeOfBox = "GroupNote"; //keyword
            CustomGroupBox groupBox = GroupBox(0);
            RichTextBox(groupBox);
            LockButton(groupBox);
            groupBox.isLocked = false;

            MyBoxesNote.Add(groupBox);
            return groupBox;
        }
        public CustomGroupBox Spawn_Picture()
        {
            TypeOfBox = "GroupPicture";
            CustomGroupBox groupBox = GroupBox(1);
            PictureBox(groupBox);
            LockButton(groupBox);
            groupBox.isLocked = false;

            MyBoxesPicture.Add(groupBox);
            return groupBox;
        }
        public CustomGroupBox Spawn_ToDo()
        {
            TypeOfBox = "GroupDo";
            CustomGroupBox groupBox = GroupBox(2);
            CheckedListBox(groupBox);
            AddButton(groupBox);
            LockButton(groupBox);
            groupBox.isLocked = false;

            MyBoxesToDo.Add(groupBox);
            return groupBox;
        }


        public CustomGroupBox Spawn_Note_With_Json(JsonNoteBox jsonInput)
        {
            TypeOfBox = "GroupNote"; //keyword
            CustomGroupBox groupBox = GroupBox(0);
            groupBox.BoxID = jsonInput.BoxID;
            groupBox.Text = jsonInput.BoxTitle;
            groupBox.Location = jsonInput.BoxLocation;
            groupBox.BackColor = jsonInput.BoxBackColor;

            RichTextBox(groupBox);
            groupBox.rtb.Text = jsonInput.RichText;

            Button lockbutton = LockButton(groupBox);
            groupBox.isLocked = jsonInput.BoxIsLocked;
            lockbutton.BackColor = jsonInput.LocButtonBackground;

            MyBoxesNote.Add(groupBox);
            return groupBox;
        }
        public CustomGroupBox Spawn_Picture_With_Json(JsonPictureBox jsonInput)
        {
            TypeOfBox = "GroupNote"; //keyword
            CustomGroupBox groupBox = GroupBox(0);
            groupBox.BoxID = jsonInput.BoxID;
            groupBox.Text = jsonInput.BoxTitle;
            groupBox.Location = jsonInput.BoxLocation;
            groupBox.BackColor = jsonInput.BoxBackColor;

            PictureBox picBox = new PictureBox();
            picBox.Location = new Point(6, 45);
            picBox.Size = new Size(220, 150);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox.Image = new Bitmap(jsonInput.PictureLocation);
            groupBox.Controls.Add(picBox);
            groupBox.LocationOfPicture = jsonInput.PictureLocation;

            Button lockbutton = LockButton(groupBox);
            groupBox.isLocked = jsonInput.BoxIsLocked;
            lockbutton.BackColor = jsonInput.LocButtonBackground;

            MyBoxesNote.Add(groupBox);
            return groupBox;
        }
        public CustomGroupBox Spawn_ToDo_With_Json(JsonToDoBox jsonInput)
        {
            TypeOfBox = "GroupDo";
            CustomGroupBox groupBox = GroupBox(2);
            groupBox.BoxID = jsonInput.BoxID;
            groupBox.Text = jsonInput.BoxTitle;
            groupBox.Location = jsonInput.BoxLocation;
            groupBox.BackColor = jsonInput.BoxBackColor;

            CheckedListBox(groupBox);

            for (int i = 0; i < jsonInput.ItemID.Length; i++)
            {
                groupBox.MyTodoList.Items.Add(jsonInput.ItemName[i], jsonInput.ItemChecked[i]);
                groupBox.MyTodoList.Items[i] = jsonInput.ItemName[i];
            }

            Button lockbutton = LockButton(groupBox);
            groupBox.isLocked = jsonInput.BoxIsLocked;
            lockbutton.BackColor = jsonInput.LocButtonBackground;


            AddButton(groupBox);

            MyBoxesToDo.Add(groupBox);
            return groupBox;
        }
    }
}