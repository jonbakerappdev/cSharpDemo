using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace abstractFactoryCSharp.Employee
{
    public class Employee:IEmployee
    {
        //private string _name;
        //private string _title;
        //private int _age;
        //private decimal _salary;
      public int EmployeeID { get; set; }
      public string LastName { get; set;}
      public string FirstName { get; set;}
      public string Title { get; set;}
      public string TitleOfCourtesy { get; set;}
      public DateTime BirthDate { get; set;}
      public DateTime HireDate { get; set;}
      public string Address { get; set;}
      public string City { get; set;}
      public string Region { get; set;}
      public string PostalCode { get; set;}
      public string Country { get; set;}
      public string HomePhone { get; set;}
      public string Extension { get; set;}
      public string Photo { get; set;}
      public string Notes { get; set;}
      public string ReportsTo { get; set;}
      public string PhotoPath { get; set;}
      
        public int Age
        {
            get {
                  return DateTime.Now.Year - BirthDate.Year;
            }
            set { Convert.ToInt32(DateTime.Now.Year - BirthDate.Year); }
        }

        public decimal Salary
        {
            get;set;
        }
    }
}

//Private _name As String
//    Private _title As String
//    Private _age As Integer
//    Private _salary As Decimal