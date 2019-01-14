using System;

namespace OandaV20.Models.InstrumentsModel
{
    public enum EWeeklyAlignment
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public class WeeklyAlignment
    {
        private EWeeklyAlignment Value;

        // CONSTRUCTORS
        public WeeklyAlignment()
        {
        }
        public WeeklyAlignment(string value)
        {
            Set(value);
        }
        public WeeklyAlignment(EWeeklyAlignment value)
        {
            this.Value = value;
        }

        // SETTERS
        private bool Set(string value)
        {
            if(Enum.TryParse(value, out this.Value))
            {
                return true;
            } else
            {
                throw new ArgumentException("Incorrect Weekly Alignment Input", "WeeklyAlignment Alignment Exception");
            }
        }

        // IMPLICIT OPERATORS
        public static implicit operator WeeklyAlignment(EWeeklyAlignment value)
        {
            return new WeeklyAlignment(value);
        }
        public static implicit operator WeeklyAlignment(string value)
        {
            return new WeeklyAlignment(value);
        }
        public static implicit operator EWeeklyAlignment(WeeklyAlignment x)
        {
            return x.Value;
        }
    }
}
