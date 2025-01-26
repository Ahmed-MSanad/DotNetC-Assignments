using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Project_one.Q1
{
    public class Duration
    {
        #region 1) Define Class Duration To include Three Attributes Hours, Minutes and Seconds:

        public int hours;
        public int minutes;
        public int seconds;

        #endregion

        #region 2) Override All System.Object Members (ToString, Equals,GetHasCode) 
        public override string ToString()
        {
            if (hours != 0)
                return $"Hours: {hours},  Minutes: {minutes}, Seconds: {seconds}";
            else if (minutes != 0)
                return $"Minutes: {minutes}, Seconds: {seconds}";
            else if (seconds != 0)
                return $"Seconds: {seconds}";
            else
                return $"00 : 00 : 00";
        }

        public override bool Equals(object? obj)
        {
            Duration other = (Duration)obj;
            return hours == other.hours && minutes == other.minutes && seconds == other.seconds;
        }

        public override int GetHashCode()
        {
            //int hashCode = hours.GetHashCode();
            //hashCode += minutes.GetHashCode();
            //hashCode += seconds.GetHashCode();
            //return hashCode;

            // OR:
            return HashCode.Combine(hours, minutes, seconds);
        }
        #endregion


        #region 3) Define All Required Constructors to Produce this output:
        public Duration() { }

        public Duration(int _hours, int _minutes, int _seconds) {
            hours = _hours;
            minutes = _minutes;
            seconds = _seconds;
        }

        public Duration(int timeInSeconds) {
            hours = timeInSeconds / 3600;
            minutes = (timeInSeconds % 3600) / 60;
            seconds = timeInSeconds % 60;
        }

        #endregion

        #region 4) Implement All required Operators overloading to enable this Code:

        public static Duration operator +(Duration a, Duration b) {
            return new Duration
            {
                hours = (a?.hours ?? 0) + (b?.hours ?? 0),
                minutes = (a?.minutes ?? 0) + (b?.minutes ?? 0),
                seconds = (a?.seconds ?? 0) + (b?.seconds ?? 0),
            };
        }

        public static Duration operator +(Duration a, int b)
        {
            return new Duration
            {
                hours = (a?.hours ?? 0) + (b / 3600),
                minutes = (a?.minutes ?? 0) + ((b % 3600) / 60),
                seconds = (a?.seconds ?? 0) + (b % 60),
            };
        }

        public static Duration operator +(int b, Duration a)
        {
            return new Duration
            {
                hours = (a?.hours ?? 0) + (b / 3600),
                minutes = (a?.minutes ?? 0) + ((b % 3600) / 60),
                seconds = (a?.seconds ?? 0) + (b % 60),
            };
        }

        public static Duration operator ++(Duration d)
        {
            if (d == null)
            {
                throw new Exception("The Duration is null.");
            }
            else if (d.minutes != 59)
            {
                d.minutes++;
            }
            else if (d.minutes == 59)
            {
                d.hours++;
                d.minutes = 0;
            }
            return d;
        }

        public static Duration operator --(Duration d)
        {
            if (d == null || (d.minutes == 0 && d.hours == 0))
            {
                throw new Exception("The Duration is either null or there is no enough hours and minutes to decrease.");
            }
            else if (d.minutes != 0)
            {
                d.minutes--;
            }
            else if (d.hours != 0) {
                d.hours--;
                d.minutes = 59;
            }
            return d;
        }

        public static Duration operator -(Duration a, Duration b)
        {
            return new Duration
            {
                hours = Math.Abs((a?.hours ?? 0) - (b?.hours ?? 0)),
                minutes = Math.Abs((a?.minutes ?? 0) - (b?.minutes ?? 0)),
                seconds = Math.Abs((a?.seconds ?? 0) - (b?.seconds ?? 0)),
            };
        }

        public static bool operator >(Duration Left, Duration Right)
        {
            return (Left?.hours ?? 0) > (Right?.hours ?? 0) ||
                    (Left?.minutes ?? 0) > (Right?.minutes ?? 0) ||
                    (Left?.seconds ?? 0) > (Right?.seconds ?? 0);
        }

        public static bool operator <(Duration Left, Duration Right)
        {
            return (Left?.hours ?? 0) < (Right?.hours ?? 0) ||
                    (Left?.minutes ?? 0) < (Right?.minutes ?? 0) ||
                    (Left?.seconds ?? 0) < (Right?.seconds ?? 0);
        }

        public static bool operator >=(Duration Left, Duration Right)
        {
            return (Left?.hours ?? 0) >= (Right?.hours ?? 0) ||
                    (Left?.minutes ?? 0) >= (Right?.minutes ?? 0) ||
                    (Left?.seconds ?? 0) >= (Right?.seconds ?? 0);
        }

        public static bool operator <=(Duration Left, Duration Right)
        {
            return (Left?.hours ?? 0) <= (Right?.hours ?? 0) ||
                    (Left?.minutes ?? 0) <= (Right?.minutes ?? 0) ||
                    (Left?.seconds ?? 0) <= (Right?.seconds ?? 0);
        }

        public static bool operator true(Duration d) {
            return (d.hours > 0) || (d.minutes > 0) || (d.seconds > 0);
        }

        public static bool operator false(Duration d)
        {
            return (d.hours == 0) && (d.minutes == 0) && (d.seconds == 0);
        }

        public static explicit operator DateTime(Duration d)
        {
            try
            {
                DateTime retDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, d.hours, d.minutes, d.seconds);
                return retDateTime;
            }
            catch (Exception e) {
                throw new Exception("Can't Convert to DateTime as the Duration Provided is NULL!!");
            }
        }

        #endregion

    }
}
