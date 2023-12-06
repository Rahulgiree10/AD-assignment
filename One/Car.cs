namespace One
{
    internal class Car
    {
        private string brand;
        private int year;
        private float price;

        public Car(string brand, int year, float price)
        {
            this.brand = brand;
            this.year = year;
            this.price = price;
        }

        public static void Main(string[] args)
        {
            Car car = new("Thar",2018,4800000.0f);
            Console.WriteLine("The brand of the car is: " + car.brand);
            Console.WriteLine("The car was bought at: " + car.year);
            Console.WriteLine("The price of the car is: " + car.price);
        }
    }
}
