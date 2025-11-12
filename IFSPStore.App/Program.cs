using IFSPStore.App.Base;
using IFSPStore.App.Infra;
using IFSPStore.App.Register;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace IFSPStore.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureDI.ConfigureService();

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}