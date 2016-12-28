namespace Homework
{
    using System;
    public class Battery
    {
        private const string defaultModel = null;
        private const BatteryType defaultBatteryType = BatteryType.None;
        //private const int? defaultCapacity= null; //The type 'int?' cannot be declared const


        private int? capacity;

        public Battery(string model, int? capacity, BatteryType batteryType)
        {
            this.Model = model;
            this.Capacity = capacity;
            this.BatteryType = batteryType;
        }

        public Battery()
            :this(defaultModel, null, defaultBatteryType)
        {

        }

        public string Model { get; set; }
        public int? Capacity 
        {
            get { return this.capacity; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Capacity cannot be zero or negative");
                }
                this.capacity = value;
            }
        }
        public BatteryType BatteryType { get; set; } //propbably not the best idea for property and class to have equal names

        public override string ToString()
        {
            string toReturn = "model:" + this.Model + ", type:" + this.BatteryType + ", capacity:" + this.capacity + "mAh";

            return toReturn;
        }
    }
}
