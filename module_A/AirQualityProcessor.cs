using System.Drawing;

namespace AirQualityModules
{
    public class AirQualityProcessor
    {
        /// <summary>
        /// Возвращает данные по качеству воздуха за выбранный месяц
        /// </summary>
        public AirQualityReport GetReport(string month)
        {
            return month.ToLower() switch
            {
                "март" => new AirQualityReport("Март", 32, "Хорошо", Color.Green),
                "апрель" => new AirQualityReport("Апрель", 145, "Опасно", Color.Red),
                // Добавь другие месяцы по необходимости
                _ => new AirQualityReport(month, 0, "Нет данных", Color.Gray)
            };
        }
    }

    public class AirQualityReport
    {
        public string Month { get; }
        public int Aqi { get; }
        public string Status { get; }
        public Color Color { get; }

        public AirQualityReport(string month, int aqi, string status, Color color)
        {
            Month = month;
            Aqi = aqi;
            Status = status;
            Color = color;
        }
    }
}