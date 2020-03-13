using ITEAProject11032020.Interfaces;
using System;

namespace ITEAProject11032020.Classes
{
    /// <summary>
    /// Запретить наследование
    /// </summary>
    public sealed class Temp: Temp2, ITemp, ITemp2
    {
        /// <summary>
        /// Свойство 1
        /// </summary>
        public string Cipher { get; set; }
        /// <summary>
        /// Свойство 2
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Свойство 3
        /// </summary>
        public string Comment { get; set; }

        private int field1 = 0;
        /// <summary>
        /// Поле 1 (get)
        /// </summary>
        public int Field1 { get { return field1; } }

        private int field2;
        /// <summary>
        /// Поле 2 (get/set)
        /// </summary>
        public int Field2 {
            get { return field2; }
            private set { field2 = value; }
        }

        /// <summary>
        /// Конструктор с параметрами на 3 поля которые были в начале
        /// </summary>
        /// <param name="cipher"></param>
        /// <param name="count"></param>
        /// <param name="comment"></param>
        public Temp(string cipher, int count, string comment)
        {
            this.Cipher = cipher;
            this.Count = count;
            this.Comment = comment;
            StatVar++;
        }

        /// <summary>
        /// метод возвращает значение
        /// </summary>
        /// <returns></returns>
        public string GetCipher()
        {
            return this.Cipher;
        }

        /// <summary>
        /// метод в параметрами невозвращающий значение
        /// </summary>
        /// <param name="value"></param>
        public void AddCountValue(int value)
        {
            this.Count += value;
        }

        /// <summary>
        /// Статическое поле, для подсчета количества созданных объектов
        /// </summary>
        static int StatVar;

        /// <summary>
        /// Статический метод для вывода подсчета количества созданных объектов
        /// </summary>
        /// <returns></returns>
        public static string SetStatVar()
        {
            return $"Создано объектов {StatVar}";
        }

        #region Реализация интерфейсов

        bool isactive;
        public bool IsActive
        {
            get { return this.isactive; }
            set { this.isactive = value; }
        }

        void ITemp.GetValues()
        {
            this.Count = 100;
        }

        void ITemp2.GetValues()
        {
            this.Count = 150;
        }

        #endregion

        #region Наследование абстрактного класса

        public override int Method1()
        {
            return this.Count;
        }

        #endregion

        #region Переопределение методов

        /// <summary>
        /// Вывод основных параметров
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Параметры класса: {Cipher}; {Count}; {Comment}";
        }

        /// <summary>
        /// Сравнение Заголовков
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return this.Cipher.Equals(((Temp)obj).Cipher, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

    }
}
