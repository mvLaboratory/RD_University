using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RD_University.Interfaces;
using RD_University_SRP.Models;

namespace RD_University.Core
{
  public class RdUniversity : IRdUniversity
  {
    public RdUniversity(
      IDataProvider<Student> data, 
      IReaderWriter consoleReaderWriter, 
      IReaderWriter printerWriter)
    {
      _dataProvider = data;
      _consoleReaderWriter = consoleReaderWriter;
      _printerWriter = printerWriter;
    }

    public void Execute()
    {
      var students = _dataProvider.GetData();

      var input = _consoleReaderWriter.Read();
      switch (input)
      {
        case "s":
          students.ToList().ForEach(_consoleReaderWriter.Write);
          break;
        case "p":
          students.ToList().ForEach(_printerWriter.Write);
          break;
      }
    }

    private readonly IDataProvider<Student> _dataProvider;
    private readonly IReaderWriter _consoleReaderWriter;
    private readonly IReaderWriter _printerWriter;
  }
}
