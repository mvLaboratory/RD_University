using System;
using System.Collections.Generic;
using RD_University_OCP.Interfaces;
using RD_University_OCP.Models;

namespace RD_University_OCP.Data
{
  public class StudentDataProvider : IDateProvider<Student>
  {
    public IEnumerable<Student> GetData()
    {
      yield return new Student(1)
      {
        FirstName = "John",
        LastName = "Doe_Art",
        BirthDate = new DateTime(1996, 3, 10),
        Specialty = Specialty.Art,
        AverageGrade = 93,
        FinishedCourses = new List<Course> {Course.Philosophy, Course.History, Course.Philosophy }
      };

      yield return new Student(10)
      {
        FirstName = "John",
        LastName = "Doe_Dev",
        BirthDate = new DateTime(1996, 3, 10),
        Specialty = Specialty.Developer,
        AverageGrade = 93,
        FinishedCourses = new List<Course> { Course.Philosophy, Course.History, Course.Philosophy }
      };

      yield return new Student(2)
      {
        FirstName = "Jane",
        LastName = "Doe",
        BirthDate = new DateTime(1993, 6, 23),
        AverageGrade = 75,
        Specialty = Specialty.Developer,
        FinishedCourses = new List<Course> { Course.Mathematics, Course.Philosophy, Course.Physics }
      };
      yield return new Student(3)
      {
        FirstName = "Alex",
        LastName = "Hart",
        BirthDate = new DateTime(1998, 12, 11),
        AverageGrade = 60,
        Specialty = Specialty.Physicist,
        FinishedCourses = new List<Course> { Course.Mathematics, Course.Philosophy, Course.Physics }
      };
      yield return new Student(4)
      {
        FirstName = "Kate",
        LastName = "Smith",
        BirthDate = new DateTime(1996, 4, 5),
        AverageGrade = 80,
        Specialty = Specialty.Mathematician,
        FinishedCourses = new List<Course> { Course.Mathematics, Course.Chemistry, Course.Physics }
      };
    }
  }
}
