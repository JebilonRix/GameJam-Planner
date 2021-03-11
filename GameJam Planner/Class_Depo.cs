using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam_Planner
{
    public class Class_Depo
    {
        public int[] TextBoxId { get; set; }
        public string[] TextBoxName { get; set; }
        public Size[] TextBoxSize { get; set; }
        public Point[] TextBoxLocation { get; set; }
        public Color[] TextBoxForeColor { get; set; }
        public Point[] RichLocation { get; set; }
        public Size[] RichSize { get; set; }
        public Color[] RichForeColor { get; set; }
        public Color[] RichBackColor { get; set; }
        public Font[] RichFont { get; set; }

        //////////////////////////////////////////

        public int[] PictureBoxId { get; set; }
        public string[] PictureBoxName { get; set; }
        public Size[] PictureBoxSize { get; set; }
        public Point[] PictureBoxLocation { get; set; }
        public Color[] PictureBoxForeColor { get; set; }


        /*
            groupBox.Text = "PictureBox" + pic_id.ToString();
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(6, 45);
            pictureBox.Size = new Size(220, 150);
            pictureBox.ForeColor = Color.Black;
            pictureBox.BackColor = Color.White;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = groupBox.ImageImporter();
         */


    }
}
