using static System.Console;

namespace DataProcessorApp;

internal class FileProcessor
{
    public string InputFilePath {  get; }
    public FileProcessor (string inputFilePath) => InputFilePath = inputFilePath;
    public void Process() {
        Console.WriteLine($"Begin process in {InputFilePath}");
    }
}
