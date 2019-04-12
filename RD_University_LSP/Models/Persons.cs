using System;
using System.Collections.Generic;
using RD_University_LSP.Interfaces;

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

  public class BookablePerson : Person, ICanBook 
  {
    public BookablePerson(int id) : base(id)
    {
    }
  }

  public class Student : Person, ICanBook
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

  public class Teacher : Person, ICanBookHighOrderRooms
  {
    public Teacher(int id) : base(id)
    {
    }
  }
}
