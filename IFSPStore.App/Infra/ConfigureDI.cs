using IFSPStore.App.Register;
using IFSPStore.App.ViewModels;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using IFSPStore.Service.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IFSPStore.App.Infra;

internal static class ConfigureDI
{
    public static ServiceProvider serviceProvider;

    public static void ConfigureService()
    {
        var dbConfigFile = "Config/DbConfig.txt";
        var dbConnectionString = File.ReadAllText(dbConfigFile);

        var services = new ServiceCollection();

        services.AddDbContext<IFSPStoreDbContext>(options =>
        {
            options.LogTo(Console.WriteLine);
            options.UseNpgsql(dbConnectionString);
        });

        services.AddScoped<IBaseRepository<Category>, BaseRepository<Category>>();

        services.AddScoped<IBaseService<Category>, BaseService<Category>>();

        services.AddLogging();

        services.AddAutoMapper(config =>
        {
            config.CreateMap<User, User>().ReverseMap();
            config.CreateMap<Category, CategoryModel>().ReverseMap();
        });

        services.AddTransient<CategoryForm>();

        serviceProvider = services.BuildServiceProvider();
    }
}
