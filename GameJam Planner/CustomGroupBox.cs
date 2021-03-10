using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public class CustomGroupBox : GroupBox
    {
        public static CustomGroupBox CGB;
        Point point;
        public bool isLocked;
        public bool BasCek;
        ContextMenu cm = new ContextMenu();
        Form_Name_Changer FNC = new Form_Name_Changer();
        Image img;


        public CustomGroupBox()
        {
            SetUpContextMenu();
            Class_Spawner.Spawner.LockButton(this).Click += ButtonLock_Click;
            Class_Spawner.Spawner.AddButton(this).Click += AddButton_Click;
        }

        #region Mouse Events
        protected override void OnMouseDown(MouseEventArgs e)
        {
            point = e.Location;
            customGroupBox_Click(e);
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
        private void customGroupBox_Click(MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right: cm.Show(this, point); break;
                case MouseButtons.Middle: Delete_Click(this, e); break;
                default: break;
            }
        }

        #endregion

        #region Lock Controls
        private void AddButton_Click(object sender, EventArgs e)
        {
            this.BasCek = !this.BasCek;

            FNC.ShowDialog();


            switch (BasCek)
            {
                case true: Class_Spawner.Spawner.CheckListItemText = FNC.Joker; break;
                default: break;
            }
        }
        private void ButtonLock_Click(object sender, EventArgs e)
        {
            this.isLocked = !this.isLocked;

            switch (isLocked)
            {
                case true: Class_Spawner.Spawner.LockButton(this).BackColor = Color.Red; break;
                case false: Class_Spawner.Spawner.LockButton(this).BackColor = Color.White; break;
                default: break;
            }
        }

        #endregion

        #region MenuItems
        private void SetUpContextMenu()
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
