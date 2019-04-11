using System;
using System.Collections.Generic;

namespace RD_University_OCP.Models
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
    public int AverageGrade { get; set; }
    public Specialty Specialty { get; set; }
    public List<Course> FinishedCourses { get; set; }

    public override string ToString()
    {
      return $"{Id}: {FirstName} {LastName}, {BirthDate:d}";
    }
  }
}
