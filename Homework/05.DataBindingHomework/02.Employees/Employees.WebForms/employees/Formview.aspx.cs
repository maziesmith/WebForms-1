using Northwind.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employees.WebForms.employees
{
    public partial class Formview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.EmployeesFormView.DataSource = new NorthwindEntities().Employees.ToList();
            this.EmployeesFormView.DataBind();
            this.EmployeesFormView.ID = "1";
        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public object EmployeesFormView_GetItem(int id)
        {
            var employee = new NorthwindEntities().Employees
                .FirstOrDefault(empl => empl.EmployeeID == id);

            return employee;
        }

        protected void EmployeesFormView_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {
            this.EmployeesFormView.PageIndex = e.NewPageIndex;
            this.EmployeesFormView.DataSource = new NorthwindEntities().Employees.ToList();
            this.EmployeesFormView.DataBind();
        }
    }
}