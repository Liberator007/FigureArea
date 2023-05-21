using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLibrary
{
    public class Circle : IFigure
    {
        private double radius;
        private string name;

        /// <summary>
        /// Получение типа фигуры
        /// </summary>
        /// <returns> Возвращает тип фигуры</returns>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Конструктор класса Circle
        /// </summary>
        public Circle()
        {
            name = this.GetType().Name.ToString();
        }

        /// <summary>
        /// Конструктор класса Circle с параметрами
        /// </summary>
        /// <param name="sides">Параметр со значением радиуса круга</param>
        public Circle(double radius) : this()
        {
            SetParams(radius);
        }

        /// <summary>
        /// Конструктор класса Circle с параметрами
        /// </summary>
        /// <param name="sides">Параметры со значением радиуса круга</param>
        public Circle(params double[] radius) : this()
        {
            SetParams(radius);
        }

        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <returns> Возвращает значение площади круга</returns>
        public double Area()
        {
            double S = Math.PI * Math.Pow(radius, 2);
            return S;
        }

        /// <summary>
        /// Установка значения радиуса круга
        /// </summary>
        /// <param name="sides">Параметр со значением радиуса круга</param>
        public bool SetParams(params double[] sides)
        {
            if (CheckingForCorrectness(sides))
            {
                radius = sides[0];
                return true;
            }
            else
            {
                return false;
            }
        }

        // Проверка корректности радиуса круга
        private bool CheckingForCorrectness(params double[] sides)
        {
            double _radius = sides[0];

            if ((sides.Length == 1) && (_radius > 0))
            {
                return true;
            }

            return false;
        }
    }
}
