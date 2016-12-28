using System;

using SchoolSystem;

namespace SchoolSystem.Models
{
    public class Mark
    {
        private float value;
        private Subject subject;

        public Mark(Subject subject, float value)
        {
            this.subject = subject;
            this.Value = value;
        }

        public float Value
        {
            get
            {
                return this.value;
            }

            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Mark should be between 2 and 6!");
                }

                this.value = value;
            }
        }

        public Subject Subject
        {
            get
            {
                return this.subject;
            }

            set
            {
                this.subject = value;
            }
        }
    }
}
