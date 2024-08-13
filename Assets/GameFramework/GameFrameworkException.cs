using System;
using System.Runtime.Serialization;

namespace GameFramework
{
    /// <summary>
    /// 游戏框架异常类
    /// </summary>
    [Serializable]
    public class GameFrameworkException : Exception
    {
        /// <summary>
        /// 初始化游戏框架异常类型的新实例
        /// </summary>
        public GameFrameworkException()
            : base()
        {
            
        }
        
        /// <summary>
        /// 使用指定错误信息初始化游戏框架异常类的新实例
        /// </summary>
        /// <param name="message"></param>
        public GameFrameworkException(string message)
            : base(message)
        {
        }
        
        /// <summary>
        /// 用指定错误消息和对作为此异常原因的内部异常的引用来初始化游戏框架异常类的新实例。
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public GameFrameworkException(string message, Exception innerException)
            : base(message, innerException)
        {
            
        }
        
        /// <summary>
        /// 用序列化数据初始化游戏框架异常类的新实例
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected GameFrameworkException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }    
}

