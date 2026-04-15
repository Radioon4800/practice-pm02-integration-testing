using System.Drawing;

namespace AirQualityModules
{
    public class AirQualityProcessor
    {

        public AirQualityReport GetReport(string month)
        {
            return month.ToLower() switch
            {
            string lowerMonth = month.ToLower();

    if (lowerMonth == "март")
                return new AirQualityReport("Март", 32, "Хорошо", Color.Green);

            if (lowerMonth == "апрель")
                return new AirQualityReport("Апрель", 145, "Опасно", Color.Red);


            if (lowerMonth == "апрель")
                return new AirQualityReport("Апрель", 45, "Хорошо", Color.Green);

            return new AirQualityReport(month, 0, "Нет данных", Color.Gray);
        };
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