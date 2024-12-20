// Start with four students. Each student has five exam scores.
// Each exam score is an integer value, 0-100, where 100 represents 100% correct.
struct Student
{
  public string Name { get; }
  public int[] ExamScores { get; }

  public decimal Score { get; }
  public decimal OverallScore { get; }
  public decimal ExtraPoints { get; }
  public string Grade { get; }

  private const int StandardExamCount = 5;

  public Student(string name, int[] scores) {
    Name = char.ToUpper(name[0]) + name.Substring(1);
    ExamScores = scores;
    (Score, OverallScore, ExtraPoints) = CalculateScore();
    Grade = CalculateGrade();
  }

  // The code includes the variables and algorithms used to sum the exam scores
  // and calculate the average exam score for each student.
  public (decimal, decimal, decimal) CalculateScore() {
    // A student's overall exam score is the average of their five exam scores.
    int baseSum = 0;
    decimal extraCredit = 0;

    for(int count = 0; count < ExamScores.Length; count++) {
      // Integrate extra credit scores when calculating the student's final
      // score and letter grade as follows:
      if (count >= StandardExamCount) {
        // Your code must detect extra credit assignments based on the number of
        // elements in the student's scores array. Your code must apply the 10%
        // weighting factor to extra credit assignments before adding extra
        // credit scores to the sum of exam scores.
        extraCredit += (decimal)ExamScores[StandardExamCount] / 10;
      } else {
        baseSum += ExamScores[count];
      }
    }

    decimal overallScore = (decimal)(baseSum + extraCredit) / StandardExamCount;
    decimal baseScore = (decimal)(baseSum) / StandardExamCount;
    decimal extraPoints = (decimal)(extraCredit / StandardExamCount);
    return (baseScore, overallScore, extraPoints);
  }

  // Your application needs to automatically assign letter grades based on the
  // calculated final score for each student.
  public string CalculateGrade() {
    string score;

    // The code includes a hard coded letter grade that the developer must apply
    // manually.
    if (this.Score >= 97) score = "A+";
    else if (this.OverallScore >= 93) score = "A";
    else if (this.OverallScore >= 90) score = "A-";
    else if (this.OverallScore >= 87) score = "B+";
    else if (this.OverallScore >= 83) score = "B";
    else if (this.OverallScore >= 80) score = "B-";
    else if (this.OverallScore >= 77) score = "C+";
    else if (this.OverallScore >= 73) score = "C";
    else if (this.OverallScore >= 70) score = "C-";
    else if (this.OverallScore >= 67) score = "D+";
    else if (this.OverallScore >= 63) score = "D";
    else if (this.OverallScore >= 60) score = "D-";
    else score = "F";

    return score;
  }
}

class Program
{
    static void Main(string[] args)
    {
      // The code declares variables used to define student names and individual
      // exam scores for each student.
      List<Student> students = new List<Student>();
      // Your application needs to support adding other students and scores with
      // minimal impact to the code.
      students.Add(new Student("sophia", [ 90, 86, 87, 98, 100, 94, 90 ]));
      students.Add(new Student("andrew", [ 92, 89, 81, 96, 90, 89 ]));
      students.Add(new Student("emma", [ 90, 85, 87, 98, 68, 89, 89, 89 ]));
      students.Add(new Student("logan", [ 90, 95, 87, 88, 96, 96 ]));
      students.Add(new Student("becky", [ 92, 91, 90, 91, 92, 92, 92 ]));
      students.Add(new Student("chris", [ 84, 86, 88, 90, 92, 94, 96, 98 ]));
      students.Add(new Student("eric", [ 80, 90, 100, 80, 90, 100, 80, 90 ]));
      students.Add(new Student("gregor", [ 91, 91, 91, 91, 91, 91, 91 ]));

      // Your application needs to output/display each student’s name and
      // formatted grade. The code includes Console.WriteLine() statements to
      // display the student grading report.
      Console.WriteLine("\nStudent\t\tExam Score\t\tOverall Grade\t\tExtra Credit\n");
      foreach (Student student in students) {
        // Console.WriteLine($"{student.Name}:\t\t{student.Score}\t{student.Grade}");
        Console.WriteLine($"{student.Name}\t\t\t{student.Score}\t\t{student.OverallScore}\t{student.Grade}\t\t{student.ExamScores[5]} ({student.ExtraPoints} pts)");
      }
      Console.WriteLine("\nPress the Enter key to continue\n");
      // Console.ReadLine();
    }
}
