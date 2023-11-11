
using Autofac.Extensions.DependencyInjection;
using Autofac;
using Newtonsoft.Json.Serialization;
using Shopping.ShoppingAPI.Utils.SwaggerExt;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Shopping.ShoppingEntity.AutoMapper;
using Shopping.ShoppingEntity.Entity;
using Serilog;
using Serilog.Events;


namespace Shopping.ShoppingAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers().AddNewtonsoftJson(opt =>
            {
                opt.SerializerSettings.ContractResolver = new DefaultContractResolver();//Swagger�ֶδ�Сд
                opt.SerializerSettings.DateFormatString = "yyyy-MM-dd HH-mm-ss";//ʱ���ʽ
            });


            #region SeriLog
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
                .WriteTo.Console(outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();
            builder.Host.UseSerilog();
            #endregion

            #region Redis
            builder.Services.AddStackExchangeRedisCache(opt =>
            {
                opt.Configuration = builder.Configuration.GetConnectionString("Redis");
                opt.InstanceName = "RedisInstance";
            });
            #endregion

            #region AutoMapper
            builder.Services.AddAutoMapperServices();
            #endregion

            #region Cors
            builder.Services.AddCors(option =>
            {
                option.AddPolicy("MyCors", opt =>
                {
                    opt.AllowAnyHeader()
                    .AllowAnyOrigin()
                    .AllowAnyMethod();
                });
            });
            #endregion

            #region autoFac
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            builder.Host.ConfigureContainer<ContainerBuilder>(ContainerBuilder =>
            {
                ContainerBuilder.RegisterAssemblyModules(typeof(Utils.AutoFac.AutoFacModule).Assembly);
            }).ConfigureServices(service => service.AddAutofac());
            #endregion

            #region Jwt
            builder.Services
                .AddAuthorization()//������֤
                .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)//ָ����Ȩ������
                .AddJwtBearer(opt =>
                {
                    opt.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("$7mV6u9GhD1_W*MpD&t+AuBoT7I8+UAz_HFm3D_355C(1RVDw")),
                        ClockSkew = TimeSpan.Zero
                    };
                });
            #endregion

            #region DBSet
            builder.Services.AddDbContext<ShoppingDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
            });
            #endregion

            #region SwaggerExt
            builder.Services.AddBuilderServicesExt();
            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                #region SwaggerExt
                app.AddAppExt();
                #endregion
            }

            app.UseStaticFiles();

            app.UseCors("MyCors");

            app.UseSerilogRequestLogging();

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();


            app.UseResponseCaching();
            app.MapControllers();
            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}