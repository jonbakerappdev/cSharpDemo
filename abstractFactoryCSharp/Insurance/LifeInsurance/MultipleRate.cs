using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace abstractFactoryCSharp.Insurance.LifeInsurance
{
    public class MultipleRate : BasePlan
    {
        private int multiple { get; set; }

        public Employee.Employee worker;

        public void New( string _name, string _title,int _age, decimal _salary,string _planName, int _planType, int _multiple) {
           // worker = new Employee.Employee(_name, _title, _age, _salary);
            PlanName = _planName;
            PlanType = _planType;
            multiple = _multiple;
            }
            
        public override double CalculateRate()
        {
            return(Convert.ToDouble(multiple * worker.Salary) * 0.3 / 10000);
        }

        public override decimal GetCoverage()
        {
            return multiple * worker.Salary;
        }
    }
}
