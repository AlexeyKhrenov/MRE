using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MRE.Repo;

namespace MRE.API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            
            services
                .AddTransient<Repo.Repo>()
                .AddTransient<Listener>()
                .AddTransient<Service>()
                .AddDbContextPool<MyDbContext>((provider, options) => options.UseInMemoryDatabase("InMemoryDb"));
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(_ => _.MapControllers());

            var scopeFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
            using var scope = scopeFactory.CreateScope();
            scope.ServiceProvider.GetRequiredService<Listener>().StartHub();
        }
    }
}
