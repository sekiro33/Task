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
    public partial class AssetsEditor : Form
    {
        int currentAssets = -1;

        public AssetsEditor()
        {
            InitializeComponent();
            InitializeAssets();
        }

        public void InitializeAssets()
        {
            Bank bank1 = new Bank
            {
                AssetsName = "Счёт в банке ЕвроВорБанк",
                BankName = "ЕвроВорБанк",
                AccountNumber = 5,
                TotalSum = 1000,
                Currency = "RUB"
            };
            Bank bank2 = new Bank
            {
                AssetsName = "Счет в банке Внешторгбанк",
                BankName = "Внешторгбанк",
                AccountNumber = 3,
                TotalSum = 5,
                Currency = "USD"
            };
            Cash cash1 = new Cash
            {
                AssetsName = "Деньги в кассе",
                Value = "Деньги",
                TotalSum = 100,
                Currency = "RUB"
            };
            Cash cash2 = new Cash
            {
                AssetsName = "Деньги в кассе",
                Value = "Талоны на бензин от Аспека",
                TotalSum = 3000,
                Currency = "RUB"
            };
            NonMonetary nonMonetary1 = new NonMonetary
            {
                AssetsName = "Торговое здание",
                FirstValue = 30000,
                SecondValue = 5000,
                ThirdValue = 1000000,
                Currency = "RUB",
                NameOfParams = new List<string>
                {
                "Адрес",
                "Год постройки",
                "Инвентарный номер"
                },
                ValueOfParams = new List<string>
                {
                "Бассейная-6",
                "1970",
                "7"
                }
            };
            NonMonetary nonMonetary2 = new NonMonetary
            {
                AssetsName = "Гвозди",
                FirstValue = 1000,
                SecondValue = 100,
                ThirdValue = 100,
                Currency = "RUB",
                NameOfParams = new List<string>
                {
                "Количество",
                "Год изготовления"
                },
                ValueOfParams = new List<string>
                {
                "100 киллограммов",
                "2000"
                }
            };

            assets.Items.Add(bank1);
            assets.Items.Add(bank2);
            assets.Items.Add(cash1);
            assets.Items.Add(cash2);
            assets.Items.Add(nonMonetary1);
            assets.Items.Add(nonMonetary2);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (currentAssets != -1)
            {
                EditForm editForm = new EditForm((Assets)assets.SelectedItem);
                editForm.ShowDialog();
            }
            else if(currentAssets == -1 && assets.Items.Count != 0)
            {
                MessageBox.Show("Не выбран актив для редактирования!");
            }
            else if(assets.Items.Count == 0)
            {
                MessageBox.Show("Список активов пуст!");
            }
        }

        private void AddButton_Click(object sender, MouseEventArgs e)
        {
            AddForm addForm = new AddForm(assets);
            addForm.ShowDialog();
        }

        private void DeleteButton_Click(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Удалить выбранный актив?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            if (currentAssets != -1 && result == DialogResult.Yes)
            { 
                assets.Items.RemoveAt(currentAssets);
                currentAssets = -1;
            }
        }

        private void assets_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentAssets = assets.SelectedIndex;
        }
    }
}
