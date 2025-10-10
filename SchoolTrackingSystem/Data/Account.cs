public class SchoolData
{
    public List<Student> Students { get; set; }
    public List<Teacher> Teachers { get; set; }
    public List<Authorized> Authorizeds { get; set; }
}

public class Student
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int Password { get; set; }
}

public class Teacher
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int Password { get; set; }
}

public class Authorized
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int Password { get; set; }
}
