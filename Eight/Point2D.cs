namespace Eight
{
    internal class Point2D
    {
        internal float x;
        internal float y;

        static float CalculateDistance(Point2D point1, Point2D point2) 
        {
            float distance = (float)Math.Sqrt(Math.Pow((point1.x - point2.x),2) + Math.Pow((point1.y - point2.y), 2));
            return distance;
        }

        static void Main(string[] args)
        {
            Point2D point1 = new Point2D();
            point1.x = 3.67f;
            point1.y = 1.0f;

            Point2D point2 = new Point2D();
            point1.x = 7.7f;
            point1.y = 4.55f;

            float distance = CalculateDistance(point1, point2);
            Console.WriteLine("The distance between point1 and point2 is: " + distance);
        }
    }
}
