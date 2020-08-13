using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TestTask.Source.Class;

namespace TestTask
{
    public partial class EditForm : Form
    {
        Assets currentAssets;

        public EditForm(Assets assets)
        {
            InitializeComponent();
            currentAssets = assets;
            currentAssets.EditForm(AssetsFieldsData);
            AssetsFieldsData.AllowUserToDeleteRows = false;
            AssetsFieldsData.AllowUserToAddRows = false;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Применить изменения для данного актива?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                if (CheckFields() == null)
                {
                    currentAssets.SaveForm(AssetsFieldsData);
                    this.Close();
                }
                else
                {
                    var cell = CheckFields();
                    int row = cell.Item1;
                    int column = cell.Item2;
                    AssetsFieldsData.ClearSelection();
                    AssetsFieldsData[column, row].Selected = true;
                    string message = "Строка " + (row+1) + ", Столбец " + (column+1) + " - ячейка не может быть пустой!";
                    MessageBox.Show(message);
                }
            }
        }

        private Tuple<int, int> CheckFields()
        {
            for(int i = 0; i < AssetsFieldsData.RowCount; i++)
            {
                if (AssetsFieldsData[0, i].Value == null && AssetsFieldsData[1, i].Value == null && i == AssetsFieldsData.RowCount - 1)
                {
                    continue;
                }
                if (AssetsFieldsData[0, i].Value == null)
                {
                    return Tuple.Create<int, int>(AssetsFieldsData[0, i].RowIndex, AssetsFieldsData[0, i].ColumnIndex);
                } 
                if (AssetsFieldsData[1, i].Value == null)
                {
                    return Tuple.Create<int, int>(AssetsFieldsData[1, i].RowIndex, AssetsFieldsData[1, i].ColumnIndex);
                }
            }
            return null;
        }

        private void AssetsFieldsData_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           AssetsFieldsData.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }

        private void AssetsFieldsData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("В данной ячейке допустимы только числовые данные!");
            e.Cancel = true;
        }
    }
}
