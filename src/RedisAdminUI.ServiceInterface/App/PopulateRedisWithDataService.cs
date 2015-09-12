using System.Collections.Generic;
using RedisAdminUI.DataSource.Northwind;
using RedisAdminUI.ServiceModel.Operations.App;
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
            //Redis.StoreAll(NorthwindData.CustomerCustomerDemos);
            Redis.StoreAll(NorthwindData.Regions);
            Redis.StoreAll(NorthwindData.Territories);
            Redis.StoreAll(NorthwindData.EmployeeTerritories);

            LoadDifferentKeyTypes(Redis);

            return new PopulateRedisWithDataResponse();
        }

        protected void LoadDifferentKeyTypes(IRedisClient client)
        {
            var items = new List<string> { "one", "two", "three", "four" };
            var map = new Dictionary<string, string> {
                        {"A","one"},
                        {"B","two"},
                        {"C","three"},
                        {"D","four"},
                    };

            items.ForEach(x => Redis.Set("urn:testkeytypes:string:" + x, x));
            items.ForEach(x => Redis.AddItemToList("urn:testkeytypes:list", x));
            items.ForEach(x => Redis.AddItemToSet("urn:testkeytypes:set", x));
            var i = 0;
            items.ForEach(x => Redis.AddItemToSortedSet("urn:testkeytypes:zset", x, i++));
            Redis.SetRangeInHash("urn:testkeytypes:hash", map);
        }
    }
}