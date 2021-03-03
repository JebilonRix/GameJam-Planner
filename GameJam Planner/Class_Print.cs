using System.IO;
using System.Windows.Forms;

namespace GameJam_Planner
{
    public class Class_Print
    {
        private static string Array_string(string[] potis)
        {
            string result = "";

            foreach (var item in potis)
            {
                result += "|_" + item.ToString() + "\n";
            }
            result += "";

            return result;
        }
        private static string Organizer(string[] Entry)
        {
            string x = "";

            if (Entry[0] == "") { }

            else
            {
                x = Array_string(Entry);
            }

            return x;
        }
        public async void Printer(string[] MainLines1, string[] MainLines2, string[] MainLines3, string[] MainLines4, string[] MainLines5, string[] MainLines6, string[] MainLines7, string[] MainLines8, string[] MainLines9, string[] MainLines10)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        string PrintLine =
                            "GENERAL" + "\n" +
                            "Group Name:" + MainLines1[0] + "\n"
                           + "Theme:" + MainLines1[1] + "\n"
                           + "Name:" + MainLines1[2] + "\n"
                           + "Genre:" + MainLines1[3] + "\n"
                           + "Style:" + MainLines1[4] + "\n"
                           + "Engine:" + MainLines1[5] + "\n" + "\n"
                           + "MAIN" + "\n"
                           + "Dynamics" + "\n" + Organizer(MainLines2) + "\n"
                           + "Mechanics" + "\n" + Organizer(MainLines3) + "\n" + "\n"
                           + "CODE" + "\n"
                           + "Classes" + "\n" + Organizer(MainLines4) + "\n"
                           + "Methods" + "\n" + Organizer(MainLines5) + "\n" + "\n"
                           + "ART" + "\n"
                           + "Characters" + "\n" + Organizer(MainLines6) + "\n"
                           + "Objects" + "\n" + Organizer(MainLines7) + "\n"
                           + "Animations" + "\n" + Organizer(MainLines8) + "\n" + "\n"
                           + "AUDIO" + "\n"
                           + "Musics" + "\n" + Organizer(MainLines9) + "\n"
                           + "Sounds" + "\n" + Organizer(MainLines10) + "\n";


                        await sw.WriteLineAsync(PrintLine);
                        MessageBox.Show("Done.");
                    }
                }

            }
        }
   
        // fırmül
    }
}
