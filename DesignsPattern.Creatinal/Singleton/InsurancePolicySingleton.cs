using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsPattern.Creatinal.Singleton
{
    public class InsurancePolicySingleton
    {
        private static readonly Lazy<InsurancePolicySingleton> _instance =
        new Lazy<InsurancePolicySingleton>(() => new InsurancePolicySingleton());

        // Private constructor to prevent instantiation
        private InsurancePolicySingleton() { }

        public static InsurancePolicySingleton Instance => _instance.Value;

        // Property
        public int PolicyId { get; set; }
        public string PolicyType { get; set; }
        public double Premium { get; set; }
        public double CoverAmount { get; set; }

        public override string ToString()
        {
            return $"Policy Type: {PolicyType}, Premium: {Premium}, Cover Amount: {CoverAmount}";
        }
    }
}
