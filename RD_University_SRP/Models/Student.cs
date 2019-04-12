using System;

namespace RD_University_SRP.Models
{
  public class Person
  {
    public Person(int id) 
    {
    }
  }

  public class OldStudent : Student
  {
    public OldStudent(int id) : base(id)
    {
    }
  }

  public class Student : Person
  {
    public Student(int id) : base(id)
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
