using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockKata
{
    public class Clock
    {
        private int hours = 0;
        private int minutes = 0;


        public Clock(int hours, int minutes = 0)
        {
            this.hours = hours;
            this.minutes = minutes;
            SimplifyTime();
        }

        private void SimplifyTime()
        {
            while (minutes > 59)
            {
                minutes -= 60;
                hours += 1;
            }
            while (hours > 23)
            {
                hours -= 24;
            }
            while (minutes < 0)
            {
                minutes += 60;
                hours -= 1;
            }
            while (hours < 0)
            {
                hours += 24;
            }
        }

        public override string ToString()
        {
            return PadLeft(hours) + ":" + PadLeft(minutes);
        }

        private string PadLeft(int number)
        {
            string result = number.ToString();
            while (result.Length < 2)
            {
                result = "0" + result;
            }
            return result;
        }

        public Clock Add(int minutesAdded)
        {
            minutes += minutesAdded;
            SimplifyTime();
            return this;
        }

        public Clock Subtract(int minutesSubtracted)
        {
            minutes -= minutesSubtracted;
            SimplifyTime();
            return this;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Clock clock = obj as Clock;
            if (clock == null) return false;
            return this.ToString() == clock.ToString();
        }

        public static bool operator ==(Clock clock1, Clock clock2)
        {
            if (ReferenceEquals(clock1, null) || ReferenceEquals(clock2, null))
                return false;
            return clock1.ToString() == clock2.ToString();
        }

        public static bool operator !=(Clock clock1, Clock clock2)
        {
            if (ReferenceEquals(clock1, null) || ReferenceEquals(clock2, null))
                return false;
            return clock1.ToString() != clock2.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
