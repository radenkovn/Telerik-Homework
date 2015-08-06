namespace ExceptionHandling.Classes
{
    using System;

    public class ExamResult
    {
        private const int minimumExamResultGrade = 0;
        private int grade;
        private int minGrade;
        private int maxGrade;
        private string comments;
        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                ValidateGrade(value, "grade");
                this.grade = value;
            }
        }
        public int MinGrade
        {
            get
            {
                return this.minGrade;
            }
            private set
            {
                ValidateGrade(value, "minimum grade");
                this.minGrade = value;
            }
        }

        public int MaxGrade
        {
            get
            {
                return this.maxGrade;
            }
            private set
            {
                ValidateGrade(value, "minimum grade");
                if (value <= minGrade)
                {
                    throw new ArgumentException("You cannot assinge a smaller maximum grade than the minimum one!");
                }
                this.maxGrade = value;
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }
            private set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException("The comments cannot be null or and empty string!");
                }
                this.comments = value;
            }
        }

        private void ValidateGrade(int grade, string gradeType)
        {
            if (grade < minimumExamResultGrade)
            {
                throw new ArgumentException(string.Format("The {0} you have provided is not valid because it is less than {1}", gradeType, minimumExamResultGrade));
            }
        }

    }
}
