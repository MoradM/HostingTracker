using HostingTracker.Src.Common.Interfaces;
using HostingTracker.Src.HostingServices.Hostinger;

namespace HostingTracker
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            MainAsync().GetAwaiter().GetResult();
            Application.Run(new HostingTracker());

            
        }

        private static async Task MainAsync()
        {
            // Placeholder for when I want to initialize async things on app start.
        }
    }
}