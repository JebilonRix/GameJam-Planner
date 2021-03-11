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
        public static Class_Depo Depo;

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
        public string PictureImageLocationInFile { get; set; }   //içeriği

        //////////////////To Do////////////////////////

        public int[] ToDoBoxId { get; set; }
        public string[] ToDoBoxName { get; set; }
        public string[] ToDoBoxLocation { get; set; }
        public bool[] ToDoBoxisLock { get; set; }
        public int ToDoListItemId { get; set; }  //içeriği
        public string ToDoListItemName { get; set; }  //içeriği

        public void DataSave()
        {
            int TotalBoxText = Class_Spawner.Spawner.box_id;
            int TotalBoxPicture = Class_Spawner.Spawner.pic_id;
            int TotalBoxTodo = Class_Spawner.Spawner.do_id;

            for (int i = 0; i < TotalBoxText; i++)
            {

            }



        }
        public void DataSet()
        {

        }
    }
}
