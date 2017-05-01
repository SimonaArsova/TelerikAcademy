using System;
namespace DefiningClasses
{
    public class Call
    {
        private string date;
        private string time;
        private string phoneNumber;
        private int duration;

        public Call(string date, string time, string phoneNumber, int duration)
        {
            this.date = date;
            this.time = time;
            this.phoneNumber = phoneNumber;
            this.duration = duration;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}s", date, time, phoneNumber, duration);
        }


    }
}
