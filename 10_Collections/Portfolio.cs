using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_Collections._09_Portfolio;

namespace _10_Collections
{
    
    internal class Portfolio
    {
        private List<IAsset> portlist;

        public Portfolio(List<IAsset> portlist2)
        {
            this.portlist = portlist2;
        }

        public double TotalValue { get; set; }

        internal double GetTotalValue()
        {
            TotalValue = 0;
            foreach (var item in portlist)
            {
                TotalValue += item.GetValue();

            }
            return TotalValue;
        }

        public Portfolio()
        {
            portlist = new List<IAsset>();
        }

        internal void AddIAsset(IAsset newasset)
        {
            portlist.Add(newasset);

        }

        internal IList<IAsset> GetIAssets()
        {
            return portlist;
        }

        public string symbol { get; set; }
        public int pricePerShare { get; set; }
        public double numShares { get; set; }
       

        internal IAsset GetIAssetByName(string v)
        {

            for (int i = 0; i < portlist.Count; i++)
            {
                if (v == portlist[i].GetName())
                {
                    return portlist[i];
                }
            }
            return null;
            
        }
      
    }
}


