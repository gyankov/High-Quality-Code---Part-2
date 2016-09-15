using System;

public class CSharpExam : Exam
{
    public const int MinScore = 0;
    public const int MaxScore = 100;

    public CSharpExam(int score)
    {
        if (score < MinScore || score > MaxScore)
        {
            throw new ArgumentOutOfRangeException(string.Format("Score must be positive integer between {0} and {1}", MinScore, MaxScore));
        }

        this.Score = score;
    }

    public int Score { get; private set; }

    public override ExamResult Check()
    {
        var result = new ExamResult(this.Score, MinScore, MaxScore, "Exam results calculated by score.");
        return result;
    }
}
