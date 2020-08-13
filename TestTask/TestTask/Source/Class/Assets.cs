using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask.Source.Class
{
    abstract public  class Assets
    {
        public string AssetsName { get; set; }
        public string Currency { get; set; }

        abstract public void SaveForm(DataGridView data);
        abstract public void EditForm(DataGridView data);

        public override string ToString()
        {
            return AssetsName;
        }
    }
}
