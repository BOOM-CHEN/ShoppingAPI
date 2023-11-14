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
                RequestMethod = logEvent.Properties["RequestMethod"].ToString(),
                RequestPath = logEvent.Properties["RequestPath"].ToString(),
                StatusCode = logEvent.Properties["StatusCode"].ToString()
            };
            output.Write(JsonConvert.SerializeObject(log));
        }
    }

}
