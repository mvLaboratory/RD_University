namespace RD_University_LSP.Interfaces
{
  public interface IOutputWriterFactory
  {
    IOutputWriter GetWriter(string writerType);
  }
}
