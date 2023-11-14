﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Shopping.ShoppingAPI.Utils.SerilogToMongoDB
{
    /// <summary>
    /// 自定义日志格式
    /// </summary>
    public class CustomMongoDBLogField
    {
        /// <summary>
        /// 时间戳
        /// </summary>
        public string ExpireTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CreateTime { get; set; }
        /// <summary>
        /// 请求方式
        /// </summary>
        public string RequestMethod { get; set; }
        /// <summary>
        /// 请求路径
        /// </summary>
        public string RequestPath { get; set; }
        /// <summary>
        /// 响应状态码
        /// </summary>
        public string StatusCode { get; set; }
        /// <summary>
        /// 事件级别
        /// </summary>
        public string EventLevel { get; set; }
    }
}
