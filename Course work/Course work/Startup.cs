﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coursework;
using Coursework.Db;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Course_work
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }
        public void ConfigureServices(IServiceCollection services)
        {
            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<EfContext>(options => options.UseSqlServer(connection));
            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseSignalR(routes =>
            {
                routes.MapHub<ChatHub>("/chat");
            });
        }
    }
}
