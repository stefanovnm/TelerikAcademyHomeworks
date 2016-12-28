namespace Homework
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        private const string defaultOwner = null;

        private string model;
        private string manufacturer;
        private int? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;

        private static readonly GSM iPhone4s =
            new GSM("Apple", "iPhone4s", defaultOwner, null, new Battery("non-removable",1432,BatteryType.LiPo), new Display(640,960,16000000));

        //constructors
        public GSM(string manufacturer, string model, string owner, int? price, Battery battery, Display display)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Owner = owner;
            this.Price = price;
            this.battery = battery;
            this.display = display;
            this.callHistory = new List<Call>();

        }

        public GSM(string manufacturer, string model )
            :this(manufacturer, model, defaultOwner, null /*price*/, new Battery(), new Display())
        {
        }

        public GSM(string owner)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Owner = owner;
        }

        //properties
        public string Model 
        { 
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be null");
                }
                this.model = value; }
        }

        private string Manufacturer
        {
            get { return this.manufacturer; }
            set {
                    if (String.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("Manufacturer cannot be null");
                    }
                    this.manufacturer = value; 
                }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public int? Price
        {
            get { return this.price; }
            set 
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be negative");
                }
                this.price = value; 
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set //can be private but that will not allow us to exchange it... :)
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get { return this.display; }
            private set 
            {
                this.display = value;
            }
        }

        public List<Call> CallHistory
        {
            get { return new List<Call>(this.callHistory); }
            set { this.callHistory = value; }
        }

        public static GSM IPhone4s
        {
            get { return iPhone4s; }
        }

        //methods
        public override string ToString()
        {
            return "- - - - - - - - - - - - - - - - -\n"
                + this.Manufacturer + " " + this.Model
                + "\nOwner: " + this.Owner
                + "\nPrice: " + this.Price
                + "\nBattery: " + this.battery.ToString()
                + "\nDisplay: " + this.display.ToString()
                + "\n- - - - - - - - - - - - - - - - -";
        }

        public List<Call> AddCall(Call call)
        {
            this.callHistory.Add(call);

            return this.callHistory;
        }

        public List<Call> DeleteCall(Call removeCall)
        {
            if (!this.callHistory.Contains(removeCall))
            {
                throw new ArgumentException("This call doesn't exist!");
            }

            this.callHistory.Remove(removeCall);
            return this.callHistory;
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public decimal TotalCallPrice() //double should be enough in princip
        {
            int duration = 0; //seconds
            decimal minutePrice = 0.37M;

            foreach (var call in callHistory)
            {
                duration += call.CallDuration;
            }
            
            decimal totalPrice = (decimal)duration / (decimal)60 * minutePrice;
            return totalPrice;
        }

        public void PrintHistory()
        {
            if (callHistory.Count > 0)
            {
                foreach (var call in callHistory)
                {
                    Console.WriteLine(call.Date.ToString().PadLeft(21) + " : call from " + call.PhoneNumber + " " + call.CallDuration + "s");
                }
            }
            else
            {
                Console.WriteLine("History is empty");
            }
        }
        
    }
}
