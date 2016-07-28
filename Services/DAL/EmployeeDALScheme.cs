using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using abstractFactoryCSharp.DAL;
using abstractFactoryCSharp.EmployeeDAL;
namespace abstractFactoryCSharp.DAL
{
    public class EmployeeDALScheme : EmployeeDAL.EmployeeDAL
    {
        public  Employee.Employee Get(int EmployeeID)
        {
          return  EmployeeGet(EmployeeID);
        }

        public List<Employee.Employee> GetALL()
        {
            return EmployeeGetAll();
        }
    }


}