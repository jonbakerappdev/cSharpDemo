using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using abstractFactoryCSharp.Employee;


namespace abstractFactoryCSharp.Insurance.LifeInsurance
{
    public class FlatRate : BasePlan

    { 
        public Employee.Employee peeOn;

        private decimal _coverage = 0;

        public void New(decimal coverage)
        {
            _coverage = coverage;
        }
        
        public override double CalculateRate()
        {
            double rate = 1.8 * PeeOn.Age;
            return rate;
        }

        public override decimal GetCoverage()
        {
            return _coverage;
        }
    }
}