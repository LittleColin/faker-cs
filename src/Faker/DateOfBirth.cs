using System;

namespace Faker
{
    public class DateOfBirth
    {
        private static readonly Random random = new Random(1234);

        private static readonly DateTime MinDate;
        private static readonly DateTime MaxDate;

        static DateOfBirth()
        {
            MinDate = new DateTime(1940, 1, 1);
            MaxDate = new DateTime(2005, 1, 1);
        }

        public static DateTime Next()
        {
            return new DateTime(random.Next((int)(MaxDate.Ticks - MinDate.Ticks)) + MinDate.Ticks).Date;
        }
    }
}
