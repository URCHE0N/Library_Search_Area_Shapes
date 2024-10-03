namespace AreaShapes
{
    public class Circle : IFigure
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Введенные данные равны нулю или отрицательные!");
            _radius = radius;
        }

        public double Area()
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2), 5);
        }
    }
}
