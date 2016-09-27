namespace _10_Collections
{
    using System;

    namespace _09_Portfolio
    {
        public class Stock : IAsset
        {
            public Stock()
            {

            }


            public Stock(string v1, double v2, int v3)
            {
                symbol = v1;
                pricePerShare = v2;
                numShares = v3;
            }

            private string symbol;

            private double pricePerShare;

            public double PricePerShare
            {
                get { return pricePerShare; }
                set { pricePerShare = value; }
            }


            public string Symbol
            {
                get { return symbol; }
                set { symbol = value; }
            }

            private int numShares;

            public int NumShares
            {
                get { return numShares; }
                set { numShares = value; }
            }


            internal double GetValue()
            {

                return (pricePerShare * numShares);
            }

            internal static double TotalValue(IAsset[] stocks)
            {
                return stocks[0].GetValue() + stocks[1].GetValue();
            }

            public override string ToString()
            {
                return "Stock[symbol=" + symbol + ",pricePerShare=" + pricePerShare.ToString().Replace(',', '.') + ",numShares=" + numShares + "]";
            }
            public override bool Equals(Object stocks)
            {

                if (stocks is Stock)
                {

                    Stock s = (Stock)stocks;
                    if (symbol == s.Symbol && pricePerShare == s.PricePerShare && numShares == s.NumShares)
                    { return true; }
                    else
                        return false;
                }
                else
                    return false;


            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            double IAsset.GetValue()
            {
                return GetValue();
            }
            public string GetName()
            {
                return symbol;
            }
        }
    }
}