using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public class CustomGroupBox : GroupBox
    {
        Point point;
        public bool isLocked;
        ContextMenu cm = new ContextMenu();

        public CustomGroupBox()
        {

        }
        public CustomGroupBox(IContainer container)
        {
            container.Add(this);
            SetUpContextMenu();
        }

        #region Mouse Events
        protected override void OnMouseDown(MouseEventArgs e)
        {
            point = e.Location;
            customGroupBox_Click(e);   // forma box'ı yüklü verirsem çalışıyor ama box'ı sonradan eklersem çalışmıyor :D 
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
        private void customGroupBox_Click(MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right: cm.Show(this, point); break;
                default: break;
            }
        }

        #endregion

        #region Lock Controls
        public void CustomGroupBoxLock(Button buttonLock)
        {
            buttonLock.Click += ButtonLock_Click;
            switch (isLocked)
            {
                case true: buttonLock.BackColor = Color.Green; break;
                case false: buttonLock.BackColor = Color.Red; break;
                default: break;
            }
        }
        private void ButtonLock_Click(object sender, EventArgs e)
        {
            this.isLocked = !this.isLocked;
        }

        #endregion

        #region MenuItems
        private void SetUpContextMenu()
        {
            cm.MenuItems.Add("Change Color Of Background", new EventHandler(changeColor_Click));
        }
        private void changeColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = cd.Color;
                }
            }
        }

        #endregion

    }
}
