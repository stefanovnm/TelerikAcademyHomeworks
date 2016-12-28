namespace _01.SchoolClasses
{
    using System;

    public class Discipline : ICommentable
    {
        private const int DefaultNumbersOfLectures = 0;
        private const int DefaultNumbersOExcercises = 0;

        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name)
        {
            this.Name = name;
        }

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
            :this(name)
        {
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Discipline should have name!");
                }
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            { return this.numberOfLectures; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Discipline has to have non negative lectures!");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            { return this.numberOfExercises; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Discipline has to have non negative exercises!");
                }
                this.numberOfExercises = value;
            }
        }

        public string Comment { get; set; }

        public override string ToString()
        {
            return string.Format("discpline {0}", this.Name);
        }
    }
}
