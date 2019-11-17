using System.Threading.Tasks;
using NugetApi;
using NugetApi.Loggers;

namespace NugetCustomConsole
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {

          await PackageInstaller.InstallWithDependencies("UmbracoCms","8.3.0","net472", new Logger());
        }
    }
}