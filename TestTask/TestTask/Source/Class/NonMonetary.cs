using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask.Source.Class
{
    class NonMonetary : Assets
    {
        public int FirstValue { get; set; }
        public int SecondValue { get; set; }
        public int ThirdValue { get; set; }

        //списки для дополнительных параметров (названия + значения)
        public List<string> NameOfParams = new List<string>();
        public List<string> ValueOfParams = new List<string>();

        public override void EditForm(DataGridView data)
        {
            data.Rows.Add("Название актива", AssetsName);
            data.Rows.Add("Начальная балансовая стоимость", FirstValue);
            data.Rows.Add("Остаточная балансовая стоимость", SecondValue);
            data.Rows.Add("Оценочная стоимость", ThirdValue);
            data.Rows.Add("Валюта", Currency);

            data[1, 1].ValueType = typeof(int);
            data[1, 2].ValueType = typeof(int);
            data[1, 3].ValueType = typeof(int);

            if (NameOfParams.Count != 0)
            {
                for (int i = 0; i < NameOfParams.Count; i++)
                {
                    data.Rows.Add(NameOfParams[i], ValueOfParams[i]);
                }
            }

            //Разрешаем добавление новых строк и запрещаем изменять первые 5 параметров
            data.AllowUserToAddRows = true;
            data.AllowUserToDeleteRows = true;
            data.Columns[0].ReadOnly = false;
            for(int i = 0; i < 5; i++)
            {
                data.Rows[i].Cells[0].ReadOnly = true;
            }
        }

        public override void SaveForm(DataGridView data)
        {
            AssetsName = data[1, 0].Value.ToString();
            FirstValue = Int32.Parse(data[1, 1].Value.ToString());
            SecondValue = Int32.Parse(data[1, 2].Value.ToString());
            ThirdValue = Int32.Parse(data[1, 3].Value.ToString());
            Currency = data[1, 4].Value.ToString();
            NameOfParams.Clear();
            ValueOfParams.Clear();
            for (int i = 5; i < data.Rows.Count; i++)
            {
                if (data[0, i].Value == null && data[1, i].Value == null && i == data.RowCount - 1)
                {
                    continue;
                }
                NameOfParams.Add(data[0, i].Value.ToString());
                ValueOfParams.Add(data[1, i].Value.ToString());
            }
        }
    }
}
