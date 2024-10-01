namespace AreaShapes.Tests
{
    public class TriangleTest
    {
        AreaCalculate areaCalculate = new AreaCalculate();

        [Test]
        public void Area_15_8_10_EqualTo_37_True()
        {
            IFigure triangle = new Triangle(15, 8, 10);
            double expectedArea = 36.97888;

            double actualArea = areaCalculate.Calculate(triangle);

            Assert.That(expectedArea, Is.EqualTo(actualArea));
        }

        [Test]
        public void Area_5_2AHalf_3_NotEqualTo_4_True()
        {
            IFigure triangle = new Triangle(5, 2.5, 3);
            double expectedArea = 4;

            double actualArea = areaCalculate.Calculate(triangle);

            Assert.That(expectedArea, Is.Not.EqualTo(actualArea));
        }

        [Test]
        public void CheckRightTriangle_25_7_24_True()
        {
            IFigure triangle = new Triangle(25, 7, 24);
            string expectedRightTriangle = "прямоугольный";

            string actualRightTriangle = ((Triangle)triangle).CheckRightTriangle();

            Assert.That(expectedRightTriangle, Is.EqualTo(actualRightTriangle));
        }

        [Test]
        public void CheckRightTriangle_5_4_2_False()
        {
            IFigure triangle = new Triangle(5, 4, 2);
            string expectedRightTriangle = "прямоугольный";

            string actualRightTriangle = ((Triangle)triangle).CheckRightTriangle();

            Assert.That(expectedRightTriangle, Is.Not.EqualTo(actualRightTriangle));
        }

        [Test]
        public void Sides_Negative_Value_True()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-25, 8, -20));
        }

        [Test]
        public void Sides_NonNegative_Value_True()
        {
            Assert.DoesNotThrow(() => new Triangle(25, 8, 20));
        }

        [Test]
        public void Sides_NotForm_Triangle_True()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
        }

        [Test]
        public void Sides_Form_Triangle_Tru()
        {
            Assert.DoesNotThrow(() => new Triangle(3, 3, 5));
        }
    }
}
