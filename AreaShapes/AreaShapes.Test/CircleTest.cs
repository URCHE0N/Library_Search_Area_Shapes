namespace AreaShapes.Tests
{
    public class CircleTest
    {
        AreaCalculate areaCalculate = new AreaCalculate();

        [Test]
        public void Area_5_EqualTo_78AHalf_True()
        {
            IFigure circle = new Circle(5);
            double expectedArea = 78.53982;

            double actualArea = areaCalculate.Calculate(circle);

            Assert.That(expectedArea, Is.EqualTo(actualArea));
        }

        [Test]
        public void Area_Minus2AHalf_Exception_True()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-2.5));
        }
    }
}