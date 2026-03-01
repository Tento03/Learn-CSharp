class Student
{
    private double grade;
    public double Grade
    {
        get { return grade; }
        set
        {
            if (value >0 && value <=4)
            {
                grade = value;
            }
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.Grade = 3.81;
        Console.WriteLine(student.Grade);
    }
}