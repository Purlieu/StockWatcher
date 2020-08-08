using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockWatcherLib.API.Finnhub
{
    public class FinnhubAPISite : APISite<FinnhubAPIEnum>
    {
        public FinnhubAPISite()
        {
            APIKey = "bsmqt27rh5r99fh1cku0";
        }

        public override void GenerateDictionary()
        {
           
        }
    }

    public enum FinnhubAPIEnum
    {

    }
}
