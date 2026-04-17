using Microsoft.VisualStudio.TestTools.UnitTesting;
using AirQualityModules;
using System.Drawing;

namespace AirQualityTests
{
    [TestClass]
    public class AirQualityProcessorTests
    {
        private AirQualityProcessor _processor;

        [TestInitialize]
        public void Setup()
        {
            _processor = new AirQualityProcessor();
        }

        [TestMethod]
        public void GetReport_March_ReturnsCorrectData()
        {
            var report = _processor.GetReport("Март");
            Assert.AreEqual("Март", report.Month);
            Assert.AreEqual(32, report.Aqi);
            Assert.AreEqual("Хорошо", report.Status);
            Assert.AreEqual(Color.Green, report.Color);
        }

        [TestMethod]
        public void GetReport_April_ReturnsCorrectData()
        {
            var report = _processor.GetReport("Апрель");
            Assert.AreEqual("Апрель", report.Month);
            Assert.AreEqual(145, report.Aqi);
            Assert.AreEqual("Опасно", report.Status);
            Assert.AreEqual(Color.Red, report.Color);
        }

        [TestMethod]
        public void GetReport_UnknownMonth_ReturnsNoData()
        {
            var report = _processor.GetReport("Май");
            Assert.AreEqual("Май", report.Month);
            Assert.AreEqual(0, report.Aqi);
            Assert.AreEqual("Нет данных", report.Status);
        }

        [TestMethod]
        public void GetReport_CaseInsensitive()
        {
            var report = _processor.GetReport("март");
            Assert.AreEqual("Март", report.Month);
        }
    }
}