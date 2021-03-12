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

        public DataTable dt1 = new DataTable();
        public void Depola(string type, int id, string title, Point location, Size size, bool locked, string content1, string content2)
        {
            DataRow dr1 = dt1.NewRow();

            dr1["Type"] = type;
            dr1["ID"] = id;
            dr1["Title"] = title;
            dr1["Location"] = location;
            dr1["Size"] = size;
            dr1["Lock"] = locked;
            dr1["Content1"] = content1;
            dr1["Content2"] = content2;

            dt1.Rows.Add(dr1);
        }

        public void Updates()
        {
            string type = Class_Spawner.Spawner.TypeOfBox;
            int id = 0;
            switch (type)
            {
                case "GroupText": id = Class_Spawner.Spawner.box_id; break;
                case "GroupPicture": id = Class_Spawner.Spawner.pic_id; break;
                case "GroupDo": id = Class_Spawner.Spawner.do_id; break;
                default: break;
            }

            string title = "";

            if (CustomGroupBox.CGB.Title == "")
            {
                title = Class_Spawner.Spawner.DefaultTitle;
            }
            else 
            {
                title = CustomGroupBox.CGB.Title;
            }

            Point location = CustomGroupBox.CGB.point;
            Size size = Class_Spawner.Spawner.BoxSize;
            bool locked = CustomGroupBox.CGB.isLocked;

            string content1 = "";
            string content2 = "";

            Depola(type, id, title, location,size, locked,  content1,  content2);




        }


    }
}
