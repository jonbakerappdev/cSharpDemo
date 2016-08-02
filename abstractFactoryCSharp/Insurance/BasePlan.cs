using abstractFactoryCSharp.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace abstractFactoryCSharp.Insurance
{
    public abstract class BasePlan
    {
        public IEmployee Worker;
        public string PlanName { get; set; }
        public int PlanType { get; set; }
        abstract public double CalculateRate ();
        abstract public decimal GetCoverage();
    }
}       


