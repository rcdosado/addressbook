using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook.Helpers
{
    /**
    * Calculate Age in C#
    * https://gist.github.com/faisalman
    *
    * Copyright 2012-2013, Faisalman <fyzlman@gmail.com>
    * Licensed under The MIT License
    * http://www.opensource.org/licenses/mit-license
    */

    public class Age
    {
        public int Years;
        public int Months;
        public int Days;

        public Age(DateTime bday)
        {
            Count(bday);
        }

        public Age(DateTime bday, DateTime cday)
        {
            Count(bday, cday);
        }

        public Age Count(DateTime bday)
        {
            return Count(bday, DateTime.Today);
        }

        public Age Count(DateTime bday, DateTime cday)
        {
            if ((cday.Year - bday.Year) > 0 ||
                (((cday.Year - bday.Year) == 0) && ((bday.Month < cday.Month) ||
                  ((bday.Month == cday.Month) && (bday.Day <= cday.Day)))))
            {
                int daysInBdayMonth = DateTime.DaysInMonth(bday.Year, bday.Month);
                int daysRemain = cday.Day + (daysInBdayMonth - bday.Day);

                if (cday.Month > bday.Month)
                {
                    Years = cday.Year - bday.Year;
                    Months = cday.Month - (bday.Month + 1) + Math.Abs(daysRemain / daysInBdayMonth);
                    Days = (daysRemain % daysInBdayMonth + daysInBdayMonth) % daysInBdayMonth;
                }
                else if (cday.Month == bday.Month)
                {
                    if (cday.Day >= bday.Day)
                    {
                        Years = cday.Year - bday.Year;
                        Months = 0;
                        Days = cday.Day - bday.Day;
                    }
                    else
                    {
                        Years = (cday.Year - 1) - bday.Year;
                        Months = 11;
                        Days = DateTime.DaysInMonth(bday.Year, bday.Month) - (bday.Day - cday.Day);
                    }
                }
                else
                {
                    Years = (cday.Year - 1) - bday.Year;
                    Months = cday.Month + (11 - bday.Month) + Math.Abs(daysRemain / daysInBdayMonth);
                    Days = (daysRemain % daysInBdayMonth + daysInBdayMonth) % daysInBdayMonth;
                }
            }
            else
            {
                throw new ArgumentException("Birthday date must be earlier than current date");
            }
            return this;
        }
    }

    /**
     * Usage example:
     * ==============
     * DateTime bday = new DateTime(1987, 11, 27);
     * DateTime cday = DateTime.Today;
     * Age age = new Age(bday, cday);
     * Console.WriteLine("It's been {0} years, {1} months, and {2} days since your birthday", age.Year, age.Month, age.Day);
     */
}
