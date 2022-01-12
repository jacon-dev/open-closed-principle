namespace OpenClose.PolymorphicExample
{
    public class PolymorphicAreaCalculator
    {
        public double CalculateShapeArea(object[] shapes)
        {
            double area = 0;
            
            foreach (var shape in shapes)
            {
                if (shape is Rectangle rectangle)
                {
                    area = rectangle.Width * rectangle.Height;
                }
            }

            return area;
        }
    }

    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class Circle
    {
        public double Radius { get; set; }
    }
}