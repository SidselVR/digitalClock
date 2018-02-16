using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClock
{
    public class ClockDisplay
    {
        private NumberDisplay hours;
        private NumberDisplay minutes;

        public ClockDisplay()
        {
            hours = new NumberDisplay(24);
            minutes = new NumberDisplay(60);
            UpdateDisplay();
        }

        public ClockDisplay(int hour, int minute)
        {
            hours = new NumberDisplay(24);
            minutes = new NumberDisplay(60);
            SetTime(hour, minute);
        }

        public void TimeTick()
        {
            minutes.Increment();
            if (minutes.GetValue() == 0)
            {
                hours.Increment();
            }
            UpdateDisplay();
        }


        private void SetTime(int hour, int minute)
        {
            throw new NotImplementedException();
        }

        public void UpdateDisplay()
        {
            //Whatever way of printing the current time
        }
    }

    public class NumberDisplay
    {
        private int limit;
        private int value;

        public NumberDisplay(int rollOverLimit)
        {
            limit = rollOverLimit;
            value = 0;
        }

        public void Increment()
        {
            value = (value + 1) % limit;
        }

        public string GetDisplayValue()
        {
            if (value < 10)
            {
                return "0" + value;
            }
            else
            {
                return value.ToString();
            }
        }

        public void SetValue(int replacementValue)
        {
            if ((replacementValue >= 0) && (replacementValue < limit))
            {
                value = replacementValue;
            }
        }

        public int GetValue()
        {
            return value;
        }
    }
}
