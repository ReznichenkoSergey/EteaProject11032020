using System;
using System.Runtime.Serialization;

namespace ITEAProject11032020.Classes
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
