using System;
using System.Collections.Generic;
using RD_University.Models;

namespace RD_University
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("===RD University!===\n");
      Console.WriteLine("What you want to do?");

      var students = new List<Student>
      {
        new Student(1) {FirstName = "John", LastName = "Doe", BirthDate = new DateTime(1996, 3, 10)},
        new Student(2) {FirstName = "Jane", LastName = "Doe", BirthDate = new DateTime(1993, 6, 23)},
        new Student(3) {FirstName = "Alex", LastName = "Hart", BirthDate = new DateTime(1998, 12, 11)},
        new Student(4) {FirstName = "Kate", LastName = "Smith", BirthDate = new DateTime(1996, 4, 5)}
      };


      var input = Console.ReadLine();
      if (input?.Equals("p", StringComparison.CurrentCultureIgnoreCase) ?? false)
        students.ForEach(Console.WriteLine);

      Console.ReadKey();
    }
  }
}
