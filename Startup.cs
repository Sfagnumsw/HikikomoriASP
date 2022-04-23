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
        public void ConfigureServices(IServiceCollection services) //���������� ������������ � ������� �������� � MVC
        {
            services.AddControllersWithViews().SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider(); //����������� ��������� MVC � ������������� ������ asp.net core 3
            //services.AddMvc(options => options.EnableEndpointRouting = false); //������ ������ �������������
            services.AddTransient<IContent, MockContent>();
            services.AddTransient<ICategory, MockCategory>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); //���� � ��������� ���������� �� ������� ��������� ���� �� �������
            }
            app.UseRouting(); //������� ������������� (���� ���������� AddMvc, �� ������������� ��������� � ��������� ������������ � �������)
            app.UseStaticFiles(); //��������� ��������� ������ (css,js...)
            app.UseStatusCodePages(); //��������� ������ http (404)
            app.UseEndpoints(endpoints => { endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}"); }); //������������� ��� useRouting(���� � ������ �� �������� ����������, �� ���������� �� ��������� ���������� ��� ������� �������� � ������)
            //app.UseMvcWithDefaultRoute(); //������ ������ �������������
            
        }
    }
}
