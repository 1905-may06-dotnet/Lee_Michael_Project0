using System;
using System.Collections.Generic;
using System.Text;
using Project00Data.Data;

namespace Project00Data
{
    public sealed class DbInstance
    {
        private static StoreContext instance = null;

        private DbInstance()
        {

        }

        public static StoreContext Instance { get
            {
                if (instance == null)
                {
                    instance = new StoreContext();
                    return instance;
                }
                else
                {
                    return instance;
                }
            }
        }
    }
}
