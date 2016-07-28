using abstractFactoryCSharp.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace abstractFactoryCSharp.Insurance
{
    public abstract class BasePlan
    {
        public IEmployee PeeOn;
        public string PlanName { get; set; }
        public int PlanType { get; set; }
        abstract public double CalculateRate ();
        abstract public decimal GetCoverage();
    }
}


//Public Property PlanName As String

//Public Property PlanType As Integer

//    Public MustOverride Function CalculateRate() As Decimal

//    Public MustOverride Function GetCoverage() As Decimal