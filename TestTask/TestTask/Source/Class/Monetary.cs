using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Source.Class
{
    /// <summary>
    /// Класс определяющий денежные активы
    /// Все денежные активы должны наследовать данный класс
    /// </summary>
    abstract class Monetary : Assets
    {
        /// <summary>
        /// Общая сумма
        /// </summary>
        public int TotalSum { get; set; }
    }
}
