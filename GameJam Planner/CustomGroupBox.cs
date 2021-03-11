﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public class CustomGroupBox : GroupBox
    {
        public static CustomGroupBox CGB;

        Class_Depo Storage = new Class_Depo();

        Point point;
        public bool isLocked;
        ContextMenu cm = new ContextMenu();
        Form_Name_Changer FNC = new Form_Name_Changer();
        Image img;

        Button MyLockButton;
        Button MyAddButton;
        public CheckedListBox MyTodoList;

        public CustomGroupBox(int type)
        {
            if (type == 0)
            {
                SetUpContextMenu();
                MyLockButton = Class_Spawner.Spawner.LockButton(this);
                MyLockButton.Click += ButtonLock_Click;
            }
            else if (type == 1)
            {
                SetUpContextMenuPic();
                MyLockButton = Class_Spawner.Spawner.LockButton(this);
                MyLockButton.Click += ButtonLock_Click;
            }
            else if (type == 2)
            {
                SetUpContextMenu();
                MyLockButton = Class_Spawner.Spawner.LockButton(this);
                MyLockButton.Click += ButtonLock_Click;
                MyAddButton = Class_Spawner.Spawner.AddButton(this);
                MyAddButton.Click += AddButton_Click;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            point = e.Location;

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
            int len = MyTodoList.Items.Count;
            MyTodoList.Items.Insert(len, FNC.Joker);
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

        #region MenuItems
        private void SetUpContextMenu()
        {
            cm.MenuItems.Add("Change Color", new EventHandler(ChangeColor_Click));
            cm.MenuItems.Add("Change Name", new EventHandler(ChangeName_Click));
            cm.MenuItems.Add("Delet Dis", new EventHandler(Delete_Click));
        }
        private void SetUpContextMenuPic()
        {
            cm.MenuItems.Add("Change Color", new EventHandler(ChangeColor_Click));
            cm.MenuItems.Add("Change Name", new EventHandler(ChangeName_Click));
            cm.MenuItems.Add("Delet Dis", new EventHandler(Delete_Click));
            cm.MenuItems.Add("Add Pic", new EventHandler(AddPicture_Click));
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
            switch (Class_Spawner.Spawner.TypeOfBox)
            {
                case "GroupText": Class_Spawner.Spawner.box_id--; break;
                case "GroupPict": Class_Spawner.Spawner.pic_id--; break;
                case "GroupDo": Class_Spawner.Spawner.do_id--; break;
                default: break;
            }
            this.Dispose();
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
            if (img == null)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "(*.BMP; *.JPG; *.JPEG; *.GIF *.PNG;)| *.BMP; *.JPG; .JPEG; *.GIF;*.PNG; | All files(*.*) | *.*";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        img = new Bitmap(ofd.FileName);
                        File.Copy(ofd.FileName, ofd.SafeFileName, true);
                    }
                }
            }
            else
            {
                img.Dispose();

                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        img = new Bitmap(ofd.FileName);
                        File.Copy(ofd.FileName, ofd.SafeFileName, true);
                    }
                }
            }

            return img;
        }

        #endregion

    }
}
