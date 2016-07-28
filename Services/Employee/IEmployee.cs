using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactoryCSharp.Employee
{
    public interface IEmployee
    {
       int EmployeeID { get; set; }
       string LastName { get; set;}
       string FirstName { get; set;}
       string Title { get; set;}
       string TitleOfCourtesy { get; set;}
       DateTime BirthDate { get; set;}
       DateTime HireDate { get; set;}
       string Address { get; set;}
       string City { get; set;}
       string Region { get; set;}
       string PostalCode { get; set;}
       string Country { get; set;}
       string HomePhone { get; set;}
       string Extension { get; set;}
       string Photo { get; set;}
       string Notes { get; set;}
       string ReportsTo { get; set;}
       string PhotoPath { get; set;}
       decimal Salary { get; set; }
        int Age { get; set; }
    }
}

//Public Property name As String
//      Get
//            Return _name
//        End Get
//        Set(value As String)
//            _name = value
//        End Set
//    End Property

//    Public Property title As String
//        Get
//            Return _title
//        End Get
//        Set(value As String)
//            _title = value
//        End Set
//    End Property
//    Public Property salary As Decimal
//        Get
//            Return _salary
//        End Get
//        Set(value As Decimal)
//            _salary = value
//        End Set
//    End Property
//    Public Property age As Integer
//        Get
//            Return _age
//        End Get
//        Set(value As Integer)
//            _age = value
//        End Set
//    End Property