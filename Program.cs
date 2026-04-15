using System;
using System.Windows.Forms;
using AirQualityModules;

namespace AirQualityModules
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AirQualityForm());
        }
    }
}