using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class TimeOnComputer
    {
        public void VOID(bool Variable) 
        {
            if (Variable)
            {
                Console.WriteLine(new string('-', 31));

                DateTime now = DateTime.Now;
                Console.WriteLine("\nОтладка\t: 0{0}.0{1}.{2} | {3}:{4}:{5}", now.Day, now.Month, now.Year, now.Hour, now.Minute, now.Second);

                Console.WriteLine("Время\t: 0{0}.0{1}.{2} | {3}:{4}:{5}", Date, Month, Year, Hour, Minute, Second);

                Console.WriteLine("\n" + new string('-', 31));
            }
            else
            {
                DateTime now = DateTime.Now;
                Console.WriteLine("\nОтладка\t: 0{0}.0{1}.{2} | {3}:{4}:{5}", now.Day, now.Month, now.Year, now.Hour, now.Minute, now.Second);

                Console.WriteLine("Время\t: 0{0}.0{1}.{2} | {3}:{4}:{5}", Date, Month, Year, Hour, Minute, Second);

                Console.WriteLine("\n" + new string('-', 31));
            }
        }

        public int GetTime()
        {
            return Hour;
        }

        public void SetTime(out int Hr, ref int Min, ref int Sec)
        {
            Hr  = Hour;
            Min = Minute;
            Sec = Second;
        }

        // Construction
        public TimeOnComputer(DateTime dt)
        {
            Year   = dt.Year;
            Month  = dt.Month;
            Date   = dt.Day;
            Hour   = dt.Hour;
            Minute = dt.Minute;
            Second = dt.Second;
        }

        public TimeOnComputer(int YearNew, int MonthNew, int DayNew, int HourNew, int MinuteNew, int SecondNew)
        {
            Year = YearNew;
            Month = MonthNew;
            Date = DayNew;
            Hour = HourNew;
            Minute = MinuteNew;
            Second = SecondNew;
        }

        private int Year   = 0;
        private int Month  = 0;
        private int Date   = 0;
        private int Hour   = 0;
        private int Minute = 0;
        private int Second = 0;
    }

    public class Program
    {
        static void Main()
        {
            try
            {
                DateTime currentTime = DateTime.Now;
                TimeOnComputer MyTime = new TimeOnComputer(currentTime);
                MyTime.VOID(true);

                TimeOnComputer MyTimeTwo = new TimeOnComputer(2000,8,9,23,21,56);
                MyTimeTwo.VOID(false);
                
                int TheHour   = 0;
                int TheMinute = 0;
                int TheSecond = 0;

                MyTime.SetTime(out TheHour, ref TheMinute, ref TheSecond); // ref - ссылка на объект, out - только его забрать из класса.

                Console.WriteLine("Hour\t: {0}\nMinutes\t: {1}\nSeconds\t: {2}", TheHour, TheMinute, TheSecond);

                Console.ReadLine();
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error:\t" + Error);
                Console.ReadLine();
            }
        }
    }
}
