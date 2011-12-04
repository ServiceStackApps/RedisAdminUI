using System;
using ServiceStack.Redis;

namespace RedisWebServices.ServiceInterface
{
    public class AuthenticatedClientFactory : IRedisClientFactory
    {
        public string Password { get; set; }

        public AuthenticatedClientFactory(string password)
        {
            Password = password;
        }

        public RedisClient CreateRedisClient(string host, int port)
        {
            return new RedisClient(host, port)
            {
                Password = Password
            };
        }
    }
}
