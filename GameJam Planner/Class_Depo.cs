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
        public string[] TextBoxTitle { get; set; }
        public string[] TextBoxLocation { get; set; }
        public bool[] TextBoxisLock { get; set; }
        public string[] RichTextBoxText { get; set; } //içeriği

        //////////////////Picture////////////////////////

        public int[] PictureBoxId { get; set; }
        public string[] PictureBoxTitle { get; set; }
        public string[] PictureBoxLocation { get; set; }
        public bool[] PictureBoxisLock { get; set; }
        public string[] PictureImageLocationInFile { get; set; }   //içeriği

        //////////////////To Do////////////////////////

        public int[] ToDoBoxId { get; set; }
        public string[] ToDoBoxTitle { get; set; }
        public string[] ToDoBoxLocation { get; set; }
        public bool[] ToDoBoxisLock { get; set; }
        public int[] ToDoListItemId { get; set; }  //içeriği
        public string[] ToDoListItemName { get; set; }  //içeriği

        public void DataSave()
        {
            int TotalBoxText = Class_Spawner.Spawner.box_id;
            int TotalBoxPicture = Class_Spawner.Spawner.pic_id;
            int TotalBoxTodo = Class_Spawner.Spawner.do_id;

            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();

            dt1.Columns.Add("ID", typeof(int));
            dt1.Columns.Add("Title", typeof(string));
            dt1.Columns.Add("Location", typeof(string));
            dt1.Columns.Add("Lock", typeof(bool));
            dt1.Columns.Add("Text", typeof(string));

            dt2.Columns.Add("ID", typeof(int));
            dt2.Columns.Add("Title", typeof(string));
            dt2.Columns.Add("Location", typeof(string));
            dt2.Columns.Add("Lock", typeof(bool));
            dt2.Columns.Add("FileLocation", typeof(string));

            dt3.Columns.Add("ID", typeof(int));
            dt3.Columns.Add("Title", typeof(string));
            dt3.Columns.Add("Location", typeof(string));
            dt3.Columns.Add("Lock", typeof(bool));
            dt3.Columns.Add("ItemID", typeof(int));
            dt3.Columns.Add("ItemName", typeof(string));

            DataRow dr1 = dt1.NewRow();
            DataRow dr2 = dt2.NewRow();
            DataRow dr3 = dt3.NewRow();

            for (int i = 0; i < TotalBoxText; i++)
            {
                dr1["ID"] = TextBoxId[i];
                dr1["Title"] = TextBoxTitle[i];
                dr1["Location"] = TextBoxLocation[i];
                dr1["Lock"] = TextBoxisLock[i];
                dr1["Text"] = RichTextBoxText[i];
                dt1.Rows.Add(dr1);
            }

            for (int i = 0; i < TotalBoxPicture; i++)
            {
                dr2["ID"] = PictureBoxId[i];
                dr2["Title"] = PictureBoxTitle[i];
                dr2["Location"] = PictureBoxLocation[i];
                dr2["Lock"] = PictureBoxisLock[i];
                dr2["FileLocation"] = PictureImageLocationInFile[i];
                dt2.Rows.Add(dr2);
            }

            for (int i = 0; i < TotalBoxTodo; i++)
            {
                dr3["ID"] = ToDoBoxId[i];
                dr3["Title"] = ToDoBoxTitle[i];
                dr3["Location"] = ToDoBoxLocation[i];
                dr3["Lock"] = ToDoBoxisLock[i];
                dr3["ItemID"] = ToDoListItemId[i];
                dr3["ItemName"] = ToDoListItemName[i];
                dt3.Rows.Add(dr3);
            }



        }
        public void DataSet()
        {

        }
    }
}
