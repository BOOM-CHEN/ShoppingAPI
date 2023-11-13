using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;

namespace Shopping.ShoppingAPI.Utils.SerilogToMongoDB
{
    /// <summary>
    /// 定时删除日志
    /// </summary>
    public class AutoCleanupLog
    {
        private Timer _timer;
        private readonly TimeSpan _cleanupInterval;
        private readonly IMongoCollection<BsonDocument> _mongoCollection;
        private int listenCount = 0;
        /// <summary>
        /// 定时删除日志
        /// </summary>
        /// <param name="cleanupInterval"></param>
        /// <param name="mongoCollection"></param>
        public AutoCleanupLog(TimeSpan cleanupInterval,IMongoCollection<BsonDocument> mongoCollection)
        {
            _cleanupInterval = cleanupInterval;
            _mongoCollection = mongoCollection;
        }
        /// <summary>
        /// 启动
        /// </summary>
        public void Start()
        {
            // 创建定时器，指定回调方法和触发间隔
            _timer = new Timer(CleanupLogs, null, TimeSpan.Zero, _cleanupInterval);
            Console.WriteLine("开始监听");
        }

        private void CleanupLogs(object state)
        {
            var test = _mongoCollection.Find(_ => true).ToEnumerable();//获取集合中所有数据
            int count = 0;
            /*if (!test.Any())
            {
                Console.WriteLine("日志为空,停止监听");
                Stop();
                return;
            }*/
            foreach (var item in test)
            {
                //时区 +8(+28800)
                if ((DateTime.Now - (DateTime)item["Timestamp"]).TotalSeconds - 28800 > 30)
                    //if ((DateTime.Now - (DateTime)item["Timestamp"]).TotalSeconds - 28800 > 86400)
                {
                    //清除存储时间大于24小时的日志
                    _mongoCollection.DeleteMany(item);
                    count++;
                    
                }
            }
            if(count > 0)
            {
                Console.WriteLine("已清理"+count+"条过期日志");
            }
            Console.WriteLine(DateTime.Now + " 第" + listenCount++ +"次监听");
        }

        /// <summary>
        /// 停止定时器
        /// </summary>
        public void Stop()
        {
            // 停止定时器
            _timer?.Change(Timeout.Infinite, 0);
        }
    }
}
