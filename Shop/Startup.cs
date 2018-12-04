using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shop.Models;

namespace Shop
{
    public class Startup
    {
        public IConfiguration Configuration { get; } // zawiera informacje odczytan przez Program.cs 

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) // wbudowany kontner umożliwiający wstrzykiwanie zależności, przez konstruktor - tutaj kolekcja usuług
        { // tu rejestracja usług systemowych i własnych, do kontenera wstrzykkiwania zależności
            services.AddDbContext<AppDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<ICarRepository, CarRepository>(); // kiedy żadana ICarRepo, zostanie zwrócone !!nowa!! instancja Mock; mogłby być AddSingelton
            services.AddTransient<IOpinionRepository, OpinionRepository>(); 
            services.AddMvc(); // app wie o MVC :D
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage(); // strona śmierci... zółta :D, tylko dla fazy development
            app.UseStatusCodePages(); // obsługa nagłowków tekstowych kodów statusu np. 400, 500
            app.UseStaticFiles(); // umożliwia obsługą plików statycznych js, obrazy 
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
            }); // powinno być na końcu
        }
    }
}
