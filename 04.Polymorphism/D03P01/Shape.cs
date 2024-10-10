namespace D03P01
{
    public abstract class Shape
    {
        public virtual string Draw()
        {
            return "Shape: ";
        }
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
