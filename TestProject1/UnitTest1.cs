using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample_project.Models;
namespace UnitTestTemperature
{
    [TestClass]
    public class UnitTestFahrenheit
    {
        private object[] correctly;

        [TestMethod]
        public void TestFahrenheitConversion()
        {
            double temperatureCelcius = 22;
            double temperatureFahrenheitActual;
            double temperatureFahrenheitExpected = 71.6;
            temperatureFahrenheitActual = Temperature.CelciusToFahrenheit(temperatureCelcius);
            Assert.AreEqual(temperatureFahrenheitExpected, temperatureFahrenheitActual, 0.001, "Temperature conversion not correctly");
        }
    }
}