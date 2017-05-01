using System;

namespace DefiningClasses
{
    public class Battery
    {
        private string batteryModel;
        private int idleHours;
        private int talkHours;
        private BatteryType batteryType;

        public Battery()
        {
            batteryModel = "null";
            idleHours = 0;
            talkHours = 0;
        }

        public Battery(string batteryModel):this()
        {
            this.batteryModel = batteryModel;
        }

        public Battery(int idleHours, int talkHours) :this()
        {
            this.idleHours = idleHours;
            this.talkHours = talkHours;
        }

        public Battery(string batteryModel, int idleHours, int talkHours, BatteryType batteryType):this(idleHours, talkHours)
        {
            this.batteryModel = batteryModel;
            this.batteryType = batteryType;
        }

        public BatteryType BatteryType
        {
            get
            {
                return batteryType;
            }
            set
            {
                batteryType = value;
            }
        }

        public string BatteryModel {
            get
            {
                return batteryModel;
            }
            set
            {
                batteryModel = value;
            }
        }

        public int IdleHours
        {
            get
            {
                return idleHours;
            }
            set
            {
                if (value < 0) 
                {
                    throw new ArgumentOutOfRangeException("Hours can't be negative!");
                }
                idleHours = value;
            }
        }

        public int TalkHours
        {
            get
            {
                return talkHours;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hours can't be negative!");
                }
                talkHours = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Battery model: {0}\nIdle hours: {1}\nTalk hours: {2}\nBattery type: {3}",
            BatteryModel, IdleHours, TalkHours,BatteryType);
        }
    }
}
