using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using IFSPStore.Service.Service;
using IFSPStore.Service.Validators;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;

namespace IFSPStore.Test;

[TestClass]
public class ServiceTest
{
    private ServiceCollection _services;

    public ServiceProvider ConfigureService()
    {
        _services = new ServiceCollection();

        _services.AddDbContext<IFSPStoreDbContext>();
        _services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
        _services.AddScoped<IBaseService<User>, BaseService<User>>();
        _services.AddLogging();
        _services.AddAutoMapper(config =>
        {
            config.CreateMap<User, User>().ReverseMap();
        });


        return _services.BuildServiceProvider();
    }

    [TestMethod]
    public void TesteUserService()
    {
        var serviceProvider = ConfigureService();
        var _userService = serviceProvider.GetService<IBaseService<User>>();

        var user = new User(
            id: 1,
            name: "John Doe",
            password: "passss123",
            login: "johndoe",
            email: "johndoe@gmail.com",
            registerDate: DateTime.UtcNow.AddDays(-10),
            loginDate: DateTime.UtcNow.AddMinutes(-5),
            isActive: true
        );

        
        var result = _userService.Add<User, User, UserValidator>(user);

        Console.WriteLine(JsonSerializer.Serialize(result));
    }
}
