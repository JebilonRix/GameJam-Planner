using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public class Class_Depo
    {
        public static Class_Depo Depo;
        public DataTable DataTableDepo = new DataTable();

        public Class_Depo()
        {

        }
        public void Depola(string type, int id, string title, Point location,  bool locked, string content1, string content2)
        {
            DataRow DataRowDepo = DataTableDepo.NewRow();

            DataRowDepo["Type"] = type;
            DataRowDepo["ID"] = id;
            DataRowDepo["Title"] = title;
            DataRowDepo["Location"] = location;
            DataRowDepo["Lock"] = locked;
            DataRowDepo["Content1"] = content1;
            DataRowDepo["Content2"] = content2;

            DataTableDepo.Rows.Add(DataRowDepo);
        }
        //sıkıntılı
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

            string title;

            if (Form_CustomMessageBox.CustomMessageBox.Joker != null)
            {
                title = CustomGroupBox.CGB.Title;
            }
            else
            {
                title = CustomGroupBox.CGB.Title;
            }


            Point location = CustomGroupBox.CGB.point;
         

            bool locked = CustomGroupBox.CGB.isLocked;

            string content1 = "";
            string content2 = "";

            if (type == "GroupPicture")
            {
                content1 = CustomGroupBox.CGB.LocationOfPicture;
                content2 = "";
            }
            else if (type == "GroupText")
            {
                content1 = "";
                content2 = "";
            }
            else if (type == "GroupDo" && CustomGroupBox.CGB.ToDoItemCount != 0)
            {
#pragma warning disable CS1690 // Başvuruya göre sıralanan bir sınıfın alanında üyeye erişmek çalışma zamanı özel durumuna neden olabilir
                content1 = CustomGroupBox.CGB.ToDoItemCount.ToString();
#pragma warning restore CS1690 // Başvuruya göre sıralanan bir sınıfın alanında üyeye erişmek çalışma zamanı özel durumuna neden olabilir
                content2 = CustomGroupBox.CGB.ToDoItemName;
            }

            Depola(type, id, title, location, locked, content1, content2);

        }
        public void Reload()
        {
            using (StreamReader sr = new StreamReader(@"deney.txt"))
            {

            }
        }

        public async void Writer(int id)
        {
            string[] Lines = new string[id];


            using (StreamWriter sw = new StreamWriter(@"deney.txt"))
            {
                await sw.WriteLineAsync(Class_Print.Array_string(Lines));
            }

        }
    }
}
