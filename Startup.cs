using HikikomoriWEB.MVC.HelperInterfaces;
using HikikomoriWEB.MVC.MockClass;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HikikomoriWEB
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services) //функционал подключаетс€ с помощью сервисов в MVC
        {
            services.AddControllersWithViews().SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider(); //подключение поддержки MVC и совместимость версий asp.net core 3
            //services.AddMvc(options => options.EnableEndpointRouting = false); //другой способ маршрутизации
            services.AddTransient<IContent, MockContent>();
            services.AddTransient<ICategory, MockCategory>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); //если в окружении разработки то выводит подробную инфу об ошибках
            }
            app.UseRouting(); //система маршрутизации (если используем AddMvc, то устанавливаем дефол–оут и отключаем эндпоинт–оут в сервисе)
            app.UseStaticFiles(); //поддержка статичных файлов (css,js...)
            app.UseStatusCodePages(); //обработка ошибок http (404)
            app.UseEndpoints(endpoints => { endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}"); }); //маршрутизаци€ под useRouting(если в адресе не прописан контроллер, то используем по умолчанию контроллер дл€ главной страницы и меотод)
            //app.UseMvcWithDefaultRoute(); //другой способ маршрутизации
            
        }
    }
}
