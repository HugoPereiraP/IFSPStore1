using IFSPStore.Domain.Base;
using IFSPStore.Service.Service;
using IFSPStore.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using AutoMapper;
using IFSPStore.Service.Validators;
using System.Text.Json;
using Microsoft.Extensions.Logging.Abstractions;

namespace IFSPStore.Test
{
    [TestClass]
    public class ServiceTest
    {
        private ServiceCollection services = null!;

        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<IFSPStoreContext>();
            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            services.AddScoped<IBaseService<User>, BaseService<User>>();
            services.AddSingleton(
                new MapperConfiguration(config => { config.CreateMap<User, User>(); }, NullLoggerFactory.Instance).CreateMapper()
            );
            return services.BuildServiceProvider();

        }



        [TestMethod]
        public void TestUserService()
        {
            var serviceProvider = ConfigureServices();


            var _userService = serviceProvider.GetRequiredService<IBaseService<User>>();

            var user = new User(
                id: 10,
                "HUgo",
                "123",
                "hugoo",
                "blabla",
                DateTime.Now,
                DateTime.Now,
                true
            );

            var result = _userService.Add<User, User, UserValidator>(user);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }
    }
}
