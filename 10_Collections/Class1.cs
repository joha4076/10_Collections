using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{
    internal class SavingsAccount : IAsset
    {

        public SavingsAccount(string v1, int v2, double v3)
        {
            Name = v1;
            Value = v2;
            InterestRate = v3;
        }
        public string Name { get; set; }
        public int Value { get; set; }
        public double InterestRate { get; set; }

        public override string ToString()
        {
            return "SavingsAccount[value=" + Value.ToString("F1").Replace(',', '.') + ",interestRate=" + InterestRate.ToString().Replace(',', '.') + "]";
        }

        public double GetValue()
        {
            return Value;
        }

        double IAsset.GetValue()
        {
            return Value;
        }
        public string GetName()
        {
            return Name;
        }
    }
}

