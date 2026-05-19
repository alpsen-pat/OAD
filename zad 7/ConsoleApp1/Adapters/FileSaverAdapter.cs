using ConsoleApp1.External;

namespace ConsoleApp1.Adapters;

public class FileSaverAdapter : IReportSaver
{
    private readonly ExternalFileSaver _externalSaver;

    public FileSaverAdapter(ExternalFileSaver externalSaver)
    {
        _externalSaver = externalSaver;
    }

    public void Save(string content)
    {
        _externalSaver.SaveToFileSystem(content);
    }
}