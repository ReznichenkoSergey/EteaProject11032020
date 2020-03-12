namespace ITEAProject11032020.Classes
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
