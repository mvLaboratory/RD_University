using System;

namespace RD_University_SRP.Models
{
  public class Student
  {
    public Student(int id)
    {
      Id = id;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    public override string ToString()
    {
      return $"{Id}: {FirstName} {LastName}, {BirthDate:d}";
    }
  }
}
