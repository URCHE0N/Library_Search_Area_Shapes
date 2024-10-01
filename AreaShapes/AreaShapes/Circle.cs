namespace AreaShapes
{
    public class Circle : IFigure
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Area()
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2), 5);
        }
    }
}
