namespace RD_University_OCP.Interfaces
{
  public interface IOutputWriterFactory
  {
    IOutputWriter GetWriter(string writerType);
  }
}
