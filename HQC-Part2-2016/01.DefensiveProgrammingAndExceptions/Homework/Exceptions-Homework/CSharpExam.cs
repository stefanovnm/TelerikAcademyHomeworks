using System;

namespace ExceptionsHomework
{
    public class CSharpExam : Exam
    {
        private const int MinGrade = 0;
        private const int MaxGrade = 100;

        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            private set
            {
                if (value < MinGrade || value > MaxGrade)
                {
                    throw new ArgumentOutOfRangeException($"The score is out of range [{MinGrade} - {MaxGrade}]");
                }

                this.score = value;
            }
        }

        public override ExamResult Check()
        {
            if (this.Score < MinGrade || this.Score > MaxGrade)
            {
                throw new ArgumentOutOfRangeException($"The score is out of range [{MinGrade} - {MaxGrade}]");
            }
            else
            {
                return new ExamResult(this.Score, MinGrade, MaxGrade, "Exam results calculated by score.");
            }
        }
    }
}