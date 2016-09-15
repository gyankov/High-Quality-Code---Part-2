using System;

public class ExamResult
{
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {        
        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("Min grade cannost be negative number");
        }

        if (maxGrade <= minGrade)
        {
            throw new ArgumentOutOfRangeException("Max grade must be greater than min grade");
        }

        if (grade < minGrade || maxGrade < grade)
        {
            throw new ArgumentOutOfRangeException("Grade must be between min grade and max grade.");
        }

        if (comments == null || comments == string.Empty)
        {
            throw new ArgumentNullException("Comments cannot be null or empty");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade { get; private set; }

    public int MinGrade { get; private set; }

    public int MaxGrade { get; private set; }

    public string Comments { get; private set; }
}
