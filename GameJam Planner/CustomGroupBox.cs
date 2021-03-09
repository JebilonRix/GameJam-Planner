using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public class CustomGroupBox : GroupBox
    {
        Point point;
        public bool isLocked;
        ContextMenu cm = new ContextMenu();
        Form_Name_Changer FNC = new Form_Name_Changer();
        Image img;

        public CustomGroupBox()
        {
            SetUpContextMenu();

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
        public Button CustomGroupBoxLock(Button buttonLock)   //çalışmıyor
        {
            buttonLock.Click += ButtonLock_Click;

            switch (isLocked)
            {
                case true: buttonLock.BackColor = Color.Red; break;
                case false: buttonLock.BackColor = Color.White; break;
                default: break;
            }

            return buttonLock;
        }
        private void ButtonLock_Click(object sender, EventArgs e)
        {
            this.isLocked = !this.isLocked;

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
            // Debug.WriteLine("Heheheh");

            if (img == null)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {

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

        public CustomGroupBox(IContainer container)
        {
            container.Add(this);
            SetUpContextMenu();
        }
    }
}
