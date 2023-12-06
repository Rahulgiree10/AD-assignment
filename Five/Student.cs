namespace Five
{
    internal class Student
    {
        private String name;
        private int age;
        private String major;

        internal Student(String name, int age, String major) 
        {
            this.name = name;
            this.age = age;
            this.major = major;
        }

        internal void Introduce() 
        {
            Console.WriteLine("The name of the person is: " + this.name);
            Console.WriteLine("The age of the person is: " + this.age);
            Console.WriteLine("The major subject of the person is: " + this.major);
        }

        static void Main(string[] args)
        {
            Student st = new("John Doe", 28,"Computer Science");
            st.Introduce();
        }
    }
}
