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
    public class FigureCreatorTests
    {
        private double a, b, c, d;
        private double[] sides;
        private IFigureCreator figureCreator;

        [TestInitialize()]
        public void TestInitialize()
        {
            a = 3;
            b = 4;
            c = 5;
            d = 11;
            sides = new double[] { 3, 4, 5};
            figureCreator = new FigureCreator();
        }

        // Вычисление площади фигуры без знания типа фигуры
        [TestMethod()]
        public void AreaFigureTest()
        {
            double actual = 6;
            
            IFigure figure = figureCreator.CreateFigure(sides);
            double expected = figure.Area();

            Assert.AreEqual(expected, actual);
        }

        // Создание класса типа Triangle при 3-ех введенных параметрах
        [TestMethod()]
        public void CreateFigureTriangleTest()
        {
            IFigure figure = figureCreator.CreateFigure(sides);
            Assert.AreEqual(figure.GetType().Name, "Triangle");
        }

        // Создание класса типа Круг при одном введенном параметре
        [TestMethod()]
        public void CreateFigureCircleTest()
        {
            IFigure figure = figureCreator.CreateFigure(a);
            Assert.AreEqual(figure.GetType().Name, "Circle");
        }

        // Вывод Null при неправильном наборе параметров
        [TestMethod()]
        public void CreateFigureIsNullTest()
        {
            IFigure figure = figureCreator.CreateFigure(a, b, c, d);
            Assert.IsNull(figure);
        }
    }
}