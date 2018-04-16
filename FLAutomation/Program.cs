using System.Threading;

namespace FLAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            AutomationBase ab = new AutomationBase();
            ab.TestInitialize();
            Thread.Sleep(100);
            ab.TestCleanup();
        }
    }
}
