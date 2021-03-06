﻿using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public class Class_Box_Spawner
    {
        public List<CustomGroupBox> MyBoxList = new List<CustomGroupBox>();
        public string TypeOfBox, CheckListItemText, DefaultTitle;
        private static string[] box_type = { "note", "pic", "do" };
        public static Class_Box_Spawner Spawner;
        public Point SpawnLocation;
        private int box_id;

        public Class_Box_Spawner()
        {
        }
        public CustomGroupBox SpawnBox(int type)
        {
            TypeOfBox = box_type[type];
            CustomGroupBox groupBox = new CustomGroupBox(type);

            switch (TypeOfBox)
            {
                case "note":
                    groupBox.Text = "NoteBox";
                    groupBox.Size = new Size(230, 200); break;
                case "pic":
                    groupBox.Text = "PictureBox";
                    groupBox.Size = new Size(230, 200); break;
                case "do":
                    groupBox.Text = "ToDoBox";
                    groupBox.Size = new Size(210, 250); break;
                default: break;
            }

            groupBox.BoxSize = groupBox.Size;
            groupBox.BoxTitle = groupBox.Text;
            groupBox.isLocked = false;
            groupBox.BoxID = box_id;
            groupBox.BoxType = TypeOfBox;
            groupBox.Location = SpawnLocation;
            groupBox.ForeColor = Color.White;
            LockButton(groupBox, groupBox.isLocked);

            MyBoxList.Add(groupBox);

            if (type == 0)
            {
                RichTextBox(groupBox);
            }
            else if (type == 1)
            {
                PictureBox picBox = new PictureBox();
                picBox.Location = new Point(6, 45);
                picBox.Size = new Size(220, 150);
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                picBox.Image = groupBox.ImageImporter();
                groupBox.Controls.Add(picBox);
            }
            else if (type == 2)
            {
                CheckedListBox(groupBox);
                AddButton(groupBox);
            }

            box_id++;
            return groupBox;
        }
        public CustomGroupBox SpawnBoxJson(int type, JsonBox jsonInput)
        {
            TypeOfBox = box_type[type];
            CustomGroupBox groupBox = new CustomGroupBox(type);
            groupBox.BackColor = jsonInput.BoxBackColor;
            groupBox.isLocked = jsonInput.BoxIsLocked;
            groupBox.Location = jsonInput.BoxLocation;
            groupBox.BoxType = jsonInput.BoxType;
            groupBox.Text = jsonInput.BoxTitle;
            groupBox.Size = jsonInput.BoxSize;
            groupBox.BoxID = jsonInput.BoxID;

            Button lockbutton = LockButton(groupBox, groupBox.isLocked);
            lockbutton.BackColor = jsonInput.LockButtonBackground;
            MyBoxList.Add(groupBox);

            if (type == 0)
            {
                RichTextBox(groupBox);
                groupBox.rtb.Text = jsonInput.RichText;
            }
            else if (type == 1)
            {
                PictureBox picBox = new PictureBox();
                picBox.Location = new Point(6, 45);
                picBox.Size = new Size(220, 150);
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                picBox.Image = new Bitmap(jsonInput.PictureLocation);
                groupBox.Controls.Add(picBox);
                groupBox.LocationOfPicture = jsonInput.PictureLocation;
            }
            else if (type == 2)
            {
                AddButton(groupBox);
                CheckedListBox(groupBox);
                for (int i = 0; i < jsonInput.ItemID.Length; i++)
                {
                    groupBox.MyTodoList.Items.Add(jsonInput.ItemName[i], jsonInput.ItemChecked[i]);
                    groupBox.MyTodoList.Items[i] = jsonInput.ItemName[i];
                }
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
        public CheckedListBox CheckedListBox(CustomGroupBox groupBox)
        {
            CheckedListBox checkedListBox = new CheckedListBox();
            checkedListBox.Location = new Point(6, 47);
            checkedListBox.Size = new Size(200, 210);
            groupBox.Controls.Add(checkedListBox);
            groupBox.MyTodoList = checkedListBox;

            return checkedListBox;
        }
        public Button LockButton(CustomGroupBox groupBox, bool isLocked)
        {
            Button buttonLock = new Button();
            buttonLock.BackgroundImage = Image.FromFile(@"Assets\kilit.png");
            switch (TypeOfBox)
            {
                case "note": buttonLock.Location = new Point(207, 22); break;
                case "pic": buttonLock.Location = new Point(207, 22); break;
                case "do": buttonLock.Location = new Point(190, 23); break;
                default: break;
            }

            buttonLock.Size = new Size(20, 20);
            buttonLock.Text = "";

            switch (isLocked)
            {
                case true: buttonLock.BackColor = Color.Red; break;
                case false: buttonLock.BackColor = Color.White; break;
                default: break;
            }

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

    }
}