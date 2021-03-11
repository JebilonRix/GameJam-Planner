using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam_Planner
{
    public class Class_Depo
    {
        public void DepoText()
        {
            DataTable dataTableText = new DataTable();
            dataTableText.Columns.Add("BoxName",typeof(string));
            dataTableText.Columns.Add();
            dataTableText.Columns.Add();
            dataTableText.Columns.Add();
            dataTableText.Columns.Add();
            dataTableText.Columns.Add();
            dataTableText.Columns.Add();
            dataTableText.Columns.Add();
            dataTableText.Columns.Add();
            dataTableText.Columns.Add();
            dataTableText.Columns.Add();
        }
        public void DepoPicture()
        {
            DataTable dataTablePicture = new DataTable();
            dataTablePicture.Columns.Add("BoxName", typeof(string));
        }
        public void DepoTodo()
        {
            DataTable dataTableTodo = new DataTable();
            dataTableTodo.Columns.Add("BoxName", typeof(string));
        }


    }
}
