using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FProjectEtea1.Classes
{
    /// <summary>
    /// Создайте свой класс Exception. Переопределите конструкторы. Добавьте отлов ошибок в метод Main
    /// </summary>
    public class MyException: Exception
    {
        public MyException() : base()
        {
        }

        public MyException(string message) : base(message)
        {
        }

        public MyException(string message, Exception ex) : base(message, ex)
        {
        }

        public MyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

    }
}
