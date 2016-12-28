namespace Homework
{
    using System;

    public class Call
    {
        private int callDuration;
        private string phoneNumber;

        public Call(DateTime date, string phoneNumber, int callDuration)
        {
            this.Date = date;
            this.PhoneNumber = phoneNumber;
            this.CallDuration = callDuration;
        }

        public int CallDuration 
        {
            get { return this.callDuration; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Duration cannot be negative");
                }
                this.callDuration = value;
            }
        }

        public string PhoneNumber 
        {
            get { return this.phoneNumber; }
            set
            {
                if (value.Length<3)
                {
                    throw new ArgumentException("Phone number is too short");
                }
                this.phoneNumber = value;
            }
        }
        public DateTime Date { get; set; } //it can be done with 2 DateTime - call begining and call end...

    }
}
