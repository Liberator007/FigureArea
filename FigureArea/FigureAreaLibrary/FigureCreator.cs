namespace FigureAreaLibrary
{
    // Для добавления новой фигуры необходимо создать класс наследуемый от
    // интрефейса IFigure и добавить создание эземпляра класса в класс FigureCreator
    // в конструкцию sitch-case (где необохдимо указать количество параметров, которые
    // будут передаваться в конструктор при создании фигуры)
    public class FigureCreator: IFigureCreator
    {

        /// <summary>
        /// Конструктор класса CreateFigure с параметрами
        /// </summary>
        /// <param name="sides">Параметры со значением сторон фигуры, или радиуса если параметр один</param>
        /// <returns>Возвращает тип фигуры</returns>
        public IFigure? CreateFigure(params double[] sides)
        {

            // Определение типа фигуры
            switch (sides.Length)
            {
                case 1:
                    {
                        return new Circle(sides[0]);
                    }
                case 3:
                    {
                        return new Triangle(sides[0], sides[1], sides[2]);
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}