using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        if (firstName == null || firstName == string.Empty)
        {
            throw new ArgumentNullException("First name cannot be null or empty");
        }

        if (lastName == null || lastName == string.Empty)
        {
            throw new ArgumentNullException("Last name cannot be null or empty");
        }

        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public IList<Exam> Exams { get; set; }

    public IList<ExamResult> CheckExams()
    {
        if (this.Exams == null || this.Exams.Count < 1)
        {
            throw new ArgumentNullException("There are no exams to check.");
        }        

        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        if (this.Exams == null || this.Exams.Count < 1)
        {
            throw new ArgumentNullException("Cannot calculate average on missing exams");
        }
        
        IList<ExamResult> examResults = this.CheckExams();
        var result = examResults.Average(x => x.Grade);
        return result;
    }
}
