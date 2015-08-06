namespace ExceptionHandling.Classes
{
    using System;

    public class CSharpExam : Exam
    {
        private const int mininumExamScore = 0;
        private const int maximumExamScore = 100;
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
                if (value < mininumExamScore || value > maximumExamScore)
                {
                    throw new InvalidOperationException(string.Format("The score cannot be less than {0} or more than {1}!", mininumExamScore, maximumExamScore));
                }
                this.score = value;
            }
        }

        public override ExamResult Check()
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
