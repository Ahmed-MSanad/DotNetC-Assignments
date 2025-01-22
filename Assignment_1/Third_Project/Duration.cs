using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Third_Project
{
    public class Duration
    {
        public double hours;
        public double minutes;
        public double seconds;

        public override string ToString()
        {
            if(hours != 0)
                return $"Hours: {hours},  Minutes: {minutes}, Seconds: {seconds}";
            else if(minutes != 0)
                return $"Minutes: {minutes}, Seconds: {seconds}";
            else if(seconds != 0)
                return $"Seconds: {seconds}";
            else
                return $"00 : 00 : 00";
        }

        public override bool Equals(object? obj)
        {
            Duration otherDuration = (Duration)obj;
            return hours == otherDuration?.hours && minutes == otherDuration?.minutes && seconds == otherDuration?.seconds;
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

        public Duration()
        {

        }

        public Duration(double hours, double minutes, double seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public Duration(double timeInSeconds)
        {
            hours = (int)(timeInSeconds / 3600);
            minutes = (int)((timeInSeconds % 3600) / 60);
            seconds = timeInSeconds % 60;
        }
    }
}
