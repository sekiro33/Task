using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask.Source.Class
{
    class Bank : Monetary
    {
        public string BankName { get; set; }
        public int AccountNumber { get; set; }

        public override void EditForm(DataGridView data)
        {
            data.Rows.Add("Название актива", AssetsName);
            data.Rows.Add("Название банка", BankName);
            data.Rows.Add("Номер счёта", AccountNumber);
            data.Rows.Add("Сумма на счёте", TotalSum);
            data.Rows.Add("Валюта", Currency);
            data.AllowUserToDeleteRows = false;
            data.AllowUserToAddRows = false;

            data[1, 2].ValueType = typeof(int);
            data[1, 3].ValueType = typeof(int);
        }

        public override void SaveForm(DataGridView data)
        {
            AssetsName = data[1, 0].Value.ToString();
            BankName = data[1, 1].Value.ToString();
            AccountNumber = Int32.Parse(data[1, 2].Value.ToString());
            TotalSum = Int32.Parse(data[1, 3].Value.ToString());
            Currency = data[1, 4].Value.ToString();
        }
    }
}
