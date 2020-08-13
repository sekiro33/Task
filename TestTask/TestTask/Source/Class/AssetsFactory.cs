using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Source.Class
{
    /// <summary>
    /// Вспомогательный класс для формы создания активов
    /// Содержит все типы конкретных активов
    /// </summary>
    static public class AssetsFactory
    {
        //Массив со всеми определенными типами активов
        //Используется в выпадающем меню в форме AddForm при создании активов
        static public string[] AssetsType =
        {
            "Счёт в банке",
            "В кассе",
            "Неденежный актив"
        };

        static public Assets CreateAssets(string type)
        {
            switch(type)
            {
                case "Счёт в банке":
                    return new Bank();
                case "В кассе":
                    return new Cash();
                case "Неденежный актив":
                    return new NonMonetary();
                default:
                    throw new Exception("Нет такого типа");
            }
        }
    }
}
