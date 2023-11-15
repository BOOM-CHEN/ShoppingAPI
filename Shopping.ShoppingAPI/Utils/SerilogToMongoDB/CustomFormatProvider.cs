using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using Newtonsoft.Json;
using Serilog.Events;
using Serilog.Formatting;

namespace Shopping.ShoppingAPI.Utils.SerilogToMongoDB
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomFormatProvider : ITextFormatter
    {
        /// <inheritdoc/>
        public void Format(LogEvent logEvent, TextWriter output)
        {
            var log = new CustomMongoDBLogField()
            {
                ExpireTime = logEvent.Timestamp.DateTime.AddHours(new Random().NextDouble()*6).ToString("yyyy-MM-dd HH:mm:ss"),
                CreateTime = logEvent.Timestamp.DateTime.ToString("yyyy-MM-dd HH:mm:ss"),
                EventLevel = logEvent.Level.ToString(),
                RequestMethod = logEvent.Properties.TryGetValue("RequestMethod",out var requestMethod).ToString(),
                RequestPath = logEvent.Properties.TryGetValue("RequestPath",out var RequestPath).ToString(),
                StatusCode = logEvent.Properties.TryGetValue("StatusCode",out var StatusCode).ToString()
            };
            output.Write(JsonConvert.SerializeObject(log));
        }
    }

}
