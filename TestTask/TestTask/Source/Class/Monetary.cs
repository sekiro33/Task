using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Source.Class
{
    abstract class Monetary : Assets
    {
        public int TotalSum { get; set; }
    }
}
