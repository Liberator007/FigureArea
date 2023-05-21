using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureAreaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaTest
{
    [TestClass()]
    public class TriangleTests
    {
        private double a, b, c, d;
        private double[] sides;
        private double[] negativeSides;
        private double[] invalidParameters;
        private IFigure triangleTest;

        [TestInitialize()]
        public void TestInitialize()
        {
            a = 5;
            b = 7;
            c = 9;
            d = 11;
            sides = new double[] { 3, 4, 5};
            invalidParameters = new double[] { 3, 4, 10};
            negativeSides = new double[] { -3, 6, 8};
            triangleTest = new Triangle();
        }

        // Создание класса типа Triangle при 3-ех введенных параметрах
        [TestMethod()]
        public void CreateTriangleTest()
        {
            string actual = "Triangle";
            IFigure triangle = new Triangle(sides);
            Assert.AreEqual(triangle.GetType().Name, actual);
        }

        // Вычисление площади треугольника
        [TestMethod()]
        public void AreaTest()
        {
            double actual = 6;
            triangleTest.SetParams(sides);
            double expected = triangleTest.Area();
            Assert.AreEqual(expected, actual);
        }

        // Вычисление типа треугольника как прямоуголный
        // А также вывод типа фигуры через свойство Name
        [TestMethod()]
        public void RightTriangleTest()
        {
            string actual = "Right Triangle";
            triangleTest.SetParams(sides);
            string expected = triangleTest.Name;
            Assert.AreEqual(expected, actual);
        }

        // Вычисление типа треугольника как непрямоуголный
        // А также вывод типа фигуры через свойство Name
        [TestMethod()]
        public void NoRightTriangleTest()
        {
            string actual = "Triangle";
            triangleTest.SetParams(a, b, c);
            string expected = triangleTest.Name;
            Assert.AreEqual(expected, actual);
        }

        // Установка корректных сторон треугольника
        [TestMethod()]
        public void SetCorrectParamsTest()
        {
            bool actual = true;
            bool expected = triangleTest.SetParams(sides);
            Assert.AreEqual(expected, actual);
        }

        // Установка сторон треугольника с отрицательным значением
        // (невозможность существования данного треугольника)
        [TestMethod()]
        public void SetNegativeParamsTest()
        {
            bool actual = false;
            bool expected = triangleTest.SetParams(negativeSides);
            Assert.AreEqual(expected, actual);
        }

        // Установка сторон треугольника с где сумма двух сторон меньше значения третьей
        // (невозможность существования данного треугольника)
        [TestMethod()]
        public void SetInvalidParamsTest()
        {
            bool actual = false;
            bool expected = triangleTest.SetParams(invalidParameters);
            Assert.AreEqual(expected, actual);
        }

        // Установка сторон треугольника с 4 переменными (сторонами)
        // (невозможность существования данного треугольника)
        [TestMethod()]
        public void SetLargeNumberOfParamsTest()
        {
            bool actual = false;
            bool expected = triangleTest.SetParams(a, b, c, d);
            Assert.AreEqual(expected, actual);
        }
    }
}