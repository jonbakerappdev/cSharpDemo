using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using abstractFactoryCSharp.Employee;
using System.Data;
namespace abstractFactoryCSharp
{
    public partial class Demo : System.Web.UI.Page
    {
       #region "Page Handlers"

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadEmployeeList(0);
                LoadEmployeeDD();
                LoadEmployeeDG("0");
                
            }    
        }
        
        protected void  DdEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEmployeeDG(ddEmployee.SelectedValue);
        }


        #endregion

       #region "Private Methods"

        private void LoadEmployeeDG(string EmployeeID)
        {
            dgEmployees.DataSource = LoadEmployeeList(Convert.ToInt32(EmployeeID));
            dgEmployees.DataBind();
        }

        private List<Employee.Employee> LoadEmployeeList(int employeeID)
        {
            List<Employee.Employee> workerList = new List<Employee.Employee>();
            DAL.EmployeeDALScheme d = new DAL.EmployeeDALScheme();
            if (employeeID != 0)
            {
                workerList.Add(d.Get(employeeID));
            }
            else
            {
               workerList= d.GetALL();
            }
            return workerList;
        }

        private void LoadEmployeeDD()
        {

            ddEmployee.DataSource = LoadEmployeeList(0);
            ddEmployee.DataTextField = "FirstName";
            ddEmployee.DataValueField = "EmployeeID";
            ddEmployee.DataBind();

            ListItem li = new ListItem();
            li.Value = "0";
            li.Text = "All Employees";
            ddEmployee.Items.Insert(0,li);
          
        }
        #endregion
    }
}