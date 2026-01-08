public class StudentDTO
{
  public int Id { get; set; }
  public string Name { get; set; } = "";
  public int Age { get; set; }
  public int CourseId { get; set; }
  public CourseDTO? Course { get; set; }
}

public class CourseDTO
{
  public int Id { get; set; }
  public string Name { get; set; } = "";
}