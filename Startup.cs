using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QuanLyKVC.Models;
using QuanLyKVC.Repository;

namespace QuanLyKVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<AmusementParkContext>(item => item.UseSqlServer(Configuration.GetConnectionString("BlogDBConnection")));
            services.AddScoped<IChiTietHoaDonRepository, ChiTietHoaDonRepository>(); 
            services.AddScoped<IVeRepository, VeRepository>();
            services.AddScoped<IHoaDonRepository, HoaDonRepository>();
            services.AddScoped<IKhuTroChoiRepository, KhuTroChoiRepository>();
            services.AddScoped<INguoiDungRepository, NguoiDungRepository>();
            services.AddScoped<IQuyenRepository, QuyenRepository>();
            services.AddScoped<INhanVienRepository, NhanVienRepository>();
            services.AddScoped<ITroChoiRepository, TroChoiRepository>();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
