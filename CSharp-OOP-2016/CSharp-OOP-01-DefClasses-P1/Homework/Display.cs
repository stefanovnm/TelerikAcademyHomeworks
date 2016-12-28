namespace Homework
{
    using System;

    public class Display
    {
        private int? colors;
        private int? height;
        private int? width;

        public Display(int? witdth, int? height, int? colors)
        {
            this.Width = width;
            this.Height = height;
            this.Colors = colors;
        }
        
        public Display()
            : this(null, null, null)
        {
        }

        public int? Width
        {
            get { return this.width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width should not be negative");
                }
                this.width = value;
            }
        }

        public int? Height 
        {
            get { return this.height; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Height should not be negative");
                }
                this.height = value;
            }
        }

        public int? Colors
        {
            get { return this.colors; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Colors cannot be negative");
                }
                this.colors = value;
            }
        }

        public override string ToString()
        {
            string toReturn = "";

            if (this.height==null || this.width == null)
            {
                toReturn = "no info"; //if assigned with null throw exception
            }
            else
            {
                toReturn = this.width + "x" + this.height + "px";
            }

            return toReturn.ToString();
        }

    }
}
