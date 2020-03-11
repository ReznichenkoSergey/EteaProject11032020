using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectEtea1.Classes
{
    /// <summary>
    /// 12. Создайте класс Extensions, в него добавьте extension метод для вашего изначального класса
    /// </summary>
    public static class Extensions
    {
        public static string GetDate(this Temp temp)
        {
            return temp.GetCipher();
        }
    }
}
