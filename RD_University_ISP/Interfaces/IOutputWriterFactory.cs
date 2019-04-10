namespace RD_University_ISP.Interfaces
{
  public interface IOutputWriterFactory
  {
    IOutputWriter GetWriter(string writerType);
  }
}
