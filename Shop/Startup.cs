using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Shop.Models;

namespace Shop
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) // wbudowany kontner umożliwiający wstrzykiwanie zależności, przez konstruktor - tutaj kolekcja usuług
        { // tu rejestracja usług systemowych i własnych, do kontenera wstrzykkiwania zależności
            services.AddTransient<ICarRepository, MockCarsRepository>(); // kiedy żadana ICarRepo, zostanie zwrócone !!nowa!! instancja Mock; mogłby być AddSingelton
            services.AddMvc(); // app wie o MVC :D
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage(); // strona śmierci... zółta :D, tylko dla fazy development
            app.UseStatusCodePages(); // obsługa nagłowków tekstowych kodów statusu np. 400, 500
            app.UseStaticFiles(); // umożliwia obsługą plików statycznych js, obrazy 
            app.UseMvcWithDefaultRoute(); // powinno być na końcu
        }
    }
}
