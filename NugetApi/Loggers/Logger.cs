using System.Threading.Tasks;
using NuGet.Common;

namespace NugetApi.Loggers
{
    public class Logger : ILogger
    {
        public void LogDebug(string data) => ObjectDumper.Dump($"DEBUG: {data}");
        public void LogVerbose(string data) => ObjectDumper.Dump($"VERBOSE: {data}");
        public void LogInformation(string data) => ObjectDumper.Dump($"INFORMATION: {data}");
        public void LogMinimal(string data) => ObjectDumper.Dump($"MINIMAL: {data}");
        public void LogWarning(string data) => ObjectDumper.Dump($"WARNING: {data}");
        public void LogError(string data) => ObjectDumper.Dump($"ERROR: {data}");
        public void LogInformationSummary(string data) => ObjectDumper.Dump($"SUMMARY: {data}");

        public void Log(LogLevel level, string data) => ObjectDumper.Dump($"{level}: {data}");

        public Task LogAsync(LogLevel level, string data)
        {
            throw new System.NotImplementedException();
        }

        public void Log(ILogMessage message)=> ObjectDumper.Dump($"{message.Level}: {message.Message}");

        public Task LogAsync(ILogMessage message)
        {
            throw new System.NotImplementedException();
        }
    }
}