namespace Phase4.Advanced;

public class FileLogger : IDisposable
{
    private readonly StreamWriter _writer;
    private bool _disposed = false;

    public FileLogger(string filePath)
    {
        _writer = new StreamWriter(filePath, append: true);
    }

    public void Log(string message)
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
        _writer.WriteLine($"{DateTime.UtcNow}: {message}"); // stays in buffer until flushed
        // _writer.Flush(); // flushes the buffer to the file immediately
    }

    public void Dispose()
    {
        if (_disposed) return;
        _disposed = true;
        _writer.Dispose();
    }
}