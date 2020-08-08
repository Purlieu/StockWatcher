using System;
using System.Collections.Generic;
using System.Text;

namespace StockWatcherLib.API.IExcloud
{
    public class IEXCloudAPISite : APISite<IEXCloudAPIEnum>
    {
        public IEXCloudAPISite()
        {
            APIKey = "pk_ab065230f53c4ab39d688d9ac6daeda7";
        }

        public override void GenerateDictionary()
        {
            
        }
    }

    public enum IEXCloudAPIEnum
    {

    }
}
