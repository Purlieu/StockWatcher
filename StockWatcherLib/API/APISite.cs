using System;
using System.Collections.Generic;
using System.Text;

namespace StockWatcherLib.API
{
    public abstract class APISite<T>
    {
        public string APIKey { get; set; }
        public Dictionary<string, T> QueryDictionary { get; set; } = new Dictionary<string, T>();
        public APISite() { GenerateDictionary(); }

        public abstract void GenerateDictionary();
    }
}
