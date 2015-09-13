using System.Collections.Generic;
using RedisAdminUI.DataSource.Northwind;
using RedisAdminUI.ServiceModel.Operations.App;
using ServiceStack;
using ServiceStack.Redis;

namespace RedisAdminUI.ServiceInterface.App
{
    public class PopulateRedisWithDataService : RedisServiceBase
    {
        static PopulateRedisWithDataService()
        {
            NorthwindData.LoadData();
        }

        public object Any(PopulateRedisWithData request)
        {
            Redis.StoreAll(NorthwindData.Categories);
            Redis.StoreAll(NorthwindData.Customers);
            Redis.StoreAll(NorthwindData.Employees);
            Redis.StoreAll(NorthwindData.Shippers);
            Redis.StoreAll(NorthwindData.Orders);
            Redis.StoreAll(NorthwindData.Products);
            Redis.StoreAll(NorthwindData.OrderDetails);
            Redis.StoreAll(NorthwindData.Regions);
            Redis.StoreAll(NorthwindData.Territories);
            Redis.StoreAll(NorthwindData.EmployeeTerritories);

            LoadBasicStrings(Redis);

            //Just load collections in DB 1
            using (var redisDb1 = new RedisClient(Redis.Host, Redis.Port, db: 1))
            {
                LoadDifferentKeyTypes(redisDb1);
            }

            return new PopulateRedisWithDataResponse();
        }

        protected void LoadBasicStrings(IRedisClient redis)
        {
            int A = 'A';
            int Z = 'Z';
            var letters = (Z - A + 1).Times(i => ((char)(i + A)).ToString());
            var numbers = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var pos = 0;
            letters.Each(x => redis.Set("string:letters/" + x, x));
            numbers.Each(x => redis.Set("string:numbers/" + pos++, x));
        }

        protected void LoadDifferentKeyTypes(IRedisClient redis)
        {
            int A = 'A';
            int Z = 'Z';
            var letters = (Z - A + 1).Times(i => ((char)(i + A)).ToString());
            var numbers = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            redis.RemoveEntry("list:letters", "list:numbers"); //don't add duplicates to existing list
            letters.Each(x => redis.AddItemToList("list:letters", x));
            numbers.Each(x => redis.AddItemToList("list:numbers", x));

            letters.Each(x => redis.AddItemToSet("set:letters", x));
            numbers.Each(x => redis.AddItemToSet("set:numbers", x));

            var pos = 0;
            letters.Each(x => redis.AddItemToSortedSet("zset:letters", x, pos++));
            pos = 0;
            numbers.Each(x => redis.AddItemToSortedSet("zset:numbers", x, pos++));

            pos = 0;
            letters.Each(x => redis.SetEntryInHash("hash:letters", x, (pos++).ToString()));
            pos = 0;
            numbers.Each(x => redis.SetEntryInHash("hash:numbers", x, (pos++).ToString()));
        }
    }
}