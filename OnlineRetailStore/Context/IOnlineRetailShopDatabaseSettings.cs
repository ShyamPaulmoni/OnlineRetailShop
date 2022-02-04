using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRetailStore.Context
{
    public interface IOnlineRetailShopDatabaseSettings
    {
        string ConnectionString { get; set; }

        string DatabaseName { get; set; }

        string ProductsCollectionName { get; set; } 
        string OrdersCollectionName { get; set; }
    }
}
