using Northwind.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employees.WebForms.employees
{
    public partial class repeater : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Employee> EmployeesRepeater_GetData()
        {
            return new NorthwindEntities().Employees;
        }
    }
}