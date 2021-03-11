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

        //////////////////RichText////////////////////////
        public int[] TextBoxId { get; set; }
        public string[] TextBoxName { get; set; }
        public string[] TextBoxLocation { get; set; }
        public bool[] TextBoxisLock { get; set; }
        public string[] RichTextBoxText { get; set; } //içeriği

        //////////////////Picture////////////////////////

        public int[] PictureBoxId { get; set; }
        public string[] PictureBoxName { get; set; }
        public string[] PictureBoxLocation { get; set; }
        public bool[] PictureBoxisLock { get; set; }
        public Image PictureImage { get; set; }   //içeriği


        //////////////////To Do////////////////////////

        public int[] ToDoBoxId { get; set; }
        public string[] ToDoBoxName { get; set; }
        public string[] ToDoBoxLocation { get; set; }
        public bool[] ToDoBoxisLock { get; set; }
        //içeriği

    }
}
