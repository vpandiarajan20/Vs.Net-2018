using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _214P_DateDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("-2\t" + Min(-2, 1));
            Console.WriteLine("22\t" + Max(2, 22));
            Console.WriteLine("1\t" + Abs(-1));
            int[] d3 = CreateDate(3, 1, 1999);
            SetMonth(d3, 2);
            SetDay(d3, 4);
            SetYear(d3, 2000);
            Console.WriteLine("2\t" + GetMonth(d3));
            Console.WriteLine("4\t" + GetDay(d3));
            Console.WriteLine("2000\t" + GetYear(d3));
            Console.WriteLine("Feb\t" + GetMonthName(GetMonth(d3)));
            Console.WriteLine("2\t" + GetMonthNumber(GetMonthName(GetMonth(d3))));
            int[] d4 = CreateDate(2, 1, 2020);
            Console.WriteLine("2/1/2020\t" + PP(d4));
            Console.WriteLine("Feb 1, 2020\t" + PPL(d4));
            Console.WriteLine("Le 1, Fevrier, 2020\t" + PPF(d4));
            Console.WriteLine("true\t" + IsLeapYear(2020));
            Console.WriteLine("false\t" + IsLeapYear(2021));
            Console.WriteLine("31\t" + DaysInMonth(12, 0));
            Console.WriteLine("29\t" + DaysInMonth(CreateDate(2, 1, 1996)));
            Console.WriteLine("28\t" + DaysInMonth(2, 1997));
            Console.WriteLine("366\t" + DaysInYear(2100));
            Console.WriteLine("true\t" + IsValidDate(CreateDate(2, 29, 2000)));
            Console.WriteLine("false\t" + IsValidDate(CreateDate(2, 29, 2001)));
            Console.WriteLine("true\t" + IsLastDayOfMonth(CreateDate(11, 30, 2000)));
            int[] d5 = CreateDate(2, 28, 2014);
            int[] d6 = CreateDate(3, 27, 2014);
            int[] d7 = CreateDate(12, 25, 2013);
            Console.WriteLine("true\t" + IsBefore(d5, d6));
            Console.WriteLine("false\t" + IsAfter(d5, d7));
            Console.WriteLine("true\t" + IsEqual(d7, CreateDate(12, 25, 2013)));
            Console.WriteLine("12/25/2013\t" + PP(EarlierDate(d5, d7)));
            Console.WriteLine("3/27/2014\t" + PP(LaterDate(d6, d7)));*/
            int[] d8 = CreateDate(12, 31, 2002);
            int[] d9 = CreateDate(2, 29, 2000);
            Console.WriteLine("1/1/2003\t" + PP(NextDay(d8)));
            Console.WriteLine("12/30/2002\t" + PP(PrevDay(d8)));
            Console.WriteLine("3/29/2000\t" + PP(NextMonth(d9)));
            Console.WriteLine("2/28/2001\t" + PP(NextYear(d9)));
            Console.WriteLine("3/10/2000\t" + PP(DaysForward(d9, 10)));
            Console.WriteLine("2/14/2000\t" + PP(DaysBack(d9, 15)));

            Console.WriteLine("1037\t" + DaysBetween(d8, d9));
            Console.WriteLine("1037\t" + DaysOld(d9, d8));
            Console.WriteLine("24888\t" + HoursOld(d9, d8));
            Console.WriteLine("89596800\t" + SecondsOld(d9, d8));

            Console.ReadLine();


        }
        static int Min(int a, int b)
        {
            if (a > b)
                return b;
            return a;
            // Returns the smaller of the 2 integers.
        }
        static int Max(int a, int b)
        {
            if (a > b)
                return a;
            return b;
            // Returns the bigger of the 2 integers.
        }
        static int Abs(int a)
        {
            if (a < 0)
                return a * -1;
            return a;
            // Returns the absolute value of the integer.
        }
        static int[] CreateDate(int m, int d, int y)
        {
            int[] returnValue = new int[3];
            returnValue[0] = m;
            returnValue[1] = d;
            returnValue[2] = y;
            return returnValue;
            // Construct a date of the form {m, d, y}
        }
        static int[] CopyDate(int[] d)
        {
            int[] returnValue = CreateDate(d[0], d[1], d[2]);
            return returnValue;
            // Create a separate copy of a given date
        }
        static int[] CreateRandomDate()
        {
            Random rng = new Random();
            int a = rng.Next(1, 12);
            int b = rng.Next(1, 31);
            int c = rng.Next(1000, 9999);
            int[] returnValue = CreateDate(a, b, c);
            return returnValue;
            // Constructs a random date between Jan 1, 1000, and Dec 31, 9999.
        }
        static int GetMonth(int[] dt)
        {
            return dt[0];
            // returns the month of a date d.
        }
        static int GetDay(int[] dt)
        {
            return dt[1];
            // returns the day of a date d.
        }
        static int GetYear(int[] dt)
        {
            return dt[2];
            // returns the year of a date d.
        }
        static void SetMonth(int[] dt, int m)
        {
            dt[0] = m;
            // sets the month of the date to m.
        }
        static void SetDay(int[] dt, int d)
        {
            dt[1] = d;
            // sets the day of the date to d.
        }
        static void SetYear(int[] dt, int y)
        {
            dt[2] = y;
            // sets the year of the date to y.
        }
        static string GetMonthName(int m)
        {
            if (m == 1)
                return "Jan";
            if (m == 2)
                return "Feb";
            if (m == 3)
                return "Mar";
            if (m == 4)
                return "Apr";
            if (m == 5)
                return "May";
            if (m == 6)
                return "Jun";
            if (m == 7)
                return "Jul";
            if (m == 8)
                return "Aug";
            if (m == 9)
                return "Sep";
            if (m == 10)
                return "Oct";
            if (m == 11)
                return "Nov";
            if (m == 12)
                return "Dec";
            return "Invalid";
            // returns the month name (Jan, Feb, ...) of given m.
        }
        static string GetMonthName(int[] dt)
        {
            return GetMonthName(GetMonth(dt));
            // returns the month name (Jan, Feb, ...) of given date.
        }
        static int GetMonthNumber(string m)
        {
            if (m == "Jan")
                return 1;
            if (m == "Feb")
                return 2;
            if (m == "Mar")
                return 3;
            if (m == "Apr")
                return 4;
            if (m == "May")
                return 5;
            if (m == "Jun")
                return 6;
            if (m == "Jul")
                return 7;
            if (m == "Aug")
                return 8;
            if (m == "Sep")
                return 9;
            if (m == "Oct")
                return 10;
            if (m == "Nov")
                return 11;
            if (m == "Dec")
                return 12;
            return 0;
            // returns 1 given "Jan", 2 given "Feb", ....
        }
        static string PrettyPrint(int[] dt)
        {
            string returnValue = dt[0] + "/" + dt[1] + "/" + dt[2];
            return returnValue;
            // Returns a nice looking string. Ex, "2/4/2000"
        }
        static string PP(int[] dt)
        {
            return PrettyPrint(dt);
            // Same as PrettyPrint(), but abbreviated.
        }
        static string PrettyPrintLong(int[] dt)
        {
            string returnValue = GetMonthName(dt) + " " + dt[1] + ", " + dt[2];
            return returnValue;
            // Returns a nicer looking string. Ex, "Feb 4, 2000"
        }
        static string PPL(int[] dt)
        {
            return PrettyPrintLong(dt);
            // Same as PrettyPrintLong(), but abbreviated.
        }
        static string GetMonthFranch(int m)
        {
            if (m == 1)
                return "janvier";
            if (m == 2)
                return "février";
            if (m == 3)
                return "mars";
            if (m == 4)
                return "avril";
            if (m == 5)
                return "mai";
            if (m == 6)
                return "juin";
            if (m == 7)
                return "juillet";
            if (m == 8)
                return "août";
            if (m == 9)
                return "septembre";
            if (m == 10)
                return "octobre";
            if (m == 11)
                return "novembre";
            if (m == 12)
                return "décembre";
            return "Invalid";
            // returns the month name (Jan, Feb, ...) of given m.
        }
        static string PrettyPrintFrancais(int[] dt)
        {
            string returnValue = "Le " + GetDay(dt) + ", " + GetMonthFranch(GetMonth(dt)) + ", " + GetYear(dt);
            return returnValue;
            // Returns a string in French. Ex, "Le 4, Fevrier, 2000"
        }
        static string PPF(int[] dt)
        {
            return PrettyPrintFrancais(dt);
            // Same as PrettyPrintFrancais(), but abbreviated.
        }
        static bool IsLeapYear(int y)
        {
            if (y % 4 == 0)
                return true;
            return false;
            // Returns true if the year is divisible by 4. IE, 2000, 2004, 2008, etc.
        }
        static int DaysInMonth(int m, int y)
        {

            if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
                return 31;
            if (m == 4 || m == 6 || m == 9 || m == 11)
                return 30;
            if (m == 2 && IsLeapYear(y))
                return 29;
            else if (m == 2 && IsLeapYear(y) != true)
                return 28;
            return 0;
            // Returns number of days in the month and year.
        }
        static int DaysInMonth(int[] dt)
        {
            return DaysInMonth(GetMonth(dt), GetYear(dt));
            // Returns number of days in the date. Day is ignored.
        }
        static int DaysInYear(int y)
        {
            if (IsLeapYear(y))
                return 366;
            return 365;
            // Returns number of days in given year.
        }
        static bool IsValidDate(int[] dt)
        {
            if (GetMonth(dt) > 12 || GetMonth(dt) < 0 || GetYear(dt) > 9999 || GetYear(dt) < 1000)
                return false;
            if (DaysInMonth(dt) < GetDay(dt) || GetDay(dt) < 1)
                return false;
            return true;
            // Returns true if the date is valid. False if not, for ex, April 31 is not valid.
        }
        static bool IsLastDayOfMonth(int[] dt)
        {
            if (DaysInMonth(dt) == GetDay(dt))
                return true;
            return false;
            // Returns true if the date is the last day of the month.
        }
        static bool IsBefore(int[] d1, int[] d2)
        {
            int dateNumber1 = GetYear(d1) * 10000 + GetMonth(d1) * 100 + GetDay(d1);
            int dateNumber2 = GetYear(d2) * 10000 + GetMonth(d2) * 100 + GetDay(d2);
            return dateNumber1 < dateNumber2;
            /*if (GetYear(d1) > GetYear(d2))
                return false;
            if (GetYear(d1) == GetYear(d2) && GetMonth(d1) > GetMonth(d2))
                return false;
            if (GetYear(d1) == GetYear(d2) && GetMonth(d1) == GetMonth(d2) && GetDay(d1) > GetDay(d2))
                return false;
            return true;
            */
            /*
            if (GetYear(d1) < GetYear(d2))
                return true;
            if (GetYear(d1) == GetYear(d2) && GetMonth(d1) < GetMonth(d2))
                return true;
            if (GetYear(d1) == GetYear(d2) && GetMonth(d1) == GetMonth(d2) && GetDay(d1) < GetDay(d2))
                return true;
            return false; */
            // YYYYMMDD
            // Returns true if d1 is (strictly) before d2.
        }
        static bool IsAfter(int[] d1, int[] d2)
        {
            if (IsEqual(d1, d2) == false && IsBefore(d1, d2) == false)
                return true;
            return false;
            // Returns true if d1 is (strictly) after d2.
        }
        static bool IsEqual(int[] d1, int[] d2)
        {
            if (GetDay(d1) == GetDay(d2) && GetMonth(d1) == GetMonth(d2) && GetYear(d1) == GetYear(d2))
                return true;
            return false;
            // Returns true if d1 and d2 are the same day.
        }
        static int[] EarlierDate(int[] d1, int[] d2)
        {
            if (IsBefore(d1, d2) == true)
                return d1;
            return d2;
            // Returns the actual (not a copy of the) date that is earlier.
        }
        static int[] LaterDate(int[] d1, int[] d2)
        {
            if (IsAfter(d1, d2) == true)
                return d1;
            return d2;
            // Returns the actual (not a copy of the) date that is later.
        }
        static bool IsLastDayOfYear(int[] dt)
        {
            if (IsLastDayOfMonth(dt) == true && dt[0] == 12)
                return true;
            return false;
        }
        static int[] NextDay(int[] dt)
        {
            if (IsLastDayOfMonth(dt) && IsLastDayOfYear(dt) && dt[2] == 9999)
                return CreateDate(1, 1, 1000);
            if (IsLastDayOfMonth(dt) && IsLastDayOfYear(dt) )
                return CreateDate(1, 1, dt[2] + 1);
            if (IsLastDayOfMonth(dt))
                return CreateDate(dt[0] + 1, 1, dt[2]);
            return CreateDate(dt[0], dt[1] + 1, dt[2]);
            // Returns the date 1 day after given date. Do not change the argument!
        }
        static void MakeNextDay(int[] dt)
        {
            // day++
            // if day too far =>
            // month ++
            // if month too far =>
            // year ++
            // if ....
            dt[1]++;
            if (dt[1] > DaysInMonth(dt))
            {
                dt[1] = 1;
                dt[0]++;
            }
            if (dt[0] > 12)
            {
                dt[0] = 1;
                dt[2]++;
            }
            if (dt[2] > 9999)
                dt[2] = 1000;
            /*if (IsLastDayOfMonth(dt) == true && IsLastDayOfYear(dt) == true && dt[2] == 9999)
                dt = CreateDate(1, 1, 1000);
            else if (IsLastDayOfMonth(dt) == true && IsLastDayOfYear(dt) == true)
                dt = CreateDate(1, 1, dt[2] + 1);
            else if (IsLastDayOfMonth(dt) == true)
                dt = CreateDate(1, dt[1] + 1, dt[2]);
            else dt = CreateDate(dt[0] + 1, dt[1] + 1, dt[2]); */
            // Make the given date move to the next day.
        }
        static int[] PrevDay(int[] dt)
        {
            if (dt[1] == 1 && dt[0] == 1 && dt[2] == 1000)
                return CreateDate(12, 31, 9999);
            if (dt[1] == 1 && dt[0] == 1)
                return CreateDate(12, 31, dt[2] - 1);
            if (dt[1] == 1)
                return CreateDate(dt[0] - 1, DaysInMonth(dt[0]-1,dt[2]), dt[2]);
            return CreateDate(dt[0], dt[1] - 1, dt[2]);
            // Returns the date 1 day before the given date.
        }
        static void MakePrevDay(int[] dt)
        {
            dt[1]--;
            if (dt[1] < 0)
            {
                dt[1] = DaysInMonth(dt[0]-1, dt[2]);
                dt[0]--;
            }
            if (dt[0] < 0)
            {
                dt[0] = 12;
                dt[2]--;
            }
            if (dt[2] < 1000)
                dt[2] = 9999;
            // Make the given date move to the previous day.
        }
        static int[] NextMonth(int[] dt)
        {
            if (dt[1] == 12)
                return CreateDate(1, dt[1], dt[2] + 1);
            if (dt[1] > DaysInMonth(dt[0] + 1, dt[2]))
                return CreateDate(dt[0] + 1, DaysInMonth(dt[0] + 1, dt[2]), dt[2]);
            return CreateDate(dt[0] + 1, dt[1], dt[2]);
            // Returns a date 1 month after given date.
            // Mar 31 goes to Apr 30 because Apr 31 is not valid!
        }
        static void MakeNextMonth(int[] dt)
        {
            int[] nextMonth = NextMonth(dt);
            dt[0] = nextMonth[0];
            dt[1] = nextMonth[1];
            dt[2] = nextMonth[2];
            // Make the given date move to the next month.
        }
        static int[] NextYear(int[] dt)
        {
            if (dt[0] == 2 && dt[1] == 29)
                return CreateDate(2, 28, dt[2] + 1);
            if (dt[2] == 9999)
                return CreateDate(dt[0], dt[1], 1000);
            return CreateDate(dt[0], dt[1], dt[2] + 1);
            // Returns the date 1 year after given date.
        }
        static void MakeNextYear(int[] dt)
        {
            int[] nextYear = NextYear(dt);
            dt[0] = nextYear[0];
            dt[1] = nextYear[1];
            dt[2] = nextYear[2];
            // Make the given date move to the next year.
        }
        static int[] DaysForward(int[] dt, int days)
        {
            /*int day = dt[1] + days;
            int month = dt[0];
            int year = dt[2];
            while (day > DaysInYear(year))
            {
                day = day - DaysInYear(year);
                year++;
            }
            while (day> DaysInMonth(month, year))
            {
                day = day - DaysInMonth(month, year);
                month++;
            }
            return CreateDate(month, day+1, year); */
            int[] x = CopyDate(dt);
            for (int i = 0; i < days; i++)
                MakeNextDay(x);
            return x;
            // Return a date the number of days in the future.
        }
        static void MoveForward(int[] dt, int days)
        {
            int[] four = DaysForward(dt, days);
            dt[0] = four[0];
            dt[1] = four[1];
            dt[2] = four[2];
            // Move the date the number of days in the future.
        }
        static int[] DaysBack(int[] dt, int days)
        {
            int[] x = CopyDate(dt);
            for (int i = 0; i < days; i++)
                MakePrevDay(x);
            return x;
            // Return a date the number of days in the past.
        }
        static void MoveBack(int[] dt, int days)
        {
            int[] four = DaysBack(dt, days);
            dt[0] = four[0];
            dt[1] = four[1];
            dt[2] = four[2];
            // Move the date the number of days in the past.
        }
        static int DayOfYear(int[] dt)
        {
            int d = GetDay(dt);
            for (int i = 0; i < GetMonth(dt); i++)
                d = d + DaysInMonth(i, GetYear(dt));
            return d; 
            // Returns the day of the year. IE, Jan 1 = 1. Feb 1 = 32. etc.
        }
        static int DaysInYearRemaining(int[] dt)
        {
            return DaysInYear(GetYear(dt)) - DayOfYear(dt);
            // Returns the number of days remaining in the calendar year.
        }
        static int DaysBetween(int[] d1, int[] d2)
        {
            /*int count = 1;
            int[] earlierDate;
            int[] laterDate;
            earlierDate = CopyDate(EarlierDate(d1,d2));
            laterDate = LaterDate(d1,d2);
            while(IsBefore(earlierDate,laterDate))
            {
                MakeNextDay(earlierDate);
                count = count + 1;
            }
            return count;*/
            int[] earlierDate = EarlierDate(d1, d2);
            int[] laterDate = LaterDate(d1, d2);
            int firstPart = 0, yearsPart = 0, lastPart = 0;
            firstPart = DayOfYear(earlierDate);
            lastPart = DayOfYear(laterDate);
            for(int y = GetYear(earlierDate); y< GetYear(laterDate); y++)
            {
                yearsPart = yearsPart + DaysInYear(y);
            }
            return -firstPart + yearsPart + lastPart + 1;
            // Returns the number of days between 2 dates, inclusive.
        }
        static int DaysOld(int[] bday, int[] today)
        {
            return DaysBetween(today,bday);
            // Returns the number of days you've been alive.
        }
        static int HoursOld(int[] bday, int[] today)
        {
            return DaysOld(bday, today) * 24;
            // Returns the number of hours you've been alive.
        }
        static int SecondsOld(int[] bday, int[] today)
        {
            return DaysOld(bday, today) * 24 * 60 * 60;
            // Returns the number of seconds you've been alive.
        }

    }
}


