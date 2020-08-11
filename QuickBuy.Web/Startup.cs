using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuickBuy.Dominio.Contracts;
using QuickBuy.Repositorio.Context;
using QuickBuy.Repositorio.Repositories;

namespace QuickBuy.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder();
            //optional:false diz que o arquivo não é opcional:
            //reloadOnChange:true diz que quando for identificado alguma alteração no arquivo json, ele será recarregado
            builder.AddJsonFile("config.json", optional:false, reloadOnChange:true);

            //o Build construi uma interface de configuração com as chaves e os valores que foram setados
            //(no caso passamos um arquivo de configuração que possui informações de chave e valor)
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            var connectionString = Configuration.GetConnectionString("MySqlConnection");

            //Referenciando o Context do projeto
            services.AddDbContext<QuickBuyContext>(option => 
                                                        option.UseLazyLoadingProxies()
                                                        .UseMySql(connectionString, 
                                                        m => m.MigrationsAssembly("QuickBuy.Repositorio"))); //Definindo o projeto que contém o context
            //usada expressão lamda onde a variável de entrada option vai utilizar o mysql
            services.AddScoped<IProductRepository, ProductRepository>();

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    /*Linha de código que inicializar de forma mais simples o Angular*/
                    //spa.UseAngularCliServer(npmScript: "start");

                    /*Executando o angular diretamente informando o caminho de publicação do mesmo*/
                    spa.UseProxyToSpaDevelopmentServer("http://localhost:4200/");
                }
            });
        }
    }
}
