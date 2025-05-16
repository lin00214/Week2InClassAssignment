public class Student
{
    private string name;
    private int grade;

    public string Name {
        get { return name; }
        set { name = value; }
    }

    public int Grade
    {
        get { return grade; }
        set { if(value >= 0 && value <= 100) {grade = value;} }
    }

    public bool IsPassing()
    {
        return grade >= 50;
    }
}