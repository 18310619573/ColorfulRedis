using System;

namespace ColorfulRedis.Core
{
    public struct RedisKey<TPrefix>
    {
        public TPrefix Prefix { get; }

        public RedisKey(TPrefix prefix)
        {
            Prefix = prefix;
        }

        /// <summary>
        /// Create redis key.
        /// </summary>
        /// <returns></returns>
        public string CreateKey()
        {
            return "";
        }
    }
}