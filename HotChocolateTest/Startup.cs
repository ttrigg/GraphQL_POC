using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using GraphQLFoundation.Domain.Company;
using HotChocolate.AspNetCore;
using HotChocolateTest.AutoMapper;
using HotChocolateTest.Services.Company;

namespace HotChocolateTest
{
    public class Startup
    {
        private const string CORS_POLICY_NAME = "AllowAll";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddCors(options => options.AddPolicy(CORS_POLICY_NAME,
                builder => builder
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowAnyOrigin()
                    .AllowCredentials()
                ));

            // Configure asp net core
            services
                .AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Configure databases
            services.AddDbContext<CompanyDBContext>(options =>
                options.UseSqlServer(@"Data Source=.;Initial Catalog=graphql_example_Company;Integrated Security=True;"));

            // Automapper
            services.AddAutoMapper(typeof(AutoMapperMaps));

            // DI
            services.AddTransient<ICompany, Company>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Cors
            app.UseCors(CORS_POLICY_NAME);

            // Use MVC
            app.UseMvc();

            app.UseGraphQL();

            // Editor location
            app.UsePlayground("/api/editor");
        }
    }
}
