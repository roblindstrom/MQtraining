using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MQtraining.UI.Services.Items;
using MQtraining.UI.Services.LineItems;
using MQtraining.UI.Services.Orders;
using System;
using System.Reflection;

namespace MQtraining.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddHttpClient<IOrderDataService, OrderDataService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44337/");
            });

            services.AddHttpClient<IItemDataService, ItemDataService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44337/");
            });


            services.AddHttpClient<ILineItemDataService, LineItemDataService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44337/");
            });

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });


        }
    }
}
