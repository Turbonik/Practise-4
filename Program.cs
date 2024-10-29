using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practise_4;

namespace Practise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] months = new string[]
        {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
         };

            int n = 5; // month length
            var N_month = from month in months
                          where month.Length == n
                          select month;

            var SprWint = from month in months
                          where (month == "January" || month == "February" || month == "December" || month == "March" || month == "April" || month == "May")
                          select month;

            var AlphMonth = from month in months
                            orderby month
                            select month;

            var Umonth = from month in months
                         where month.Contains("u") & month.Length >= 4
                         select month;



            Print_Array(N_month, $"Месяца длиной { n }: ");
            Print_Array(SprWint, $"Месяца весны и зимы: ");
            Print_Array(AlphMonth, $"Месяца в алфавитном порядке: ");
            Print_Array(Umonth, $"Месяца с буквой u и длиной не менее 4 букв: ");
       
            List<Time> times = new List<Time>();
            times.Add(new Time(20, 50, 10));
            times.Add(new Time(12, 42, 20));
            times.Add(new Time(6, 6, 15));
            times.Add(new Time(9, 9, 9));
            times.Add(new Time(10, 50, 30));
            times.Add(new Time(2, 45, 30));

            int required_hour = 12; // set hour value

            var Straight_time = from time in times
                                where time.Hour == required_hour
                                select time;

            var night = from time in times
                        where (time.Hour >= 0 & time.Hour < 6)
                        select time;
            var morning = from time in times
                        where (time.Hour >= 6 & time.Hour < 12)
                        select time;
            var day = from time in times
                        where (time.Hour >= 12 & time.Hour < 17)
                        select time;
            var evening = from time in times
                          where (time.Hour >= 17 & time.Hour <= 23)
                          select time;

            var H_eq_M = times.FirstOrDefault(t => t.hour == t.minute);
            
            var sorted_time = from time in times
                              orderby time.Count_time()
                              select time;
            var min = sorted_time.First();

            Print_List(Straight_time, $"Время с заданным значением часа {required_hour}");

            Print_List(morning, "Утреннее время: ");
            Print_List(day, "Дневное время: ");
            Print_List(evening, "Вечернее время: ");
            Print_List(night, "Ночное время: ");

            Console.WriteLine($"Минимальное время: {min.Show_time()} \n");

            Console.WriteLine($"Первое время когда часы равняются минутам: {H_eq_M.Show_time()} \n");

            Print_List(sorted_time, "Отсортированный список времен: ");
        }

        public static void Print_Array(IEnumerable<string> array, string text)
        {
            Console.WriteLine(text);
            foreach (string str in array)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine("\n");
        }

        public static void Print_List(IEnumerable<Time> array, string text)
        {
            Console.WriteLine(text);
            foreach (Time t in array)
            {
                Console.Write(t.Show_time() + " ");
            }
            Console.WriteLine("\n");
        }
    }
}