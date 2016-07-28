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

//Public Sub New(_name As String, _title As String, _age As Integer, _salary As Decimal, _planName As String, _planType As Integer, _multiple As Integer)
//        PeeOn = New Employee(_name, _title, _age, _salary)
//        PlanName = _planName
//        PlanType = _planType
//        multiple = _multiple
//    End Sub

//Public Sub New(_name As String, _title As String, _age As Integer, _salary As Decimal, _planName As String, _planType As Integer, _multiple As Integer)
//        MyBase.New(_name, _title, _age, _salary, _planName, _planType)
//        multiple = _multiple
//    End Sub

//    Public Overrides Function CalculateRate() As Decimal
//        Return(multiple* PeeOn.salary) * 0.3 / 10000
//    End Function

//    Public Overrides Function GetCoverage() As Decimal
//        Return(multiple* PeeOn.salary)
//    End Function