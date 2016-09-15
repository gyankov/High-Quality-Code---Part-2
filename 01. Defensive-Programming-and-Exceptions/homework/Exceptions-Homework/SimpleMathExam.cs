using System;

public class SimpleMathExam : Exam
{
    private const int MaxSolvedProblems = 10;

    public SimpleMathExam(int problemsSolved)
    {
        if (problemsSolved < 0)
        {
            throw new ArgumentOutOfRangeException("Solved problems cannot be negative number");
        }

        if (problemsSolved > MaxSolvedProblems)
        {
            throw new ArgumentOutOfRangeException(string.Format("Solved problems cannot be more than {0}", MaxSolvedProblems));
        }
        
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved { get; private set; }

    public override ExamResult Check()
    {
        if (this.ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (this.ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Average result: one problem solved.");
        }
        else if (this.ProblemsSolved == 2)
        {
            return new ExamResult(6, 2, 6, "Excellent result: everything solved.");
        }
        else
        {
            throw new ArgumentOutOfRangeException("Invalid number of solved problems");
        }        
    }
}
