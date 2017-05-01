using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private string battery;
        private string display;
        private static string iPhone4S = "Some information about iPhone4S";
        private static int maxDuration = 0;
        private static List<Call> callList = new List<Call>();
        private static List<int> durations = new List<int>();

        public GSM(string model, string manufacturer, string battery, string display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.battery = battery;
            this.display = display;
            price = 0.0;
            owner = "null";
        }

        public GSM(string model, string manufacturer, double price, string battery, string display) : this(model, manufacturer, battery, display)
        {
            this.price = price;
        }

        public GSM(string model, string manufacturer, double price, string owner, string battery, string display) : this(model, manufacturer, price, battery, display)
        {
            this.owner = owner;
        }

        public string Owner {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }
        }

        public string Model {
            get
            {
                return model;
            }
            set
            {
                if (string.IsNullOrEmpty(model))
                {
                    throw new ArgumentNullException("This information about the GSM is compulsory!");
                }
                model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(manufacturer))
                {
                    throw new ArgumentNullException("This information about the GSM is compulsory!");
                }
                manufacturer = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0) 
                {
                    throw new ArgumentOutOfRangeException("Price can't be negative!");
                }
                price = value;
            }
        }

        public static string IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public static List<Call> CallList {
            get
            {
                return callList;
            }
            set
            {
                callList = value;
            }
        }

        public void AddCall(string date, string time, string phoneNumber, int duration)
        {
            Call call = new Call(date, time, phoneNumber, duration);
            CallList.Add(call);
            durations.Add(duration);
            if (maxDuration < duration)
            {
                maxDuration = duration;
            }
        }

        public void DeleteCall()
        {
            for (int i = 0; i < CallList.Count; i++)
            {
                if (CallList[i].ToString().Contains(maxDuration.ToString()))
                {
                    CallList.RemoveAt(i);
                    durations.RemoveAt(i);
                }
            }
        }

        public void ClearHistory()
        {
            for (int i = 0; i <= CallList.Count + 1; i++) 
            {
                CallList.Remove(CallList[0]);
            }
            Console.WriteLine("History deleted!");
        }

        public double CalculateCallPrice(double pricePerMinute)
        {
            double price = 0.0;
            foreach (var d in durations)
            {
                price += d / 60 * pricePerMinute;
            }
            return price;
        }

        public override string ToString()
        {
            return String.Format("Model: {0}\nManufacturer: {1}\nPrice: {2:F2}BGN\nOwner: {3}\n{4}\n{5}",
            Model, Manufacturer, Price, Owner, battery, display);
        }

       
    }
}
