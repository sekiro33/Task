using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask.Source.Class
{
    /// <summary>
    /// Класс определяющий актив типа "В кассе"
    /// </summary>
    class Cash : Monetary
    {
        /// <summary>
        /// В чём хранится 
        /// </summary>
        public string Value { get; set; }

        public override void EditForm(DataGridView data)
        {
            data.Rows.Add("Название актива", AssetsName);
            data.Rows.Add("В чём хранится", Value);
            data.Rows.Add("Сумма", TotalSum);

            data[1, 2].ValueType = typeof(int);

            data.Rows.Add("Валюта", Currency);
            data.AllowUserToDeleteRows = false;
            data.AllowUserToAddRows = false;
        }

        public override void SaveForm(DataGridView data)
        {
            AssetsName = data[1, 0].Value.ToString();
            Value = data[1, 1].Value.ToString();
            TotalSum = Int32.Parse(data[1, 2].Value.ToString());
            Currency = data[1, 3].Value.ToString();
        }
    }
}
