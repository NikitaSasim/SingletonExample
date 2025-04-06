using System;
using System.Globalization;

namespace SingletonExample
{
    public sealed class TimeStampSingleton
    {
        private static readonly TimeStampSingleton instance = new TimeStampSingleton();

        public static TimeStampSingleton GetInstance() => instance;

        private readonly DateTime creationTime;

        private TimeStampSingleton()
        {
            creationTime = DateTime.Now;
        }

        public override string ToString()
        {
            return creationTime.ToString(CultureInfo.InvariantCulture);
        }
    }
}


