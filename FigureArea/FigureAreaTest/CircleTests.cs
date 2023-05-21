using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureAreaLibrary;

namespace FigureAreaTest
{
    [TestClass]
    public class CircleTests
    {
        private double radius;
        private double negativeRadius;
        private double[] sides;
        private IFigure circleTest;

        [TestInitialize()]
        public void TestInitialize()
        {
            radius = 5;
            negativeRadius = -3;
            sides = new double[] { 3, 4 };
            circleTest = new Circle();
        }

        // Создание класса типа Circle при одном введенном параметре (радиусе)
        [TestMethod()]
        public void CreateCircleTest()
        {
            string actual = "Circle";
            IFigure circle = new Circle(radius);
            Assert.AreEqual(circle.GetType().Name, actual);
        }

        // Вычисление площади круга
        [TestMethod]
        public void AreaTest()
        {
            double expected = Math.PI * Math.Pow(radius, 2);
            circleTest.SetParams(radius);
            double actual = circleTest.Area();
            Assert.AreEqual(expected, actual, "Площадь круга с радиусом {0} должна быть равна {1}", radius, expected);
        }

        // Вычисление типа фигуры
        // А также вывод типа фигуры (круга) через свойство Name
        [TestMethod()]
        public void TypeFigureTest()
        {
            string actual = "Circle";
            circleTest.SetParams(radius);
            string expected = circleTest.Name;
            Assert.AreEqual(expected, actual);
        }

        // Установка корректного радиуса круга
        [TestMethod()]
        public void SetCorrectParamsTest()
        {
            bool actual = true;
            bool expected = circleTest.SetParams(radius);
            Assert.AreEqual(expected, actual);
        }

        // Установка радиуса круга с отрицательным значением
        // (невозможность существования данного круга)
        [TestMethod()]
        public void SetNegativeParamsTest()
        {
            bool actual = false;
            bool expected = circleTest.SetParams(negativeRadius);
            Assert.AreEqual(expected, actual);
        }

        // Установка параметров круга с 2 переменными (сторонами)
        // (невозможность существования круга)
        [TestMethod()]
        public void SetLargeNumberOfParamsTest()
        {
            bool actual = false;
            bool expected = circleTest.SetParams(sides);
            Assert.AreEqual(expected, actual);
        }
    }
}