using System;

namespace o
{
    class Program
    {
        static void Main(string[] args)
        {
            var DiasSemana = DateTime.Now.DayOfWeek; 

              Console.WriteLine("");// Espaço 
            
            if (DiasSemana == DayOfWeek.Sunday)
            {
              Console.WriteLine($"Today is: {DayOfWeek.Sunday}");  
            }
            else if (DiasSemana == DayOfWeek.Monday)
            {
                Console.WriteLine($"Today is: {DayOfWeek.Monday}");
            }
            else if (DiasSemana == DayOfWeek.Tuesday)
            {
                Console.WriteLine($"Today is: {DayOfWeek.Tuesday}");
            }
            else if (DiasSemana == DayOfWeek.Wednesday)
            {
                Console.WriteLine($"Today is: {DayOfWeek.Wednesday}");
            }
            else if (DiasSemana == DayOfWeek.Thursday)
            {
                Console.WriteLine($"Today is: {DayOfWeek.Thursday}");
            }
            else if (DiasSemana == DayOfWeek.Friday)
            {
                Console.WriteLine($"Today is: {DayOfWeek.Friday}");
            }
            else if (DiasSemana == DayOfWeek.Saturday)
            {  
              Console.WriteLine($"Today is: {DayOfWeek.Saturday}");
           }
        }
    }
}
