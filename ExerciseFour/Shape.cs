namespace ExerciseFour
{
    internal class Shape
    {

        internal virtual double calculateArea()
        {
            return 0;
        }
    }

    internal class Circle : Shape
    {

        private float radius;
        internal Circle(float radius)
        {
            this.radius = radius;
        }

        internal override double calculateArea()
        {
            double Area = 3.14 * (this.radius) * (this.radius);
            return Area;
        }

        static void Main (String[] args)
        {
            Circle circle = new Circle(8);
            double area = circle.calculateArea();
            Console.WriteLine("The area of circle is: " + area);
        }
    }
}
