using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRetailStore.Context
{
    public class OnlineRetailStoreDatabaseSettings : IOnlineRetailShopDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string ProductsCollectionName { get; set; } = null!;
        public string OrdersCollectionName { get; set; } = null!;
    }
}
