using System;
using System.Collections.Generic;
using System.Text;

namespace StockWatcherLib.API.AlphaAdvantage
{
    public class AlphaAdvantageAPISite : APISite<AlphaVantageAPIEnum>
    {
        public AlphaAdvantageAPISite()
        {
            APIKey = "EV6OZSLIZGEHYEIT";
        }

        public override void GenerateDictionary()
        {
            
        }
    }

    public enum AlphaVantageAPIEnum
    {

    }
}
