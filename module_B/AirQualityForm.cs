using System;
using System.Drawing;
using System.Windows.Forms;
using AirQualityModules;   // ссылка на module_A

namespace AirQualityModules
{
    public partial class AirQualityForm : Form
    {
        private readonly AirQualityProcessor _processor = new AirQualityProcessor();

        private Label lblTitle;
        private Label lblResult;
        private Button btnMarch;
        private Button btnApril;

        public AirQualityForm()
        {
            InitializeComponent();
            SetupMyDesign();
        }

        private void SetupMyDesign()
        {
            this.Text = "Анализ качества воздуха";
            this.Size = new Size(400, 300);
            this.BackColor = Color.WhiteSmoke;

            lblTitle = new Label
            {
                Text = "Выберите месяц для отчета:",
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(30, 20),
                AutoSize = true
            };

            btnMarch = new Button
            {
                Text = "Март",
                Location = new Point(30, 60),
                Size = new Size(100, 40),
                BackColor = Color.LightBlue
            };
            btnMarch.Click += (s, e) => ShowReport("Март");

            btnApril = new Button
            {
                Text = "Апрель",
                Location = new Point(150, 60),
                Size = new Size(100, 40),
                BackColor = Color.LightCoral
            };
            btnApril.Click += (s, e) => ShowReport("Апрель");

            lblResult = new Label
            {
                Text = "Данные не выбраны",
                Font = new Font("Arial", 11),
                Location = new Point(30, 130),
                Size = new Size(320, 100)
            };

            this.Controls.Add(lblTitle);
            this.Controls.Add(btnMarch);
            this.Controls.Add(btnApril);
            this.Controls.Add(lblResult);
        }

        private void ShowReport(string month)
        {
            var report = _processor.GetReport(month);
            lblResult.Text = $"Отчет за {report.Month}:\n\nСредний AQI: {report.Aqi}\nСтатус: {report.Status}";
            lblResult.ForeColor = report.Color;
        }
    }
}