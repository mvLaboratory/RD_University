using System;
using System.Collections.Generic;
using System.Text;
using RD_University_SRP.Models;

namespace RD_University_SRP.Data
{
  public class StudentDataProvider
  {
    public IEnumerable<Student> GetStudents()
    {
      yield return new Student(1) {FirstName = "John", LastName = "Doe", BirthDate = new DateTime(1996, 3, 10)};
      yield return new Student(2) {FirstName = "Jane", LastName = "Doe", BirthDate = new DateTime(1993, 6, 23)};
      yield return new Student(3) {FirstName = "Alex", LastName = "Hart", BirthDate = new DateTime(1998, 12, 11)};
      yield return new Student(4) {FirstName = "Kate", LastName = "Smith", BirthDate = new DateTime(1996, 4, 5)};
    }
  }
}
