namespace D03P01
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle()
        {
        }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return width * height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * width + 2 * height;
        }

        public override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}
