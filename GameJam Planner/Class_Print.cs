using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam_Planner
{
    public class Class_Print
    {

        //Print.Array_double
        public static string Array_double(double[] potis)
        {
            string result = "";
            foreach (var item in potis)
            {
                result += item.ToString() + " ";
            }
            result += "";
            return result;
        }
        public static string Array_int(int[] potis)
        {
            string result = "[ ";
            foreach (var item in potis)
            {
                result += item.ToString() + " ";
            }
            result += "] ";
            return result;
        }
        public static string Array_string(string[] potis)
        {
            string result = "";
            foreach (var item in potis)
            {
                result += item.ToString() + "/././";
            }
            result += "";
            return result;
        }
        public static string Matris_double(double[,] potis)
        {
            int rows = potis.GetLength(0);
            int colombus = potis.GetLength(1);

            string result = " ";
            for (int i = 0; i < rows; i++)
            {
                result += "[";
                for (int j = 0; j < colombus; j++)
                {
                    result += potis[i, j].ToString() + " ";
                }
                result += "]\n ";
            }
            return result;
        }
        public static string Matris_int(int[,] potis)
        {
            int rows = potis.GetLength(0);
            int colombus = potis.GetLength(1);

            string result = " ";
            for (int i = 0; i < rows; i++)
            {
                result += "[";
                for (int j = 0; j < colombus; j++)
                {
                    result += potis[i, j].ToString() + " ";
                }
                result += "]\n ";
            }
            return result;
        }
        public static string Matris_string(string[,] potis)
        {
            int rows = potis.GetLength(0);
            int colombus = potis.GetLength(1);

            string result = " ";
            for (int i = 0; i < rows; i++)
            {
                result += "[";
                for (int j = 0; j < colombus; j++)
                {
                    result += potis[i, j].ToString() + " ";
                }
                result += "]\n ";
            }
            return result;
        }
    }
}
