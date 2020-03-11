using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjectEtea1.Classes
{
    /// <summary>
    /// Абстрактный класс с абстрактным и виртуальным методом
    /// </summary>
    public abstract class Temp2
    {
        public abstract int Method1();

        public virtual string Method2()
        {
            return $"Hello!";
        }
    }
}
