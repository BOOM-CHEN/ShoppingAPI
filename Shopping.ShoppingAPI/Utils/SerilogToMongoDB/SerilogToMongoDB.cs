using MongoDB.Bson;
using MongoDB.Driver;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.MongoDB;
using Shopping.ShoppingEntity.Models;

namespace Shopping.ShoppingAPI.Utils.SerilogToMongoDB
{
    /// <summary>
    /// 存储日志
    /// </summary>
    public static class SerilogToMongoDB
    {
        private static readonly WebApplicationBuilder builder;
        static SerilogToMongoDB()
        {
            builder = WebApplication.CreateBuilder();
        }
        /// <summary>
        /// 存储日志
        /// </summary>
        /// <param name="services"></param>
        public static void AddSerilogToMongoDBService(this IServiceCollection services)
        {
            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.AddSerilog();
            });

            var MongoDBConnection = builder.Configuration.GetSection("MongoDB").Get<MongoDBSetting>();
            var MongoDBClient = new MongoClient(MongoDBConnection.ConnectionString);
            var MongoDBDataBase = MongoDBClient.GetDatabase(MongoDBConnection.DatabaseName);
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
                .WriteTo.Console(outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .WriteTo.MongoDB(
                    MongoDBDataBase,
                    collectionName: MongoDBConnection.CollectionName,
                    restrictedToMinimumLevel:LogEventLevel.Information
                )
                .CreateLogger();
        }
    }
}
