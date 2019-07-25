using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace FifteenBelow.DeployedSystemTester.Runner
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            await new HostBuilder().Build().RunAsync();
        }
    }
}
