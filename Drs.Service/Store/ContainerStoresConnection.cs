﻿using System.Collections.Generic;
using Drs.Model.Store;
using Drs.Repository.Store;

namespace Drs.Service.Store
{
    public static class ContainerStoresConnection
    {
        public static List<StoreConnection> Stores {
            get
            {
                using (var repository = new StoreRepository())
                {
                    return repository.GetStoreConnection();
                }                        
            }
        }
    }
}
