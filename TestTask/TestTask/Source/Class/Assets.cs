using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask.Source.Class
{
    /// <summary>
    /// Абстрактный класс для активов
    /// </summary>
    abstract public  class Assets
    {
        /// <summary>
        /// Имя актива
        /// </summary>
        public string AssetsName { get; set; }

        /// <summary>
        /// Валюта
        /// </summary>
        public string Currency { get; set; }

        //методы определяющие заполнение данных в таблицу
        //и сохранение данных из таблицы
        abstract public void SaveForm(DataGridView data);
        abstract public void EditForm(DataGridView data);

        public override string ToString()
        {
            return AssetsName;
        }
    }
}
