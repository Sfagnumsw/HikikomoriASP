using HikikomoriWEB.MVC.HelperClass;
using HikikomoriWEB.MVC.HelperInterfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using HikikomoriWEB.Domain.Repository;
using HikikomoriWEB.Domain;
using Microsoft.EntityFrameworkCore;

namespace HikikomoriWEB
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services) //���������� ������������ � ������� �������� � MVC
        {
            Configuration.Bind("Project", new Config()); //����������� ������������ �� appsettings.json � ���������� � �������������� �������
      
            //services.AddMvc(options => options.EnableEndpointRouting = false); //������ ������ ������������� ����� configure(��������� ��������)

            services.AddTransient<IContent, ContentRepositoryEntity>(); //����������� �����������
            services.AddTransient<ICategory, CategoryRepositoryEntity>();
            services.AddTransient<IRemember, RememberRepositoryEntity>();
            services.AddTransient<DataManager>();

            services.AddDbContext<AppDbContext>(i => i.UseSqlServer(Config.ConnectionString)); //����������� ��������� ��

            services.AddControllersWithViews().SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider(); //����������� ��������� MVC � ������������� ������ asp.net core 3 , � ��� �� ������� ��� ������������ � �������������
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) //����� ����� ������� ����������� �������
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); //���� � ��������� ���������� �� ������� ��������� ���� �� �������
            }
            app.UseStaticFiles(); //��������� ��������� ������ (css,js...)
            app.UseRouting(); //������� ������������� (���� ���������� AddMvc, �� ������������� ��������� � ��������� ������������ � �������)
            app.UseStatusCodePages(); //��������� ������ http (404)
            app.UseEndpoints(endpoints => { endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}"); }); //������������� ��� useRouting(���� � ������ �� �������� ����������, �� ���������� �� ��������� ���������� ��� ������� �������� � ������)
            //app.UseMvcWithDefaultRoute(); //������ ������ �������������
        }
    }
}
