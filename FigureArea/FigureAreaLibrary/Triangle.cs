using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLibrary
{
    public class Triangle : IFigure
    {
        private double a, b, c;
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
        /// Конструктор класса Triangle
        /// </summary>
        public Triangle()
        {
            name = this.GetType().Name.ToString();
        }

        /// <summary>
        /// Конструктор класса Triangle с 3-мя параметрами
        /// </summary>
        /// <param name="sides">Параметры со значением сторон треугольника</param>
        public Triangle(double a, double b, double c) : this()
        {
            SetParams(a, b, c);
        }

        /// <summary>
        /// Конструктор класса Triangle с параметрами
        /// </summary>
        /// <param name="sides">Параметры со значением сторон треугольника</param>
        public Triangle(params double[] sides) : this()
        {
            SetParams(sides);
        }

        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns> Возвращает значение площади треугольника</returns>
        public double Area()
        {
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }

        /// <summary>
        /// Установка значений сторон треугольника
        /// </summary>
        /// <param name="sides">Параметры со значением сторон тругольника</param>
        public bool SetParams(params double[] sides)
        {
            if (CheckingForCorrectness(sides))
            {
                a = sides[0];
                b = sides[1];
                c = sides[2];

                TriangleType();

                return true;
            }
            else
            {
                return false;
            }            
        }

        // Проверка корректности сторон треугольника
        private bool CheckingForCorrectness(params double[] sides)
        {
            double _a = sides[0];
            double _b = sides[1];
            double _c = sides[2];

            if ((sides.Length == 3) 
                && (_a > 0) && (_b > 0) && (_c > 0)
                && (_a + _b  > _c) && (_a + _c > _b) && (_b + _c > _a))
            {
                return true;
            } 
            
            return false;
        }

        // Проверка прямоугольный треугольник или нет
        private void TriangleType()
        {
            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
            {
                name = string.Format("Right {0}", name);
            }
        }

    }
}
