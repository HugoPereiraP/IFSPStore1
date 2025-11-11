using IFSPStore.Service.Service;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace IFSPStore.App.Infra
{
    public static class ConfigureDi
    {
        private static ServiceCollection services;
        private static IServiceProvider serviceProvider;

        public  static void ConfigureServices()
        {
            var dbConfigFile = "Config/dbconfig.txt";
            var strCon = File.ReadAllText(dbConfigFile);
            services = new ServiceCollection();
            services.AddDbContext<IFSPStoreContext>(
                options =>
                {
                    options.LogTo(Console.WriteLine);
                    options.UseMySQL(strCon);
                }
                );


            services.AddScoped<IBaseRepository<Category>, BaseRepository<Category>>();
            services.AddScoped<IBaseService<Category>, BaseService<Category>>();
            serviceProvider = services.BuildServiceProvider();

        }
    }
}
