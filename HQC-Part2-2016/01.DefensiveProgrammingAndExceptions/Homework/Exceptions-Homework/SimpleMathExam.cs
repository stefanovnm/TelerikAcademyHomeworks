namespace ExceptionsHomework
{
    public class SimpleMathExam : Exam
    {
        private const int MinProblemsSolved = 0;
        private const int MaxProblemsSolved = 10;
        private const int BadGradeProblems = 2;
        private const int AverageGradeProblems = 5;
        private const int GoodGradeProblems = 8;

        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                return this.problemsSolved;
            }

            private set
            {
                if (value < MinProblemsSolved)
                {
                    this.problemsSolved = MinProblemsSolved;
                }
                else if (value > MaxProblemsSolved)
                {
                    this.problemsSolved = MaxProblemsSolved;
                }
                else
                {
                    this.problemsSolved = value;
                }
            }
        }

        public override ExamResult Check()
        {
            string comment;

            if (this.ProblemsSolved <= BadGradeProblems)
            {
                comment = "Bad result!";
            }
            else if (this.ProblemsSolved <= AverageGradeProblems)
            {
                comment = "Average result!";
            }
            else if (this.problemsSolved <= GoodGradeProblems)
            {
                comment = "Good result!";
            }
            else
            {
                comment = "Excelent result";
            }

            return new ExamResult(this.problemsSolved, MinProblemsSolved, MaxProblemsSolved, comment);
        }
    }
}