using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using abstractFactoryCSharp.Employee;
using abstractFactoryCSharp.DAL;
using System.Data;

namespace abstractFactoryCSharp.EmployeeDAL
{
    public class EmployeeDAL
    {
        #region "Internal Methods"

        internal Employee.Employee EmployeeGet(int EmployeeID)
        {
            return HydrateEmployee(EmployeeID);
        }

        internal List<Employee.Employee> EmployeeGetAll()
        {
            return HydrateEmployeeALL();
        }

        #endregion

        #region "Private Methods"

        private Employee.Employee HydrateEmployee(int EmployeeID)
        {
            DataSet ds ;
            List<Employee.Employee> empList = new List<Employee.Employee>();
            dao x = new dao();
            Dictionary<string, object> dbParms = new Dictionary<string, object>();
            dbParms.Add("@EmployeeID", EmployeeID);
            ds =  x.ExecuteGet("usp_demo_employeesSEL", dbParms);
   
            Employee.Employee emp = new Employee.Employee();
            if (ds.Tables[0].Rows.Count > 0 )
            {
                DataRow item = ds.Tables[0].Rows[0];
                emp.FirstName = item["FirstName"].ToString();
                emp.LastName = item["LastName"].ToString();
                emp.Address = item["Address"].ToString();
                emp.BirthDate = Convert.ToDateTime(item["BirthDate"]);
                emp.City = item["City"].ToString();
                emp.Country = item["Country"].ToString();
                emp.EmployeeID = Convert.ToInt32(item["EmployeeID"]);
                emp.Extension = item["Extension"].ToString();
                emp.HireDate = Convert.ToDateTime(item["HireDate"]);
                emp.HomePhone = item["HomePhone"].ToString();
                emp.Notes = item["Notes"].ToString();
                emp.Photo = item["Photo"].ToString();
                emp.PhotoPath = item["PhotoPath"].ToString();
                emp.PostalCode = item["PostalCode"].ToString();
                emp.Region = item["Region"].ToString();
                emp.ReportsTo = item["ReportsTo"].ToString();
                emp.Title = item["Title"].ToString();
                emp.TitleOfCourtesy = item["TitleOfCourtesy"].ToString();
                emp.Salary = Convert.ToDecimal(item["Salary"]);
                
            }
            return emp;
             
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<Employee.Employee> HydrateEmployeeALL()
        {
            DataSet ds;
            List<Employee.Employee> empList = new List<Employee.Employee>();
            dao x = new dao();
            Dictionary<string, object> dbParms = new Dictionary<string, object>();
            
            ds = x.ExecuteGet("usp_demo_EmployeesSel", dbParms);

            foreach (DataRow item in ds.Tables[0].Rows)
            { 

                Employee.Employee emp = new Employee.Employee();

                emp.FirstName = item["FirstName"].ToString();
                emp.LastName = item["LastName"].ToString();
                emp.Address = item["Address"].ToString();
                emp.BirthDate = Convert.ToDateTime(item["BirthDate"]);
                emp.City = item["City"].ToString();
                emp.Country = item["Country"].ToString();
                emp.EmployeeID = Convert.ToInt32(item["EmployeeID"]);
                emp.Extension = item["Extension"].ToString();
                emp.HireDate = Convert.ToDateTime(item["HireDate"]);
                emp.HomePhone = item["HomePhone"].ToString();
                emp.Notes = item["Notes"].ToString();
                emp.Photo = item["Photo"].ToString();
                emp.PhotoPath = item["PhotoPath"].ToString();
                emp.PostalCode = item["PostalCode"].ToString();
                emp.Region = item["Region"].ToString();
                emp.ReportsTo = item["ReportsTo"].ToString();
                emp.Title = item["Title"].ToString();
                emp.TitleOfCourtesy = item["TitleOfCourtesy"].ToString();
                emp.Salary = Convert.ToDecimal(item["Salary"]);
                empList.Add(emp);
            }

            return empList;

        }
        #endregion
    }
}