using System;
using System.Collections.Generic;

namespace RD_University_LSP.Models
{
  public class Person
  {
    public Person(int id)
    {
      Id = id;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
  }

  public class Student : Person
  {
    public Student(int id) : base(id)
    {
    }

    public int AverageGrade { get; set; }
    public Specialty Specialty { get; set; }
    public List<Course> FinishedCourses { get; set; }

    public override string ToString()
    {
      return $"{Id}: {FirstName} {LastName}, {BirthDate:d}";
    }
  }

  public class Teacher : Person
  {
    public Teacher(int id) : base(id)
    {
    }
  }
}
