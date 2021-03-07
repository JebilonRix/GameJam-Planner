using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public class CustomGroupBox : GroupBox
    {
        Point point;
        public bool isLocked;

        public CustomGroupBox() { }

        public CustomGroupBox(IContainer container)
        {
            container.Add(this);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            point = e.Location;
            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (!this.isLocked && e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
            else if (this.isLocked)
            {
                //We'll bang,OK!
            }

            base.OnMouseMove(e);
        }

        public void CustomGroupBoxLock(Button buttonLock)
        {
            buttonLock.Click += ButtonLock_Click;
            ImageChanger(buttonLock, isLocked);
        }
        private void ButtonLock_Click(object sender, EventArgs e)
        {
            this.isLocked = !this.isLocked;
        }
        private void ImageChanger(Button buttonLock, bool isLocked)
        {
            switch (isLocked)
            {
                case true:
                    buttonLock.BackgroundImage.Dispose();
                    buttonLock.BackgroundImage = Image.FromFile(@"Assets\kilit.png");
                    break;
                case false:
                    buttonLock.BackgroundImage.Dispose();
                    buttonLock.BackgroundImage = Image.FromFile(@"Assets\kilit2.png");
                    break;
                default:
                    break;
            }
        }

    }
}
