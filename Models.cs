public class Student
{
  public int Id { get; set; }
  public string Name { get; set; } = "";
  public int Age { get; set; }
  public Course Course { get; set; } = new();
}

public class Course
{
  public int Id { get; set; }
  public string Name { get; set; } = "";
  public virtual List<Student> Students { get; set; } = new();
}