using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ModenovaAP.Sprint7.Project.V6.Lib;

namespace Tyuiu.ModenovaAP.Sprint7.Project.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        string[,] array = { { "1", "Капустин Андрей Геннадьевич", "06.01.2000", "Кто-то очень жёсткий", "Кардиолог", "Тахикардия", "Да", "10", "Да"},
                            { "2", "Комиссаров Лаврентий Наумович", "06.01.2000", "Кто-то очень жёсткий", "Кардиолог", "Тахикардия", "Да", "9", "Да"},
                            { "3", "Ларионов Нисон Вадимович", "06.01.2000", "Кто-то очень жёсткий", "Кардиолог", "Тахикардия", "Да", "1", "Да"},
                            { "4", "Капустин Андрей Геннадьевич", "06.01.2000", "Кто-то очень жёсткий", "Кардиолог", "Тахикардия", "Да", "2", "Да"},
                            { "5", "Капустин Андрей Геннадьевич", "06.01.2000", "Кто-то очень жёсткий", "Кардиолог", "Тахикардия", "Да", "5", "Да"}};
        string name = "Капустин Андрей Геннадьевич";
        [TestMethod]
        public void TestTimesPatient()
        {
            int res = ds.TimesPatient(array, name);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void TestMinTime()
        {
            int res = ds.MinTime(array, name);
            Assert.AreEqual(2, res);
        }
        [TestMethod]
        public void TestMaxTime()
        {
            int res = ds.MaxTime(array, name);
            Assert.AreEqual(10, res);
        }
        [TestMethod]
        public void TestAvgTime()
        {
            int res = ds.AvgTime(array, name);
            Assert.AreEqual(5, res);
        }
        
    }
}
