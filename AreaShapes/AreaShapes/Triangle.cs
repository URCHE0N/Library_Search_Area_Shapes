namespace AreaShapes
{
    public class Triangle : IFigure
    {
        private double _a, _b, _c;

        public Triangle (double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Введенные данные равны нулю или отрицательные!");
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Введенные данные не образуют треугольник!");
            _a = a;
            _b = b;
            _c = c;
        }

        public double Area()
        {
            double p  = (_a + _b + _c) / 2;
            return Math.Round(Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c)), 5);
        }

        public string CheckRightTriangle()
        {
            double[] sides = [_a, _b, _c];
            Array.Sort(sides);
            double bigSide = Math.Pow(sides[2], 2);
            double smallSide = (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2));
            if (bigSide == smallSide)
            {
                return "прямоугольный";
            }
            return "не прямоугольный";
        }
    }
}
