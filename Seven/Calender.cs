namespace Seven
{
    internal class Calender
    {
        enum DaysOfWeek 
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        internal void PrintWeekDays()
        {
            foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
            {
                if (day >= DaysOfWeek.Monday && day <= DaysOfWeek.Friday)
                {
                    Console.WriteLine("The days of the week are given below:");
                    Console.WriteLine(day);
                }
            }
        }



        static void Main(string[] args)
        {
            Calender cal = new();
            cal.PrintWeekDays();
        }
    }
}
