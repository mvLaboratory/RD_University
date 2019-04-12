using System;
using System.Collections.Generic;
using System.Text;
using RD_University.Interfaces;

namespace RD_University.Core
{
    public class ChatBotReaderWriter : IReaderWriter
    {
      public string Read()
      {
        return "s";
      }

      public void Write(object objectToWrite)
      {
        Console.WriteLine($"Hey this is ChatBot {objectToWrite}");
      }
    }
}
