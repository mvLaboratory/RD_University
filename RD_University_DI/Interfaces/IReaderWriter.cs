namespace RD_University_DI.Interfaces
{
  public interface IReaderWriter 
  {
    string Read();

    void Write(object objectToWrite);
  }
}
